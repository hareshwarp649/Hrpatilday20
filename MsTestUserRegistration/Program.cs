using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestUserRegistration
{
    public class Program
    {
        public static void UserRegisration()
        {


            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("Choose Option to Validate with their specified Pattern");
                Console.WriteLine("1 = First Name\n2 = Last Name\n3 = Mobile Number\n4 = Password\n0 = Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Continue = false;
                        break;
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine(UserRegistration.FirstName(firstName));
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine(UserRegistration.FirstName(lastName));
                        break;
                    case 3:
                        Console.WriteLine("Enter Mobile Number");
                        string mobileNumber = Console.ReadLine();
                        Console.WriteLine(UserRegistration.MobileNumber(mobileNumber));
                        break;
                    case 4:
                        Console.WriteLine("Enter PassWord");
                        string password = Console.ReadLine();
                        Console.WriteLine(UserRegistration.Password(password));
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option!");
                        break;
                }
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            UserRegisration();
            Console.ReadLine();

        }
    }
    
}
