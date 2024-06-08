using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Bills;
using Services.Emails;
using Services.Products;

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
        public IEnumerable<BillResponse> Get()
        {
            List<BillResponse> billResponses = new List<BillResponse>();

            foreach (var bill in _svBill.GetAllBill())
            {
                UserResponse userResponse = new UserResponse
                {
                    id = bill.User.id,
                    name = bill.User.name,
                    email = bill.User.email,
                    address = bill.User.address,
                };

                BillResponse response = new BillResponse
                {
                    id = bill.id,
                    date = bill.date,
                    paymentMethod = bill.paymentMethod,
                    total = bill.total,
                    UserId = bill.UserId,
                    Details = bill.Details,
                    UserResponse = userResponse
                };
                billResponses?.Add(response);
            }
            return billResponses;
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
