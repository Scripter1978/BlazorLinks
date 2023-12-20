using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.EntityConfigs;

public class BioConfiguration : IEntityTypeConfiguration<Bio>
{
    public void Configure(EntityTypeBuilder<Bio> builder)
    {
        builder.HasKey(k=>k.BioId)
            .IsClustered();
        builder.Property(x => x.BioId)
            .IsRequired()
            .HasColumnType("varchar(25)")
            .HasMaxLength(25)
            .IsUnicode(false);
        builder.Property(x => x.UserName)
            .IsRequired()
            .HasColumnType("varchar(100)")
            .HasMaxLength(100)
            .IsUnicode(false);
        builder.Property(x => x.Title)
            .IsRequired(false)
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100)
            .IsUnicode();
        builder.Property(x => x.Description)    
            .IsRequired(false)
            .HasColumnType("nvarchar(1000)")
            .HasMaxLength(1000)
            .IsUnicode();
        builder.Property(x => x.Image)  
            .IsRequired(false)
            .HasColumnType("varchar(1000)")
            .HasMaxLength(1000)
            .IsUnicode(false);
        builder.Property(x => x.Url)    
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
    
        builder.Property(x => x.IsDeleted) 
            .IsRequired()
            .HasColumnType("int");
        
    }
}