using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Bills;
using Services.Emails;

namespace API_Ecommerce.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BillsController : Controller
    {
        private IsVBill _svBill;
        private readonly IEmailSender _emailSender;
        public BillsController(IsVBill svBill, IEmailSender emailSender)
        {
            _emailSender = emailSender;
            _svBill = svBill;
        }

        [HttpGet]
        public IEnumerable<Bill> Get()
        {
            return _svBill.GetAllBill();
        }
        
        [HttpGet("{id}")]
        public Bill Get(int id)
        {
            var result = _svBill.GetBillById(id);
            return _svBill.GetBillById(id);
        }

        [HttpPost]
        public void Post([FromBody] Bill bill)
        {
            _svBill.AddBill(bill);
            _svBill.CalculateTotals(bill.id);
            _emailSender.SendEmail(bill);
        }

    }
}
