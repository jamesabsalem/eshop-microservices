﻿namespace Catalog.API.Products.CreateProduct;

public record CreateProductRequest(
    string Name,
    string Description,
    List<string> Category,
    string ImageFile,
    decimal Price,
    int Stock);

public record CreateProductResponse(Guid Id);

public class CreateProductEndpoint
{
}