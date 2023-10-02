namespace Code_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.listViewDataAccessLayer = new System.Windows.Forms.ListView();
            this.listViewColumns = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetProperties = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkIsNull = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDatatypeSize = new System.Windows.Forms.TextBox();
            this.cbDataTypes = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddColumns = new System.Windows.Forms.Button();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbColumns = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPrimaryKey = new System.Windows.Forms.Button();
            this.btnAddFunction = new System.Windows.Forms.Button();
            this.btnUpdateFunction = new System.Windows.Forms.Button();
            this.btnFindFunction = new System.Windows.Forms.Button();
            this.btnDeleteFunction = new System.Windows.Forms.Button();
            this.btnGetAllFunction = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listViewBusinessLayer = new System.Windows.Forms.ListView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbColumn2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTable2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTable1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbColumn1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddForeignKey = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Code Generator";
            // 
            // listViewDataAccessLayer
            // 
            this.listViewDataAccessLayer.HideSelection = false;
            this.listViewDataAccessLayer.Location = new System.Drawing.Point(6, 21);
            this.listViewDataAccessLayer.Name = "listViewDataAccessLayer";
            this.listViewDataAccessLayer.Size = new System.Drawing.Size(455, 471);
            this.listViewDataAccessLayer.TabIndex = 8;
            this.listViewDataAccessLayer.UseCompatibleStateImageBehavior = false;
            this.listViewDataAccessLayer.View = System.Windows.Forms.View.List;
            // 
            // listViewColumns
            // 
            this.listViewColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewColumns.HideSelection = false;
            this.listViewColumns.Location = new System.Drawing.Point(489, 267);
            this.listViewColumns.Name = "listViewColumns";
            this.listViewColumns.Size = new System.Drawing.Size(410, 276);
            this.listViewColumns.TabIndex = 9;
            this.listViewColumns.UseCompatibleStateImageBehavior = false;
            this.listViewColumns.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ColumnName";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data Type";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "AllowNull";
            this.columnHeader3.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCreateDatabase);
            this.groupBox1.Controls.Add(this.txtDatabaseName);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 187);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Database Name";
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Location = new System.Drawing.Point(170, 97);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(148, 62);
            this.btnCreateDatabase.TabIndex = 6;
            this.btnCreateDatabase.Text = "Create Database";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(133, 35);
            this.txtDatabaseName.Multiline = true;
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(221, 35);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTables);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbDatabases);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnGetProperties);
            this.groupBox2.Location = new System.Drawing.Point(956, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 200);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(150, 97);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(152, 24);
            this.cbTables.TabIndex = 9;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Choose Table";
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(150, 38);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(152, 24);
            this.cbDatabases.TabIndex = 8;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Choose Database";
            // 
            // btnGetProperties
            // 
            this.btnGetProperties.Location = new System.Drawing.Point(154, 146);
            this.btnGetProperties.Name = "btnGetProperties";
            this.btnGetProperties.Size = new System.Drawing.Size(148, 41);
            this.btnGetProperties.TabIndex = 6;
            this.btnGetProperties.Text = "Get Properties";
            this.btnGetProperties.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnCreateTable);
            this.groupBox3.Controls.Add(this.txtTableName);
            this.groupBox3.Location = new System.Drawing.Point(489, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 187);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Table";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Table Name";
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(170, 97);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(148, 62);
            this.btnCreateTable.TabIndex = 6;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(133, 35);
            this.txtTableName.Multiline = true;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(221, 35);
            this.txtTableName.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkIsNull);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtDatatypeSize);
            this.groupBox4.Controls.Add(this.cbDataTypes);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnAddColumns);
            this.groupBox4.Controls.Add(this.txtColumnName);
            this.groupBox4.Location = new System.Drawing.Point(21, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 237);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Column Name";
            // 
            // chkIsNull
            // 
            this.chkIsNull.AutoSize = true;
            this.chkIsNull.Location = new System.Drawing.Point(133, 152);
            this.chkIsNull.Name = "chkIsNull";
            this.chkIsNull.Size = new System.Drawing.Size(65, 20);
            this.chkIsNull.TabIndex = 13;
            this.chkIsNull.Text = "Is Null";
            this.chkIsNull.UseVisualStyleBackColor = true;
            this.chkIsNull.CheckedChanged += new System.EventHandler(this.chkIsNull_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "IsNull???";
            // 
            // txtDatatypeSize
            // 
            this.txtDatatypeSize.Location = new System.Drawing.Point(311, 86);
            this.txtDatatypeSize.Multiline = true;
            this.txtDatatypeSize.Name = "txtDatatypeSize";
            this.txtDatatypeSize.Size = new System.Drawing.Size(34, 27);
            this.txtDatatypeSize.TabIndex = 10;
            this.txtDatatypeSize.TextChanged += new System.EventHandler(this.txtDatatypeSize_TextChanged_1);
            // 
            // cbDataTypes
            // 
            this.cbDataTypes.FormattingEnabled = true;
            this.cbDataTypes.Items.AddRange(new object[] {
            "nvarchar(0)",
            "int",
            "decimal",
            "bit",
            "tinyint",
            "money",
            "smallmoney",
            "smallint",
            "float",
            "date",
            "datetime",
            "binary",
            "image"});
            this.cbDataTypes.Location = new System.Drawing.Point(133, 89);
            this.cbDataTypes.Name = "cbDataTypes";
            this.cbDataTypes.Size = new System.Drawing.Size(152, 24);
            this.cbDataTypes.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "DataType";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Column Name";
            // 
            // btnAddColumns
            // 
            this.btnAddColumns.Location = new System.Drawing.Point(237, 165);
            this.btnAddColumns.Name = "btnAddColumns";
            this.btnAddColumns.Size = new System.Drawing.Size(148, 62);
            this.btnAddColumns.TabIndex = 6;
            this.btnAddColumns.Text = "Add Columns";
            this.btnAddColumns.UseVisualStyleBackColor = true;
            this.btnAddColumns.Click += new System.EventHandler(this.btnAddColumns_Click);
            // 
            // txtColumnName
            // 
            this.txtColumnName.Location = new System.Drawing.Point(133, 35);
            this.txtColumnName.Multiline = true;
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(221, 35);
            this.txtColumnName.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbColumns);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnAddPrimaryKey);
            this.groupBox5.Location = new System.Drawing.Point(956, 289);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(391, 131);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Primary Key";
            // 
            // cbColumns
            // 
            this.cbColumns.FormattingEnabled = true;
            this.cbColumns.Location = new System.Drawing.Point(130, 40);
            this.cbColumns.Name = "cbColumns";
            this.cbColumns.Size = new System.Drawing.Size(152, 24);
            this.cbColumns.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Column Name";
            // 
            // btnAddPrimaryKey
            // 
            this.btnAddPrimaryKey.Location = new System.Drawing.Point(243, 70);
            this.btnAddPrimaryKey.Name = "btnAddPrimaryKey";
            this.btnAddPrimaryKey.Size = new System.Drawing.Size(126, 41);
            this.btnAddPrimaryKey.TabIndex = 6;
            this.btnAddPrimaryKey.Text = "Add Primary Key";
            this.btnAddPrimaryKey.UseVisualStyleBackColor = true;
            this.btnAddPrimaryKey.Click += new System.EventHandler(this.btnAddPrimaryKey_Click);
            // 
            // btnAddFunction
            // 
            this.btnAddFunction.Location = new System.Drawing.Point(47, 650);
            this.btnAddFunction.Name = "btnAddFunction";
            this.btnAddFunction.Size = new System.Drawing.Size(110, 62);
            this.btnAddFunction.TabIndex = 12;
            this.btnAddFunction.Text = "Add Function";
            this.btnAddFunction.UseVisualStyleBackColor = true;
            this.btnAddFunction.Click += new System.EventHandler(this.btnAddFunction_Click);
            // 
            // btnUpdateFunction
            // 
            this.btnUpdateFunction.Location = new System.Drawing.Point(47, 736);
            this.btnUpdateFunction.Name = "btnUpdateFunction";
            this.btnUpdateFunction.Size = new System.Drawing.Size(110, 62);
            this.btnUpdateFunction.TabIndex = 13;
            this.btnUpdateFunction.Text = "Update Function";
            this.btnUpdateFunction.UseVisualStyleBackColor = true;
            // 
            // btnFindFunction
            // 
            this.btnFindFunction.Location = new System.Drawing.Point(47, 818);
            this.btnFindFunction.Name = "btnFindFunction";
            this.btnFindFunction.Size = new System.Drawing.Size(110, 62);
            this.btnFindFunction.TabIndex = 14;
            this.btnFindFunction.Text = "Find Function";
            this.btnFindFunction.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFunction
            // 
            this.btnDeleteFunction.Location = new System.Drawing.Point(47, 895);
            this.btnDeleteFunction.Name = "btnDeleteFunction";
            this.btnDeleteFunction.Size = new System.Drawing.Size(110, 62);
            this.btnDeleteFunction.TabIndex = 15;
            this.btnDeleteFunction.Text = "Delete";
            this.btnDeleteFunction.UseVisualStyleBackColor = true;
            // 
            // btnGetAllFunction
            // 
            this.btnGetAllFunction.Location = new System.Drawing.Point(47, 571);
            this.btnGetAllFunction.Name = "btnGetAllFunction";
            this.btnGetAllFunction.Size = new System.Drawing.Size(110, 62);
            this.btnGetAllFunction.TabIndex = 16;
            this.btnGetAllFunction.Text = "GetAll Function";
            this.btnGetAllFunction.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listViewDataAccessLayer);
            this.groupBox6.Location = new System.Drawing.Point(306, 573);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(454, 470);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DataAccess";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listViewBusinessLayer);
            this.groupBox7.Location = new System.Drawing.Point(858, 573);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(454, 470);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Business Layer";
            // 
            // listViewBusinessLayer
            // 
            this.listViewBusinessLayer.HideSelection = false;
            this.listViewBusinessLayer.Location = new System.Drawing.Point(6, 21);
            this.listViewBusinessLayer.Name = "listViewBusinessLayer";
            this.listViewBusinessLayer.Size = new System.Drawing.Size(430, 471);
            this.listViewBusinessLayer.TabIndex = 8;
            this.listViewBusinessLayer.UseCompatibleStateImageBehavior = false;
            this.listViewBusinessLayer.View = System.Windows.Forms.View.List;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbColumn2);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.cbTable2);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.cbTable1);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.cbColumn1);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.btnAddForeignKey);
            this.groupBox8.Location = new System.Drawing.Point(956, 432);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(449, 142);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Add Foreign Key";
            // 
            // cbColumn2
            // 
            this.cbColumn2.FormattingEnabled = true;
            this.cbColumn2.Location = new System.Drawing.Point(251, 62);
            this.cbColumn2.Name = "cbColumn2";
            this.cbColumn2.Size = new System.Drawing.Size(105, 24);
            this.cbColumn2.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Column 2";
            // 
            // cbTable2
            // 
            this.cbTable2.FormattingEnabled = true;
            this.cbTable2.Location = new System.Drawing.Point(65, 62);
            this.cbTable2.Name = "cbTable2";
            this.cbTable2.Size = new System.Drawing.Size(99, 24);
            this.cbTable2.TabIndex = 14;
            this.cbTable2.SelectedIndexChanged += new System.EventHandler(this.cbTable2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Table 2";
            // 
            // cbTable1
            // 
            this.cbTable1.FormattingEnabled = true;
            this.cbTable1.Location = new System.Drawing.Point(65, 21);
            this.cbTable1.Name = "cbTable1";
            this.cbTable1.Size = new System.Drawing.Size(99, 24);
            this.cbTable1.TabIndex = 12;
            this.cbTable1.SelectedIndexChanged += new System.EventHandler(this.cbTable1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Table 1";
            // 
            // cbColumn1
            // 
            this.cbColumn1.FormattingEnabled = true;
            this.cbColumn1.Location = new System.Drawing.Point(251, 23);
            this.cbColumn1.Name = "cbColumn1";
            this.cbColumn1.Size = new System.Drawing.Size(105, 24);
            this.cbColumn1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Column 1";
            // 
            // btnAddForeignKey
            // 
            this.btnAddForeignKey.Location = new System.Drawing.Point(293, 94);
            this.btnAddForeignKey.Name = "btnAddForeignKey";
            this.btnAddForeignKey.Size = new System.Drawing.Size(126, 41);
            this.btnAddForeignKey.TabIndex = 6;
            this.btnAddForeignKey.Text = "Add Foreign Key";
            this.btnAddForeignKey.UseVisualStyleBackColor = true;
            this.btnAddForeignKey.Click += new System.EventHandler(this.btnAddForeignKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 1055);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnGetAllFunction);
            this.Controls.Add(this.btnDeleteFunction);
            this.Controls.Add(this.btnFindFunction);
            this.Controls.Add(this.btnUpdateFunction);
            this.Controls.Add(this.btnAddFunction);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewColumns);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewDataAccessLayer;
        private System.Windows.Forms.ListView listViewColumns;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetProperties;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkIsNull;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDatatypeSize;
        private System.Windows.Forms.ComboBox cbDataTypes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddColumns;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbColumns;
        private System.Windows.Forms.Button btnAddPrimaryKey;
        private System.Windows.Forms.Button btnAddFunction;
        private System.Windows.Forms.Button btnUpdateFunction;
        private System.Windows.Forms.Button btnFindFunction;
        private System.Windows.Forms.Button btnDeleteFunction;
        private System.Windows.Forms.Button btnGetAllFunction;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListView listViewBusinessLayer;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cbColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddForeignKey;
        private System.Windows.Forms.ComboBox cbColumn2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbTable2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTable1;
        private System.Windows.Forms.Label label3;
    }
}

