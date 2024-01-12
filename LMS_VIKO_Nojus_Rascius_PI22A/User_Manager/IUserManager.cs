using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_VIKO_Nojus_Rascius_PI22A.User_Manager
{
    public interface IUserManager
    {
        bool CheckUserExists(string username, string password);
        bool RegisterUser(string username, string password, string firstName, string lastName);
    }
}
