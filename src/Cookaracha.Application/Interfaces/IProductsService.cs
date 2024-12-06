﻿using Cookaracha.Application.Dtos;

namespace Cookaracha.Application.Interfaces;

public interface IProductsService
{
    Task<IEnumerable<ProductDto>> GetAllAsync();
}