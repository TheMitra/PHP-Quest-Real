using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Quest_Real
{
    class MasterControl
    {
        // Konstruera listor
        private UserList userList;
        private GlosLista glosLista;
        private User currentUser;
        private GlosTestControl glosTest;
        
        

        // Initiera listor
        public MasterControl()
        {
            userList = new UserList();
            glosLista = new GlosLista();
            currentUser = new User("username", "password");
        }



        
        /*          Metoder för UserList        */
        // Logga in: 

        public bool ValidLogin(string username, string password)
        {
            if (userList.Login(username, password))
            {
                currentUser.Username = username;
                currentUser.Password = password;
                return true;
            }
            return false;
        }

        // Registrera
        public bool Register(string username, string password)
        {
            return (userList.Register(username, password));
        }




        /*      Metoder för GlosLista och Glosa     */
        // Registrera glosa:
        public bool RegistreraGlosaVailid(string ord, string översättning, string språk, User user)
        {
            return glosLista.RegistreraGlosaValid(ord, översättning, språk, user);
        }
        // Ta bort glosa
        public void DeleteGlosa(Glosa glosa)
        {
            glosLista.Delete(glosa);
        }



        /*      Metoder för glostest                */
        /* Ett lätt test presenterar flera glosor(tre) som man behöver välja mellan och
        en av de är den rätta glosan. Man har tre försök på sig att välja rätt glosa
        igenom hela testet. */ 
        public void Lätt(string språk)
        {
            while (glosTest.AntalGlosor != 0 || glosTest.Exit == false)
            {
                Glosa felGlosa1;
                Glosa felGlosa2;

                if (glosTest.Kontroll() == true)
                {

                }
            }
        }

        public User CurrentUser
        {
            get { return currentUser; }
            set { value = currentUser; }
        }

    }    
}
