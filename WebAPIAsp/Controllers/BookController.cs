using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIAsp.Models;

namespace WebAPIAsp.Controllers
{
    public class BookController : ApiController
    {


        List<Book> books = new List<Book>()
        {
            new Book{Id=1, Title = "Book1", Author="Author_1", Price=101 },
             new Book{Id=2, Title = "Book2", Author="Author_2", Price=102 },
              new Book{Id=3, Title = "Book3", Author="Author_3", Price=103 },
               new Book{Id=4, Title = "Book4", Author="Author_4", Price=104 },

        };

        
        [HttpPost]
        [Route("api/book/AddBook/{book}")]
        public IHttpActionResult AddBook(Book newBook)
        {
            var IdBook = books.Count() + 1;

            newBook.Id = IdBook;

            books.Add(newBook);

            return Ok(newBook);
        }



        [HttpGet]
        [Route("api/book/GetAllBooks/")]
        public IEnumerable<Book> GetAllBooks()
        {            
            return books;
        }

        [HttpGet]
        [Route("api/book/GetBook/{id}")]
        public IHttpActionResult GetBook(int id)
        {
            var b = books.FirstOrDefault((bo) => bo.Id == id);
            if (b == null)
            {
                return NotFound();
            }
            return Ok(b);
        }
        

        [HttpDelete]
        [Route("api/book/DeleteBook/{idBook}")]
        public HttpResponseMessage DeleteBook(int idBook)
        {
            Book b = books.FirstOrDefault((bo) => bo.Id == idBook);

            if (b == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            books.Remove(b);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }


        [HttpPut]
        [Route("api/book/UpdateBook/{book}")]
        public IHttpActionResult UpdateBook(Book book)
        {
            Book b = books.FirstOrDefault((bo) => bo.Id == book.Id);

            if (b == null)
            {
                return NotFound();
            }

            b.Title = book.Title;
            b.Author = book.Author;
            b.Price = book.Price;

          
            return Ok(b);
        }

    }
}
