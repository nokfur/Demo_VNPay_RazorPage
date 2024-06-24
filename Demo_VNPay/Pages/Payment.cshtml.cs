using Demo_VNPay.Models;
using Demo_VNPay.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo_VNPay.Pages
{
    public class PaymentModel : PageModel
    {
        private readonly IVnPayService _vnPayService;

        public PaymentModel(IVnPayService vnPayService)
        {
            _vnPayService = vnPayService;
        }

        [BindProperty]
        public VnPaymentRequestModel PaymentRequest { get; set; }

        public VnPaymentResponseModel PaymentResponse { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            PaymentRequest.OrderId = "1";
            PaymentRequest.CreatedDate = DateTime.Now;

            return Redirect(_vnPayService.CreatePaymentUrl(HttpContext, PaymentRequest));
        }
    }
}
