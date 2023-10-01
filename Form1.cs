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

namespace Code_Generator
{
    public partial class Form1 : Form
    {
        //generate business layer (class name , class properties , constructors , methods)
        //generate dataAccess layer
        //copy text from list view

        private string NullValue;
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
            IsNullOrNot();

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


        private void cbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FillTablesInComboBox(cbDatabases.Text);
        }

        private void chkIsNull_CheckedChanged(object sender, EventArgs e)
        {
            IsNullOrNot();
        }
    }
}
