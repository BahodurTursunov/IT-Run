namespace HW2
{
    internal class CustomerOrder
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int Count { get; set; }
        public string? Products { get; set; }
        public DateTime OrderDate { get; set; }
        public string? Status { get; set; }


        public CustomerOrder(int orderId, int customerId, int count, string products, DateTime orderDate, string status)
        {
            OrderId = orderId;
            CustomerId = customerId;
            CustomerId = count;
            Count = count;
            Products = products;
            OrderDate = orderDate;
            Status = status;
        }
    }
}
