﻿namespace EShopService.Models;

public class BaseModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public bool Deleted { get; set; }
    public DateTime Created_at { get; set; } = DateTime.UtcNow;
    public Guid Created_by { get; set; }
    public DateTime? Updated_at { get; set;} = DateTime.UtcNow;
    public Guid? Updated_by { get; set; }
}
