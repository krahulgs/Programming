using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_1
{
    public class Floor    {
        public string name { get; set; } 
        public int qty { get; set; }

    }

    public class Backroom   {
        public string name { get; set; } 
        public int qty { get; set; } 

    }

    public class LocalStore    {
        public string name { get; set; } 
        public int qty { get; set; } 

    }

    public class Warehouse    {
        public string name { get; set; } 
        public int qty { get; set; } 

    }

    public class Root    {
        public List<Floor> floor { get; set; } 
        public List<Backroom> backroom { get; set; } 
        public List<LocalStore> localStore { get; set; } 
        public List<Warehouse> warehouse { get; set; } 

    }

}
