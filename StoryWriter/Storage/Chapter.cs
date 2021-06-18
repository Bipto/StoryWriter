namespace StoryWriter.Storage
{
    public class Chapter
    {
        public string Title { get; }
        public string[] Lines { get; set; }

        public Chapter(string title)
        {
            Title = title;
        }
    }
}
