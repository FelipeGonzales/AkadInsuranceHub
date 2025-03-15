using Microsoft.AspNetCore.Mvc;
using PaymentService.Data;
using Microsoft.EntityFrameworkCore;

namespace PaymentService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentContext _context;

        public PaymentController(PaymentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPayments()
        {
            var payments = await _context.Payments.ToListAsync();
            return Ok(payments);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayment([FromBody] Payment payment)
        {
            if (payment == null || payment.Amount <= 0 || payment.PolicyId <= 0)
            {
                return BadRequest("ID da Apólice e Valor do Pagamento são obrigatórios.");
            }

            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPayments), new { id = payment.Id }, payment);
        }
    }
}
