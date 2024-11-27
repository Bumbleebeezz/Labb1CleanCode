using Dataccess.Entities;
using Dataccess.Repositories.Products;
using Microsoft.AspNetCore.Http;
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
    public async void GetProducts_ReturnsOkResult_WithAListOfProducts()
    {
        // Arrange
        var controller = new ProductController();

        // Act
        var result = controller.GetProducts();

        // Assert
        Assert.NotNull(result);
        var products = Assert.IsType<List<Product>>(result.Value); // Ensure the value is a list of Product
        Assert.NotEmpty(products);  // Ensure the list is not empty
    }

    [Fact]
    public void AddProduct_ReturnsOkResult()
    {
        // Arrange
        var mockController = new ProductController();

        var addProduct = new Product
        {
            Id = 1,
            Name = "Add test product"
        };

        // Act
        var result = mockController.AddProduct(addProduct);

        // Assert
        var okResult = Assert.IsType<OkResult>(result);
        Assert.NotNull(okResult); // Ensure the result is not null
    }
}
