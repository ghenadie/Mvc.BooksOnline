using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Moq;
using Mvc.BooksOnline.Domain.Entities;
using Mvc.BooksOnline.Domain.DataAccessObjects;

namespace Mvc.BooksOnline.Domain.Tests.DataAccessObjects
{
    /// <summary>
    /// Tests BookTitleRepository class for CRUD operations.
    /// </summary>    
    public class BookTitleRepositoryTests
    {
        [Fact]
        public void FindById_BookTitle_ReturnsBookTitle()
        {
            //Mock a BookTitle
            var mockBookTitle = new Mock<BookTitle>();
            mockBookTitle.Setup(bookTitle => bookTitle.Isbn).Returns("ISBN 978-3-16-148410-0");
            mockBookTitle.Setup(bookTitle => bookTitle.Title).Returns("ASP.NET MVC 2 in Action");

            //Mock a BookTitleRepository
            var mockBookTitleRepository = new Mock<IBookTitleRepository>();
            mockBookTitleRepository
                .Setup(bookTitleRepository => bookTitleRepository.FindById("ISBN 978-3-16-148410-0",true))
                .Returns(mockBookTitle.Object);

            //Act
            var bookTitleReturned = mockBookTitleRepository.Object.FindById("ISBN 978-3-16-148410-0",true);

            //Assert
            Assert.Equal<string>("ASP.NET MVC 2 in Action", bookTitleReturned.Title);
        }
       
        [Fact]
        public void FindAll_NoArgument_ReturnsBookTitleList()
        {
            
        }
        [Fact]
        public void FindByExample_BookTitle_ReturnsBookTitle()
        { 
        }
        [Fact]
        public void MakePersistent_BookTitle_AddsBookTitleToRepository()
        {
            var authors = new Author[] {new Author("Jeffery","Palermo"),
                                        new Author("Ben","Scheirman"),
                                        new Author("Jimmy","Bogard")};

            //Mock a BookTitle
            var mockBookTitle = new Mock<BookTitle>();
            mockBookTitle.Setup(book => book.Title).Returns("ASP.NET MVC 2 in Action");
            mockBookTitle.Setup(book => book.Authors).Returns(new List<Author>(authors));
            mockBookTitle.Setup(book => book.Publisher).Returns(new Publisher("Manning"));

            //Mock a BookTitleRepository
            var mockBookTitleRepository = new Mock<IBookTitleRepository>();
            mockBookTitleRepository
                .Setup(bookTitleRepository => bookTitleRepository.MakePersistent(mockBookTitle.Object))
                .Returns(mockBookTitle.Object);

            //Act
            var persistentBookTitle = mockBookTitleRepository.Object.MakePersistent(mockBookTitle.Object);

            //Asserts
            Assert.NotNull(persistentBookTitle);
            Assert.Equal<string>(persistentBookTitle.Title, "ASP.NET MVC 2 in Action");
            Assert.NotNull(persistentBookTitle.Publisher);
            Assert.Equal<string>(persistentBookTitle.Publisher.Name, "Manning");
            Assert.NotEmpty(persistentBookTitle.Authors);
        }
        [Fact]
        public void MakeTransient_BookTitle_DeletesBookTitleFromRepository()
        { 
        }
    }
}
