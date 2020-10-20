using LibraryManager.Domain.Entities.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManager.Domain.Entities
{
    [Table("authors")]
    public class Author : IEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
    }
}
