﻿namespace Proyecto1TBD2
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
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 559);
            this.Controls.Add(this.done);
            this.Name = "AddData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddData";
            this.Load += new System.EventHandler(this.AddData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button done;
    }
}