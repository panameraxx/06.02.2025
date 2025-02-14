using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Calculate
    {
        private double field1;
        private double field2;

        public double Field1
        {
            get => field1;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error");
                field1 = value;
            }
        }

        public double Field2
        {
            get => field2;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error");
                field2 = value;
            }
        }

        /// <summary>
        /// Конструктор без параметров (по умолчанию)
        /// </summary>
        public Calculate() { }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        public Calculate(double field1)
        {
            this.Field1 = field1;
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        public Calculate(double field1, double field2) : this(field1)
        {
            this.Field2 = field2;
        }

        /// <summary>
        /// Функция формирования строки с информацией об объекте.
        /// </summary>
        public void Output1()
        {
            Console.WriteLine($"field1 = {Field1}\t field2 = {Field2}\t корень: {Func()} ");
        }

        public override string ToString()
        {
            return $"field1 = {Field1}\t field2 = {Field2}\t корень: {Func()}";
        }

        /// <summary>
        /// Функция обработки значений полей: вычислить корень квадратный из произведения чисел.
        /// </summary>
        public double Func()
        {
            return Math.Sqrt(Field1 * Field2);
        }
    }
}
