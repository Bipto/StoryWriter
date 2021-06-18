using Newtonsoft.Json;
using StoryWriter.DockingWindows;
using StoryWriter.Management;
using StoryWriter.Storage;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace StoryWriter
{
    public partial class StoryWriter : Form
    {
        private Story _story;
        private string _filepath;
        private ChapterWindow _chapterWindow;
        private EditorWindow _editorWindow;
        private ViewerWindow _viewerWindow;

        public StoryWriter()
        {
            InitializeComponent();

            _chapterWindow = new ChapterWindow();
            _chapterWindow.Text = "Chapters";
            _chapterWindow.CloseButtonVisible = false;
            _chapterWindow.Show(dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockLeftAutoHide);

            _editorWindow = new EditorWindow();
            _editorWindow.Text = "Editor";
            _editorWindow.CloseButtonVisible = false;
            _editorWindow.AllowEndUserDocking = false;
            _editorWindow.Show(dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);

            _viewerWindow = new ViewerWindow();
            _viewerWindow.Text = "View";
            _viewerWindow.CloseButtonVisible = false;
            _viewerWindow.AllowEndUserDocking = false;
            _viewerWindow.Show(dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);

            _editorWindow.Show(dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);            
        }

        private void storyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CreateStory createStory = new CreateStory();
            createStory.StoryCreated += (object obj, EventArgs args) =>
            {
                _story = createStory.Story;
                _filepath = createStory.Filepath;
                _chapterWindow.UpdateChapters(_story);
            };
            createStory.ShowDialog();
        }

        private void chapterToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CreateChapter createChapter = new CreateChapter();
            createChapter.ChapterCreated += (object obj, EventArgs args) =>
            {
                _story.AddChapter(createChapter.Chapter);
                _chapterWindow.UpdateChapters(_story);
            };
            createChapter.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string json = _story.ConvertToJson();

            FileStream fs = new FileStream(_filepath, FileMode.Create);

            var sw = new StreamWriter(fs);

            sw.Write(json);
            sw.Flush();

            MessageBox.Show("File saved successfully");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"Documents";
            openFileDialog.Title = "Open a story";
            openFileDialog.DefaultExt = "json";
            openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.ShowDialog();

            string filepath = openFileDialog.FileName;

            string json = File.ReadAllText(filepath);
            _story = JsonConvert.DeserializeObject<Story>(json);
            _chapterWindow.UpdateChapters(_story);
        }
    }
}
