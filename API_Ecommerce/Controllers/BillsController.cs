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
            List<Bill> bills = _svBill.GetAllBill();
            foreach (var bill in bills)
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
                    UserResponse = userResponse,
                    Details = new List<DetailResponse>() 
                };

                foreach (var detail in bill.Details)
                {
                    DetailResponse newDetail = new DetailResponse
                    {
                        quantity = detail.quantity,
                        subtotal = detail.subtotal,
                        ProductId = detail.ProductId
                    };

                    newDetail.Product = new ProductResponseDetail
                    {
                        id = detail.Product.id,
                        name = detail.Product.name,
                        price = detail.Product.price,
                    };

                    response.Details?.Add(newDetail);
                }

                billResponses.Add(response);
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
