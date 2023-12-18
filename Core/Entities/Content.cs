namespace Core.Entities;

public class Content
{
    public string ContentId { get; set; }
    public int ContentType { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset UpdateAt { get; set; }
    public int Order { get; set; }
    public int Status { get; set; }
    public byte[] RowVersion { get; set; }
    public int IsDeleted { get; set; }
}