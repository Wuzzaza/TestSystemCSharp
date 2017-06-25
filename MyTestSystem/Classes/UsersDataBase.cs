using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestSystem
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
        private user currentUser;


        private UsersDataBase()
        {
            userList = new List<user>();
            userList.Add(new user() { login = "admin", password = "1234", adminRights = true });
            userList.Add(new user() { login = "guest", password = "1234", adminRights = false });
        }

        public static UsersDataBase getInstance()
        {
            if (userDatabase == null) userDatabase = new UsersDataBase();
            return userDatabase;
        }

        public bool logIn(string login, string password)
        {
            if (userList.Exists(a=>a.login == login && password == password))
            {
                currentUser = userList.Find(a => a.login == login && password == password);

                Console.WriteLine("User Exists");
                return true;
            }

            return false;
        }

        public bool currentUserIsAdmin()
        {
            return currentUser.adminRights;
        }

    }
}
