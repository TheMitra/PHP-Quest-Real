using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Quest_Real.Control
{
    class CurrentUser
    {
        private static User currentUser;


        public CurrentUser(string username, string password)
        {
            currentUser = new User(username, password);
        }

        public static User GetUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
    }
}
