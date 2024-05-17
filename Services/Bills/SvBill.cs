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
            return _myDbContext.Bills.Include(x=>x.Details).ToList();
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
            _myDbContext.SaveChanges();

            return bill;
        }

        public void RemoveBill(int id)
        {
            Bill deletBill = _myDbContext.Bills.Find(id);

            if (deletBill is not null)
            {
                _myDbContext.Bills.Remove(deletBill);
                _myDbContext.SaveChanges();
            }
        }

        public bool SendEmail()
        {
            return true;
        }

        public Bill UpdateBill(int id, Bill bill)
        {
            Bill billUpdate = _myDbContext.Bills.Find(id);
            billUpdate.UserId = bill.UserId;
            billUpdate.datetime = bill.datetime;
            billUpdate.paymentMethod = bill.paymentMethod;

            _myDbContext.Update(billUpdate);
            _myDbContext.SaveChanges();

            return bill;


        }


        #endregion
    }
}