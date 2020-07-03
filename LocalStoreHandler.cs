using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility_1
{
    class LocalStoreHandler:AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "wax")
            {
                Inventory inv = new Inventory();
               
                var result = inv.GetResult().localStore.Single(s => s.name == request.ToString());
                if (result != null)
                {
                    return $"We have {result.qty} {result.name} in our stock \n";
                }
                else
                {
                    return base.Handle(request);
                }
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
