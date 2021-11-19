namespace Aplicativo_CRUD
{
    internal class Users
    {
        public string name;
        public string email;
        public string password;
        public string age;

        public Users(string Name, string Age, string Email, string Password)
        {
            name = Name;
            age = Age;
            password = Password;
            email = Email;
        }
    }
}

