using MassTransit;
using PaymentService.Data;
using AkadInsuranceHub.Shared.Events; // Agora importamos do projeto compartilhado!

namespace PaymentService.Consumers
{
    public class PolicyCreatedConsumer : IConsumer<PolicyCreatedEvent> // Correção
    {
        private readonly PaymentContext _context;

        public PolicyCreatedConsumer(PaymentContext context)
        {
            _context = context;
        }

        public async Task Consume(ConsumeContext<PolicyCreatedEvent> context) // Correção
        {
            var payment = new Payment
            {
                PolicyId = context.Message.PolicyId,
                PolicyNumber = context.Message.PolicyNumber,
                HolderName = context.Message.HolderName,
                Amount = context.Message.PremiumAmount,
                PaymentDate = DateTime.UtcNow
            };

            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
        }
    }
}
