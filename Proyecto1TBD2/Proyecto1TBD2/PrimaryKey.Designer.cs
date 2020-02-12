namespace Proyecto1TBD2
{
    partial class PrimaryKey
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
            this.actualTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commit = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.newPrimary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // actualTable
            // 
            this.actualTable.AutoSize = true;
            this.actualTable.Location = new System.Drawing.Point(83, 23);
            this.actualTable.Name = "actualTable";
            this.actualTable.Size = new System.Drawing.Size(44, 17);
            this.actualTable.TabIndex = 9;
            this.actualTable.Text = "Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "New primary key";
            // 
            // commit
            // 
            this.commit.Location = new System.Drawing.Point(123, 328);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(75, 23);
            this.commit.TabIndex = 11;
            this.commit.Text = "Commit";
            this.commit.UseVisualStyleBackColor = true;
            this.commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(40, 112);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(260, 176);
            this.dataTable.TabIndex = 20;
            this.dataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellClick);
            // 
            // newPrimary
            // 
            this.newPrimary.Location = new System.Drawing.Point(166, 62);
            this.newPrimary.Name = "newPrimary";
            this.newPrimary.Size = new System.Drawing.Size(100, 22);
            this.newPrimary.TabIndex = 21;
            // 
            // PrimaryKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 385);
            this.Controls.Add(this.newPrimary);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.commit);
            this.Controls.Add(this.actualTable);
            this.Controls.Add(this.label1);
            this.Name = "PrimaryKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimaryKey";
            this.Load += new System.EventHandler(this.PrimaryKey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label actualTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button commit;
        public System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.TextBox newPrimary;
    }
}