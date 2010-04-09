using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mvc.BooksOnline.Domain.Entities;
using Mvc.BooksOnline.DataAccess;

namespace Mvc.BooksOnline.Domain.DataAccessObjects
{
    /// <summary>
    /// Interface for BookTitleRepository inherits CRUD operations from IRepository.
    /// </summary>
    /// <remarks>
    /// This interface could be extended with BookTitle's specific operations.
    /// </remarks>
    public interface IBookTitleRepository : IRepository<BookTitle, string>
    {
    }
}
