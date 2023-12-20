using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.EntityConfigs;

public class ButtonLinkConfiguration : IEntityTypeConfiguration<ButtonLink>
{
    public void Configure(EntityTypeBuilder<ButtonLink> builder)
    {
        builder.HasKey(k=>k.ButtonLinkId)
            .IsClustered();
        builder.Property(x => x.ButtonLinkId)
            .IsRequired()
            .HasColumnType("varchar(25)")
            .HasMaxLength(25)
            .IsUnicode(false);
        builder.Property(x => x.Title)
            .IsRequired()
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100)
            .IsUnicode();
        builder.Property(x => x.Body)
            .IsRequired(false)
            .HasColumnType("varchar(4000)")
            .HasMaxLength(4000)
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
        builder.Property(x => x.Status) 
            .IsRequired()
            .HasColumnType("int");
        builder.Property(x => x.ButtonLinkType) 
            .IsRequired()
            .HasColumnType("int");
    
        builder.Property(x => x.IsDeleted) 
            .IsRequired()
            .HasColumnType("int");
        
    }
}