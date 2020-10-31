using LibraryManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LibraryManager.Infrastructure.Repositories.Mappings
{
    public sealed class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(t => t.Id).HasColumnName("id").IsRequired().HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(t => t.Name).HasColumnName("name").IsRequired().HasColumnType("VARCHAR").HasMaxLength(100);
            builder.Property(t => t.AuthorId).HasColumnName("author_id").IsRequired().HasColumnType("INT");
            builder.Property(t => t.Summary).HasColumnName("summary").IsRequired().HasColumnType("VARCHAR").HasMaxLength(500);
            builder.Property(t => t.ImageUrl).HasColumnName("image_url").IsRequired().HasColumnType("VARCHAR").HasMaxLength(300);

            builder.HasKey(t => t.Id);

            builder.HasOne(b => b.Author).WithMany(a => a.BookList).HasForeignKey(b => b.AuthorId);
        }
    }
}
