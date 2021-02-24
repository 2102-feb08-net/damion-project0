using System;
using System.Collections.Generic;
using ModelsLibrary;
namespace ModelsLibrary
{ 

    public class Products{
        public int ID { get; set; }
        public int Quantity { get; set; }

        private string _ProductName; 
        private decimal _ProductPrice;
        private string _ProductDescription;




        public string ProductName{
            get{return _ProductName;}

            set{
                if(value.Length > 0 ){
                    _ProductName = value;
                }
                else{
                    throw new Exception("Please enter a product name.");
                }

            }
        }


        public decimal ProductPrice{
            get{return _ProductPrice;}

            set{
                if(value > 0 ){
                    _ProductPrice = value;
                }
                else{
                    throw new Exception("Please enter a product price.");
                }

            }
        }


          public string ProductDescription{
            get{return _ProductDescription;}

            set{
                if(value.Length > 10 ){
                    _ProductDescription = value;
                }
                else{
                    throw new Exception("Please enter a descriptive product description.");
                }

            }
        }


         public Products(){}

         public Products(string name, decimal price, string descrip,int Quantity){

             this._ProductName = name;
             this._ProductPrice = price;
             this._ProductDescription = descrip;
             this.Quantity = Quantity;

         }


        










    }









}