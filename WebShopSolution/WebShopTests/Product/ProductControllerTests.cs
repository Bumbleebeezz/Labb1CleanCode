using Dataccess.Repositories.Products;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebShop;
using WebShop.Controllers;

public class ProductControllerTests
{
    private readonly Mock<IProductRepository> _mockProductRepository;
    private readonly ProductController _controller;

    public ProductControllerTests()
    {
        _mockProductRepository = new Mock<IProductRepository>();

        // Ställ in mock av Products-egenskapen
    }

    [Fact]
    public void GetProducts_ReturnsOkResult_WithAListOfProducts()
    {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void AddProduct_ReturnsOkResult()
    {
        // Arrange

        // Act

        // Assert
    }
}
