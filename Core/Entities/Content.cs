using Postgrest.Attributes;

namespace Core.Entities;
[Table("content")]
public class Content : BaseModelAp
{ 
    [Column("content_type")]
    public int ContentType { get; set; }
    [Column("title")]
    public string Title { get; set; }
    [Column("body")]
    public string Body { get; set; }
    [Column("url")]
    public string Url { get; set; }
    [Column("icon")]
    public string Icon { get; set; } 
    [Column("order")]
    public int Order { get; set; } 
}