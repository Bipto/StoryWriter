
namespace StoryWriter.DockingWindows
{
    partial class ChapterWindow
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
            this.TvwChapters = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // TvwChapters
            // 
            this.TvwChapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvwChapters.Location = new System.Drawing.Point(0, 0);
            this.TvwChapters.Name = "TvwChapters";
            this.TvwChapters.Size = new System.Drawing.Size(800, 450);
            this.TvwChapters.TabIndex = 0;
            this.TvwChapters.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvwChapters_AfterSelect);
            // 
            // ChapterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TvwChapters);
            this.Name = "ChapterWindow";
            this.Text = "ChapterWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TvwChapters;
    }
}