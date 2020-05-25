using BraintreeHttp;
using PayPalCheckoutSdk.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCManukauTech.Models.DB;
using Microsoft.AspNetCore.Http;
using HttpResponse = BraintreeHttp.HttpResponse;
using Order = PayPalCheckoutSdk.Orders.Order;

namespace MVCManukauTech.PayPal
{
    public class PayPalGetOrder
    {
        //2. Set up your server to receive a call from the client
        /*
          You can use this method to retrieve an order by passing the order ID.
         */
        public async static Task<HttpResponse> GetOrder(string orderID, string sessionId, bool debug = false)
        {
            Console.WriteLine("OrderID: " + orderID);
            Console.WriteLine("SessionID: " + sessionId);


            OrdersGetRequest request = new OrdersGetRequest(orderID);
            //3. Call PayPal to get the transaction
            var response = await PayPalClient.client().Execute(request);
            //4. Save the transaction in your database. Implement logic to save transaction to your database for future reference.
            var result = response.Result<Order>();
            if (result == null)
            {
                Console.WriteLine("Result is null.");
            }
            Console.WriteLine("Customer Name: " + result.Payer.Name.GivenName);
            using (var db = new RareShoesContext())
            {
                var order = db.Order.Where(a => a.SessionId == sessionId).FirstOrDefault();
                if(order == null)
                {
                    Console.WriteLine("Order is null");
                    
                }
                else
                {
                    Console.WriteLine("OrderID: " + order.OrderId);
                }
                order.CustomerName = result.Payer.Name.FullName;
                order.EmailAddress = result.Payer.EmailAddress;
                order.TransactionId = result.Id;
                order.OrderStatusId = 3;
                order.DateOfOrder = DateTime.Now;
                order.DeliveryAddress = result.PurchaseUnits[0].Shipping.AddressPortable.AddressLine1 +
                    result.Payer.AddressPortable.AddressLine2 + ", " + result.Payer.AddressPortable.AdminArea2 + ", " +
                    result.Payer.AddressPortable.AdminArea1;
                Console.WriteLine("Deliver address: " + order.DeliveryAddress);
                db.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }

            return response;
        }
    }
}
