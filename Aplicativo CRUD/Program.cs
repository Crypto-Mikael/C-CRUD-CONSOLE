using System;
using System.Collections.Generic;

namespace Aplicativo_CRUD
{
    public class Program
    {
        static void Main()
        {
            List<Users> Users = new List<Users>();
            Menu.Interface(ref Users);           
        }
    }
}
