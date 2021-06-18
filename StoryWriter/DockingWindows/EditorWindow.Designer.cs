
namespace StoryWriter.DockingWindows
{
    partial class EditorWindow
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
            this.RtbEditor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RtbEditor
            // 
            this.RtbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbEditor.Location = new System.Drawing.Point(0, 0);
            this.RtbEditor.Name = "RtbEditor";
            this.RtbEditor.Size = new System.Drawing.Size(800, 450);
            this.RtbEditor.TabIndex = 0;
            this.RtbEditor.Text = "";
            this.RtbEditor.TextChanged += new System.EventHandler(this.RtbEditor_TextChanged);
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RtbEditor);
            this.Name = "EditorWindow";
            this.Text = "EditorWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbEditor;
    }
}