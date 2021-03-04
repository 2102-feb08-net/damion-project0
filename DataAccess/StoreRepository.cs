using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ModelsLibrary;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class StoreRepository : IStoreRepository
    {        public void Addstore(Stores store)
        {
            string connectionString = File.ReadAllText("C:/Revature/databaseconnectionstring.txt");


            var options = new DbContextOptionsBuilder<DamionBuyContext>()
            .UseSqlServer(connectionString)
            .Options;
            using (var context = new DamionBuyContext(options))
            { 
                var newstore = new Store()
                {

                StoreName = "DamionBuy",
                StoreLocationAddress = store.StoreLocationAddress,
                StoreLocationCity = store.StoreLocationCity,
                StoreLocationState = store.StoreLocationState,
                StoreLocationCountry = store.StoreLocationCountry,
                StoreLocationZip = store.StoreLocationZip,
                StorePhoneNumber = store.StorePhoneNumber,
                };
                context.Add(newstore);
                context.SaveChanges();







            }


            






        }

         Stores IStoreRepository.Findstore(string ZipC)
        {
            string connectionString = File.ReadAllText("C:/Revature/databaseconnectionstring.txt");


            var options = new DbContextOptionsBuilder<DamionBuyContext>()
            .UseSqlServer(connectionString)
            .Options;
            using (var context = new DamionBuyContext(options))


            {   
                Stores newfoundstore = new Stores();


                    Store query = context.Stores.Where(x => x.StorePhoneNumber.Equals(ZipC)).First();

                  if( query == null){

                    newfoundstore = null;

                }       

                else{

                    newfoundstore.StoreLocationAddress = query.StoreLocationAddress;

                    newfoundstore.StoreLocationCity = query.StoreLocationCity;

                    newfoundstore.StoreLocationState = query.StoreLocationState;
                    newfoundstore.StoreLocationCountry = query.StoreLocationCountry;

                    newfoundstore.StoreLocationZip = query.StoreLocationCountry;
                    newfoundstore.StorePhoneNumber = query.StorePhoneNumber;

                }

                return newfoundstore;



            }
        }
    }





}
