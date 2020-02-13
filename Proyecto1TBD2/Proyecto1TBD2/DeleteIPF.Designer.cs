namespace Proyecto1TBD2
{
    partial class DeleteIPF
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
            this.dIndex = new System.Windows.Forms.CheckBox();
            this.dPrimary = new System.Windows.Forms.CheckBox();
            this.dForeign = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // commit
            // 
            this.commit.Location = new System.Drawing.Point(118, 279);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(98, 30);
            this.commit.TabIndex = 0;
            this.commit.Text = "Commit";
            this.commit.UseVisualStyleBackColor = true;
            this.commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // dIndex
            // 
            this.dIndex.AutoSize = true;
            this.dIndex.Location = new System.Drawing.Point(118, 65);
            this.dIndex.Name = "dIndex";
            this.dIndex.Size = new System.Drawing.Size(98, 21);
            this.dIndex.TabIndex = 1;
            this.dIndex.Text = "Drop index";
            this.dIndex.UseVisualStyleBackColor = true;
            // 
            // dPrimary
            // 
            this.dPrimary.AutoSize = true;
            this.dPrimary.Location = new System.Drawing.Point(118, 132);
            this.dPrimary.Name = "dPrimary";
            this.dPrimary.Size = new System.Drawing.Size(138, 21);
            this.dPrimary.TabIndex = 2;
            this.dPrimary.Text = "Drop primary key";
            this.dPrimary.UseVisualStyleBackColor = true;
            // 
            // dForeign
            // 
            this.dForeign.AutoSize = true;
            this.dForeign.Location = new System.Drawing.Point(118, 192);
            this.dForeign.Name = "dForeign";
            this.dForeign.Size = new System.Drawing.Size(135, 21);
            this.dForeign.TabIndex = 3;
            this.dForeign.Text = "Drop foreign key";
            this.dForeign.UseVisualStyleBackColor = true;
            // 
            // DeleteIPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 385);
            this.Controls.Add(this.dForeign);
            this.Controls.Add(this.dPrimary);
            this.Controls.Add(this.dIndex);
            this.Controls.Add(this.commit);
            this.Name = "DeleteIPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.DeleteIPF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button commit;
        private System.Windows.Forms.CheckBox dIndex;
        private System.Windows.Forms.CheckBox dPrimary;
        private System.Windows.Forms.CheckBox dForeign;
    }
}