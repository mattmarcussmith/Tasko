using Microsoft.EntityFrameworkCore;
using Tasko.Bll.Entities;

namespace Tasko.Api.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<NoteItem> NoteItems { get; set; }
    }
}