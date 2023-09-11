using CodeGeneratorBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
      

        private void btnAddTable_Click(object sender, EventArgs e)
        {

            DataTable dt = clsCodeGenerator.GetAllPeople(txtTabeleSingleName.Text);

            foreach (DataRow row in dt.Rows)
            {

             ListViewItem item = new ListViewItem(row[0].ToString());
             listViewColumns.Items.Add(item);
             item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());

            }



                // add columns
                // add datatypes
                // add allow nulls



            lblNumberOfRecords.Text = clsCodeGenerator.CountColumns().ToString();

        }

       
    }
}
