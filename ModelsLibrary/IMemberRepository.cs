
using System;
using System.Collections.Generic;

namespace ModelsLibrary
{ 
    public interface IMemberRepository{


        public void AddCustomer(User customer);


       public User SearchUserByEmail(string EMail);


       public Products GetProductsNearYou(int ZipCode);


       public User TestSignIn(string EmailAdresstest, string Passwordtest);


        


    }






}