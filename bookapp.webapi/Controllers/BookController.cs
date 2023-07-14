using Microsoft.AspNetCore.Mvc;
using bookapp.webapi.models;

namespace bookapp.webapi.Controllers{
        
    [ApiController]
    [Route("[controller]s")]
    public class BookController : ControllerBase
    {
        private static readonly List<Book> Booklist = new List<Book>(){
            new Book(){BookId=1, Title="The Great Gatsby", GenreId=1, PublishDate=DateTime.Parse("1925-04-10"), PageCount=180},
            new Book(){BookId=2, Title="Lolita", GenreId=1, PublishDate=DateTime.Parse("1955-09-15"), PageCount=317},
            new Book(){BookId=3, Title="The Grapes of Wrath", GenreId=2, PublishDate=DateTime.Parse("1939-04-14"), PageCount=464},
            new Book(){BookId=4, Title="Nineteen Eighty-Four", GenreId=2, PublishDate=DateTime.Parse("1949-06-08"), PageCount=328},
            new Book(){BookId=5, Title="Ulysses", GenreId=3, PublishDate=DateTime.Parse("1922-02-02"), PageCount=228},
            new Book(){BookId=6, Title="Catch-22", GenreId=3, PublishDate=DateTime.Parse("1961-11-10"), PageCount=453},
            new Book(){BookId=7, Title="The Catcher in the Rye", GenreId=4, PublishDate=DateTime.Parse("1951-07-16"), PageCount=277},
            new Book(){BookId=8, Title="Beloved", GenreId=4, PublishDate=DateTime.Parse("1987-09-02"), PageCount=321},
            new Book(){BookId=9, Title="The Sound and the Fury", GenreId=5, PublishDate=DateTime.Parse("1929-10-07"), PageCount=326},
            new Book(){BookId=10, Title="To Kill a Mockingbird", GenreId=5, PublishDate=DateTime.Parse("1960-07-11"), PageCount=399},
        };

        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBooks")]
        public IEnumerable<Book> Get()
        {
            return Booklist.OrderBy(b => b.BookId).ToList<Book>();
        }

        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return Booklist.Where(b => b.BookId == id).SingleOrDefault();
        }
    }
}