using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace StoryWriter.Storage
{
    public class Story
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public DateTime DateCreated { get; private set; }
        public string Description { get; private set; }
        public List<Chapter> Chapters { get; private set; }

        public Story(string name, string author)
        {
            Name = name;
            Author = author;
            Description = "None";
            DateCreated = DateTime.Now;
            Chapters = new List<Chapter>();
        }

        public void AddChapter(Chapter chapter)
        {
            Chapters.Add(chapter);
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            return json;
        }
    }
}