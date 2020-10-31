namespace LibraryManager.Domain.Entities.Dtos
{
    public class CreateBookDto
    {
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
    }
}
