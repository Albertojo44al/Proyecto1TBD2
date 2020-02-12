namespace Proyecto1TBD2
{
    partial class AddView
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
            this.show = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.viewColumn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameView = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(304, 56);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 8;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click_1);
            // 
            // tabs
            // 
            this.tabs.FormattingEnabled = true;
            this.tabs.Location = new System.Drawing.Point(147, 56);
            this.tabs.Name = "tabs";
            this.tabs.Size = new System.Drawing.Size(121, 24);
            this.tabs.TabIndex = 7;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(12, 106);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(517, 371);
            this.dataTable.TabIndex = 5;
            this.dataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellClick);
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentClick);
            // 
            // nameColumn
            // 
            this.nameColumn.Location = new System.Drawing.Point(205, 82);
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Size = new System.Drawing.Size(100, 22);
            this.nameColumn.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(793, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Compile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(230, 211);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 11;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nameView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.viewColumn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.nameColumn);
            this.panel1.Location = new System.Drawing.Point(562, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 257);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name view column";
            // 
            // viewColumn
            // 
            this.viewColumn.Location = new System.Drawing.Point(205, 136);
            this.viewColumn.Name = "viewColumn";
            this.viewColumn.Size = new System.Drawing.Size(100, 22);
            this.viewColumn.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name of column";
            // 
            // nameView
            // 
            this.nameView.Location = new System.Drawing.Point(205, 24);
            this.nameView.Name = "nameView";
            this.nameView.Size = new System.Drawing.Size(100, 22);
            this.nameView.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name of view";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "__________________________________";
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTable);
            this.Name = "AddView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show;
        private System.Windows.Forms.ComboBox tabs;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.TextBox nameColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox viewColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameView;
    }
}