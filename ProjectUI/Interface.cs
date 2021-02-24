using System;
using ModelsLibrary;
using DataAccess;



namespace ProjectUI
{
    public class UserInterface
    {


        IMemberRepository newusercreation;
        IStoreRepository newstorecreation;




        public UserInterface(IMemberRepository repo, IStoreRepository newstore) 
        {
            newusercreation = repo;
            newstorecreation = newstore;
            
        }




        public void Run()
        {

            Console.WriteLine("Welcome to DamionBuy, a new store with all the latest technology!");
            Console.WriteLine("");
            Console.WriteLine("How may I help you today? Please select from one of the following: ");
            Console.WriteLine("");


            WelcomeOptions();

        }


        private void WelcomeOptions()
        {


            Console.WriteLine("1: Become a member");
            Console.WriteLine("2: Sign In");
            Console.WriteLine("3: Quit Application");



            string response = Console.ReadLine();

            try
            {

                if (int.Parse(response) == 1)
                {
                    try
                    {
                                            Console.WriteLine("Please fill out the following questionaire. At any time, press X to quit the application.");
                    Console.WriteLine("");
                    NewUser();
                    Console.WriteLine("");
                    Console.WriteLine("You will now be directed back to the main menu...");



                    WelcomeOptions();
                    }
                    catch(Exception e)
                    {
                        
                       Console.WriteLine(e);
                    }





                }

                else if (int.Parse(response) == 2)
                {
                    //Sign user in;
                    //Display options based on role

                    Signin();



                }

                else if (int.Parse(response) == 3)
                {
                    //Sign user in;
                    //Display options based on role

                    Console.WriteLine("Quitting Application...");
                    Environment.Exit(0);


                }

            }

            catch (Exception e)
            {
                Console.WriteLine("You did not enter a proper value. Please try again.");
                Console.WriteLine();
                WelcomeOptions();
            }




        }






        public void NewUser()
        {
            User customer = new User();
            Console.WriteLine("Lets start by getting your first name...");
            string firstName = Console.ReadLine();
            customer.FirstName = firstName;
            Console.WriteLine("");


            Console.WriteLine($"It's nice to meet you {firstName}, please enter your last name...");
            string lastName = Console.ReadLine();
            customer.LastName = lastName;
            Console.WriteLine("");


            Console.WriteLine($"I'm glad you have chosen our platform {firstName} {lastName}. Please enter your email address.");
            string email = Console.ReadLine();

            if (newusercreation.SearchUserByEmail(email) == null)
            {

                customer.Email = email;
                Console.WriteLine("");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("A user with this email already exist. Returning you to the main directory.");
                Console.WriteLine("");
                WelcomeOptions();

            }


            bool password_incomplete = true;
            do
            {
                Console.WriteLine($"We still have a few more pieces of data to collect, {firstName} {lastName}. Lets continue by getting a password for your account. ");
                string password = Console.ReadLine();
                Console.WriteLine($"For safety, Please re-enter your password");
                string repeat_password = Console.ReadLine();

                if (password == repeat_password)
                {

                    customer.Password = password;
                    Console.WriteLine("");
                    password_incomplete = false;



                }
                else
                {

                    Console.WriteLine("Your passwords did not match. Please try again");

                    password_incomplete = true;

                }



            } while (password_incomplete == true);




            Console.WriteLine($"We're over halfway done with the creation of your account. We just need to get a few additional details regarding your location. What is your Street Address?");
            string address = Console.ReadLine();
            customer.CustomerLocationAddress = address;
            Console.WriteLine("");


            Console.WriteLine($"What city do you live in?");
            string city = Console.ReadLine();
            customer.CustomerLocationCity = city;
            Console.WriteLine("");


            Console.WriteLine($"What state do you live in?");
            string state = Console.ReadLine();
            customer.CustomerLocationState = state;
            Console.WriteLine("");



            Console.WriteLine($"What country do you live in?");
            string country = Console.ReadLine();
            customer.CustomerLocationCountry = country;
            Console.WriteLine("");

            Console.WriteLine($"What is your zip code?");
            string zip = Console.ReadLine();
            customer.CustomerLocationZIP = zip;
            Console.WriteLine("");

            newusercreation.AddCustomer(customer);
            Console.WriteLine($"Thank you for creating an account {firstName} {lastName}. You are now registered.");
        }


        public void Signin()
        {



             bool login = false;
              do
            {

                try
                {
                    Console.WriteLine("Please Enter Your Email Address");
                    string email = Console.ReadLine();

                    Console.WriteLine("Please Enter Your Password");
                    string password = Console.ReadLine();

                    Console.WriteLine("Checking your login credentials.....");

                    Console.WriteLine("");
                    if (newusercreation.TestSignIn(EmailAdresstest: email, Passwordtest: password) != null)
                    {

                        User user = newusercreation.TestSignIn(EmailAdresstest: email, Passwordtest: password);




                        Console.WriteLine($"You are now logged in, {user.FirstName} {user.LastName} !");

                        login = true;
                        string userrole = user.Role;


                        if (userrole  == "ADMIN")
                        {
                                Console.WriteLine("Please select one of the options: ");
                                Console.WriteLine("");
                                Console.WriteLine("1: Add Store");
                                Console.WriteLine("2: Add Product");
                                Console.WriteLine("3: Search an member by email");
                                Console.WriteLine("4: View store order history");

                                string response = Console.ReadLine();




                                            try
            {

                if (int.Parse(response) == 1)
                {
                    addStore();
                    





                }

                else if (int.Parse(response) == 2)
                {
                   

                   // addProduct();



                }

                else if (int.Parse(response) == 3)
                {
                    //searchOrder();


                }

                 else if (int.Parse(response) == 4)
                {
                   // viewStorehistory();



                }

            }

            catch (Exception e)
            {
                Console.WriteLine("You did not enter a proper value. Please try again.");
                Console.WriteLine();
                WelcomeOptions();
            }


                        }
                        else
                        {
                                
                                Console.WriteLine("Please select one of the options: ");
                                Console.WriteLine("");
                                Console.WriteLine("1: View Previous Orders");
                                Console.WriteLine("2: Place an order");
                                



                        }


                    }
                }
                catch
                {

                    Console.WriteLine("Your information is not correct! Please Try Again!");


                }





            } while (login == false);

        
        







        }


        public void addStore(){
            Stores s = new Stores();
            try
            {
            Console.WriteLine("What is your store address?");
            Console.WriteLine("");
             s.StoreLocationAddress = Console.ReadLine();
            Console.WriteLine("what is your store City?");
            Console.WriteLine("");
            s.StoreLocationCity = Console.ReadLine();
            Console.WriteLine("What is your State? ");
            Console.WriteLine("");
            s.StoreLocationState = Console.ReadLine();
            Console.WriteLine("What is your Country?");
            Console.WriteLine("");
            s.StoreLocationCountry = Console.ReadLine();
            Console.WriteLine("What is your Zip Code?");
            Console.WriteLine("");
            string z = Console.ReadLine();
            s.StoreLocationZip = z;
            Console.WriteLine("What is your store phone number?");
            s.StorePhoneNumber = Console.ReadLine();


            newstorecreation.Addstore(s);
            }
            catch (Exception e)
            {
            
                Console.WriteLine(e);
            }



        }




        
          public void Addstore(Products product){


                 
             }





    }

}
