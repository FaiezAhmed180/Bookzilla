using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookzilla
{
    public class Book
    {
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public int NumberOfPages { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string BookTitle { get; set; }
    }
}
