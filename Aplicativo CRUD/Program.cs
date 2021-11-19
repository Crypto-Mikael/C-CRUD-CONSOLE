using System;
using System.Collections.Generic;

namespace Aplicativo_CRUD
{
    public class Program
    {
        static void Main()
        {
            List<Users> Users = new List<Users>();
            Users.Add(new Users("Robertinho", "12", "robertinho@gmail.com", "123"));
            Users.Add(new Users("Atoninho", "14", "atoninho@gmail.com", "321"));
            Users.Add(new Users("Jequinha", "12", "jecazinho@gmail.com", "123"));
            Menu.Interface(ref Users);           
        }
    }
}
