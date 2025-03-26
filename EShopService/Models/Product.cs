﻿using System.ComponentModel;

namespace EShopService.Models;

public class Product : BaseModel
{
    public required string Ean { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; } = 0;
    public required string Sku { get; set; }
    public required Category Category { get; set; }
}
