using LibraryManager.Domain.Entities.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.Domain.Entities
{
    [Table("books")]
    public class Book : IEntity
    {
        public Book(string name, int authorId)
        {
            Name = name;
            AuthorId = authorId;
        }
        
        public int Id { get; set; }        
        public string Name { get; set; }        
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
