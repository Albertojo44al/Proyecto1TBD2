namespace Proyecto1TBD2
{
    partial class Triggers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triggers));
            this.nameTrigger = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.ComboBox();
            this.before = new System.Windows.Forms.RadioButton();
            this.after = new System.Windows.Forms.RadioButton();
            this.insert = new System.Windows.Forms.CheckBox();
            this.update = new System.Windows.Forms.CheckBox();
            this.delete = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.RichTextBox();
            this.updatePrimary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.compile = new System.Windows.Forms.Button();
            this.showTriggers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTrigger
            // 
            this.nameTrigger.Location = new System.Drawing.Point(143, 41);
            this.nameTrigger.Name = "nameTrigger";
            this.nameTrigger.Size = new System.Drawing.Size(146, 22);
            this.nameTrigger.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "For table";
            // 
            // tabs
            // 
            this.tabs.FormattingEnabled = true;
            this.tabs.Location = new System.Drawing.Point(434, 41);
            this.tabs.Name = "tabs";
            this.tabs.Size = new System.Drawing.Size(121, 24);
            this.tabs.TabIndex = 3;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // before
            // 
            this.before.AutoSize = true;
            this.before.Location = new System.Drawing.Point(56, 29);
            this.before.Name = "before";
            this.before.Size = new System.Drawing.Size(71, 21);
            this.before.TabIndex = 4;
            this.before.TabStop = true;
            this.before.Text = "Before";
            this.before.UseVisualStyleBackColor = true;
            // 
            // after
            // 
            this.after.AutoSize = true;
            this.after.Location = new System.Drawing.Point(56, 70);
            this.after.Name = "after";
            this.after.Size = new System.Drawing.Size(59, 21);
            this.after.TabIndex = 5;
            this.after.TabStop = true;
            this.after.Text = "After";
            this.after.UseVisualStyleBackColor = true;
            // 
            // insert
            // 
            this.insert.AutoSize = true;
            this.insert.Location = new System.Drawing.Point(33, 38);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(65, 21);
            this.insert.TabIndex = 6;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.Location = new System.Drawing.Point(150, 39);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(76, 21);
            this.update.TabIndex = 7;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Location = new System.Drawing.Point(270, 40);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(71, 21);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.before);
            this.panel1.Controls.Add(this.after);
            this.panel1.Location = new System.Drawing.Point(25, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.insert);
            this.panel2.Controls.Add(this.update);
            this.panel2.Location = new System.Drawing.Point(287, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 73);
            this.panel2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "On event";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(60, 246);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(864, 306);
            this.code.TabIndex = 13;
            this.code.Text = "BEGIN\n\n\nEND;";
            // 
            // updatePrimary
            // 
            this.updatePrimary.BackColor = System.Drawing.Color.Azure;
            this.updatePrimary.FlatAppearance.BorderSize = 0;
            this.updatePrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePrimary.Image = ((System.Drawing.Image)(resources.GetObject("updatePrimary.Image")));
            this.updatePrimary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatePrimary.Location = new System.Drawing.Point(592, 199);
            this.updatePrimary.Name = "updatePrimary";
            this.updatePrimary.Size = new System.Drawing.Size(140, 24);
            this.updatePrimary.TabIndex = 37;
            this.updatePrimary.Text = "Update trigger";
            this.updatePrimary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updatePrimary.UseVisualStyleBackColor = false;
            this.updatePrimary.Click += new System.EventHandler(this.updatePrimary_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(434, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 24);
            this.button1.TabIndex = 36;
            this.button1.Text = "Delete trigger";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // compile
            // 
            this.compile.BackColor = System.Drawing.Color.Azure;
            this.compile.FlatAppearance.BorderSize = 0;
            this.compile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compile.Location = new System.Drawing.Point(836, 199);
            this.compile.Name = "compile";
            this.compile.Size = new System.Drawing.Size(76, 24);
            this.compile.TabIndex = 35;
            this.compile.Text = "Compile";
            this.compile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.compile.UseVisualStyleBackColor = false;
            this.compile.Click += new System.EventHandler(this.compile_Click);
            // 
            // showTriggers
            // 
            this.showTriggers.FormattingEnabled = true;
            this.showTriggers.Location = new System.Drawing.Point(791, 41);
            this.showTriggers.Name = "showTriggers";
            this.showTriggers.Size = new System.Drawing.Size(121, 24);
            this.showTriggers.TabIndex = 39;
            this.showTriggers.SelectedIndexChanged += new System.EventHandler(this.showTriggers_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Triggers";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Azure;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(287, 199);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(126, 24);
            this.add.TabIndex = 40;
            this.add.Text = "Add trigger";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Triggers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 612);
            this.Controls.Add(this.add);
            this.Controls.Add(this.showTriggers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updatePrimary);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.compile);
            this.Controls.Add(this.code);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTrigger);
            this.Name = "Triggers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Triggers";
            this.Load += new System.EventHandler(this.Triggers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTrigger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tabs;
        private System.Windows.Forms.RadioButton before;
        private System.Windows.Forms.RadioButton after;
        private System.Windows.Forms.CheckBox insert;
        private System.Windows.Forms.CheckBox update;
        private System.Windows.Forms.CheckBox delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox code;
        private System.Windows.Forms.Button updatePrimary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button compile;
        private System.Windows.Forms.ComboBox showTriggers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add;
    }
}