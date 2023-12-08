namespace MvcLinks.Models;

public class LinkItem
{
    public string Id { get; set; }
    public string Text { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public string LinkType { get; set; }
    public int Order { get; set; }
    public string CssClassName { get; set; }
    public string CssClass { get; set; }
}