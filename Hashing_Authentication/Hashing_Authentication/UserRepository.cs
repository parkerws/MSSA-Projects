using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashing_Authentication
{
    public class UserRepository 
    {
         public Dictionary<string, User> UserSearch = new Dictionary<string, User>();

        public void AddUser(User user)
        {
            UserSearch.Add(user.UserName, user);
        }

        public string DisplayUsers()
        {
            string response = "";
            foreach (User user in UserSearch.Values)
            {
                response += $"User information:\nUsername: {user.UserName}" +
                           $"\nHash: {user.Hash}" +
                           $"\nCreation Date: {user.CreationDate}\n\n";
            }

            return response;
        }

        public string DisplayUser(string name)
        {
            string response = "";
            if (!UserSearch.ContainsKey(name))
            {
                return null;
            }
            else
            { 
                response = $"User information:\nUsername: {UserSearch[name].UserName}" +
                           $"\nHash: {UserSearch[name].Hash}" +
                           $"\nCreation Time: {UserSearch[name].CreationDate}";
            
            }

            return response;
        }

        public User GetUser(string name)
        {
            
            if (UserSearch.ContainsKey(name))
            {
                return UserSearch[name];
            }
            else
            {
                return null;
            }
        }

    }
}
