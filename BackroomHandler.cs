using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ChainOfResponsibility_1
{
    public class BackroomHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "ski poles")
            {
                Inventory inv = new Inventory();
              
                var result = inv.GetResult().backroom.Single(s => s.name == request.ToString());
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
