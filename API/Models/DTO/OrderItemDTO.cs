namespace MyProject.API.Models.DTO
{
    public class OrderItemDTO
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
    }
}
