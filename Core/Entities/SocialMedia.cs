namespace Core.Entities;

public class SocialMedia
{
    public string SocialMediaId { get; set; }
    public string UserName { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset UpdateAt { get; set; }
    public int SocialMediaType { get; set; }
    public int Status { get; set; }
    public byte[] RowVersion { get; set; }
    public int IsDeleted { get; set; }
}