﻿namespace CodeFirst_StudentClassrom
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ıdentifyClassroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıdentifyStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ıdentifyClassroomToolStripMenuItem,
            this.ıdentifyStudentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ıdentifyClassroomToolStripMenuItem
            // 
            this.ıdentifyClassroomToolStripMenuItem.Name = "ıdentifyClassroomToolStripMenuItem";
            this.ıdentifyClassroomToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.ıdentifyClassroomToolStripMenuItem.Text = "Identify Classrooms";
            this.ıdentifyClassroomToolStripMenuItem.Click += new System.EventHandler(this.ıdentifyClassroomToolStripMenuItem_Click);
            // 
            // ıdentifyStudentsToolStripMenuItem
            // 
            this.ıdentifyStudentsToolStripMenuItem.Name = "ıdentifyStudentsToolStripMenuItem";
            this.ıdentifyStudentsToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.ıdentifyStudentsToolStripMenuItem.Text = "Identify Students";
            this.ıdentifyStudentsToolStripMenuItem.Click += new System.EventHandler(this.ıdentifyStudentsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ıdentifyClassroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıdentifyStudentsToolStripMenuItem;
    }
}

