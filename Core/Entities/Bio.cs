namespace Core.Entities;

public class Bio
{
    public Bio()
    {
        Contents = new List<Content>();
        SocialMedias = new List<SocialMedia>();
    }
    public string BioId { get; set; }
    public string UserName { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Url { get; set; }
    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset UpdateAt { get; set; }
    public int Status { get; set; }
    public virtual ICollection<Content> Contents { get; set; } 
    public virtual ICollection<SocialMedia> SocialMedias { get; set; }
    public int IsDeleted { get; set; }
}