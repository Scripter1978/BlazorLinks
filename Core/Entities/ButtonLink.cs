namespace Core.Entities;

public class ButtonLink
{
    public string ButtonLinkId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
    public DateTimeOffset CreateDate { get; set; }
    public DateTimeOffset UpdateDate { get; set; }
    public int ButtonLinkType { get; set; }
    public int Status { get; set; }
    
    public byte[] RowVersion { get; set; }
    public int IsDeleted { get; set; }
}