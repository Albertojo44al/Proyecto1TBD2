namespace Proyecto1TBD2
{
    partial class ConnectDataBase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Button();
            this.Database = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.charset = new System.Windows.Forms.ComboBox();
            this.alias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 120);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "DataBase Login";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(91, 63);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(148, 22);
            this.user.TabIndex = 5;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(343, 65);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(148, 22);
            this.pass.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(259, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(28, 281);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(132, 29);
            this.test.TabIndex = 8;
            this.test.Text = "Test connection";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Database
            // 
            this.Database.Location = new System.Drawing.Point(184, 42);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(148, 22);
            this.Database.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "DataBase Name";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(31, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Charset";
            // 
            // charset
            // 
            this.charset.FormattingEnabled = true;
            this.charset.Items.AddRange(new object[] {
            "UTF8",
            "ASCII",
            "UNICODE_FSS"});
            this.charset.Location = new System.Drawing.Point(121, 334);
            this.charset.Name = "charset";
            this.charset.Size = new System.Drawing.Size(121, 24);
            this.charset.TabIndex = 12;
            this.charset.Text = "UTF8";
            // 
            // alias
            // 
            this.alias.Location = new System.Drawing.Point(184, 91);
            this.alias.Name = "alias";
            this.alias.Size = new System.Drawing.Size(148, 22);
            this.alias.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(36, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Alias";
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(399, 391);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(97, 29);
            this.finish.TabIndex = 15;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(273, 391);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(97, 29);
            this.back.TabIndex = 16;
            this.back.Text = "< Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ConnectDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.alias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.charset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.test);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.label3);
            this.Name = "ConnectDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect DataBase";
            this.Load += new System.EventHandler(this.ConnectDataBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Database;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox charset;
        private System.Windows.Forms.TextBox alias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button back;
    }
}