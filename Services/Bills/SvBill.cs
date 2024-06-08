using Entities;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Bills
{
    public class SvBill : IsVBill
    {
        private MyContext _myDbContext = default!;
        public SvBill()
        {
            _myDbContext = new MyContext();
        }

        #region reads
        public List<Bill> GetAllBill()
        {           
            return _myDbContext.Bills.Include(x => x.Details).ThenInclude(d => d.Product).Include(x => x.User).ToList(); 
        }

        public Bill GetBillById(int id)
        {
            return _myDbContext.Bills.Include(x => x.Details).ThenInclude(d => d.Product).Include(x => x.User).SingleOrDefault(x => x.id == id);
        }
        #endregion

        #region writes
        public Bill AddBill(Bill bill)
        { 
            _myDbContext.Bills.Add(bill);
            _myDbContext.SaveChanges();
            return bill;
        }

        public void CalculateTotals(int id)
        {
            Bill bill = GetBillById(id);
            if (bill != null && bill.total == 0 && bill.Details != null)
            { 
                bill.total = 0; 
                foreach (Detail detail in bill.Details)
                {
                    detail.subtotal = detail.quantity * detail.Product.price;
                }
                bill.total = bill.Details.Sum(x => x.subtotal);
                UpdateBill(id, bill);
            }

        }

        public void UpdateBill(int id, Bill bill)
        {
            Bill billUpdate = _myDbContext.Bills.Find(id);
            billUpdate.total = bill.total;
            billUpdate.Details = bill.Details;
            _myDbContext.Update(billUpdate);
            _myDbContext.SaveChanges();
        }

        #endregion
    }
}