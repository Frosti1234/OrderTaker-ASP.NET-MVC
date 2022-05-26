using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class OrderController : Controller
    {
        private readonly IBLOrder blOrder;

        public OrderController(IBLOrder order)
        {
            this.blOrder = order;
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(blOrder.GetAllOrders());
        }

        [HttpGet]
        public JsonResult Get(int id)
        {
            return Json(blOrder.GetOrderById(id));
        }

        [HttpPost]
        public bool Post(OrderMaster objOrderMaster)
        {
            return blOrder.AddOrder(objOrderMaster);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return blOrder.DeleteOrder(id);
        }
    }
}