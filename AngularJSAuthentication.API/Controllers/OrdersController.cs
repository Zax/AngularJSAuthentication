﻿using System;
using System.Collections.Generic;
using System.Web.Http;

namespace AngularJSAuthentication.API.Controllers
{
	[RoutePrefix("api/Orders")]
	public class OrdersController : ApiController
	{
		[Authorize]
		[Route("")]
		public IHttpActionResult Get()
		{
			/*
			var principal = Request.GetRequestContext().Principal as ClaimsPrincipal;
			var name = ClaimsPrincipal.Current.Identity.Name;
			var name1 = User.Identity.Name;
			var userName = principal.Claims.Single(c => c.Type == "sub").Value;
				*/
			return Ok(Order.CreateOrders());
		}

	}


    #region Helpers

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public Boolean IsShipped { get; set; }


        public static List<Order> CreateOrders()
        {
            var orderList = new List<Order> 
            {
                new Order {OrderId = 10248, CustomerName = "Taiseer Joudeh", ShipperCity = "Amman", IsShipped = true },
                new Order {OrderId = 10249, CustomerName = "Ahmad Hasan", ShipperCity = "Dubai", IsShipped = false},
                new Order {OrderId = 10250,CustomerName = "Tamer Yaser", ShipperCity = "Jeddah", IsShipped = false },
                new Order {OrderId = 10251,CustomerName = "Lina Majed", ShipperCity = "Abu Dhabi", IsShipped = false},
                new Order {OrderId = 10252,CustomerName = "Yasmeen Rami", ShipperCity = "Kuwait", IsShipped = true}
            };

            return orderList;
        }
    }

    #endregion
}
