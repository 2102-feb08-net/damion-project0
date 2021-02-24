using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ModelsLibrary;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{


    public class ProductRepository : IProductRepository
    {

         public void addProduct(Products newproduct){

             string connectionString = File.ReadAllText("C:/Revature/databaseconnectionstring.txt");


            var options = new DbContextOptionsBuilder<DamionBuyContext>()
            .UseSqlServer(connectionString)
            .Options;
            using (var context = new DamionBuyContext(options))
            {

                    var newproduc = new Product()
                    {
                        ProductName = newproduct.ProductName,
                        ProductPrice = newproduct.ProductPrice,
                        ProductDescription = newproduct.ProductDescription


                    };
                    

                    context.Add(newproduc);
                    context.SaveChanges();




             }



            
         }



    }






}