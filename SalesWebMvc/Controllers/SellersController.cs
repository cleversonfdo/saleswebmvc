using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        //Dinâmica do MVC
        public IActionResult Index() //chamada do controlador
        {
            var list = _sellerService.FindAll();//controlador acessa o model
            return View(list);//encaminhando dados para a view
        }
    }
}
