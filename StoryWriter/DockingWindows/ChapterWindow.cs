using StoryWriter.Storage;
using System;
using WeifenLuo.WinFormsUI.Docking;

namespace StoryWriter.DockingWindows
{
    public partial class ChapterWindow : DockContent
    {
        public event EventHandler ChapterSelected;

        public string SelectedChapter { get; private set; }

        public ChapterWindow()
        {
            InitializeComponent();
        }

        public void UpdateChapters(Story story)
        {
            TvwChapters.Nodes.Clear();
            TvwChapters.BeginUpdate();
            TvwChapters.Nodes.Add(story.Name);
            foreach (Chapter chapter in story.Chapters)
                TvwChapters.Nodes[0].Nodes.Add(chapter.Title);
            TvwChapters.EndUpdate();
            TvwChapters.ExpandAll();
        }

        private void TvwChapters_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            if (e.Node.Text != TvwChapters.Nodes[0].Text)
            {
                SelectedChapter = e.Node.Text;
                ChapterSelected?.Invoke(this, new EventArgs());
            }
        }
    }
}
