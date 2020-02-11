namespace Proyecto1TBD2
{
    partial class NewTable
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
            this.commit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newField = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.fieldName = new System.Windows.Forms.TextBox();
            this.primarykey = new System.Windows.Forms.CheckBox();
            this.notnull = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // commit
            // 
            this.commit.Location = new System.Drawing.Point(434, 385);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(89, 23);
            this.commit.TabIndex = 0;
            this.commit.Text = "Commit";
            this.commit.UseVisualStyleBackColor = true;
            this.commit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table name ";
            // 
            // tablename
            // 
            this.tablename.Location = new System.Drawing.Point(147, 42);
            this.tablename.Name = "tablename";
            this.tablename.Size = new System.Drawing.Size(186, 22);
            this.tablename.TabIndex = 2;
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
            // newField
            // 
            this.newField.Location = new System.Drawing.Point(421, 171);
            this.newField.Name = "newField";
            this.newField.Size = new System.Drawing.Size(89, 23);
            this.newField.TabIndex = 4;
            this.newField.Text = "New Field";
            this.newField.UseVisualStyleBackColor = true;
            this.newField.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
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
            this.panel1.Controls.Add(this.newField);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 212);
            this.panel1.TabIndex = 5;
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
            // fieldName
            // 
            this.fieldName.Location = new System.Drawing.Point(134, 81);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(148, 22);
            this.fieldName.TabIndex = 7;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Field";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "SMALLINT",
            "INTEGER",
            "FLOAT",
            "DATE",
            "TIME",
            "CHAR",
            "VARCHAR"});
            this.type.Location = new System.Drawing.Point(134, 121);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 24);
            this.type.TabIndex = 7;
            this.type.Text = "SMALLINT";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(316, 385);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(89, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button3_Click);
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
            this.length.TextChanged += new System.EventHandler(this.length_TextChanged);
            // 
            // NewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 446);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commit);
            this.Name = "NewTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button commit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tablename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox primarykey;
        private System.Windows.Forms.CheckBox notnull;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fieldName;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label4;
    }
}