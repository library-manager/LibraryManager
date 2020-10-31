namespace LibraryManager.Domain.Entities.Dtos
{
    public class GetAllBooksDto
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
    }
}
