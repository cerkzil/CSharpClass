namespace Skaitykla.Domains
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public Author Author { get; set; }
    }
}
