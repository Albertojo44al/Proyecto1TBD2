namespace Proyecto1TBD2
{
    partial class Indexes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indexes));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.indexesTable = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.primaryTable = new System.Windows.Forms.DataGridView();
            this.foreignTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.indexS = new System.Windows.Forms.Label();
            this.primaryS = new System.Windows.Forms.Label();
            this.foreignS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updatePrimary = new System.Windows.Forms.Button();
            this.updateForeign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.indexesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primaryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreignTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Index";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(512, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete field";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Azure;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(336, 540);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(115, 24);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add index";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // indexesTable
            // 
            this.indexesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indexesTable.Location = new System.Drawing.Point(48, 112);
            this.indexesTable.Name = "indexesTable";
            this.indexesTable.RowHeadersWidth = 51;
            this.indexesTable.RowTemplate.Height = 24;
            this.indexesTable.Size = new System.Drawing.Size(262, 278);
            this.indexesTable.TabIndex = 9;
            this.indexesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.indexesTable_CellClick);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(204, 541);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Foreign key";
            // 
            // primaryTable
            // 
            this.primaryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.primaryTable.Location = new System.Drawing.Point(388, 112);
            this.primaryTable.Name = "primaryTable";
            this.primaryTable.RowHeadersWidth = 51;
            this.primaryTable.RowTemplate.Height = 24;
            this.primaryTable.Size = new System.Drawing.Size(260, 278);
            this.primaryTable.TabIndex = 19;
            this.primaryTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.primaryTable_CellClick);
            // 
            // foreignTable
            // 
            this.foreignTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foreignTable.Location = new System.Drawing.Point(724, 112);
            this.foreignTable.Name = "foreignTable";
            this.foreignTable.RowHeadersWidth = 51;
            this.foreignTable.RowTemplate.Height = 24;
            this.foreignTable.Size = new System.Drawing.Size(265, 278);
            this.foreignTable.TabIndex = 23;
            this.foreignTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foreignTable_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Primary keys";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Foreign keys";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Primary key";
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(84, 541);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 23);
            this.button6.TabIndex = 28;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // indexS
            // 
            this.indexS.AutoSize = true;
            this.indexS.Location = new System.Drawing.Point(120, 461);
            this.indexS.Name = "indexS";
            this.indexS.Size = new System.Drawing.Size(38, 17);
            this.indexS.TabIndex = 30;
            this.indexS.Text = "------";
            // 
            // primaryS
            // 
            this.primaryS.AutoSize = true;
            this.primaryS.Location = new System.Drawing.Point(446, 461);
            this.primaryS.Name = "primaryS";
            this.primaryS.Size = new System.Drawing.Size(38, 17);
            this.primaryS.TabIndex = 31;
            this.primaryS.Text = "------";
            // 
            // foreignS
            // 
            this.foreignS.AutoSize = true;
            this.foreignS.Location = new System.Drawing.Point(787, 461);
            this.foreignS.Name = "foreignS";
            this.foreignS.Size = new System.Drawing.Size(38, 17);
            this.foreignS.TabIndex = 32;
            this.foreignS.Text = "------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Selected:";
            // 
            // updatePrimary
            // 
            this.updatePrimary.BackColor = System.Drawing.Color.Azure;
            this.updatePrimary.FlatAppearance.BorderSize = 0;
            this.updatePrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePrimary.Image = ((System.Drawing.Image)(resources.GetObject("updatePrimary.Image")));
            this.updatePrimary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatePrimary.Location = new System.Drawing.Point(468, 408);
            this.updatePrimary.Name = "updatePrimary";
            this.updatePrimary.Size = new System.Drawing.Size(102, 24);
            this.updatePrimary.TabIndex = 34;
            this.updatePrimary.Text = "Update";
            this.updatePrimary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updatePrimary.UseVisualStyleBackColor = false;
            this.updatePrimary.Click += new System.EventHandler(this.updatePrimary_Click);
            // 
            // updateForeign
            // 
            this.updateForeign.BackColor = System.Drawing.Color.Azure;
            this.updateForeign.FlatAppearance.BorderSize = 0;
            this.updateForeign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateForeign.Image = ((System.Drawing.Image)(resources.GetObject("updateForeign.Image")));
            this.updateForeign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateForeign.Location = new System.Drawing.Point(804, 408);
            this.updateForeign.Name = "updateForeign";
            this.updateForeign.Size = new System.Drawing.Size(102, 24);
            this.updateForeign.TabIndex = 35;
            this.updateForeign.Text = "Update";
            this.updateForeign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateForeign.UseVisualStyleBackColor = false;
            this.updateForeign.Click += new System.EventHandler(this.updateForeign_Click);
            // 
            // Indexes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 612);
            this.Controls.Add(this.updateForeign);
            this.Controls.Add(this.updatePrimary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.foreignS);
            this.Controls.Add(this.primaryS);
            this.Controls.Add(this.indexS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.foreignTable);
            this.Controls.Add(this.primaryTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.indexesTable);
            this.Controls.Add(this.label1);
            this.Name = "Indexes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Indexes";
            this.Load += new System.EventHandler(this.Indexes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.indexesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primaryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreignTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.DataGridView indexesTable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView primaryTable;
        public System.Windows.Forms.DataGridView foreignTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label indexS;
        private System.Windows.Forms.Label primaryS;
        private System.Windows.Forms.Label foreignS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updatePrimary;
        private System.Windows.Forms.Button updateForeign;
    }
}