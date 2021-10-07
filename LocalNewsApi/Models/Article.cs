using System;

namespace LocalNewsApi.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public int Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UrlToImage { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
    }
}
