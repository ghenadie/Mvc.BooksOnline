using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Mvc.BooksOnline.Domain.Entities;

namespace Mvc.BooksOnline.Domain.Tests.Entities
{
    /// <summary>
    /// Test class for Category entity.
    /// </summary>
    public class CategoryTests
    {
        [Fact]
        public void Category_Create_Succeed()
        {
            string categoryDescription = "In Action Series";

            Category category = new Category(categoryDescription);

            Assert.Equal<string>(category.Description, categoryDescription);
        }

        [Fact]
        public void Category_DescriptionIsNullOrEmpty_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(
                "You must provide the category description.",
                delegate
                {
                    new Category(string.Empty);
                }
            );
        }
    }
}
