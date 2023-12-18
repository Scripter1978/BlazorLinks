namespace Core.Entities;

public class Member
{
    public Member()
    {
        Bios = new List<Bio>();
    }
    public string MemberId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset UpdateAt { get; set; }
    public int Status { get; set; }
    public int MemberType { get; set; }
    public virtual ICollection<Bio> Bios { get; set; }
    public byte[] RowVersion { get; set; }
    public int IsDeleted { get; set; }
}