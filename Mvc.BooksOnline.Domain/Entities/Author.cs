using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvc.BooksOnline.Domain.Entities
{
    /// <summary>
    /// Author entity class.
    /// </summary>
    public class Author
    {
        #region Properties
        /// <summary>
        /// Gets or sets the author ID.
        /// </summary>
        /// <value>The id.</value>
        public virtual long Id { get; private set; }
        /// <summary>
        /// Gets or sets the author first name.
        /// </summary>
        /// <value>The author first name.</value>
        public virtual string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the author last name.
        /// </summary>
        /// <value>The author last name.</value>
        public virtual string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Author's books collection.
        /// </summary>
        /// <value>The books collection.</value>
        public virtual List<BookTitle> Books { get; set; }
        #endregion

        #region .ctors
        /// <summary>
        /// Initializes a new instance of the <see cref="Author"/> class.
        /// </summary>
        /// <param name="firstName">The author first name.</param>
        /// <param name="lastName">The author last name.</param>
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Author"/> class.
        /// </summary>
        public Author() { }
        #endregion

        #region Methods
        /// <summary>
        /// Adds the book title to the Author's books collection.
        /// </summary>
        /// <param name="book">The book title.</param>
        public virtual void AddBookTitle(BookTitle book)
        {
            if (Books == null)
            {
                Books = new List<BookTitle>();
            }
            Books.Add(book);
        }
        #endregion
    }
}
