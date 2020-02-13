namespace Proyecto1TBD2
{
    partial class CreateDataBase
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dialect = new System.Windows.Forms.ComboBox();
            this.charset = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(259, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "DataBase Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Database
            // 
            this.Database.Location = new System.Drawing.Point(195, 54);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(148, 22);
            this.Database.TabIndex = 4;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(91, 63);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(148, 22);
            this.user.TabIndex = 5;
            this.user.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(343, 65);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(148, 22);
            this.pass.TabIndex = 6;
            this.pass.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 120);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "DataBase Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dialect);
            this.panel2.Controls.Add(this.charset);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(29, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 120);
            this.panel2.TabIndex = 9;
            // 
            // dialect
            // 
            this.dialect.FormattingEnabled = true;
            this.dialect.Items.AddRange(new object[] {
            "3",
            "1"});
            this.dialect.Location = new System.Drawing.Point(207, 74);
            this.dialect.Name = "dialect";
            this.dialect.Size = new System.Drawing.Size(121, 24);
            this.dialect.TabIndex = 10;
            this.dialect.Text = "3";
            // 
            // charset
            // 
            this.charset.FormattingEnabled = true;
            this.charset.Items.AddRange(new object[] {
            "UTF8",
            "ASCII",
            "UNICODE_FSS"});
            this.charset.Location = new System.Drawing.Point(207, 36);
            this.charset.Name = "charset";
            this.charset.Size = new System.Drawing.Size(121, 24);
            this.charset.TabIndex = 9;
            this.charset.Text = "UTF8";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Other parameters";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Charset";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sql dialect";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(293, 399);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(97, 29);
            this.back.TabIndex = 17;
            this.back.Text = "< Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // CreateDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 468);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "CreateDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create DataBas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Database;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox dialect;
        private System.Windows.Forms.ComboBox charset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button back;
    }
}

