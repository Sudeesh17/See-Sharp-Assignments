using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentfiles
{
    class holidays
    {


        static void Main(string[] args)
        {
            int weekday;


            Console.Write("Enter weekday number (1-7): ");
            weekday = Convert.ToInt32(Console.ReadLine());


            switch (weekday)
            {
                case 1:
                    Console.WriteLine("It is MONDAY  and it's working day");
                    break;
                case 2:
                    Console.WriteLine("It is TUESDAY it's working day");
                    break;
                case 3:
                    Console.WriteLine("It is WEDNESDAY it's working day");
                    break;
                case 4:
                    Console.WriteLine("It is THURSDAY it's working day");
                    break;
                case 5:
                    Console.WriteLine("It is FRIDAY it's working day");
                    break;
                case 6:
                    Console.WriteLine("It is SATURDAY and it's Holiday");
                    break;
                case 7:
                    Console.WriteLine("It is SUNDAY and it's Holiday");
                    break;

            }


        }
    }
}
