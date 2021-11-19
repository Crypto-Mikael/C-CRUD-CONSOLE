using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_CRUD
{
    internal class Menu
    {
        public static void Interface(ref List<Users> Users)
        {
            Console.WriteLine("Console User Register Aplication");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Choose an option form the following list: ");
            Console.WriteLine("  1 - Add user");
            Console.WriteLine("  2 - Get all user");
            Console.WriteLine("  3 - Remove User");
            Console.WriteLine("  4 - Update User");
            Console.WriteLine("  5 - Exit");
            Console.WriteLine(" ");
            Console.Write("Your option? ");
            Choices(ref Users);

        }
        public static void Choices(ref List<Users> Users)
        {
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Cases.CreateUser(ref Users);
                        Interface(ref Users);
                        break;
                    case "2":
                        Console.Clear();
                        Cases.ReadAllUsers(ref Users);
                        Interface(ref Users);
                        break;
                    case "3":
                        Console.Clear();
                        Cases.DeleteUser(ref Users);
                        Interface(ref Users);
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Cases.UpdateUser(ref Users);
                        Console.Clear();
                        Interface(ref Users);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Good Bye!");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Escreva um numero valido!");
                        Console.WriteLine(" ");
                        Interface(ref Users);
                        break;
                }
            }
        }
    }
}
