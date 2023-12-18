using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.EntityConfigs;

public class ContentConfiguration : IEntityTypeConfiguration<Content>
{
    public void Configure(EntityTypeBuilder<Content> builder)
    {
        builder.HasKey(k=>k.ContentId)
            .IsClustered();
        builder.Property(x => x.ContentId)
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
            .HasDefaultValueSql("SYSDATETIMEOFFSET()")
            .IsRequired();
        builder.Property(x => x.UpdateAt)  
            .HasDefaultValueSql("SYSDATETIMEOFFSET()")
            .IsRequired();
        builder.Property(x => x.Status) 
            .IsRequired()
            .HasColumnType("int");
        builder.Property(x => x.ContentType) 
            .IsRequired()
            .HasColumnType("int");
        builder.Property(x => x.Order) 
            .IsRequired()
            .HasColumnType("int");
        builder.Property(x => x.RowVersion)
            .IsRowVersion();
        builder.Property(x => x.IsDeleted) 
            .IsRequired()
            .HasColumnType("int");
    }
}