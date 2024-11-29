namespace Dataccess.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<int> Products { get; set; } = new();
    }
}
