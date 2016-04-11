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

        public GlosTestControl(string språk, bool omTreFörsök)
        {
            this.språk = språk;
            this.omTreFörsök = omTreFörsök;
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
        public Glosa SlumpaGlosa(string språk, GlosLista glosLista)
        {            
            List<Glosa> listGlosor = new List<Glosa>();
            glosLista.SlumpaGlosaList(språk);
            Random random = new Random();
            int n = random.Next(0, glosLista.ListGlosor.Count);

            Glosa glosa = new Glosa(glosLista.ListGlosor[n].Ord,
                                    glosLista.ListGlosor[n].Översättning,
                                    glosLista.ListGlosor[n].Språk,
                                    glosLista.ListGlosor[n].User); 
            
            return glosa;
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
