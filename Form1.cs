using CodeGeneratorBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Code_Generator
{
    public partial class Form1 : Form
    {
        

        private string NullValue;


        private string property;
        private string DefaultConstructorData;
        private dynamic DefaultConstructorValue;
        private string ParameterConstructorData;
        private string ParameterConstructorParameters;




        public Form1()
        {
            InitializeComponent();
        }

        private void _FillDatabasesInComboBox()
        {
            DataTable dtDatabases = clsCodeGenerator.GetAllDatabases();
            cbDatabases.Items.Clear();
            foreach (DataRow row in dtDatabases.Rows)
            {
                cbDatabases.Items.Add(row["name"]);
            }


        }
        private void _FillTablesInComboBox(string DatabaseName)
        {
           
            DataTable dtTables = clsCodeGenerator.GetAllTables(DatabaseName);
            cbTables.Items.Clear();
            foreach (DataRow row in dtTables.Rows)
            {
                cbTables.Items.Add(row["TABLE_NAME"]);
            }
        }

        private void _FillTable1InComboBox(string DatabaseName)
        {
            DataTable dtTable1 = clsCodeGenerator.GetAllTables(DatabaseName);
            cbTable1.Items.Clear();
            foreach (DataRow row in dtTable1.Rows)
            {
                cbTable1.Items.Add(row["TABLE_NAME"]);
            }
        }

        private void _FillTable2InComboBox(string DatabaseName)
        {
            DataTable dtTable2 = clsCodeGenerator.GetAllTables(DatabaseName);
            cbTable2.Items.Clear();
            foreach (DataRow row in dtTable2.Rows)
            {
                cbTable2.Items.Add(row["TABLE_NAME"]);
            }
        }

        private void _FillColumn1InComboBox(string DatabaseName, string Table1)
        {
            DataTable dtColumn1 = clsCodeGenerator.GetAllColumns(DatabaseName, Table1);
            cbColumn1.Items.Clear();
            foreach (DataRow row in dtColumn1.Rows)
            {
                cbColumn1.Items.Add(row["COLUMN_NAME"]);
            }
        }


        private void _FillColumn2InComboBox(string DatabaseName, string Table2)
        {
            DataTable dtColumn2 = clsCodeGenerator.GetAllColumns(DatabaseName, Table2);
            cbColumn2.Items.Clear();
            foreach (DataRow row in dtColumn2.Rows)
            {
                cbColumn2.Items.Add(row["COLUMN_NAME"]);
            }
        }

        private void _FillColumnsInComboBox(string DatabaseName, string TableName)
        {
            DataTable dtColumns = clsCodeGenerator.GetAllColumns(DatabaseName, TableName);
            cbColumns.Items.Clear();
            foreach (DataRow row in dtColumns.Rows)
            {
                cbColumns.Items.Add(row["COLUMN_NAME"]);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _FillDatabasesInComboBox();
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {

            if (clsCodeGenerator.CreateDatabase(txtDatabaseName.Text))
            {
                MessageBox.Show(txtDatabaseName.Text + " Database Created Successfully");
                _FillDatabasesInComboBox();
            }
        }

        private void btnAddColumns_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem(txtColumnName.Text);

            listViewColumns.Items.Add(item);
            
            item.SubItems.Add(cbDataTypes.Text);

            if (chkIsNull.Checked)
            {
                item.SubItems.Add("Null");
            }
            else
            {
                item.SubItems.Add("Not Null");
            }


            GenerateProperties(item,cbDataTypes.Text);

            GenerateDefaultConstructor(item);

            GenerateParameterizedConstructor(item);
          
               



        }

        private void GenerateDefaultConstructor(ListViewItem item)
        {
            DefaultConstructorData += $"this." + item.Text + "= " + DefaultConstructorValue + ";\n";
        }

        private void GenerateParameterizedConstructor(ListViewItem item)
        {
            ParameterConstructorData += $"this." + item.Text + "= " + item.Text + ";\n";
        }


        private void GenerateProperties(ListViewItem item, string DataType)
        {
            switch(DataType)
            {
                case "nvarchar(50)":
                    property += "public string " + item.Text.ToString() + " { get; set; };\n\n";
                    DefaultConstructorValue = "\"\" ";
                    ParameterConstructorParameters += $"string {item.Text},";
                    break;

                case "int":
                    property += "public int " + item.Text.ToString() + "  { get; set; };\n\n";
                    DefaultConstructorValue = 0;

                    ParameterConstructorParameters += $"int {item.Text},";

                    break;

                case "decimal":
                    property += "public decimal " + item.Text.ToString() + " { get; set; };\n\n";
                    DefaultConstructorValue = 0;
                    ParameterConstructorParameters += $"decimal {item.Text},";


                    break;
                case "bit":
                    property += "public bool " + item.Text.ToString() + " { get; set; };\n\n";
                    DefaultConstructorValue = false;
                    ParameterConstructorParameters += $"bool {item.Text},";


                    break;
                    
                case "money":
                    property += "public decimal " + item.Text.ToString() + " { get; set; };\n\n";
                    DefaultConstructorValue = 0;
                    ParameterConstructorParameters += $"decimal {item.Text},";


                    break;

                case "smallmoney":
                    
                    property += "public decimal " + item.Text.ToString() + " { get; set; };\n\n";
                    DefaultConstructorValue = 0;

                    ParameterConstructorParameters += $"decimal {item.Text},";

                    break;

                case "smallint":
                    property += "public Int16 " + item.Text.ToString() + " { get; set; };\n\n";
                    DefaultConstructorValue = 0;
                    ParameterConstructorParameters += $"Int16 {item.Text},";


                    break;
                case "float":
                    property += "public float " + item.Text.ToString() + " { get; set; };\n\n";
                    DefaultConstructorValue = 0;

                    ParameterConstructorParameters += $"float {item.Text},";

                    break;
                case "date":

                    break;
                case "datetime":
                    property += "public DateTime " + item.Text.ToString() + " { get; set; };\n\n";
                    DefaultConstructorValue = DateTime.Now;
                    ParameterConstructorParameters += $"DateTime {item.Text},";


                    break;
                case "binary":
                    property += "public Byte[] " + item.Text.ToString() + " { get; set; };\n\n";



                    break;
                case "image":

                    break;






            }


        }

        private void txtDatatypeSize_TextChanged_1(object sender, EventArgs e)
        {
            if (txtDatatypeSize.Text.Length > 1 || txtDatatypeSize.Text.Length > 2)
            {
                if (cbDataTypes.SelectedIndex == 0)
                {
                    cbDataTypes.Text = cbDataTypes.Text.Replace("(0)", "(" + txtDatatypeSize.Text + ")");
                }

            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {

            bool isTableCreated = false;
            if (!isTableCreated)
            {
                if (clsCodeGenerator.CreateTable(cbDatabases.SelectedItem.ToString(), txtTableName.Text, "ID", "int", "Not Null"))
                {
                    MessageBox.Show("Table Created Successfully");
                }


            }
            isTableCreated = true;

            if (isTableCreated)
            {
                foreach (ListViewItem itemRow in this.listViewColumns.Items)
                {
                    if (clsCodeGenerator.AlterTable(txtTableName.Text, itemRow.SubItems[0].Text, itemRow.SubItems[1].Text, itemRow.SubItems[2].Text))
                    {
                        MessageBox.Show("Table Altered Successfully");
                    }
              }
            }

            _FillTablesInComboBox(cbDatabases.Text);
        }

        private void IsNullOrNot()
        {
            if (chkIsNull.Checked)
            {
                NullValue = "NULL";
            }
            else
            {
                NullValue = "Not NULL";
            }
        }

        private void chkIsNull_CheckedChanged(object sender, EventArgs e)
        {
            IsNullOrNot();
        }

        private void cbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FillTablesInComboBox(cbDatabases.Text);

            _FillTable1InComboBox(cbDatabases.Text);

            _FillTable2InComboBox(cbDatabases.Text);

        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FillColumnsInComboBox(cbDatabases.Text ,cbTables.Text);
        }

        private void btnAddPrimaryKey_Click(object sender, EventArgs e)
        {
            if (clsCodeGenerator.AddPrimaryKey(cbTables.Text, cbColumns.Text))
            {
                MessageBox.Show("Primary Key Added");
            }
        }


        private void btnAddForeignKey_Click(object sender, EventArgs e)
        {
            if (clsCodeGenerator.AddForeignKey(cbTable1.Text ,cbTable2.Text ,cbColumn1.Text, cbColumn2.Text))
            {
                MessageBox.Show("Foreign Key Added");
            }
        }

        private void cbTable1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FillColumn1InComboBox(cbDatabases.Text, cbTable1.Text);
        }

        private void cbTable2_SelectedIndexChanged(object sender, EventArgs e)
        {
              _FillColumn2InComboBox(cbDatabases.Text , cbTable2.Text);
        }
        private void btnAddFunction_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = $"public bool _AddNew{txtTableName.Text}()"

                + $"this.{txtTableName.Text}ID = cls{txtTableName.Text}DataAccess.AddNew{txtTableName.Text}()"

             + $"\nreturn (this.{txtTableName.Text} != -1)"

             + "\n }";

        }
        private void btnUpdateFunction_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = $"private bool _Update{txtTableName.Text}()"

          + "{" + $"\nreturn cls{txtTableName.Text}DataAccess.Update{txtTableName.Text}(this.);"

          + "\n }";


        }
        private void btnIsExist_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = $"public static bool Is{txtTableName.Text}Exist(int ID)"

              + "{" + $"\nreturn cls{txtTableName.Text}DataAccess.Is{txtTableName.Text}Exist(ID);"

              + "\n }";
        }

        private void btnDeleteFunction_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = $"public static bool Delete{txtTableName.Text}(int ID)"

       + "{" + $"\nreturn cls{txtTableName.Text}DataAccess.Delete{txtTableName.Text}(ID);"

       + "\n }";
        }

        private void btnSaveFunction_Click(object sender, EventArgs e)
        {



            richTextBox1.Text = $"public virtual bool Save()"

          + "{\n"

          + "switch (Mode) { \n"

          + "case enMode.AddNew:"
          + $"\nif (_AddNew{txtTableName.Text}())"
          + "{ \n"
          + "Mode = enMode.Update;\n"
          + "return true;\n"
          + "} else {\n"
          + "return false;\n"
          + "}\n"
          + "\ncase enMode.Update:"
          + $"\nreturn _Update{txtTableName.Text}();\n"
          +  "}\n"
          + "return false;"
          + "\n }";

        }



        private void btnGetAllFunction_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = $"public static DataTable GetAll{txtTableName.Text}s()"

                + "{" + $"\nreturn cls{txtTableName.Text}DataAccess.GetAll{txtTableName.Text}s();"
                
                + "\n }";

        }

        private void btnFindFunction_Click(object sender, EventArgs e)
        {
    

            richTextBox1.Text = $"public static cls{txtTableName.Text} Find(int ID)"

   + "{\n"
   + $"if (cls{txtTableName.Text}DataAccess.Get{txtTableName.Text}InfoByID(ID, ref , ref ))"
   + "{"
   + $"\n return new cls{txtTableName.Text}(ID,);\n"
   + "} else"
   + "{\n"
   + "return null;"
   + "}\n"
   + "}";


        }

        private void btnGenerateProperties_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = property;
        }

        private void btnDefaultConstructor_Click(object sender, EventArgs e)
        {
                richTextBox1.Text = $"public cls{txtTableName.Text}()"
                           + "{\n"
                           + DefaultConstructorData
                           + "Mode = enMode.AddNew;"
                           +"\n}"; 
        }

        private void btnParameterizedConstructor_Click(object sender, EventArgs e)
        {
            if (ParameterConstructorParameters.EndsWith(","))
            {
                ParameterConstructorParameters = ParameterConstructorParameters.Substring(0, ParameterConstructorParameters.Length - 1);
            }
            richTextBox1.Text = $"public cls{txtTableName.Text}("
                + $"{ParameterConstructorParameters}" + ")"
                       + "{\n"
                       + ParameterConstructorData
                       + "Mode = enMode.Update;"
                       + "\n}";



        }
    }

}
