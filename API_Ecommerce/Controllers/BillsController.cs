using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Bills;

namespace API_Ecommerce.Controllers
{
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
        public void Post([FromBody] Bill bill)
        {
            _svBill.AddBill(bill);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Bill bill)
        {
            _svBill.UpdateBill(id, new Bill
            {
                UserId = bill.UserId,
                 datetime = bill.datetime,
                 paymentMethod = bill.paymentMethod,

           
            });
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svBill.RemoveBill(id);
        }
    }
}
