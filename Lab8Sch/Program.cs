namespace Lab7Csh
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class UserArray : GenericArray<User>
    {
        public UserArray(int size) : base(size) { }
    }

    public class UserRegistration
    {
        private UserArray userArray;

        public UserRegistration(int size)
        {
            userArray = new UserArray(size);
        }

        public void RegisterUser(string login, string password)
        {
            User newUser = new User { Login = login, Password = password };
            userArray.Add(newUser);
        }

        public void DisplayUsers()
        {
            for (int i = 0; i < userArray.Length(); i++)
            {
                User user = userArray.GetItem(i);
                Console.WriteLine($"Логин: {user.Login}, Пароль: {user.Password}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserRegistration registration = new UserRegistration(5);
            registration.RegisterUser("user1", "pass1");
            registration.RegisterUser("user2", "pass2");
            registration.RegisterUser("user3", "pass3");

            registration.DisplayUsers();
        }
    }
}
