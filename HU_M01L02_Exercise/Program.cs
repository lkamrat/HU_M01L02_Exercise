using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {
        private static int n;

        static void Main(string[] args)
        {

            // Personal Data Exercise

            string MyName = "Lior Kamrat";
            int MyID = 4;
            string MyPhone = "0542002002";

            Console.WriteLine("{0} {1} {2}", MyName, MyPhone, MyID); // One liner data
            Console.WriteLine(MyName + "\n" + MyPhone + "\n" + MyID); // Multiple lines data

            // Operators-01 Exercise

            int numOne = 5;
            int numeTwo = 6;
            double numThree = 7.5;

            Console.WriteLine("The sum of all my numbers is: {0}", numOne + numeTwo + numThree);
            Console.WriteLine("The avarage of all my numbers is: {0}", (numOne + numeTwo + numThree) / 3);
            Console.WriteLine("The multiplying of all my numbers is: {0}", numOne * numeTwo * numThree);

            // Operators-02 Exercise

            int a = 5;
            int b = 10;
            int c = a;
            a = b;
            b = c;

            Console.WriteLine("a = {0}", a);  // The result will be 10
            Console.WriteLine("b = {0}", b);  // The result will be 5

            // Operators-03 Exercise

            a = (a * b); 
            b = (a / b);
            a = (a / b);
            
            Console.WriteLine("a = {0}", a);  // The result will be 5
            Console.WriteLine("b = {0}", b);  // The result will be 10 
                        
        }
    }
}
