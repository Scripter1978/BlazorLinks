namespace Core.Entities;

public class Member
{
    public string MemberId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTimeOffset CreateDate { get; set; }
    public DateTimeOffset UpdateDate { get; set; }
    public int Status { get; set; }
    public int MemberType { get; set; }
    public ICollection<Bio> Bios { get; set; }
    public byte[] RowVersion { get; set; }
    public int IsDeleted { get; set; }
}