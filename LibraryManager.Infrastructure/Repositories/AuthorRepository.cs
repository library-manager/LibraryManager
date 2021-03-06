﻿using LibraryManager.Domain.Entities;
using LibraryManager.Domain.Repositories;
using LibraryManager.Infrastructure.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManager.Infrastructure.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {        
        public AuthorRepository(LibraryManagerContext context)
            : base(context)
        {            
        }

        public IList<Author> GetAll()
        {
            return Query().ToList();
        }

        public Author GetAuthorById(int id)
        {            
            return Query().Include(a => a.BookList).FirstOrDefault(x => x.Id == id);
        }
    }
}
