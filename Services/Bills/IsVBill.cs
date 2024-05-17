using Entities;

namespace Services
{
    public interface IsVBill
    {
        public Bill AddBill(Bill bill);
        public void RemoveBill(int id);
        public Bill UpdateBill(int id,Bill bill);
        public List<Bill> GetAllBill();
        public Bill GetBillById(int id);
        public bool SendEmail();

    }
}
