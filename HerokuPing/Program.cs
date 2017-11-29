using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;

namespace HerokuPing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heroku Ping");
            HerokuPing(@"http://verdant-project.herokuapp.com");
            System.Threading.Thread.Sleep(2000);
        }

        static void HerokuPing(string address)
        {
            Console.WriteLine("Ping adress : {0}, time {1}", address, DateTime.Now.ToString());
        }
    }
}
