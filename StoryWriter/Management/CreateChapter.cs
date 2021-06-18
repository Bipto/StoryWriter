using StoryWriter.Storage;
using System;
using System.Windows.Forms;

namespace StoryWriter.Management
{
    public partial class CreateChapter : Form
    {
        public event EventHandler ChapterCreated;

        public Chapter Chapter { get; private set; }

        public CreateChapter()
        {
            InitializeComponent();
            BtnCreate.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Chapter = new Chapter(TbxName.Text);
            ChapterCreated?.Invoke(this, new EventArgs());
            this.Close();
        }

        private void TbxName_TextChanged(object sender, EventArgs e)
        {
            if (TbxName.Text.Length > 0)
                BtnCreate.Enabled = true;
            else
                BtnCreate.Enabled = false;
        }
    }
}
