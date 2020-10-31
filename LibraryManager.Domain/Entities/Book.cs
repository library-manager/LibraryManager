using LibraryManager.Domain.Entities.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.Domain.Entities
{
    [Table("books")]
    public class Book : IEntity
    {
        public Book(string name, int authorId, string summary, string imageUrl)
        {
            Name = name;
            AuthorId = authorId;
            Summary = summary;
            ImageUrl = imageUrl;
        }
        
        public int Id { get; set; }        
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Summary { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
