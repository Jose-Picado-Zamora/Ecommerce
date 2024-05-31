﻿using Entities;
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

        [HttpPost("{id}")]
        public void Confirmation(int id)
        {
            _svBill.CalculateTotals(id);
        }
    }
}
