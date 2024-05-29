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
            return _myDbContext.Bills.Include(x=>x.Details).Include(x => x.User).ToList();
        }

        public Bill GetBillById(int id)
        {
            return _myDbContext.Bills.Include(x => x.Details).SingleOrDefault(x => x.id == id);
        }
        #endregion

        #region writes
        public Bill AddBill(Bill bill)
        {
            _myDbContext.Bills.Add(bill);
            foreach (var det  in bill.Details)
            {
               // det.CalcularSubTotal();
            }
            _myDbContext.SaveChanges();

            return bill;
        }
        public bool SendEmail()
        {
            return true;
        }

        #endregion
    }
}