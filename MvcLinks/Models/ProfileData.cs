namespace MvcLinks.Models;

public class ProfileData
{
    public string UserName { get; set; }
    public string ProfileImagePath { get; set; }
    public string Bio { get; set; }
    public string Website { get; set; }
    
    public string JpgImageName { get; set; }
    public string PngImageName { get; set; }
    public IEnumerable<LinkItem> LinkItems { get; set; }
}