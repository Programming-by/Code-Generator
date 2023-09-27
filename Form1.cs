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
        public Form1()
        {
            InitializeComponent();
        }

        
        private void GenerateClassProperties()
        {
            DataTable dt = clsCodeGenerator.GetAllPeople(txtTabeleSingleName.Text);

            foreach (DataRow row in dt.Rows)
            {
                if (row[1].ToString() == "int")
                {

                }


                if (row[1].ToString() == "nvarchar")
                {

                }


            }


        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {

            if(listViewColumns.Items.Count > 0)
            {
                //Message box then Reset
                return;
            }


            DataTable dt = clsCodeGenerator.GetAllPeople(txtTabeleSingleName.Text);

            foreach (DataRow row in dt.Rows)
            {

             ListViewItem item = new ListViewItem(row[0].ToString());
             listViewColumns.Items.Add(item);
             item.SubItems.Add(row[1].ToString());
             item.SubItems.Add(row[2].ToString());


                GenerateClassProperties();

            }

            lblNumberOfRecords.Text = clsCodeGenerator.CountColumns(txtTabeleSingleName.Text).ToString();

        }

        //generate business layer (class name , class properties , constructors , methods)
        //generate dataAccess layer
        //copy text from list view



        private void btnBusinessLayer_Click(object sender, EventArgs e)
        {



     

        }


        private void btnDataAccessLayer_Click(object sender, EventArgs e)
        {

        }
        private void btnCopyText_Click(object sender, EventArgs e)
        {
           // Clippord Copy
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateDatabase_Click(object sender, EventArgs e) { 
        
            if (clsCodeGenerator.CreateDatabase(txtDatabaseName.Text))
            {
                MessageBox.Show(txtDatabaseName.Text + " Database Created Successfully");
            }


        }
    }
}
