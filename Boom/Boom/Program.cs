using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boom
{
    class Program
    {
        public static string [] BoomBang(int start,int end)
        {
            List<string> Words = new List<string>();
           
            for (var i = start; i< end; i++)
            {
               if (i % 3 == 0 && i % 5 == 0)
                Words.Add("BoomBang");
                 else if (i % 3 == 0)
                Words.Add("Boom");
                 else if (i % 5 == 0)
                Words.Add("Bang");
                else
                Words.Add(i.ToString());
                  
            }
            string[] symbols = Words.ToArray();
            return (symbols);
         
        
        }
    
        static void Main(string[] args)
            {
            Console.Write("Insert starting number:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert ending number:");
            int end = Convert.ToInt32(Console.ReadLine());
            string[] array = BoomBang(start, end);
            Console.WriteLine("[{0}]",string.Join(",",array));
            Console.ReadLine();

            }
    }
   
}

