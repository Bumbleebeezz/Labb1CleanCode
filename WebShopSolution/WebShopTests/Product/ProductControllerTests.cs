using Dataccess.Entities;
using Dataccess.Repositories.Products;
using Moq;
using WebShop.Controllers;

public class ProductControllerTests
{
    private readonly Mock<IProductRepository> _mockProductRepository;
    private readonly ProductController _controller;

    public ProductControllerTests()
    {
        // Ställ in mock av Products-egenskapen
        _mockProductRepository = new Mock<IProductRepository>();
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
        Assert.NotNull(result); // Ensure the result is not null
    }
}
