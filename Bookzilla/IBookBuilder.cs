using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookzilla
{
    public interface IBookBuilder
    {
        void SetAuthorName(string authorName);
        void SetPublisherName(string publisherName);
        void SetNumberOfPages(int numberOfPages);
        void SetPublishDate(DateTime publishDate);
        void SetDescription(string description);
        void SetCategory(string category);
        void SetBookTitle(string bookTitle);
        Book GetBook();
    }
}
