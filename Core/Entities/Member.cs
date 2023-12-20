using Postgrest.Attributes;

namespace Core.Entities;

[Table("member")]
public class Member : BaseModelAp
{
    public Member()
    {
        Bios = new List<Bio>();
    }
    [Column("first_name")]
    public string FirstName { get; set; }
    [Column("last_name")]
    public string LastName { get; set; } 
    
    [Column("status")]
    public int Status { get; set; }
    [Column("member_type")]
    public int MemberType { get; set; }
    public virtual ICollection<Bio> Bios { get; set; }
}