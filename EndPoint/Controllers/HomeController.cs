using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EndPoint.Models;
using Demo.Core.ApplicatoinService;
using Demo.Core.Contract;
using EndPoint.Service;

namespace EndPoint.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderFacade orderFacade;
        private readonly IViewerCountService viewerCountService;

        public HomeController(IOrderFacade orderFacade, IViewerCountService viewerCountService)
        {
            this.orderFacade = orderFacade;
            this.viewerCountService = viewerCountService;
        }
        public IActionResult Index()
        {
            OrderViewModel orderViewModel = new OrderViewModel();
            var dto = orderFacade.NewOrderHeader();
            orderViewModel.OrderCpde = dto.OrederCode.ToString();
            orderViewModel.StoresInit(dto);

            ViewBag.viewerCount = viewerCountService.Count();
            return View(orderViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
