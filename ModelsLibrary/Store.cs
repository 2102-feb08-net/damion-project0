using System;
using System.Collections.Generic;
using ModelsLibrary;
namespace ModelsLibrary
{


    public class Stores
    { 
        public int ID {get;set;}
        private string _StoreName = "DamionBuy";
        private string _StoreLocationAddress;
        private string _StoreLocationCity;
        private string _StoreLocationState;
        private string _StoreLocationCountry;
        private string _StoreLocationZip;

        private string _StorePhoneNumber;

        public string StoreLocationAddress {
            get{return _StoreLocationAddress;}
            set
            {
                if (value.Length > 0)
                {
                    _StoreLocationAddress = value;
                }
                else{
                    throw new Exception("Please enter your store address!");
                }
        }

        }




                public string StoreLocationCity {
            get{return _StoreLocationCity;}
            set
            {
                if (value.Length > 0)
                {
                    _StoreLocationCity = value;
                }
                else{
                    throw new Exception("Please enter your store city!");
                }
        }

        }

        
                public string StoreLocationState {
            get{return _StoreLocationState;}
            set
            {
                if (value.Length > 0)
                {
                    _StoreLocationState = value;
                }
                else{
                    throw new Exception("Please enter your store state!");
                }
        }

        }

        
                public string StoreLocationCountry {
            get{return _StoreLocationCountry;}
            set
            {
                if (value.Length > 0)
                {
                    _StoreLocationCountry = value;
                }
                else{
                    throw new Exception("Please enter your store country!");
                }
        }

        }


         public string StoreLocationZip {
            get{return _StoreLocationZip;}
            set
            {
                if (value.Length > 0)
                {
                    _StoreLocationZip = value;
                }
                else{
                    throw new Exception("Please enter your store Zip Code!");
                }
        }

        }


          public string StorePhoneNumber {
            get{return _StorePhoneNumber;}
            set
            {
                if (value.Length > 6)
                {
                    _StorePhoneNumber = value;
                }
                else{
                    throw new Exception("Please enter a correct phone number!");
                }
        }

        }



        public Stores() { }


        public Stores(string StoreName,string StoreLocationAddress, string StoreLocationCity, string StoreLocationState, string StoreLocationCountry, string StoreLocationZip, string StorePhoneNumber){
                this._StoreName = StoreName;
                
                
                this._StoreLocationAddress = StoreLocationAddress;
                this._StoreLocationCity = StoreLocationCity;
                this._StoreLocationState = StoreLocationState;
                this._StoreLocationCountry = StoreLocationCountry;
                this._StoreLocationZip = StoreLocationZip;
                this._StorePhoneNumber = StorePhoneNumber;


        }







    }







}