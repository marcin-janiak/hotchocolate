using System.Collections;
using System.Linq;
using AspNetCore.PureCodeFirst.Books.Data;
using AspNetCore.PureCodeFirst.Books.Models;
using HotChocolate;

namespace AspNetCore.PureCodeFirst.Books
{
    public class Query
    {
        public IQueryable<Book> GetBooks([Service] BooksContext context) => context.Books;
        public IQueryable<Author> GetAuthors([Service] BooksContext context) => context.Authors;
    }
}
