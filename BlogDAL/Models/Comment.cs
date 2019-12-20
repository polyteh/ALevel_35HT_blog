using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Models
{
    [TableName("Comments")]
  //  [PrimaryKey("Id")]
    public class Comment
    {
        public int Id { get; set; }
        public int AutorId { get; set; }
        public int ArticleId { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
    }
}
