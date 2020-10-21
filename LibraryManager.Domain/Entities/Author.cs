using LibraryManager.Domain.Entities.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.Domain.Entities
{
    [Table("authors")]
    public class Author : IEntity
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public IReadOnlyCollection<Book> BookList { get; set; }
    }
}
