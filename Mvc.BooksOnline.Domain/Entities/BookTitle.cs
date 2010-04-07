using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvc.BooksOnline.Domain.Entities
{
    /// <summary>
    /// BookTitle business entity class.
    /// </summary>
    public class BookTitle
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ISBN.
        /// </summary>
        /// <value>The ISBN.</value>
        /// <remarks>
        /// International Standard Book Number(ISBN) is a unique numeric commercial book identifier based
        /// upon the 9-digit Standard Book Numbering (SBN) code  created by Gordon Foster,
        /// now Emeritus Professor of Statistics at Trinity College, Dublin,
        /// for the booksellers and stationers W.H. Smith and others in 1966.
        /// </remarks>
        public virtual string Isbn { get; private set; }
        /// <summary>
        /// Gets or sets the book title.
        /// </summary>
        /// <value>The title.</value>
        public virtual string Title { get; set; }
        /// <summary>
        /// Gets or sets the book's publisher.
        /// </summary>
        /// <value>The publisher ID.</value>
        public virtual Publisher Publisher { get; set; }
        /// <summary>
        /// Gets or sets published date.
        /// </summary>
        /// <value>Published date.</value>
        public virtual DateTime PublishedDate { get; set; }
        /// <summary>
        /// Gets or sets the book's format.
        /// </summary>
        /// <value>The book's format.</value>
        public virtual BookFormat BookFormat { get; set; }
        /// <summary>
        /// Gets or sets pages number.
        /// </summary>
        /// <value>Pages number.</value>
        public virtual int Pages { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public virtual decimal Price { get; set; }
        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>The comments.</value>
        public virtual string Comments { get; set; }
        /// <summary>
        /// Gets or sets the authors of the book.
        /// </summary>
        /// <value>The authors of the book.</value>
        public virtual List<Author> Authors { get; set; }
        /// <summary>
        /// Gets or sets the categories of the book.
        /// </summary>
        /// <value>The categories of the book.</value>
        public virtual List<Category> Categories { get; set; }
        #endregion

        #region .ctors
        /// <summary>
        /// Initializes a new instance of the <see cref="BookTitle"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        public BookTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("title", "You must provide the book title.");
            }
            Title = title;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds the author.
        /// </summary>
        /// <param name="author">The author.</param>
        public virtual void AddAuthor(Author author)
        {
            if (Authors == null)
            {
                Authors = new List<Author>();
            }
            author.AddBookTitle(this);
            Authors.Add(author);
        }
        /// <summary>
        /// Adds the category.
        /// </summary>
        /// <param name="category">The category.</param>
        public virtual void AddCategory(Category category)
        {
            if (Categories == null)
            {
                Categories = new List<Category>();
            }
            category.AddBookTitle(this);
            Categories.Add(category);
        }
        #endregion
    }
}
