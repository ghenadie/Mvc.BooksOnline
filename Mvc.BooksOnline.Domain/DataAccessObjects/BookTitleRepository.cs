using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mvc.BooksOnline.Domain.Entities;
using Mvc.BooksOnline.DataAccess;

namespace Mvc.BooksOnline.Domain.DataAccessObjects
{
    /// <summary>
    /// BookTitleRepository class.
    /// </summary>
    public class BookTitleRepository:Repository<BookTitle,string>, IBookTitleRepository
    {
        
    }
}
