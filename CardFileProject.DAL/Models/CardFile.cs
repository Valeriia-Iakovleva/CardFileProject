using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFileProject.DAL.Models
{
    public class CardFile
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }

        public DateTime PublicationDate { get; set; }
        public List<string> Hashtags { get; set; }
    }
}