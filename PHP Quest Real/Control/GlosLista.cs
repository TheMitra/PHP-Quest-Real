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
        private List<Glosa> glosLista;                      // Skapar en lista av glosklassen.

        public GlosLista()
        {
            glosLista = new List<Glosa>();
        }

        public Glosa glosa;

        public Glosa Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }

        public void Add(Glosa item)
        {
            glosLista.Add(item);
        }

        public void Delete(Glosa item)
        {
            glosLista.Remove(item);
        }

        public void Write()
        {

        }

        public bool RegistreraGlosaValid(string ord, string översättning , string språk, User user)
        {
            // Input to lowercase med hjälp av metoden ToLower()
            // Förhindrar att stringen inte stämmer beroende på om ordet är i lower eller uppercase.

            ord.ToLower();
            översättning.ToLower();
            språk.ToLower();
            for (int i = 0; i < glosLista.Count; i++)
            {
                // To lowercase:
                glosLista[i].Ord.ToLower();
                glosLista[i].Översättning.ToLower();
                glosLista[i].Språk.ToLower();
                if (ord == glosLista[i].Ord && översättning == glosLista[i].Översättning && språk == glosLista[i].Språk && user == glosLista[i].User)
                {
                    return false;
                }
            }

            return true;
        }
        public void TestData()
        {
            Glosa ord = new Glosa("Bil", "Car", "Engelska", new User("Amanda", "Password"));
            Add(ord);
            ord = new Glosa("Hus", "House", "Engelska", new User("Amanda", "Password"));
            Add(ord);
            ord = new Glosa("Hund", "Dog", "Engelska", new User("Amanda", "Password"));
            Add(ord);
            ord = new Glosa("Katt", "Cat", "Engelska", new User("Amanda", "Password"));
            Add(ord);
            ord = new Glosa("Hus", "House", "Engelska", new User("Amanda", "Password"));
            Add(ord);
        }

    }
}
