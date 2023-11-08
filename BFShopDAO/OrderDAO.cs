using BFShopBussinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFShopDAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;
        private static object objectLock = new object();

        public static OrderDAO Instance
        {
            get
            {
                lock (objectLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public string createOrderID()
        {
            using (var context = new Bird_Farm_Shop_PRNContext())
            {
                var matchingOrders = context.Orders
                    .Where(order => order.OrderId.StartsWith("O"))
                    .Select(order => order.OrderId.Substring(1))
                    .AsEnumerable();

                if (matchingOrders.Any())
                {
                    var maxOrderId = matchingOrders.Max(orderId => int.Parse(orderId));
                    int num = maxOrderId + 1;
                    return "O" + num.ToString("D2");
                }
                else
                {
                    return "O01";
                }
            }

        }


    }
}
