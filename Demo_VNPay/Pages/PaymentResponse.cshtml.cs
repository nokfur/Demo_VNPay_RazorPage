using Demo_VNPay.Models;
using Demo_VNPay.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo_VNPay.Pages
{
    public class PaymentResponseModel : PageModel
    {
        private readonly IVnPayService _vnPayService;

        public PaymentResponseModel(IVnPayService vnPayService)
        {
            _vnPayService = vnPayService;
        }

        public VnPaymentResponseModel PaymentResponse { get; set; }

        public void OnGet()
        {
            var response = _vnPayService.MakePayment(Request.Query);

            if (response != null)
            {
                PaymentResponse = response;
            }

        }
    }
}
