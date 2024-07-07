using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZODotNetCore.MvcApp2.Models
{
    [Table("Tbl_Blog")]
    public class BlogModel
    {
        [Key]
        public int BlogId { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogAuthor { get; set; }
        public string? BlogContent { get; set; }
    }

    //public record BlogEntity(int BlogId, string BlogTitle, string BlogAuthor, string BlogContent);

    public class MessageModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}