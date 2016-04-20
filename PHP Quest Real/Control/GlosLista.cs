using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHP_Quest_Real.View;

namespace PHP_Quest_Real
{
    class GlosLista
    {
        // Datamedlemmar:
        private List<Glosa> listGlosor;                  // Skapar en lista av glosklassen.
        private List<string> språkLista;

        public GlosLista()
        {
            listGlosor = new List<Glosa>();
            språkLista = new List<string>();
        }
        
        public List<Glosa> ListGlosor
        {
            get { return listGlosor; }
            set { value = listGlosor; }
        }

        public List<string> ListSpråk
        {
            get { return språkLista; }
            set { value = språkLista; }
        }       

        public void Add(Glosa item)
        {
            listGlosor.Add(item);
        }

        public void Delete(Glosa item)
        {
            listGlosor.Remove(item);
        }

        public void Write()
        {

        }

        public List<Glosa> SlumpaGlosaList(string språk)
        {
            Random random = new Random();
            List<Glosa> lista = new List<Glosa>();
            for (int i = 0; i < listGlosor.Count; i++)
            {
                if (listGlosor[i].Språk.ToLower() == språk.ToLower())
                {
                    lista.Add(listGlosor[i]);
                }
            }

            return lista;
        }

        public bool RegistreraGlosaValid(string ord, string översättning , string språk, User user)
        {
            // Input to lowercase med hjälp av metoden ToLower()
            // Förhindrar att stringen inte stämmer beroende på om ordet är i lower eller uppercase.

            ord.ToLower();
            översättning.ToLower();
            språk.ToLower();
            for (int i = 0; i < listGlosor.Count; i++)
            {
                // To lowercase:
                listGlosor[i].Ord.ToLower();
                listGlosor[i].Översättning.ToLower();
                listGlosor[i].Språk.ToLower();
                if (ord == listGlosor[i].Ord && översättning == listGlosor[i].Översättning && språk == listGlosor[i].Språk && user == listGlosor[i].User)
                {
                    return false;
                }
            }
            Glosa nyGlosa = new Glosa(ord, översättning, språk, user);
            listGlosor.Add(nyGlosa);
            return true;
        }
        
        public bool RegistreraSpråkValid(string språk)
        {
            // Input to lowercase med hjälp av metoden ToLower()
            // Förhindrar att stringen inte stämmer beroende på om ordet är i lower eller uppercase.

            string lowSpråk = språk.ToLower();
            for (int i = 0; i < listGlosor.Count; i++)
            {
                string text = listGlosor[i].Språk.ToLower();
                if (text == lowSpråk)
                {
                    return false;
                }
            }
            språkLista.Add(språk);
            return true;
        }
        

        public void TestData()
        {
            Glosa ord = new Glosa("Bil", "Car", "Engelska", new User("Amanda", "Password"));
            listGlosor.Add(ord);
            ord = new Glosa("Hus", "House", "Engelska", new User("Amanda", "Password"));
            listGlosor.Add(ord);
            ord = new Glosa("Hund", "Dog", "Engelska", new User("Amanda", "Password"));
            listGlosor.Add(ord);
            ord = new Glosa("Katt", "Cat", "Engelska", new User("Amanda", "Password"));
            listGlosor.Add(ord);
            ord = new Glosa("Vild", "Wild", "Engelska", new User("Amanda", "Password"));
            listGlosor.Add(ord);
            ord = new Glosa("Gammal", "Old", "Engelska", new User("Amanda", "Password"));
            listGlosor.Add(ord);

            for (int i = 0; i < listGlosor.Count; i++)
            {
                if (!språkLista.Contains<string>(listGlosor[i].Språk))
                {
                    språkLista.Add(listGlosor[i].Språk);
                }
            }
        }

    }
}
