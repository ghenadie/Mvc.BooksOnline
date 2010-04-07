using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

using Mvc.BooksOnline.Domain.Entities;

namespace Mvc.BooksOnline.Domain.Tests.Entities
{
    /// <summary>
    /// Test class for BookTitle entity
    /// </summary>
    public class BookTitleTests
    {
        [Fact]
        public void BookTitle_Create_Succeed()
        {
            string title = "Asp.Net Mvc 2 In Action";

            BookTitle bookTitle = new BookTitle(title);

            Assert.NotNull(bookTitle.Isbn);
            Console.WriteLine(bookTitle.Isbn);
            Assert.Equal<string>(bookTitle.Title, title);
        }
        [Fact]
        public void BookTitle_TitleIsNullOrEmpty_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(
                    "You must provide the book title.",
                    delegate
                    {
                        new BookTitle(string.Empty);
                    }
            );
        }
    }
}
