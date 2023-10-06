using System;

namespace MVCBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}