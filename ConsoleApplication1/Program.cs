using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program { 


       
        static void Main(string[] args)
        {
             string s = "man";
            Console.WriteLine(s.Length);
            char z;
            for (int i=s.Length-1;i>=0;i--)
            {
                z = s[i];
                Console.Write(z);
            }
            Console.ReadKey();
        
            
           

        }
    }
}
