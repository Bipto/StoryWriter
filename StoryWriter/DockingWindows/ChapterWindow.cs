using StoryWriter.Storage;
using WeifenLuo.WinFormsUI.Docking;

namespace StoryWriter.DockingWindows
{
    public partial class ChapterWindow : DockContent
    {
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
                TvwChapters.Nodes[0].Nodes.Add(chapter.Name);
            TvwChapters.EndUpdate();
            TvwChapters.ExpandAll();
        }
    }
}
