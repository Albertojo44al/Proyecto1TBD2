namespace Proyecto1TBD2
{
    partial class AddIndex
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
            this.newIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.commit = new System.Windows.Forms.Button();
            this.actualTable = new System.Windows.Forms.Label();
            this.columns = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unique = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // newIndex
            // 
            this.newIndex.Location = new System.Drawing.Point(168, 105);
            this.newIndex.Name = "newIndex";
            this.newIndex.Size = new System.Drawing.Size(100, 22);
            this.newIndex.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "New index";
            // 
            // commit
            // 
            this.commit.Location = new System.Drawing.Point(123, 302);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(75, 23);
            this.commit.TabIndex = 25;
            this.commit.Text = "Commit";
            this.commit.UseVisualStyleBackColor = true;
            this.commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // actualTable
            // 
            this.actualTable.AutoSize = true;
            this.actualTable.Location = new System.Drawing.Point(39, 43);
            this.actualTable.Name = "actualTable";
            this.actualTable.Size = new System.Drawing.Size(38, 17);
            this.actualTable.TabIndex = 26;
            this.actualTable.Text = "------";
            // 
            // columns
            // 
            this.columns.FormattingEnabled = true;
            this.columns.Location = new System.Drawing.Point(168, 221);
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(121, 24);
            this.columns.TabIndex = 27;
            this.columns.SelectedIndexChanged += new System.EventHandler(this.columns_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Columns";
            // 
            // unique
            // 
            this.unique.AutoSize = true;
            this.unique.Location = new System.Drawing.Point(42, 165);
            this.unique.Name = "unique";
            this.unique.Size = new System.Drawing.Size(75, 21);
            this.unique.TabIndex = 29;
            this.unique.Text = "Unique";
            this.unique.UseVisualStyleBackColor = true;
            // 
            // AddIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 385);
            this.Controls.Add(this.unique);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.actualTable);
            this.Controls.Add(this.commit);
            this.Controls.Add(this.newIndex);
            this.Controls.Add(this.label1);
            this.Name = "AddIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIndex";
            this.Load += new System.EventHandler(this.AddIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button commit;
        private System.Windows.Forms.Label actualTable;
        private System.Windows.Forms.ComboBox columns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox unique;
    }
}