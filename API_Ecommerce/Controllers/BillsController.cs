using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Bills;

namespace API_Ecommerce.Controllers
{
    public class AddBillRequest
    {
        public string datetime { get; set; }
        public string paymentMethod { get; set; }
        public int UserId { get; set; }
        public List<Detail>? Details { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class BillsController : Controller
    {
        private IsVBill _svBill;
        public BillsController(IsVBill svBill)
        {
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
        public void Post([FromBody] AddBillRequest billRequest)
        {
            Bill bill = new Bill()
            {
                datetime = billRequest.datetime,
                paymentMethod = billRequest.paymentMethod,
                UserId = billRequest.UserId,
            };
            /*
            foreach (int productId in billRequest.Details)
            {
                Detail detail = new Detail() { ProductId = productId };
                bill.Details.Add(detail);
            }*/
            _svBill.AddBill(bill);
        }

        [HttpPost("{id}")]
        public void Confirmation(int id)
        {
            _svBill.CalculateTotals(id);
        }
    }
}
