using Postgrest.Attributes;
using Postgrest.Models;

namespace Core.Entities;

public class BaseModelAp : BaseModel
{
    
    [PrimaryKey("id")]
    public string Id { get; set; }
    [Column("created_at")]
    public DateTimeOffset CreatedAt { get; set; }
    [Column("update_at")]
    public DateTimeOffset UpdateAt { get; set; } 
    [Column("status")] 
    public int Status { get; set; } 
    [Column("user_id")]
    public string UserId { get; set; }
    
}