using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Mvc.BooksOnline.Domain.Entities;

namespace Mvc.BooksOnline.Domain.Tests.Entities
{
    /// <summary>
    /// Test class for Author entity.
    /// </summary>
    public class AuthorTests
    {
        [Fact]
        public void Author_Create_Succeed()
        {
            string firstName = "Jeffrey";
            string lastName = "Palermo";

            Author author = new Author(firstName, lastName);

            Assert.Equal<string>(author.FirstName, firstName);
            Assert.Equal<string>(author.LastName, lastName);
        }
    }
}
