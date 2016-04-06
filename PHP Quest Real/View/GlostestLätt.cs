using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_Quest_Real.View
{
    public partial class GlostestLätt : Form
    {
        private string språk;

        public GlostestLätt(string språk)
        {
            this.språk = språk;
        }

        // Get- set metod för språk
        public string Språk
        {
            get { return språk; }
            set { språk = value; }
        }

        public GlostestLätt()
        {
            InitializeComponent();
            // Initierar klasser:
            MasterControl master = new MasterControl();
            GlosTestControl control = new GlosTestControl(språk, true);
            control.Språk = språk;
            // Randomizera ord från språk:
            btnOrd1.Text = control.SlumpaGlosa(språk).Ord;
            btnOrd2.Text = control.SlumpaGlosa(språk).Ord;
            btnOrd3.Text = control.SlumpaGlosa(språk).Ord;
            btnOrd4.Text = control.SlumpaGlosa(språk).Ord;
        }
    }
}
