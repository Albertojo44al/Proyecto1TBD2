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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nameView = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.column = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(821, 26);
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
            this.tabs.Location = new System.Drawing.Point(664, 26);
            this.tabs.Name = "tabs";
            this.tabs.Size = new System.Drawing.Size(121, 24);
            this.tabs.TabIndex = 7;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(589, 76);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(396, 371);
            this.dataTable.TabIndex = 5;
            this.dataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellClick);
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Compile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name of view";
            // 
            // nameView
            // 
            this.nameView.Location = new System.Drawing.Point(173, 29);
            this.nameView.Name = "nameView";
            this.nameView.Size = new System.Drawing.Size(100, 22);
            this.nameView.TabIndex = 16;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(36, 76);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(520, 371);
            this.code.TabIndex = 18;
            this.code.Text = "    (\" \",\n     \" \",\n     \" \"\n      )\n      AS\n         SELECT \n         FROM\n    " +
    "     WHERE; ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Column";
            // 
            // column
            // 
            this.column.Location = new System.Drawing.Point(444, 29);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(100, 22);
            this.column.TabIndex = 19;
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.column);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameView);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show;
        private System.Windows.Forms.ComboBox tabs;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameView;
        private System.Windows.Forms.RichTextBox code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox column;
    }
}