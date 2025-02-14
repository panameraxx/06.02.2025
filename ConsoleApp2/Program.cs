using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            calc.Field1 = 3;
            calc.Field2 = 10;
            calc.Output1();  

           
            Calculate calc1 = new Calculate(1);
            calc1.Field2 = 5;
            calc1.Output1();  

            
            Calculate calc2 = new Calculate(3, 4);
            calc2.Output1();  

            
            Console.WriteLine("Введите первое число:");
            double asd1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double asd2 = double.Parse(Console.ReadLine());

            
            Calculate calc3 = new Calculate(asd1, asd2);
            Console.WriteLine($"{calc3.ToString()}");  

            Console.ReadKey(); 
        }
    }
}
