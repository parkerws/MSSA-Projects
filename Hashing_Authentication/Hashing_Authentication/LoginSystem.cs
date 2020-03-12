using System;

namespace Hashing_Authentication
{
    public class LoginSystem
    {
        public static UserRepository userlist = new UserRepository();

        public void Login()
        {
            Console.Clear();
            Console.WriteLine("****************************************************\n" +
                              "*  Welcome to the Ambiguous Company Login System!  *\n" +
                              "*      Please select an option:                    *\n" +
                              "*      (1) Create Account                          *\n" +
                              "*      (2) Login and Change Settings               *\n" +
                              "*      (3) List Current Users (for demonstration)  *\n" +
                              "*      (4) Exit                                    *\n" +
                              "****************************************************\n");
            Console.Write("\nSelection: ");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid option, 1-3");
            }

            if (input == 1)
            {
                Create();
                int choice;
                Console.WriteLine("What would you like to do?\n(1)Return to Main Menu\n(2)Quit");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please enter a valid option.");
                }
                if (choice == 1)
                {
                    Login();
                }
            }
            else if (input == 2)
            {
                Console.Clear();
                User currentUser = Authenticate();

                int choice;
                Console.WriteLine("What would you like to do?\n(1)View Account Info\n(2)Change Password\n(3)Quit");
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 && choice > 3)
                {
                    Console.WriteLine("Please enter a valid number");
                }
                if (choice == 1)
                {
                    Console.Write(userlist.DisplayUser(currentUser.UserName));
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter a new password:  ");
                    string pass = Console.ReadLine();
                    Console.WriteLine(currentUser.ChangePassword(pass));
                    Console.Write(userlist.DisplayUser(currentUser.UserName));
                    Console.ReadKey();
                }

                Login();
            }
            else if (input == 3)
            {
                Console.WriteLine(userlist.DisplayUsers());
                Console.ReadKey();
                Login();
            }
            else if (input == 4)
            {
                Console.WriteLine("Exiting.");
                Console.ReadKey();
            }
        }

        public void Create()
        {
            Console.Clear();
            Console.Write("Welcome! Please enter a new valid username:  ");
            string name = Console.ReadLine();

            while (userlist.GetUser(name) != null)
            {
                Console.Write("\nThat username is taken. Please enter another:  ");
                name = Console.ReadLine();
            }
            Console.Write("That username is available. \nPlease enter a password:  ");
            string password = Password.PasswordMasker();
            User user = new User(name, password);
            Console.WriteLine("\n");
            userlist.AddUser(user);
            Console.WriteLine(user.AccountCreation()); 
            
        }

        public User Authenticate()
        {
            string user;
            string password;
            string hash;
            User auth;

            Console.Write("Please enter your username:  ");
            user = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(user))
            {
                Console.Write("\nPlease enter a username: ");
                user = Console.ReadLine();
            }
            Console.Write("\nEnter Password:  ");
            password = Password.PasswordMasker();

            auth = userlist.GetUser(user);
            hash = Password.SHA256HashGenerator(password);

            Console.Clear();
            while (auth.Hash != hash || auth.Hash == null)
            {
                Console.WriteLine("That username/password combination does not exit. Press any key to try again or press Esc to exit.");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }

                Authenticate();
            }

            return auth;

        }
    }
}