using BusinessObjects.Request;
using BussinessObjects;
using BussinessObjects.Request;

namespace Services
{
    public interface IVoucherRepository
    {
        public List<Voucher> GetVoucher();
        public RequestVoucherDTO CreateVoucher(RequestVoucherDTO request);
        public bool DeleteVoucher(int id);
        public Voucher UpdateVoucher(Voucher request);
        public List<Voucher> searchVoucher(string context);
        public int CountVoucher();
        public bool checkVoucherExistedByReissued(int reissued);
        public Voucher checkVoucherExistedByID(int id);
    }
}
