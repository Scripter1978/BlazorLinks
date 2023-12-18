using Core.Entities;
using Core.Enums;
using Core.Generators;
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

        builder.Property(x => x.CreateAt)
            .HasDefaultValueSql("SYSDATETIMEOFFSET()")
            .IsRequired();
        builder.Property(x => x.UpdateAt)
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
        builder.HasData(new Member
        {
            IsDeleted = 0,
            LastName = "Griffin",
            MemberId = UniqueIdService.Generator(UniqueIdType.User),
            MemberType = (int)MemberType.Premium,
            Status = (int)Status.Active,
            FirstName = "Scott",
            Email = "Scott.l.griffin@gmail.com" 
        });

    }
}