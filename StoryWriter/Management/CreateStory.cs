using StoryWriter.Storage;
using System;
using System.IO;
using System.Windows.Forms;

namespace StoryWriter.Management
{
    public partial class CreateStory : Form
    {
        public event EventHandler StoryCreated;

        public Story Story { get; private set; }
        public string Filepath { get; private set; }

        public CreateStory()
        {
            InitializeComponent();
            BtnCreate.Enabled = false;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"Documents";
            saveFileDialog.Filter = "JSON file (.json)|*.json";
            saveFileDialog.Title = "Create a new story";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Story = new Story(TbxName.Text, TbxAuthor.Text);
                string json = Story.ConvertToJson();

                FileStream fs = (FileStream)saveFileDialog.OpenFile();

                var sw = new StreamWriter(fs);

                Filepath = fs.Name;

                sw.Write(json);
                sw.Flush();
                sw.Close();
                fs.Close();
            }

            StoryCreated?.Invoke(this, new EventArgs());
            this.Close();
        }

        private void TbxAuthor_TextChanged(object sender, EventArgs e)
        {
            CheckFieldsFilledIn();
        }

        private void TbxDirectory_TextChanged(object sender, EventArgs e)
        {
            CheckFieldsFilledIn();
        }

        private void TbxName_TextChanged(object sender, EventArgs e)
        {
            CheckFieldsFilledIn();
        }

        private void CheckFieldsFilledIn()
        {
            BtnCreate.Enabled = false;

            if (TbxName.Text.Length > 0)
                if (TbxAuthor.Text.Length > 0)
                        BtnCreate.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
