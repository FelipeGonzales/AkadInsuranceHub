using Microsoft.EntityFrameworkCore;

namespace PolicyService.Data
{
    public class PolicyContext : DbContext
    {
        public PolicyContext(DbContextOptions<PolicyContext> options) : base(options) {}

        public DbSet<Policy> Policies { get; set; }
    }

    public class Policy
    {
        public int Id { get; set; }
        public required string PolicyNumber { get; set; }
        public required string HolderName { get; set; }
        public decimal PremiumAmount { get; set; }
    }
}
