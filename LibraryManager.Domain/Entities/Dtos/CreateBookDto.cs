namespace LibraryManager.Domain.Entities.Dtos
{
    public class CreateBookDto
    {
        public string Name { get; set; }
        public int AuthorId { get; set; }
    }
}
