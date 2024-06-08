namespace Entities
{ 
    public class BillResponse
    {
        public int id { get; set; }
        public string date { get; set; }
        public string paymentMethod { get; set; }
        public double? total { get; set; } = 0;
        public int UserId { get; set; }
        public UserResponse? UserResponse { get; set; }
        public List<Detail>? Details { get; set; }
    }
}
