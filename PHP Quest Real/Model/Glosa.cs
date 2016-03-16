using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_Quest_Real
{
    class Glosa
    {

        // Medlemsvariabler: 
        private string ord;             // Ordet på det språket.
        private string översättning;    // Svensk översättning.
        private string språk;           // Språket.
        private User user;              // Användare som lagt till ordet.

        // Konstrukor som tar emot: ordet, svensk översättning, språk, och användare.
        public Glosa(string glosa, string översättning, string språk, User user)
        {
            this.ord = glosa;
            this.översättning = översättning;
            this.språk = språk;
            this.user = user;
        }


        // Get- setmetoder:
        public string Ord
        {
            get { return ord; }
            set { ord = value; }
        }

        public string Översättning
        {
            get { return översättning; }
            set { översättning = value; }
        }

        public string Språk
        {
            get { return språk; }
            set { språk = value; }
        }

        public User User
        {
            get { return user; }
            set { user = value; }
        }
    }
}
