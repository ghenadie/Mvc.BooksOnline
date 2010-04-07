using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Mvc.BooksOnline.Domain.Entities;

namespace Mvc.BooksOnline.Domain.Tests.Entities
{
    /// <summary>
    /// Test class for BookFormat entity.
    /// </summary>
    public class BookFormatTests
    {
        [Fact]
        public void BookFormat_Create_Succeed()
        {
            string formatDescription = "Manning format";

            BookFormat bookFormat = new BookFormat(formatDescription);

            Assert.Equal<string>(bookFormat.Description, formatDescription);
        }

        [Fact]
        public void BookFormat_DescriptionIsNullOrEmpty_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(
                               "You must provide the book format description.",
                               delegate
                               {
                                   new BookFormat(string.Empty);
                               }
                       );
        }
    }
}
