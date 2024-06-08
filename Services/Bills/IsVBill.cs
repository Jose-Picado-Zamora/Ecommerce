using Entities;

namespace Services
{
    public interface IsVBill
    {
        public Bill AddBill(Bill bill);
        public List<Bill> GetAllBill();
        public Bill GetBillById(int id);
        public void CalculateTotals(int id);
        public void UpdateBill(int id, Bill bill);

    }
}
