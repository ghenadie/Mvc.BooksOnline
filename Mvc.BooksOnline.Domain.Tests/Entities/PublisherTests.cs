using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Mvc.BooksOnline.Domain.Entities;

namespace Mvc.BooksOnline.Domain.Tests.Entities
{
    /// <summary>
    /// Test class for Publisher entity.
    /// </summary>
    public class PublisherTests
    {
        [Fact]
        public void Publisher_Create_Succeed()
        {
            string publisherName = "Manning";

            Publisher publisher = new Publisher(publisherName);

            Assert.Equal<string>(publisher.Name, publisherName);
        }
        [Fact]
        public void Publisher_NameIsNullOrEmpty_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(
                              "You must provide the publisher name.",
                              delegate
                              {
                                  new Publisher(string.Empty);
                              }
                      );
        }
    }
}
