using System.ComponentModel.DataAnnotations;

namespace Core.Enums;

public enum UniqueIdType
{
    [Display(Name = "user")]
    User,
    [Display(Name = "link")]
    Link,
    [Display(Name = "image")]
    Image,
    [Display(Name = "linkitem")]
    LinkItem,
    [Display(Name = "cssclass")]
    CssClass,
    [Display(Name = "cssclassname")]
    CssClassName,
    [Display(Name = "content")]
    Content,
    [Display(Name = "bio")]
    Bio,
    [Display(Name = "socialmedia")]
    SocialMedia,
    
}