using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOne3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This is a exercise that helps to explain the use of predefined function of C#.
             */
            //Convertion between string to int
            string number1 = "150";
            Console.WriteLine("string->int: " + (int.Parse(number1) + 10));
            Console.WriteLine("string->int: " + (Convert.ToInt32(number1)+10));

            //Convertion between string to float
            string number2 = "1234567890123456789";
            Console.WriteLine("string->long: " + (long.Parse(number2)+10));
            Console.WriteLine("string->long: " +(Convert.ToInt64(number2)+10) );
            /*
             * Just check if your system is configured to use '.' or ','
             */
            //Convertion between string to float
            string number3 = "23.56";
            Console.WriteLine("string->float " + (float.Parse(number3)+10));
            Console.WriteLine("string->float " +(Convert.ToSingle(number3)+10) );

            //Convertion between string to double
            string number4 = "78353.24858";
            Console.WriteLine("string->double " + (double.Parse(number4)+10));
            Console.WriteLine("string->double " +(Convert.ToDouble(number4)+10));

            //Convertion between string to decimal
            string number5 = "78353.24858";
            Console.WriteLine("string->decimal " + (decimal.Parse(number5)+10));
            Console.WriteLine("string->decimal " + (Convert.ToDecimal(number5)+10));

            //Convertion between string to DateTime
            string date = "10/02/2016";
            Console.WriteLine("string->DateTime " + DateTime.Parse(date));
            Console.WriteLine("string->DateTime " + Convert.ToDateTime(date) );

            //Convertion between string to DateTime
            string hour = "08:25";
            Console.WriteLine("string->DateTime " + DateTime.Parse(hour).Hour + ":" + DateTime.Parse(hour).Minute);
            Console.WriteLine("string->DateTime " + Convert.ToDateTime(hour).Hour + ":" + Convert.ToDateTime(hour).Minute );

            Console.ReadKey();
        }
    }
}
