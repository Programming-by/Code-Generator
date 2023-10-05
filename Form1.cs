using CodeGeneratorBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        public string DataReader;

        public string Reader_Data = "";
        public string CommandsParameter_Data = "";
        public string SetDataInUpdate = "";


        struct FunctionData
        {
            public string Property;
            public dynamic AssignedValue;
            public string InitializeVariables;
            public string Parameter;
            public string Argument;
            public string DefaultConstructorData;
            public string ParameterConstructorData;
            public string VariableNameWithComma;
            public string VariableNameByRef;
            public string VariableNameByRefWithDataType;
            public string VariableNameWithAt;
            public string Datatype;
        }

        FunctionData Data;


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
            Data.DefaultConstructorData += $"this." + item.Text + "= " + Data.AssignedValue + ";\n";
        }

        private void GenerateParameterizedConstructor(ListViewItem item)
        {
            Data.ParameterConstructorData += $"this." + item.Text + "= " + item.Text + ";\n";
        }


        private void GenerateProperties(ListViewItem item, string DataType)
        {
            switch(DataType)
            {
                case "nvarchar(50)":
                    Data.Property += "public string " + item.Text.ToString() + " { get; set; };\n\n";
                    Data.AssignedValue = "\"\" ";
                    Data.Parameter += $"string {item.Text},";
                    Data.Argument += $"this.{item.Text},";
                    Data.InitializeVariables += $"string {item.Text} = " + Data.AssignedValue + " ; \n";
                    Data.VariableNameByRef += "ref " + item.Text + ",";
                    Data.VariableNameWithComma += item.Text + ",";
                    Data.VariableNameByRefWithDataType += "ref string " + item.Text + ",";
                    Data.VariableNameWithAt += "@" + item.Text + ",";
                    Data.Datatype = "string";

                    break;

                case "int":
                    Data.Property += "public int " + item.Text.ToString() + "  { get; set; };\n\n";
                    Data.AssignedValue = 0;

                    Data.Parameter += $"int {item.Text},";
                    Data.Argument += $"this.{item.Text},";
                    Data.InitializeVariables += $"int {item.Text} = " + Data.AssignedValue + " ; \n";
                    Data.VariableNameByRef += "ref " + item.Text + ",";
                    Data.VariableNameWithComma += item.Text + ",";
                    Data.VariableNameByRefWithDataType += "ref int " + item.Text + ",";
                    Data.VariableNameWithAt += "@" + item.Text + ",";
                    Data.Datatype = "int";



                    break;

                case "decimal":
                    Data.Property += "public decimal " + item.Text.ToString() + " { get; set; };\n\n";
                    Data.AssignedValue = 0;
                    Data.Parameter += $"decimal {item.Text},";
                    Data.Argument += $"this.{item.Text},";

                    Data.InitializeVariables += $"decimal {item.Text} = " + Data.AssignedValue + " ; \n";
                    Data.VariableNameByRef += "ref " + item.Text + ",";
                    Data.VariableNameWithComma += item.Text + ",";
                    Data.VariableNameByRefWithDataType += "ref decimal " + item.Text + ",";
                    Data.VariableNameWithAt += "@" + item.Text + ",";
                    Data.Datatype = "decimal";

                    break;
                case "bit":
                    Data.Property += "public bool " + item.Text.ToString() + " { get; set; };\n\n";
                    Data.AssignedValue = "false";
                    Data.Parameter += $"bool {item.Text},";
                    Data.Argument += $"this.{item.Text},";

                    Data.InitializeVariables += $"bool {item.Text} = " + Data.AssignedValue + " ; \n";
                    Data.VariableNameByRef += "ref " + item.Text + ",";
                    Data.VariableNameWithComma += item.Text + ",";
                    Data.VariableNameByRefWithDataType += "ref bool " + item.Text + ",";
                    Data.VariableNameWithAt += "@" + item.Text + ",";
                    Data.Datatype = "decimal";




                    break;
                    
                case "money":
                    Data.Property += "public decimal " + item.Text.ToString() + " { get; set; };\n\n";
                    Data.AssignedValue = 0;
                    Data.Parameter += $"decimal {item.Text},";
                    Data.Argument += $"this.{item.Text},";

                    Data.InitializeVariables += $"decimal {item.Text} = " + Data.AssignedValue + " ; \n";
                    Data.VariableNameByRef += "ref " + item.Text + ",";
                    Data.VariableNameWithComma += item.Text + ",";
                    Data.VariableNameByRefWithDataType += "ref decimal " + item.Text + ",";
                    Data.VariableNameWithAt += "@" + item.Text + ",";
                    Data.Datatype = "decimal";




                    break;

                case "smallmoney":
                    
                    Data.Property += "public decimal " + item.Text.ToString() + " { get; set; };\n\n";
                    Data.AssignedValue = 0;

                    Data.Parameter += $"decimal {item.Text},";
                    Data.Argument += $"this.{item.Text},";
                    Data.InitializeVariables += $"decimal {item.Text} = " + Data.AssignedValue + " ; \n";
                    Data.VariableNameByRef += "ref " + item.Text + ",";
                    Data.VariableNameWithComma += item.Text + ",";
                    Data.VariableNameByRefWithDataType += "ref decimal " + item.Text + ",";
                    Data.VariableNameWithAt += "@" + item.Text + ",";
                    Data.Datatype = "decimal";



                    break;

                case "smallint":
                    Data.Property += "public Int16 " + item.Text.ToString() + " { get; set; };\n\n";
                    Data.AssignedValue = 0;
                    Data.Parameter += $"Int16 {item.Text},";
                    Data.Argument += $"this.{item.Text},";
                    Data.InitializeVariables += $"Int16 {item.Text} = " + Data.AssignedValue + " ; \n";
                    Data.VariableNameByRef += "ref " + item.Text + ",";
                    Data.VariableNameWithComma += item.Text + ",";
                    Data.VariableNameByRefWithDataType += "ref Int16 " + item.Text + ",";
                    Data.VariableNameWithAt += "@" + item.Text + ",";
                    Data.Datatype = "Int16";



                    break;
                case "float":
                    Data.Property += "public float " + item.Text.ToString() + " { get; set; };\n\n";
                    Data.AssignedValue = 0;

                    Data.Parameter += $"float {item.Text},";
                    Data.Argument += $"this.{item.Text},";
                    Data.InitializeVariables += $"float {item.Text} = " + Data.AssignedValue + " ; \n";
                    Data.VariableNameByRef += "ref " + item.Text + ",";
                    Data.VariableNameWithComma += item.Text + ",";
                    Data.VariableNameByRefWithDataType += "ref float " + item.Text + ",";
                    Data.VariableNameWithAt += "@" + item.Text + ",";
                    Data.Datatype = "float";


                    break;
                case "date":

                    break;
                case "datetime":
                    Data.Property += "public DateTime " + item.Text.ToString() + " { get; set; };\n\n";
                    Data.AssignedValue = DateTime.Now;
                    Data.Parameter += $"DateTime {item.Text},";
                    Data.Argument += $"this.{item.Text},";
                    Data.InitializeVariables += $"DateTime {item.Text} = " + Data.AssignedValue + " ; \n";
                    Data.VariableNameByRef += "ref " + item.Text + ",";
                    Data.VariableNameWithComma += item.Text + ",";
                    Data.VariableNameByRefWithDataType += "ref DateTime " + item.Text + ",";
                    Data.VariableNameWithAt += "@" + item.Text + ",";

                    Data.Datatype = "DateTime";


                    break;
                case "binary":
                    Data.Property += "public Byte[] " + item.Text.ToString() + " { get; set; };\n\n";



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
          if (cbTables.Items.Contains(txtTableName.Text))
            {
                MessageBox.Show("there is a table in the database with the same name");
                return;
            }

                if (clsCodeGenerator.CreateTable(cbDatabases.SelectedItem.ToString(), txtTableName.Text, "ID", "int", "Not Null"))
                {
                   MessageBox.Show("Table Created Successfully", "Created",MessageBoxButtons.OK);

                   }



                foreach (ListViewItem itemRow in this.listViewColumns.Items)
                {
                    if (clsCodeGenerator.AlterTable(txtTableName.Text, itemRow.SubItems[0].Text, itemRow.SubItems[1].Text, itemRow.SubItems[2].Text))
                    {
                        MessageBox.Show("Table Altered Successfully");
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

            GenerateAddNewDataAccess();

            RemoveLastComma(ref Data.Parameter);
            RemoveLastComma(ref Data.Argument);

            richTextBox1.Text = $"private bool _AddNew{txtTableName.Text}(" + Data.Parameter + ")"

                + $"\nthis.{txtTableName.Text}ID = cls{txtTableName.Text}DataAccess.AddNew{txtTableName.Text}("

                + Data.Argument + ")"

             + $"\nreturn (this.{txtTableName.Text}ID != -1)"

             + "\n }";

        }
        private void btnUpdateFunction_Click(object sender, EventArgs e)
        {

            GenerateUpdateDataAccess();

            RemoveLastComma (ref Data.Parameter);
            RemoveLastComma(ref Data.Argument);

            richTextBox1.Text = $"private bool _Update{txtTableName.Text}()"

          + "{" + $"\nreturn cls{txtTableName.Text}DataAccess.Update{txtTableName.Text}({Data.Argument})"

          + "\n }";


        }
        private void btnIsExist_Click(object sender, EventArgs e)
        {
            GenerateIsExistDataAccess();

            richTextBox1.Text = $"public static bool Is{txtTableName.Text}Exist(int ID)"

              + "{" + $"\nreturn cls{txtTableName.Text}DataAccess.Is{txtTableName.Text}Exist(ID);"

              + "\n }";
        }

        private void btnDeleteFunction_Click(object sender, EventArgs e)
        {
            GenerateDeleteDataAccess();

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

            GenerateGetAllDataAccess();



            richTextBox1.Text = $"public static DataTable GetAll{txtTableName.Text}s()"

                + "{" + $"\nreturn cls{txtTableName.Text}DataAccess.GetAll{txtTableName.Text}s();"
                
                + "\n }";

        }

        private void ReplaceText(ref string Text)
        {
            Text = Text.Replace("ref ID,", "ID,");

        }


    private void btnFindFunction_Click(object sender, EventArgs e)
        {

            GenerateFindDataAccess();

            ReplaceText(ref Data.VariableNameByRef);

            Data.InitializeVariables = Data.InitializeVariables.Replace("int ID = 0 ;", "");



            richTextBox1.Text = $"public static cls{txtTableName.Text} Find(int ID)"

   + "{\n"
   + $"{Data.InitializeVariables}"
   + $"if (cls{txtTableName.Text}DataAccess.Get{txtTableName.Text}InfoByID({RemoveLastComma(ref Data.VariableNameByRef)}))"
   + "{"
   + $"\n return new cls{txtTableName.Text}({RemoveLastComma(ref Data.VariableNameWithComma)});\n"
   + "} else"
   + "{\n"
   + "return null;"
   + "\n}"
   + "\n}";


        }

        private void btnGenerateProperties_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Data.Property;
        }

        private void btnDefaultConstructor_Click(object sender, EventArgs e)
        {
                richTextBox1.Text = $"public cls{txtTableName.Text}()"
                           + "{\n"
                           + Data.DefaultConstructorData
                           + "Mode = enMode.AddNew;"
                           +"\n}"; 
        }

        private void btnParameterizedConstructor_Click(object sender, EventArgs e)
        {
            RemoveLastComma(ref Data.Parameter);

         
            richTextBox1.Text = $"public cls{txtTableName.Text}("
                + $"{Data.Parameter}" + ")"
                       + "{\n"
                       + Data.ParameterConstructorData
                       + "Mode = enMode.Update;"
                       + "\n}";



        }

        private string RemoveLastComma(ref string Text)
        {
            if (Text.EndsWith(","))
            {
                Text = Text.Substring(0, Text.Length - 1);
            }

            return Text;

        }

        private void GenerateGetAllDataAccess()
        {
            richTextBox2.Text += $"public static DataTable GetAll{txtTableName.Text}s()"
              + "{\n"
              + "DataTable dt = new DataTable();\n" +
              "SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);\n"
              + $"string query = \"Select * from {txtTableName.Text}s\";\n"
             + "SqlCommand command = new SqlCommand(query, connection);\n"
             + "try \n"
             + "{ \n"
             + "connection.Open();\n"
             + "SqlDataReader reader = command.ExecuteReader();\n"
             + "if(reader.HasRows)\n"
             + "{\n"
             + "dt.Load(reader);\n"
             + "}\n"
             + "reader.Close();\n"
             + "}\n"
             + "catch (Exception ex)\n"
             + "{\n"
             + "}\n"
             + "finally { connection.Close(); }\n"
             + "return dt;\n"
             + "}"
             + "\n\n";






        }
        
        private void SplitStringInReader()
        {
            string[] stringSeparators = new string[] { "," };
            string[] result;


            result = Data.VariableNameWithComma.Split(stringSeparators, StringSplitOptions.None);

            foreach (string SingleReader in result)
            {
                if (SingleReader == "ID")
                {
                    continue;
                }

                if (SingleReader == "")
                {
                    break;
                }

                Reader_Data += SingleReader + $" = ({Data.Datatype}) reader[\"{SingleReader}\"]; \n";
            }




        }

        private void SplitStringInCommandParameters()
        {
            string[] stringSeparators = new string[] { "," };
            string[] result;


            result = Data.VariableNameWithComma.Split(stringSeparators, StringSplitOptions.None);

            foreach (string SingleReader in result)
            {
                if (SingleReader == "")
                {
                    break;
                }

                CommandsParameter_Data += "command.Parameters.AddWithValue(" + $"\"@{SingleReader}\",{SingleReader}" + ");\n";
            }
        }

        private void SplitStringInUpdate()
        {
            string[] stringSeparators = new string[] { "," };
            string[] result;


            result = Data.VariableNameWithComma.Split(stringSeparators, StringSplitOptions.None);

            foreach (string SingleReader in result)
            {

                if (SingleReader == "ID")
                {
                    continue;
                }

                if (SingleReader == "")
                {
                    break;
                }

                SetDataInUpdate += $"{SingleReader} =@{SingleReader}\n";
            }


        }

        private void GenerateFindDataAccess()
        {


            Data.VariableNameByRefWithDataType = Data.VariableNameByRefWithDataType.Replace("ref int ID,", "int ID,");


            SplitStringInReader();
            

            richTextBox2.Text = $"public static bool Generate{txtTableName.Text}InfoByID(" +
                 $"{RemoveLastComma(ref Data.VariableNameByRefWithDataType)}" + ")"
                 + "{\n"
                 + "bool isFound = false;\n" +
                 "SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);\n"
                 + $"string query = \"Select * from {txtTableName.Text}s Where {txtTableName.Text}ID = @ID\";\n"
                + "SqlCommand command = new SqlCommand(query, connection);\n"
                + "command.Parameters.AddWithValue(\"@ID\",ID);\n"
                + "try \n"
                + "{ \n"
                + "connection.Open();\n"
                + "SqlDataReader reader = command.ExecuteReader();\n"
                + "if (reader.Read())\n"
                + "{\n"
                + "isFound = true;\n"
                + Reader_Data
                + "\n}\n"
                + "else\n"
                + "{\n"
                + "isFound = false;\n"
                + "}\n"
                + "}\n"
                + "catch (Exception ex)\n"
                + "{\n"
                + "isFound = false;\n"
                + "}\n"
                + "finally { connection.Close(); }\n"
                + "return isFound;\n"
                + "}";


        }
   
        private void GenerateAddNewDataAccess()
        {

            Data.Parameter = Data.Parameter.Replace("int ID," , "");
            Data.VariableNameWithAt = Data.VariableNameWithAt.Replace("@ID", "");

            SplitStringInCommandParameters();

            richTextBox2.Text += $"public static int AddNew{txtTableName.Text}(" + RemoveLastComma(ref Data.Parameter)  +  ")\n"
        + "{\n"
        + "int ClientID = -1;\n" +
        "SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);\n"
        + $"string query = @\"INSERT INTO {txtTableName.Text}s ({RemoveLastComma(ref Data.VariableNameWithComma)}) " +
        $"VALUES ({RemoveLastComma(ref Data.VariableNameWithAt)}) " +
        $"SELECT SCOPE_IDENTITY()\";\n"
       + "SqlCommand command = new SqlCommand(query, connection);\n"      
       + CommandsParameter_Data
       + "try \n"
       + "{ \n"
       + "connection.Open();\n"
       + "object result = command.ExecuteScalar();\n"
       + "if(result != null && int.TryParse(result.ToString(),out int insertedID))\n"
       + "{\n"
       + "ClientID = insertedID;\n"
       + "}\n"
       + "}\n"
       + "catch (Exception ex)\n"
       + "{\n"
       + "}\n"
       + "finally { connection.Close(); }\n"
       + "return ClientID;\n"
       + "}"
       + "\n\n";

            //    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            //    command.Parameters.AddWithValue("@Balance", Balance);
            //    command.Parameters.AddWithValue("@PersonID", PersonID);
        }

        private void GenerateUpdateDataAccess()
        {

            SplitStringInCommandParameters();

            SplitStringInUpdate();

            richTextBox2.Text += $"public static bool Update{txtTableName.Text}s(" + RemoveLastComma(ref Data.Parameter) + ")\n"
        + "{\n"
        + "int RowsAffected = 0;\n" +
        "SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);\n"
        + $"string query = @\"Update {txtTableName.Text}s set "  + $"{SetDataInUpdate}"
        + $"Where {txtTableName.Text}s.{txtTableName.Text}ID = @ID\";\n"
       + "SqlCommand command = new SqlCommand(query, connection);\n"
       + CommandsParameter_Data
       + "try \n"
       + "{ \n"
       + "connection.Open();\n"
       + "RowsAffected = command.ExecuteNonQuery();\n"
       + "}\n"
       + "catch (Exception ex)\n"
       + "{\n"
       + "return false;\n"
       + "}\n"
       + "finally { connection.Close(); }\n"
       + "return (RowsAffected > 0);\n"
       + "}"
       + "\n\n";

        }

        private void GenerateIsExistDataAccess()
        {
            richTextBox2.Text += $"public static bool Is{txtTableName.Text}Exist(int ID)"
                 + "{\n"
                 + "bool isFound = false;\n" +
                 "SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);\n"
                 + $"string query = \"Select Found = 1 from {txtTableName.Text}s Where {txtTableName.Text}ID = @ID\";\n"
                + "SqlCommand command = new SqlCommand(query, connection);\n"
                + "command.Parameters.AddWithValue(\"@ID\",ID);\n"
                + "try \n"
                + "{ \n"
                + "connection.Open();\n"
                + "SqlDataReader reader = command.ExecuteReader();\n"
                + "isFound = reader.HasRows;\n"
                + "reader.Close();\n"
                + "}\n"
                + "catch (Exception ex)\n"
                + "{\n"
                + "isFound = false;\n"
                + "}\n"
                + "finally { connection.Close(); }\n"
                + "return isFound;\n"
                + "}"
                + "\n\n";

        }

        private void GenerateDeleteDataAccess()
        {
            richTextBox2.Text += $"public static bool Delete{txtTableName.Text}(int ID)"
                 + "{\n"
                 + "int RowsAffected = 0;\n" +
                 "SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);\n"
                 + $"string query = \"Delete {txtTableName.Text}s Where {txtTableName.Text}ID = @ID\";\n"
                + "SqlCommand command = new SqlCommand(query, connection);\n"
                + "command.Parameters.AddWithValue(\"@ID\",ID);\n"
                + "try \n"
                + "{ \n"
                + "connection.Open();\n"
                + "RowsAffected = command.ExecuteNonQuery();\n"
                + "}\n"
                + "catch (Exception ex)\n"
                + "{\n"
                + "return false;\n"
                + "}\n"
                + "finally { connection.Close(); }\n"
                + "return (RowsAffected > 0);\n"
                + "}"
                + "\n\n";


        }
    }

}


