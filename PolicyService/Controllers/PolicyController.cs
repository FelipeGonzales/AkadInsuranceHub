using MassTransit;
using Microsoft.AspNetCore.Mvc;
using PolicyService.Data;
using AkadInsuranceHub.Shared.Events;
using Microsoft.EntityFrameworkCore;

namespace PolicyService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PolicyController : ControllerBase
    {
        private readonly PolicyContext _context;
        private readonly IPublishEndpoint _publishEndpoint;

        public PolicyController(PolicyContext context, IPublishEndpoint publishEndpoint)
        {
            _context = context;
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePolicy([FromBody] Policy policy)
        {
            if (policy == null || string.IsNullOrEmpty(policy.PolicyNumber) || string.IsNullOrEmpty(policy.HolderName))
            {
                return BadRequest("Número da Apólice e Nome do Titular são obrigatórios.");
            }

            _context.Policies.Add(policy);
            await _context.SaveChangesAsync();

            // Publicar evento no RabbitMQ
            await _publishEndpoint.Publish(new PolicyCreatedEvent
            {
                PolicyId = policy.Id,
                PolicyNumber = policy.PolicyNumber,
                HolderName = policy.HolderName,
                PremiumAmount = policy.PremiumAmount
            });

            return CreatedAtAction(nameof(CreatePolicy), new { id = policy.Id }, policy);
        }
    }
}
