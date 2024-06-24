using Demo_VNPay.Models;

namespace Demo_VNPay.Services
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(HttpContext context, VnPaymentRequestModel model);

        VnPaymentResponseModel MakePayment(IQueryCollection colletions);
    }
}
