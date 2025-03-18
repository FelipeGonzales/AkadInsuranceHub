namespace PaymentService.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public string PolicyNumber { get; set; } = string.Empty;
        public string HolderName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}