using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDTO.Models
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public int AutorId { get; set; }
        public int ArticleId { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
    }
}
