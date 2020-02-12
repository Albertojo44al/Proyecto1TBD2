namespace Proyecto1TBD2
{
    partial class UpdateTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTable));
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.newField = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.notnull = new System.Windows.Forms.CheckBox();
            this.primarykey = new System.Windows.Forms.CheckBox();
            this.fieldName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(33, 54);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(260, 212);
            this.dataTable.TabIndex = 21;
            this.dataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellClick);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(112, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Delete";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newField
            // 
            this.newField.Image = ((System.Drawing.Image)(resources.GetObject("newField.Image")));
            this.newField.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newField.Location = new System.Drawing.Point(511, 321);
            this.newField.Name = "newField";
            this.newField.Size = new System.Drawing.Size(116, 23);
            this.newField.TabIndex = 4;
            this.newField.Text = "New Field";
            this.newField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newField.UseVisualStyleBackColor = true;
            this.newField.Click += new System.EventHandler(this.newField_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Field";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "SMALLINT",
            "INTEGER",
            "FLOAT",
            "DATE",
            "CHAR",
            "VARCHAR"});
            this.type.Location = new System.Drawing.Point(134, 121);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 24);
            this.type.TabIndex = 7;
            this.type.Text = "SMALLINT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Field";
            // 
            // notnull
            // 
            this.notnull.AutoSize = true;
            this.notnull.Location = new System.Drawing.Point(26, 35);
            this.notnull.Name = "notnull";
            this.notnull.Size = new System.Drawing.Size(78, 21);
            this.notnull.TabIndex = 9;
            this.notnull.Text = "Not null";
            this.notnull.UseVisualStyleBackColor = true;
            // 
            // primarykey
            // 
            this.primarykey.AutoSize = true;
            this.primarykey.Location = new System.Drawing.Point(210, 35);
            this.primarykey.Name = "primarykey";
            this.primarykey.Size = new System.Drawing.Size(148, 21);
            this.primarykey.TabIndex = 10;
            this.primarykey.Text = "Add to primary key";
            this.primarykey.UseVisualStyleBackColor = true;
            // 
            // fieldName
            // 
            this.fieldName.Location = new System.Drawing.Point(134, 81);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(148, 22);
            this.fieldName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "length";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(134, 168);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(84, 22);
            this.length.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.length);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fieldName);
            this.panel1.Controls.Add(this.primarykey);
            this.panel1.Controls.Add(this.notnull);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.type);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(344, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 212);
            this.panel1.TabIndex = 23;
            // 
            // UpdateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.newField);
            this.Name = "UpdateTable";
            this.Text = "UpdateTable";
            this.Load += new System.EventHandler(this.UpdateTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox notnull;
        private System.Windows.Forms.CheckBox primarykey;
        private System.Windows.Forms.TextBox fieldName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Panel panel1;
    }
}