using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.BooksOnline.Controllers
{
    public class BooksController : Controller
    {
        //
        // GET: /Books/

        public string Index()
        {
            return "<h1> Welcome to the Online Books eShop</h1>";
        }

    }
}
