using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvc.BooksOnline.Domain.Entities
{
    /// <summary>
    /// Publisher entity class.
    /// </summary>
    public class Publisher
    {
        #region Properties
        /// <summary>
        /// Gets or sets the publisher ID.
        /// </summary>
        /// <value>The publisher ID.</value>
        public virtual long Id { get; private set; }
        /// <summary>
        /// Gets or sets the publisher name.
        /// </summary>
        /// <value>The publisher name.</value>
        public virtual string Name { get; set; }
        /// <summary>
        /// Gets or sets published books collection.
        /// </summary>
        /// <value>The books.</value>
        public virtual List<BookTitle> Books { get; set; }
        #endregion

        #region .ctors
        /// <summary>
        /// Initializes a new instance of the <see cref="Publisher"/> class.
        /// </summary>
        /// <param name="publisherName">Name of the publisher.</param>
        public Publisher(string publisherName)
        {
            if (string.IsNullOrEmpty(publisherName))
            {
                throw new ArgumentNullException("publisherName", "You must provide the publisher name.");
            }

            Name = publisherName;
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
            book.Publisher = this;
            Books.Add(book);
        }
        #endregion
    }
}
