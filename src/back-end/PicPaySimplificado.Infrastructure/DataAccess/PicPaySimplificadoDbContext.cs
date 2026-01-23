using Microsoft.EntityFrameworkCore;
using PicPaySimplificado.Domain.Entities;

namespace PicPaySimplificado.Infrastructure.DataAccess
{
    public class PicPaySimplificadoDbContext : DbContext
    {
        public PicPaySimplificadoDbContext(DbContextOptions<PicPaySimplificadoDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(options =>
            {
                options.Property(u => u.FullName).IsRequired().HasMaxLength(255).IsUnicode();
                options.Property(u => u.Document).IsRequired().HasMaxLength(14).IsUnicode();
                options.Property(u => u.Email).IsRequired().HasMaxLength(255).IsUnicode();
                options.Property(u => u.Password).IsRequired().HasMaxLength(255);
                options.Property(u => u.Balance).HasColumnType("decimal(18,2)").IsRequired();
            });
        }
    }
}
