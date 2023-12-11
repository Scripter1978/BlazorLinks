namespace Core.Entities;

public class Profile
{
    public string ProfileId { get; set; }
    public string Name { get; set; }
    public byte[] RowVersion { get; set; }
    public int IsDeleted { get; set; }
}