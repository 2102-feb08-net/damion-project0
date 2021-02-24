using System;
using System.Collections.Generic;
using ModelsLibrary;
namespace ModelsLibrary
{

    public class IncorrectFormat : Exception{
            public IncorrectFormat(string message){}
}





    public class User
    {
        private string _FirstName;
        private string _LastName; 
        private string _Email; 
        private string _Password;
        private string _Role = "Member"; 



        private string _CustomerLocationAddress; 
        private string _CustomerLocationCity; 
        private string _CustomerLocationState; 
        private string _CustomerLocationCountry; 
        private string _CustomerLocationZIP;



        public string FirstName{
            get{return _FirstName;}
                 
            set{
               if (value.Length > 0)
               {
                   _FirstName = value;

               }  
               else{
                   throw new IncorrectFormat("Please enter your First Name.");
               } 

            }
            

        }


         public string Role{
            get{return _Role;}
                 
            set{
               if (value.Length > 0)
               {
                   _Role = value;

               }  
               else{
                   throw new IncorrectFormat("Please enter a valid role");
               } 

            }
            

        }


           public string LastName{
            get{return _LastName;}
                 
            set{
               if (value.Length > 0)
               {
                   _LastName = value;

               }  
               else{
                   throw new IncorrectFormat("Please enter your Last Name.");
               } 

            }
            

        }   

        public string Email{

            get{return _Email;}
            set{
                if (value.Contains("@"))
                {
                    _Email = value;
                }
                else{
                   throw new IncorrectFormat("Please enter your correct Email.");
               } 



            }


        }


            public string Password{

            get{return _Password;}
            set{
                if (value.Length > 5)
                {
                    _Password = value;
                }
                else{
                   throw new IncorrectFormat("Please enter a strong password.");
               } 



            }


        }

        public string CustomerLocationAddress{

            get{return _CustomerLocationAddress;}
            set{

                if (value.Length > 2)
                {
                    _CustomerLocationAddress = value;
                }
                else{
                   throw new IncorrectFormat("Please enter your correct address.");

                }

            }
        }

        public string CustomerLocationCity{

                    get{return _CustomerLocationCity;}
            set{

                if (value.Length > 4)
                {
                    _CustomerLocationCity = value;
                }
                else{
                   throw new IncorrectFormat("Please enter your correct City.");

                }

            }
         }


        public string CustomerLocationState{

                    get{return _CustomerLocationState;}
            set{

                if (value.Length > 4)
                {
                    _CustomerLocationState = value;
                }
                else{
                   throw new IncorrectFormat("Please enter your correct State.");

                }

            }
         }

         public string CustomerLocationCountry{

                    get{return _CustomerLocationCountry;}
            set{

                if (value.Length > 4)
                {
                    _CustomerLocationCountry = value;
                }
                else{
                   throw new IncorrectFormat("Please enter your correct Country.");

                }

            }
         }


           public string CustomerLocationZIP{

                    get{return _CustomerLocationZIP;}
            set{

                if (value.Length == 5)
                {
                    _CustomerLocationZIP = value;
                }
                else{
                   throw new IncorrectFormat("Please enter your correct Zip Code.");

                }

            }
         }




        public User(){}

        public User(string FirstName, string LastName, string Email, string CustomerLocationAddress, string CustomerLocationCity, string CustomerLocationState, string CustomerLocationCountry, string CustomerLocationZIP){

                this._FirstName = FirstName;

                this._LastName = LastName;

                this._Email = Email;
                this._CustomerLocationAddress = CustomerLocationAddress;

                this._CustomerLocationCity = CustomerLocationCity;

                this._CustomerLocationState = CustomerLocationState;
                this._CustomerLocationCountry = CustomerLocationCountry;

                this._CustomerLocationZIP = CustomerLocationZIP;
                


        }
        

    }
}
