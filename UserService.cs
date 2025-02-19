using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem
{
    class UserService
    {
        //declare event
        public delegate void UserRegisteredHandler(string username, string email);

        public event UserRegisteredHandler? OnUserRegistered;

        public void RegisterUser(string username, string email)
        {
            Console.WriteLine($"Registering user: {username}");
            OnUserRegistered?.Invoke(username, email);
        }
    }
}
