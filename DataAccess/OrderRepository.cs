using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ModelsLibrary;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{

    public class OrderRepository : IOrderRepository
    {
     

        public void placeorder(Orders order)
        {
            string connectionString = File.ReadAllText("C:/Revature/databaseconnectionstring.txt");


            var options = new DbContextOptionsBuilder<DamionBuyContext>()
            .UseSqlServer(connectionString)
            .Options;
            using (var context = new DamionBuyContext(options))
            { 

                var newOrder = new Order(){

                    CustomerId = order.CustomerNumber,
                    StoreId = order.StoreID,
                    DatePlaced = DateTime.Now,

                
                };
                context.Add(newOrder);
                context.SaveChanges();
                Order dbOrderV2 = context.Orders.OrderBy(x => x.Id).Last();
                List<OrderItem> orderDetailList = new List<OrderItem>();

                List<OrderItem> newdetail = new List<OrderItem>();
                foreach ( var product in order.Product){

                    OrderItem neworderdetail = new OrderItem
                    {
                        Orderid = dbOrderV2.Id,
                        Productid = product.ID,
                        Quantity = product.Quantity
                    };
                    orderDetailList.Add(neworderdetail);



                }
                  foreach (var i in orderDetailList)
                    {
                        context.Add(i);
                        context.SaveChanges();
                    }



                


            };
        }
    }

    }