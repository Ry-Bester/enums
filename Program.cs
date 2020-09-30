using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter mthe current day of the week. ");
            string Day = Console.ReadLine();

            try
            {
                DayOfWeek UsersDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Day, true);

                if (Enum.IsDefined(typeof(DayOfWeek), UsersDay))
                    Console.WriteLine(UsersDay + " is a good day to party!");

                else
                {
                    Console.WriteLine("Try Again");
                }
            }
            //string Day = (string) enum.Parse(typeof(Day), string;

            //foreach ( string Day in DayOfWeek)
            //{

            //}




            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
        
            Console.ReadLine();
        }
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
