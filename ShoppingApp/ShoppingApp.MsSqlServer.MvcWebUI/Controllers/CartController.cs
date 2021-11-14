using Microsoft.AspNetCore.Mvc;
using ShoppingApp.MsSqlServer.Business.Abstract;
using ShoppingApp.MsSqlServer.Entities.Concrete;
using ShoppingApp.MsSqlServer.MvcWebUI.Models;
using ShoppingApp.MsSqlServer.MvcWebUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.MsSqlServer.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }
        public IActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", string.Format("Ürününüz {0} Başarıyla Eklendi", productToBeAdded.ProductName));

            return RedirectToAction("Index", "Product");
        }
        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }
        public IActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", string.Format("Ürününüz Başarıyla Kaldırıldı"));
            return RedirectToAction("List");
        }
        public IActionResult Complete()
        {
            var ShippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(ShippingDetailsViewModel);
        }
        [HttpPost]
        public IActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", string.Format("Teşekkürler {0}, Sipaişin Hazırlanıyor",shippingDetails.FirstName));
            return View();
        }
    }
}
