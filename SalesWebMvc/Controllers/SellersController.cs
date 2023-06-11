using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
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

        public IActionResult Create()
        {
            return View();
        }

        //informar que a ação de post e não de get
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            //com nameof se mudar o nome do metodo index não precisa mudar aqui
            return RedirectToAction(nameof(Index));//("Index")
        }
    }
}
