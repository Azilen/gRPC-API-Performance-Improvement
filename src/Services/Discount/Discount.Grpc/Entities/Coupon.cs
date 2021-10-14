namespace Discount.Grpc.Entities
{
    public class Coupon
    {

        public int id { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }
    }
}
