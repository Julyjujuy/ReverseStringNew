using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Str, Reversestr = "";
            

            int Length;
          

            Console.Write("Please Enter A String : ");
            

            Str = Console.ReadLine();
           

            Length = Str.Length - 1;
            

            while (Length >= 0)
            {
                Reversestr += Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse  String  Is:  {0}", Reversestr); 
            Console.ReadLine();

        }
    }
}
