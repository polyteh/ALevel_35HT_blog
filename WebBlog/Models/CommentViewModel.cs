using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public int AutorId { get; set; }
        public int ArticleId { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
    }
}