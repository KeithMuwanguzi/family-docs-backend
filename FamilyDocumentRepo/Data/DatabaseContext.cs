using FamilyDocumentRepo.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyDocumentRepo.Data;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<DocumentCategory> DocumentCategories { get; set; }
}
