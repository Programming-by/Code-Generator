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
            this.gbTableInfo = new System.Windows.Forms.GroupBox();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.txtTabeleSingleName = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewLayers = new System.Windows.Forms.ListView();
            this.listViewColumns = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBusiness = new System.Windows.Forms.Button();
            this.btnDataAccess = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.gbTableInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTableInfo
            // 
            this.gbTableInfo.Controls.Add(this.btnAddTable);
            this.gbTableInfo.Controls.Add(this.txtTabeleSingleName);
            this.gbTableInfo.Controls.Add(this.txtTableName);
            this.gbTableInfo.Controls.Add(this.label2);
            this.gbTableInfo.Controls.Add(this.label1);
            this.gbTableInfo.Location = new System.Drawing.Point(22, 86);
            this.gbTableInfo.Name = "gbTableInfo";
            this.gbTableInfo.Size = new System.Drawing.Size(410, 145);
            this.gbTableInfo.TabIndex = 0;
            this.gbTableInfo.TabStop = false;
            this.gbTableInfo.Text = "Table Info";
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(318, 64);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 62);
            this.btnAddTable.TabIndex = 6;
            this.btnAddTable.Text = "Add";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // txtTabeleSingleName
            // 
            this.txtTabeleSingleName.Location = new System.Drawing.Point(146, 89);
            this.txtTabeleSingleName.Name = "txtTabeleSingleName";
            this.txtTabeleSingleName.Size = new System.Drawing.Size(142, 22);
            this.txtTabeleSingleName.TabIndex = 4;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(113, 33);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(142, 22);
            this.txtTableName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Table Single Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name";
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
            // listViewLayers
            // 
            this.listViewLayers.HideSelection = false;
            this.listViewLayers.Location = new System.Drawing.Point(489, 86);
            this.listViewLayers.Name = "listViewLayers";
            this.listViewLayers.Size = new System.Drawing.Size(410, 471);
            this.listViewLayers.TabIndex = 8;
            this.listViewLayers.UseCompatibleStateImageBehavior = false;
            // 
            // listViewColumns
            // 
            this.listViewColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewColumns.HideSelection = false;
            this.listViewColumns.Location = new System.Drawing.Point(22, 259);
            this.listViewColumns.Name = "listViewColumns";
            this.listViewColumns.Size = new System.Drawing.Size(410, 344);
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
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(22, 701);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 62);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnBusiness
            // 
            this.btnBusiness.Location = new System.Drawing.Point(489, 574);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(130, 62);
            this.btnBusiness.TabIndex = 8;
            this.btnBusiness.Text = "Show Business Layer";
            this.btnBusiness.UseVisualStyleBackColor = true;
            // 
            // btnDataAccess
            // 
            this.btnDataAccess.Location = new System.Drawing.Point(789, 574);
            this.btnDataAccess.Name = "btnDataAccess";
            this.btnDataAccess.Size = new System.Drawing.Size(110, 62);
            this.btnDataAccess.TabIndex = 10;
            this.btnDataAccess.Text = "Show Data Access Layer";
            this.btnDataAccess.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(925, 495);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 62);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 650);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Of Records";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Location = new System.Drawing.Point(19, 650);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(28, 16);
            this.lblNumberOfRecords.TabIndex = 12;
            this.lblNumberOfRecords.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 766);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDataAccess);
            this.Controls.Add(this.btnBusiness);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.listViewColumns);
            this.Controls.Add(this.listViewLayers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbTableInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTableInfo.ResumeLayout(false);
            this.gbTableInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTableInfo;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TextBox txtTabeleSingleName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewLayers;
        private System.Windows.Forms.ListView listViewColumns;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBusiness;
        private System.Windows.Forms.Button btnDataAccess;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumberOfRecords;
    }
}

