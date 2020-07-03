using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_1
{
    public interface IHandler
    {
        IHandler setNext(IHandler handler);
        Object Handle(Object request);
    }
}
