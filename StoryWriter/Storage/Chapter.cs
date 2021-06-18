namespace StoryWriter.Storage
{
    public class Chapter
    {
        public string Name { get; }
        public string[] Lines { get; }

        public Chapter(string title)
        {
            Name = title;
        }
    }
}
