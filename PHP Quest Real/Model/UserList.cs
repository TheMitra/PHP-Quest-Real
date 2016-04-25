using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Quest_Real
{
    class UserList
    {
        private List<User> userList;

        public UserList()
        {
            userList = new List<User>();
            TestData();
        }


        public void Add(User item)
        {
            userList.Add(item);
        }

        public void Delete(User item)
        {
            userList.Remove(item);
        }

        public bool Login(string username, string password)
        {
            for (int index = 0; index < userList.Count; index++)
            {
                if (this.userList[index].Username == username)
                {
                    if (this.userList[index].Password == password)
                    {

                        return true;
                    }
                }
            }
            return false;
        }

        public bool HasUser(string username)
        {
            for (int index = 0; index < this.userList.Count; index++)
            {
                if (this.userList[index].Username == username)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Register(string namn, string pass)
        {
            if (HasUser(namn) == false)
            {
                User newUser = new User(namn, pass);
                userList.Add(newUser);
                return true;
            }
            return false;
        }


        public void TestData()
        {
            User id = new User("Amanda", "Password");
            Add(id);
            id = new User("Pontus", "BraPassword");
            Add(id);
        }
    }
}
