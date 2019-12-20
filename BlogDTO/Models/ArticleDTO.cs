using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDTO.Models
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public int AutorId { get; set; }
        public List<CommentDTO> Comments { get; set; }
    }
}
