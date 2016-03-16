using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Quest_Real
{
    class User
    { 
        // Medlemsvariabler
        private string username;
        private string password;
        
        // Konstruktor
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        // Get- setmetoder
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
