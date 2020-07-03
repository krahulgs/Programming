using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ChainOfResponsibility_1
{
    public class FloorHandler:AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "ski hats")
            {
                Inventory inv = new Inventory();
                var result = inv.GetResult().floor.Single(s => s.name == request.ToString());
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
