using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using OrderManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace OrderManager.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Orders_Read([DataSourceRequest] DataSourceRequest request)
        {
            var result = _orderService.GetAll();

            var dsResult = result.ToDataSourceResult(request);
            return Json(dsResult);
        }
    }
}