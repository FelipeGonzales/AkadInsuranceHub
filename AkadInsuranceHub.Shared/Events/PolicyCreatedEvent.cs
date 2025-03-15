namespace AkadInsuranceHub.Shared.Events
{
    public class PolicyCreatedEvent
    {
        public int PolicyId { get; set; }
        public string PolicyNumber { get; set; } = string.Empty;
        public string HolderName { get; set; } = string.Empty;
        public decimal PremiumAmount { get; set; }
    }
}
