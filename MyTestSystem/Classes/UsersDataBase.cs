using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestSystem.Classes
{
    



    class UsersDataBase
    {
        private struct user
        {
            public string login;
            public string password;
            public bool adminRights;
        }

        private List<user> userList;
        private static UsersDataBase userDatabase;
        private UsersDataBase()
        {
            userList = new List<user>();
            user admin = new user() { login = "admin", password = "1234", adminRights = true };
            userList.Add(admin);
        }

        public static UsersDataBase getInstance()
        {
            if (userDatabase == null) userDatabase = new UsersDataBase();
            return userDatabase;
        }

    }
}
