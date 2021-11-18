using System;
using System.Collections.Generic;

namespace Aplicativo_CRUD
{
    internal class Cases
    {
        public static void CreateUser(ref List<Users> Users)
        {
            string name;
            string email;
            string password;
            string age;
            Console.Write("What is the user email? ");
            email = Console.ReadLine();
            Console.Write("What is the user name? ");
            name = Console.ReadLine();
            Console.Write("What is the user age? ");
            age = Console.ReadLine();
            Console.Write("What is the user password? ");
            password = Console.ReadLine();
            Users.Add(new Users(name, age, email, password));
            Console.Clear();
        }

        public static void ReadAllUsers(ref List<Users> Users)
        {
            if (Users.Count != 0)
            {
                foreach (var user in Users)
                {
                    Console.WriteLine(
                        $" ---------------- \n    " +
                        $"Email: {user.email} \n    " +
                        $"Name: {user.name} \n    " +
                        $"Age: {user.age} \n " +
                        $"---------------- ");
                }
            } 
            else
            {
                Console.WriteLine("There is no User!");
            }
                Console.ReadLine();
                Console.Clear();
        }
        public static void DeleteUser(ref List<Users> Users)
        {
            if (Users.Count != 0)
            {
                string email;
                Console.Write("What is the user email? ");
                email = Console.ReadLine();
                for (int i = 0; i < Users.Count; i++)
                {
                    if (Users[i].email == email)
                    {
                        Users.Remove(Users[i]);
                        Console.WriteLine("User Removed! ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Email not found! ");
                        Console.ReadLine();
                        Console.Clear();
                    };
                }
            } else
            {
                Console.WriteLine("There is no User!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
