﻿using EShopDomain.Models;

namespace EShop.Application
{
    public interface IProductService
    {
        public Task<List<Product>> GetAllAsync();
        Task<Product> GetAsync(int id);
        Task<Product> Update(Product product);
        Task<Product> Add(Product product);
    }
}