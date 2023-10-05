using Microsoft.EntityFrameworkCore;

namespace BB20_Categories.SecurityModels
{
    public partial class BB20_SecurityGateWayContext : DbContext
    {
        public BB20_SecurityGateWayContext()
        {
        }

        public BB20_SecurityGateWayContext(DbContextOptions<BB20_SecurityGateWayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var dir = Directory.GetCurrentDirectory();

                var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

                IConfiguration _configuration = builder.Build();

                string cnn = _configuration.GetConnectionString("SecurityDatabase");
                optionsBuilder.UseSqlServer(cnn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.ToTable("RefreshToken");

                entity.HasIndex(e => e.AccountId, "IX_RefreshToken_AccountId");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.RefreshTokens)
                    .HasForeignKey(d => d.AccountId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
