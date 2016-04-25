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
            MasterControl master;
            GlosTestControl control;
            master = new MasterControl();
            control = new GlosTestControl(språk, true);
            control.Språk = språk;
            // Slumpa ord från språk:
            control.SlumpaGlosa(språk, master.GlosLista);

        }

        private void btnOrd1_Click(object sender, EventArgs e)
        {
            GlosTestControl control = new GlosTestControl(språk, true);
            control.Kontroll();
        }
    }
}
