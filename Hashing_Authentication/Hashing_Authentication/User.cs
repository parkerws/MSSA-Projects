using System;
using System.Collections.Generic;
using System.Text;


namespace Hashing_Authentication
{
    public class User
    {
        public string UserName { get; private set; }
        public string Hash { get; private set; }
        public string CreationDate { get; private set; }

        public User(string name, string password)
        //public string CreateAccount(string name, string password)
        {
            UserName = name;
            CreationDate = DateTime.Now.ToString("f");
            Hash = Password.SHA256HashGenerator(password);
            
        }

        public string AccountCreation()
        {
            return $"Account {UserName} created at {CreationDate}\nHash: {Hash}\n";
        }

        public string ChangePassword(string password)
        { 
            Hash = Password.SHA256HashGenerator(password);
            return $"Password successfully changed to {password}, Hash: {Hash}.";
        }

        
    }
}
