using System;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.ComponentModel;
using Nancy.Json;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ChainOfResponsibility_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var Floor = new FloorHandler();
            var Localstore = new LocalStoreHandler();
            var BackroomHandler = new BackroomHandler();

            Floor.setNext(Localstore).setNext(BackroomHandler);
            Client.ClientCode(Floor);
            Console.WriteLine();

            Console.WriteLine("Sub Chain: localstore> BookRoom \n");
            Client.ClientCode(Localstore);

        }



    }

    internal class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var item in new List<string> { "ski hats", "ski rack","wax" })
            {
                Console.WriteLine($"Client: Who wants a {item}?");

                var result = handler.Handle(item);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {item} was left untouched.");
                }
            }
        }
    }


}
