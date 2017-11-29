using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Timers;

namespace HerokuPing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heroku Ping");

            Console.CancelKeyPress += delegate {
                Environment.Exit(0);
            };

            TimerEvent();
            System.Threading.Thread.Sleep(2000);
        }

        private static void TimerEvent()
        {
            while(true)
            {
                HerokuPing(@"http://verdant-project.herokuapp.com");
                System.Threading.Thread.Sleep(1000 * 60 * 20);
            }
        }

        static void HerokuPing(string address)
        {
            Console.WriteLine("Ping adress : {0}, time {1}", address, DateTime.Now.ToString());
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(address).Result;
                Console.WriteLine(result.StatusCode);
            }
        }
    }
}
