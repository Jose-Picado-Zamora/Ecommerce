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
        #endregion

        #region functional
        public string SendEmail(int id)
        {
            Bill billToSend = GetBillById(id);
            if(billToSend is not null)
            {
                return "Sending bill " + billToSend.id + " by emalil";
            }
            return "Bill id " + billToSend.id + "haven't been found. Please check and try again";
        }
        #endregion
    }
}