using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Quest_Real
{
    class GlosTestControl
    {
        private int antalRätt;
        private int antalGlosor;
        private Glosa glosa;
        private string språk;
        private string input;
        private string resultat;
        private DateTime tidräknare;
        private bool omTreFörsök;
        private int treFörsök = 3;
        private bool exit = false;
        private List<Glosa> testGlosor = new List<Glosa>();
        private Glosa slumpadGlosa;

        public GlosTestControl(string språk, bool omTreFörsök)
        {
            this.språk = språk;
            this.omTreFörsök = omTreFörsök;
            testGlosor = new List<Glosa>();
        }

        public int AntalRätt
        {
            get { return antalRätt; }
            set { antalRätt = value; }
        }

        public int AntalGlosor
        {
            get { return antalGlosor; }
            set { antalGlosor = value; }
        }

        public Glosa Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }

        public string Språk
        {
            get { return språk; }
            set { språk = value; }
        }

        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        public string Resultat
        {
            get { return resultat; }
            set { resultat = value; }
        }

        public DateTime Tidräknare
        {
            get { return tidräknare; }
            set { tidräknare = value; }
        }

        public int TreFörsök
        {
            get { return treFörsök; }
            set { treFörsök = value; }
        }

        public bool Exit
        {
            get { return exit; }
            set { exit = value; }
        }

        public bool GameOver()
        {
            if (treFörsök == 0)
            {
                return true;
            }
            return false;
        }

        public bool Kontroll()
        {
            input.ToLower();
            string sGlosa = glosa.ToString();
            sGlosa.ToLower();
            if (input == sGlosa)
            {
                return true;
            }
            return false;
        }

        // Slumpar fram en glosa beroende på vilket språk som är valt
        // Lär returnera en lista på 3 unika glosor varav 1 ska vara rätt
        public Glosa SlumpaGlosa(string språk, GlosLista glosLista)
        {
            // Gör en lista med de glosor som ska slumpas
            for (int number = 0; number < glosLista.ListGlosor.Count; number++)
            {

            }

            Random r = new Random();            
            int i = r.Next(0, glosLista.ListGlosor.Count); 
            slumpadGlosa = new Glosa(

                return slumpadGlosa;
        }

        public void Svår()
        {

        }
        
        public string PrintResultat()
        {
            resultat = antalRätt.ToString() + "/" + antalGlosor.ToString();
            return resultat;
        }
    }
}
