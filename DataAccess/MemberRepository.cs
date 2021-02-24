using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ModelsLibrary;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
 


    public class MemberRepository : IMemberRepository
    {

        public void AddCustomer(User customer)
        {


            string connectionString = File.ReadAllText("C:/Revature/databaseconnectionstring.txt");


            var options = new DbContextOptionsBuilder<DamionBuyContext>()
            .UseSqlServer(connectionString)
            .Options;
            using (var context = new DamionBuyContext(options))
            {

                var newCustomer = new Member()
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Role = customer.Role,
                    Email = customer.Email,
                    CustomerLocationAddress = customer.CustomerLocationAddress,
                    CustomerLocationCity = customer.CustomerLocationCity,
                    CustomerLocationState = customer.CustomerLocationState,
                    CustomerLocationCountry = customer.CustomerLocationCountry,
                    CustomerLocationZip = customer.CustomerLocationZIP,
                    Password = customer.Password
                };

                context.Add(newCustomer);

                context.SaveChanges();



            };
        }


        public User SearchUserByEmail(string EMail)
        {

            
            string connectionString = File.ReadAllText("C:/Revature/databaseconnectionstring.txt");


            var options = new DbContextOptionsBuilder<DamionBuyContext>()
            .UseSqlServer(connectionString)
            .Options;
            User memberFound = new User();
            using (var context = new DamionBuyContext(options))
            { 
                try
                {
                    Member query = context.Members.Where(x => x.Email.Equals(EMail)).First();
                    if( query == null){

                    memberFound = null;

                }       
                else{

                    memberFound.FirstName = query.FirstName;
                    memberFound.LastName = query.LastName;
                    memberFound.Email = query.Email;
                    memberFound.Password = query.Password;
                    memberFound.CustomerLocationAddress = query.CustomerLocationAddress;
                    memberFound.CustomerLocationCity = query.CustomerLocationCity;
                    memberFound.CustomerLocationState = query.CustomerLocationState;
                    memberFound.CustomerLocationCountry = query.CustomerLocationCountry;
                    memberFound.CustomerLocationZIP = query.CustomerLocationZip;




                }
                }
                catch
                {
                    
                    memberFound = null;
                }
                

                
                return memberFound;


            }

        }

        ModelsLibrary.Products IMemberRepository.GetProductsNearYou(int ZipCode)
        {
            throw new NotImplementedException();
        }

        public User TestSignIn(string EmailAdresstest, string Passwordtest)
        {
             string connectionString = File.ReadAllText("C:/Revature/databaseconnectionstring.txt");


            var options = new DbContextOptionsBuilder<DamionBuyContext>()
            .UseSqlServer(connectionString)
            .Options;
            User memberFound = new User();
            using (var context = new DamionBuyContext(options)) { 


                Member query = context.Members.Where(x => x.Email.Equals(EmailAdresstest)).First();
                

                if( query == null){

                    memberFound = null;

                }       
                else{

                    if(query.Password != Passwordtest){
                        memberFound = null;
                    }


                    else{
                    memberFound.FirstName = query.FirstName;
                    memberFound.LastName = query.LastName;
                    memberFound.Email = query.Email;
                    memberFound.Password = query.Password;
                    memberFound.CustomerLocationAddress = query.CustomerLocationAddress;
                    memberFound.CustomerLocationCity = query.CustomerLocationCity;
                    memberFound.CustomerLocationState = query.CustomerLocationState;
                    memberFound.CustomerLocationCountry = query.CustomerLocationCountry;
                    memberFound.CustomerLocationZIP = query.CustomerLocationZip;
                    memberFound.Role = query.Role;
                    



                    }

                    



                }




            }
            return memberFound;
        }
    }
}