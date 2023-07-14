namespace bookapp.webapi.models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int GenreId { get; set; }
        public DateTime PublishDate { get; set; }
        public int PageCount { get; set; }
    }
}