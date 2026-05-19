using Messaging.Domain;
using Microsoft.EntityFrameworkCore;

namespace Messaging.Storage;

public class MessagingDbContext : DbContext
{
    public MessagingDbContext(DbContextOptions<MessagingDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Message> Messages => Set<Message>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("Users");
            entity.HasKey(u => u.Id);
            entity.Property(u => u.Id).UseIdentityColumn();

            entity.Property(u => u.Login).HasMaxLength(100).IsRequired();

            entity.Property(u => u.Email).HasMaxLength(255).IsRequired();
            entity.HasIndex(u => u.Email).IsUnique();

            entity.Property(u => u.PasswordHash).HasMaxLength(512).IsRequired();
            entity.Property(u => u.PasswordSalt).HasMaxLength(512).IsRequired();
            entity.Property(u => u.CreatedAt).IsRequired();

            entity.HasMany(u => u.SentMessages)
                .WithOne(m => m.Sender)
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(u => u.ReceivedMessages)
                .WithOne(m => m.Recipient)
                .HasForeignKey(m => m.RecipientId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.ToTable("Messages");
            entity.HasKey(m => m.Id);
            entity.Property(m => m.Id).UseIdentityColumn();

            entity.Property(m => m.Subject).HasMaxLength(255).IsRequired();
            entity.Property(m => m.Body).HasColumnType("text");
            entity.Property(m => m.SentAt).IsRequired();
            entity.Property(m => m.SizeBytes).IsRequired();

            entity.Property(m => m.IsDeletedBySender).HasDefaultValue(false);
            entity.Property(m => m.IsDeletedByRecipient).HasDefaultValue(false);
        });
    }
}
