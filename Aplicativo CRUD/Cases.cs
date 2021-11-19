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
        public static void UpdateUser(ref List<Users> Users)
        {
            string userChoice;
            if (Users.Count != 0)
            {
                for (int i = 0; i < Users.Count; i++)
                {
                    Console.WriteLine($" {i + 1} - \n Name: {Users[i].name} \n Email: {Users[i].email} \n ");
                }
                Console.Write("What user do you want? ");
                userChoice = Console.ReadLine();
                int ChoiceToInt = int.Parse(userChoice) - 1;
                Console.Write(Users.Count);
                if (ChoiceToInt < Users.Count)
                {
                    string newName;
                    string newEmail;
                    string newPassword;
                    string newAge;
                    Console.Clear();
                    Console.Write("What is the user new email? ");
                    newEmail = Console.ReadLine();
                    Users[ChoiceToInt].email = newEmail;
                    Console.Write("What is the user new name? ");
                    newName = Console.ReadLine();
                    Users[ChoiceToInt].name = newName;
                    Console.Write("What is the user new age? ");
                    newAge = Console.ReadLine();
                    Users[ChoiceToInt].age = newAge;
                    Console.Write("What is the user new password? ");
                    newPassword = Console.ReadLine();
                    Users[ChoiceToInt].password = newPassword;
                } else
                {
                    Console.Clear();
                    Console.WriteLine("Numero Invalido!");
                    Console.ReadLine();
                }   
            }
            else
            {
                Console.WriteLine("There is no User!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
