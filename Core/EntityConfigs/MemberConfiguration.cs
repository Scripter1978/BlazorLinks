using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.EntityConfigs;

public class MemberConfiguration : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.HasKey(k => k.MemberId)
            .IsClustered();
        builder.Property(x => x.MemberId) 
            .IsRequired()
            .HasColumnType("varchar(25)")
            .HasMaxLength(25)
            .IsUnicode(false);
        
        builder.Property(x => x.FirstName) 
            .IsUnicode()
            .IsRequired(false)
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);
        builder.Property(x => x.LastName) 
            .IsUnicode()
            .IsRequired(false)
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);
        
        builder.Property(x => x.Email) 
            .IsUnicode(false)
            .IsRequired()
            .HasColumnType("varchar(1000)")
            .HasMaxLength(1000);

        builder.Property(x => x.CreateDate)
            .HasDefaultValueSql("SYSDATETIMEOFFSET()")
            .IsRequired();
        builder.Property(x => x.UpdateDate)
            .HasDefaultValueSql("SYSDATETIMEOFFSET()")
            .IsRequired();
        builder.Property(x => x.Status)
            .IsRequired()
            .HasColumnType("int");
        builder.Property(x => x.MemberType)
            .IsRequired()
            .HasColumnType("int");
        builder.Property(x => x.RowVersion)
            .IsRowVersion();
        builder.Property(x => x.IsDeleted) 
            .IsRequired()
            .HasColumnType("int");
    }
}