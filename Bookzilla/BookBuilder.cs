using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookzilla
{
    public class BookBuilder : IBookBuilder
    {
        private Book _book;

        public BookBuilder()
        {
            _book = new Book();
        }

        public void SetAuthorName(string authorName) => _book.AuthorName = authorName;
        public void SetPublisherName(string publisherName) => _book.PublisherName = publisherName;
        public void SetNumberOfPages(int numberOfPages) => _book.NumberOfPages = numberOfPages;
        public void SetPublishDate(DateTime publishDate) => _book.PublishDate = publishDate;
        public void SetDescription(string description) => _book.Description = description;
        public void SetCategory(string category) => _book.Category = category;
        public void SetBookTitle(string bookTitle) => _book.BookTitle = bookTitle;

        public Book GetBook() => _book;
    }
}
