namespace Proyecto1TBD2
{
    partial class AddData
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
            this.done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(395, 481);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(81, 31);
            this.done.TabIndex = 0;
            this.done.Text = "Commit";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "if it is text place in quotes \'  \'";
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.done);
            this.Name = "AddData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddData";
            this.Load += new System.EventHandler(this.AddData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label label1;
    }
}