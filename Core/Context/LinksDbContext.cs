using Core.Entities;
using Core.EntityConfigs;
using Core.Enums;
using Core.Generators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Core.Context;

public class LinksDbContext : DbContext
{ 

    public override async Task<int> SaveChangesAsync(CancellationToken token = default)
    {
        ChangeTracker.DetectChanges();
        foreach (var entry in ChangeTracker.Entries().Where(o=>o.State == EntityState.Added))
        {
            if (entry.Entity is Member member)
            {
                member.MemberId = UniqueIdService.Generator(UniqueIdType.User);
                member.CreateAt = DateTimeOffset.UtcNow;
                member.UpdateAt = DateTimeOffset.UtcNow;
                member.Status = 1;
            }
            if (entry.Entity is Content content)
            {
                content.ContentId = UniqueIdService.Generator(UniqueIdType.Content);
                content.CreateAt = DateTimeOffset.UtcNow;
                content.UpdateAt = DateTimeOffset.UtcNow;
                content.Status = 1;
            }
            if (entry.Entity is Bio bio)
            {
                bio.BioId = UniqueIdService.Generator(UniqueIdType.Bio);
                bio.CreateAt = DateTimeOffset.UtcNow;
                bio.UpdateAt = DateTimeOffset.UtcNow;
                bio.Status = 1;
            }
            if (entry.Entity is SocialMedia socialMedia)
            {
                socialMedia.SocialMediaId = UniqueIdService.Generator(UniqueIdType.SocialMedia);
                socialMedia.CreateAt = DateTimeOffset.UtcNow;
                socialMedia.UpdateAt = DateTimeOffset.UtcNow;
                socialMedia.Status = 1;
            }
        }
        return await base.SaveChangesAsync(token);
    } 
 
    public DbSet<Member> Members { get; set; }
    public DbSet<Content> Contents { get; set; }
    public DbSet<Bio> Bios { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=Database\app.db;");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("links");
        modelBuilder.ApplyConfiguration(new BioConfiguration());
        modelBuilder.ApplyConfiguration(new ButtonLinkConfiguration());
        modelBuilder.ApplyConfiguration(new ContentConfiguration());
        modelBuilder.ApplyConfiguration(new MemberConfiguration());
        modelBuilder.ApplyConfiguration(new SocialMediaConfiguration());
    }
}