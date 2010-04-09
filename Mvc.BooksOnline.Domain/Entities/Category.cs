using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvc.BooksOnline.Domain.Entities
{
    /// <summary>
    /// Category entity class.
    /// </summary>
    public class Category
    {
        #region Properties
        /// <summary>
        /// Gets or sets the category ID.
        /// </summary>
        /// <value>The category ID.</value>
        public virtual long Id { get; private set; }
        /// <summary>
        /// Gets or sets the category description.
        /// </summary>
        /// <value>The category description.</value>
        public virtual string Description { get; set; }
        /// <summary>
        /// Gets or sets the books corresponding to the category.
        /// </summary>
        /// <value>The books.</value>
        public virtual List<BookTitle> Books { get; private set; }
        #endregion

        #region .ctors
        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="description">The category description.</param>
        public Category(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException("description", "You must provide category description.");
            }
            Description = description;            
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds the book title.
        /// </summary>
        /// <param name="bookTitle">The book title.</param>
        public virtual void AddBookTitle(BookTitle bookTitle)
        {
            if (Books == null)
            {
                Books = new List<BookTitle>();
            }
            Books.Add(bookTitle);
        }
        #endregion        
    }
}
