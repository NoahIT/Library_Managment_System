using LMS_VIKO_Nojus_Rascius_PI22A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_VIKO_Nojus_Rascius_PI22A.User_Manager
{
    public class UserManager : IUserManager
    {
        private List<User> _registeredUsers = new List<User>();

        public bool CheckUserExists(string username, string password)
        {
            return _registeredUsers.Any(user =>
                user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                user.Password == password);
        }

        public bool RegisterUser(string username, string password, string firstName, string lastName)
        {
            if (!_registeredUsers.Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                _registeredUsers.Add(new User
                {
                    UserId = _registeredUsers.Count + 1,
                    Username = username,
                    Password = password,
                    FirstName = firstName,
                    LastName = lastName
                });
                return true;
            }
            return false;
        }
    }
}
