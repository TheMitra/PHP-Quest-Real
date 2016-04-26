using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHP_Quest_Real.Control;

namespace PHP_Quest_Real.View
{
    public partial class GlostestLätt : Form
    {
        private string språk;
        // Initierar klasser:
        
        

        // Get- set metod för språk
        public string Språk
        {
            get { return språk; }
            set { språk = value; }
        }

        public GlostestLätt(string språk, bool treFörsök)
        {
            InitializeComponent();
            this.språk = språk;

            MasterControl master = new MasterControl(); ;
            GlosTestControl control = new GlosTestControl(språk, true);

            control.Språk = språk;
            // Initiera testglosor
            control.InitTestGlosor(språk, master.GlosLista);

            // Slumpa ord från språk:
            btnOrd1.Text = control.SlumpaGlosa(språk, master.GlosLista).Ord;
            btnOrd2.Text = control.SlumpaGlosa(språk, master.GlosLista).Ord;
            btnOrd3.Text = control.SlumpaGlosa(språk, master.GlosLista).Ord;
            btnOrd4.Text = control.SlumpaGlosa(språk, master.GlosLista).Ord;

        }

        private void btnOrd1_Click(object sender, EventArgs e)
        {
            GlosTestControl control = new GlosTestControl(språk, true);
            control.Kontroll();
        }
    }
}
