using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Publish p1 = new Publish("Peace&War", "Lev", 2000);
                Console.WriteLine(p1.ToString());
                Console.WriteLine("Enter + year");
            
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(p1.Plus(x));
                
               
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
        


        
    }
}
