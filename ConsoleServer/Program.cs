using Microsoft.Owin.Hosting;
using System;

namespace ConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:8080";
            using (WebApp.Start(url))
            {
                Console.WriteLine("Server started on {0}", url);
                Console.ReadLine();
            }
        }
    }
}
