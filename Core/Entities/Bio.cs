namespace Core.Entities;

public class Bio
{ 
    public string BioId { get; set; }
    public string UserName { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Url { get; set; }
    public DateTimeOffset CreateDate { get; set; }
    public DateTimeOffset UpdateDate { get; set; }
    public int Status { get; set; }
    public ICollection<Content> Contents { get; set; } 
    public ICollection<SocialMedia> SocialMedias { get; set; }
    public byte[] RowVersion { get; set; }
    public int IsDeleted { get; set; }
}