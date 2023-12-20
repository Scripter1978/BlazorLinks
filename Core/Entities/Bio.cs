using Postgrest.Attributes;

namespace Core.Entities;

[Table("bio")]
public class Bio : BaseModelAp
{
    public Bio()
    {
        Contents = new List<Content>();
        SocialMedias = new List<SocialMedia>();
    } 
    [Column("title")]
    public string Title { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [Column("image")]
    public string Image { get; set; }
    [Column("url")]
    public string Url { get; set; }
    [Column("url_text")]
    public string UrlText { get; set; }
    public virtual ICollection<Content> Contents { get; set; } 
    public virtual ICollection<SocialMedia> SocialMedias { get; set; }
}