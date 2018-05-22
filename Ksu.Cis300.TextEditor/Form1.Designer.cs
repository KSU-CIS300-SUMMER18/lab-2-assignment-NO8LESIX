namespace Ksu.Cis300.TextEditor
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
            this.uxFileMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.uxOpenFileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFileDialogue = new System.Windows.Forms.SaveFileDialog();
            this.uxFileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxFileMenu
            // 
            this.uxFileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.uxFileMenu.Location = new System.Drawing.Point(0, 0);
            this.uxFileMenu.Name = "uxFileMenu";
            this.uxFileMenu.Size = new System.Drawing.Size(484, 24);
            this.uxFileMenu.TabIndex = 0;
            this.uxFileMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPenToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // oPenToolStripMenuItem
            // 
            this.oPenToolStripMenuItem.Name = "oPenToolStripMenuItem";
            this.oPenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oPenToolStripMenuItem.Text = "Open...";
            this.oPenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 27);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(460, 622);
            this.TextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.uxFileMenu);
            this.MainMenuStrip = this.uxFileMenu;
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.uxFileMenu.ResumeLayout(false);
            this.uxFileMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxFileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialogue;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialogue;
    }
}

