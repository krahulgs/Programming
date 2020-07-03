using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_1
{
    public class AbstractHandler : IHandler
    {
        private IHandler NextHandler;

        public IHandler setNext(IHandler handler)
        {
            this.NextHandler = handler;
            return handler;
        }
       
        public virtual object Handle(object request)
        {
            if (this.NextHandler != null)
            {
                return this.NextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
