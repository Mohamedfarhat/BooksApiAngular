using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BooksApiAngular.Models
{
    public partial class BooksAspWepApiAngularContext : DbContext
    {
        public BooksAspWepApiAngularContext()
        {
        }

        public BooksAspWepApiAngularContext(DbContextOptions<BooksAspWepApiAngularContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }

    }
}
