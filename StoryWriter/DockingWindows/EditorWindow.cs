using System;
using WeifenLuo.WinFormsUI.Docking;

namespace StoryWriter.DockingWindows
{
    public partial class EditorWindow : DockContent
    {
        public event EventHandler TextChanged;
        public string[] Lines { get; set; }

        public EditorWindow()
        {
            InitializeComponent();
            RtbEditor.Enabled = false;
        }

        public void EnableEditor()
        {
            RtbEditor.Enabled = true;
        }

        private void RtbEditor_TextChanged(object sender, System.EventArgs e)
        { 
            Lines = RtbEditor.Lines;
            TextChanged?.Invoke(this, new EventArgs());
        }

        public void SetTextToNewChapter()
        {
            RtbEditor.Lines = Lines;
        }
    }
}
