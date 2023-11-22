namespace MyProject.API.Models.DTO
{
    public class ShippingAddressDTO
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public List<int> Order { get; set; }
    }
}
