using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvc.BooksOnline.Domain.Entities
{
    /// <summary>
    /// BookFormat entity class.
    /// </summary>
    public class BookFormat
    {
        #region Properties
        /// <summary>
        /// Gets or sets the book format ID.
        /// </summary>
        /// <value>The book format ID.</value>
        public virtual long Id { get; private set; }
        /// <summary>
        /// Gets or sets the book format description.
        /// </summary>
        /// <value>The book format description.</value>
        public virtual string Description { get; set; }
        /// <summary>
        /// Gets or sets the books.
        /// </summary>
        /// <value>The books.</value>
        public virtual List<BookTitle> Books { get; set; }
        #endregion

        #region .ctors
        /// <summary>
        /// Initializes a new instance of the <see cref="BookFormat"/> class.
        /// </summary>
        /// <param name="description">The book format description.</param>
        public BookFormat(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException("description", "You must provide book format description.");
            }
            Description = description;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds the book title.
        /// </summary>
        /// <param name="book">The book.</param>
        public virtual void AddBookTitle(BookTitle book)
        {
            if (Books == null)
            {
                Books = new List<BookTitle>();
            }
            book.BookFormat = this;
            Books.Add(book);
        }
        #endregion
    }
}
