using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFileProject.DAL.Models
{
    public class Comment
    {
        public int CardFileId { get; set; }
        public int Id { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }
        public DateTime PublicationTime { get; set; }
    }
}