namespace Core.Entities;

public class SubTitle
{
    public string SubTitleId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset UpdateAt { get; set; }
    public int SubTitleType { get; set; }
    public int Status { get; set; }
    public byte[] RowVersion { get; set; }
    
    public int IsDeleted { get; set; }
}