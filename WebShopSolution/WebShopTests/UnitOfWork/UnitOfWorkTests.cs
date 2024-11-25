using Moq;
using WebShop;
using WebShop.Notifications;
using WebShop.UnitOfWork;

namespace WebShopTests.UnitOfWork
{
    public class UnitOfWorkTests
    {
        [Fact]
        public void NotifyProductAdded_CallsObserverUpdate()
        {
            // Arrange
            var product = new Product { Id = 1, Name = "Test" };

            // Skapar en mock av INotificationObserver
            var mockObserver = new Mock<INotificationObserver>();

            // Skapar en instans av ProductSubject och l�gger till mock-observat�ren
            var productSubject = new ProductSubject();
            productSubject.Attach(mockObserver.Object);

            // Injicerar v�rt eget ProductSubject i UnitOfWork
            var unitOfWork = new UoW(productSubject);

            // Act
            unitOfWork.NotifyProductAdded(product);

            // Assert
            // Verifierar att Update-metoden kallades p� v�r mock-observat�r
            mockObserver.Verify(o => o.Update(product), Times.Once);
        }
    }
}