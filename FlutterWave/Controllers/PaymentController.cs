using FlutterWave.Data;
using FlutterWave.Logic;
using FlutterWave.Models;
using FlutterWave.Models.Domain;
using FlutterWave.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FlutterWave.Controllers
{
    public class PaymentController : Controller
    {
        private readonly FlutterCLient _fCLient;
        private readonly UnitRepo _unitRepo;

        public PaymentController(UnitRepo unitRepo, FlutterCLient fCLient)
        {
            _unitRepo = unitRepo;
            _fCLient = fCLient;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
 
        [HttpPost]
        public async Task<ActionResult> Index(PaymentViewModel model)
        {
            try
            {
                var customer = new Customer(model.Name, model.Email, model.PhoneNumber);
                var transReference = Guid.NewGuid();

                var trans = new Transaction() { Id = transReference , Customer = customer};

                _unitRepo.AddEntity(trans);
                _unitRepo.AddEntity(customer);
                await _unitRepo.SaveChangesAsync();

                var redirectUrl =  await _fCLient.InitiatePaymentAsync(new FlutterRequest
                {
                    amount = model.Amount,
                    tx_Ref = transReference.ToString(),
                    customer = customer,
                });

                return Redirect(redirectUrl);
            }
            catch
            {
                return View();
            }
        }
    }
}
