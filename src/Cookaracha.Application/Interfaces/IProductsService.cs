﻿using Cookaracha.Application.Commands;
using Cookaracha.Application.Dtos;

namespace Cookaracha.Application.Interfaces;

public interface IProductsService
{
    Task<IEnumerable<ProductDto>> GetAllAsync();
    Task<ProductDto?> GetAsync(Guid id);
    Task<Guid?> CreateProductAsync(CreateProduct command);
    Task<bool> UpdateProductAsync(UpdateProduct command);
    Task<bool> DeleteProductAsync(DeleteProduct command);
}