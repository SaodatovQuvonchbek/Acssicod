using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakuniy_javobi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            string str = Console.ReadLine();
            Console.WriteLine(Check(str));
            Console.ReadKey();
        }

        static string Check(string a)
        {
            string str1="";
            int count = 0;
            foreach(var i in a)
            {
                if (Convert.ToInt32(i) > 47 && Convert.ToInt32(i) < 58)
                {
                    count++;
                }
            }
            if(count == a.Length)
            {
                return (Convert.ToInt32(a) + 10).ToString();
            }
            foreach(var i in a)
            {
                if (Convert.ToInt32(i) > 47 && Convert.ToInt32(i) <58)
                {
                    str1 += Convert.ToString(i);
                }
            }

            return str1.ToString();
        } 
    }
}
