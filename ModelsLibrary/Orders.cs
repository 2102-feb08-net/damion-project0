using System;
using System.Collections.Generic;
using ModelsLibrary;
namespace ModelsLibrary
{ 

    public class Orders{


     
        public int ID { get; set; }
        public List<Products> Product { get; set; }
        public DateTime OrderPlaced { get; set; }
        public decimal Total { get; set; }
        public int CustomerNumber { get; set; }
        public int StoreID { get; set; }

    }


        








    }
