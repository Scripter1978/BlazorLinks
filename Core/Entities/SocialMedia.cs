using Postgrest.Attributes;

namespace Core.Entities;

[Table("socialmedia")]
public class SocialMedia : BaseModelAp
{
    
    [Column("url")]
    public string Url { get; set; }
    [Column("icon")]
    public string Icon { get; set; } 
    [Column("social_media_type")]
    public int SocialMediaType { get; set; }
    [Column("bio_id")]
    public string BioId { get; set; } 
}