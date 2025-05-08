using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Static_Assignment
{
    public class Simplecode
    {
        
        
            private int result;

            public int Addition(int a, int b)
            {
                result = a + b;
                return result;
            }

            public int Substract(int a, int b)
            {
                result = a - b;
                return result;
            }

            public void PrintValues()
            {
                Console.WriteLine("Result: " + result);
            }

            public string Name="";
            public int Age;
            public void ShowInfo()
            {
                Console.WriteLine("Name:" + Name);
                Console.WriteLine("Age:" + Age);
            

            }





    }
}