using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace ChainOfResponsibility_1
{
    public class Inventory
    {
        public Root GetResult()
        {
            List<string> result = new List<string>();
            var JSON = System.IO.File.ReadAllText(@"../../../inventory.json");

            return (Root)JsonConvert.DeserializeObject(JSON, typeof(Root));
            
            //if (myJsonObject != null)
            //{
            //    var obj = myJsonObject.floor.Single(s => s.name == searchItem);
            //    return obj.name + " " + obj.qty;
            //}
            //else
            //{
            //    return "Could Not find the value";
            //}
        }
    }
  



}
