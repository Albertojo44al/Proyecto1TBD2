namespace Proyecto1TBD2
{
    partial class ForeignKey
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
            this.foreign = new System.Windows.Forms.TextBox();
            this.tabs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actualTable = new System.Windows.Forms.Label();
            this.commit = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foreign
            // 
            this.foreign.Location = new System.Drawing.Point(44, 206);
            this.foreign.Name = "foreign";
            this.foreign.Size = new System.Drawing.Size(100, 22);
            this.foreign.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.FormattingEnabled = true;
            this.tabs.Location = new System.Drawing.Point(44, 96);
            this.tabs.Name = "tabs";
            this.tabs.Size = new System.Drawing.Size(121, 24);
            this.tabs.TabIndex = 1;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Foreign key";
            // 
            // actualTable
            // 
            this.actualTable.AutoSize = true;
            this.actualTable.Location = new System.Drawing.Point(87, 19);
            this.actualTable.Name = "actualTable";
            this.actualTable.Size = new System.Drawing.Size(44, 17);
            this.actualTable.TabIndex = 4;
            this.actualTable.Text = "Table";
            // 
            // commit
            // 
            this.commit.Location = new System.Drawing.Point(119, 314);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(75, 23);
            this.commit.TabIndex = 5;
            this.commit.Text = "Commit";
            this.commit.UseVisualStyleBackColor = true;
            this.commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(191, 97);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 23);
            this.select.TabIndex = 6;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Primary key";
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Location = new System.Drawing.Point(188, 209);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(38, 17);
            this.key.TabIndex = 8;
            this.key.Text = "------";
            // 
            // ForeignKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 385);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.select);
            this.Controls.Add(this.commit);
            this.Controls.Add(this.actualTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.foreign);
            this.Name = "ForeignKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForeignKey";
            this.Load += new System.EventHandler(this.ForeignKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox foreign;
        private System.Windows.Forms.ComboBox tabs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label actualTable;
        private System.Windows.Forms.Button commit;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label key;
    }
}