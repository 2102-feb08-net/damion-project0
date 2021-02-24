using System;
using System.Collections.Generic;

namespace ModelsLibrary
{
    public interface IStoreRepository 
    
    { 

        
        public void Addstore(Stores store);

        public Stores Findstore(string ZipC);




    }
}

