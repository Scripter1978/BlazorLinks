using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.EntityConfigs;

public class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
{
    public void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        builder.HasKey(k=>k.SocialMediaId)
            .IsClustered();
        builder.Property(x => x.SocialMediaId)
            .IsRequired()
            .HasColumnType("varchar(25)")
            .HasMaxLength(25)
            .IsUnicode(false);
        builder.Property(x => x.UserName)
            .IsRequired()
            .HasColumnType("varchar(100)")
            .HasMaxLength(100)
            .IsUnicode(false);
        builder.Property(x => x.Url)
            .IsRequired(false)
            .HasColumnType("varchar(4000)")
            .HasMaxLength(4000)
            .IsUnicode(false);
        builder.Property(x => x.Icon)    
            .IsRequired(false)
            .HasColumnType("varchar(4000)")
            .HasMaxLength(4000)
            .IsUnicode(false);
        builder.Property(x => x.CreateAt)
            .HasDefaultValue(DateTimeOffset.UtcNow) 
            .IsRequired();
        builder.Property(x => x.UpdateAt)
            .HasDefaultValue(DateTimeOffset.UtcNow) 
            .IsRequired();
        builder.Property(x => x.SocialMediaType) 
            .IsRequired()
            .HasColumnType("int");
        builder.Property(x => x.Status) 
            .IsRequired()
            .HasColumnType("int");
    
        builder.Property(x => x.IsDeleted) 
            .IsRequired()
            .HasColumnType("int");
    }
}