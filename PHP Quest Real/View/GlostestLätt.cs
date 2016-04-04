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

        public string Språk
        {
            get { return språk; }
            set { språk = value; }
        }

        public GlostestLätt()
        {
            InitializeComponent();
            MasterControl master = new MasterControl();
            GlosTestControl control = new GlosTestControl();
            
        }
    }
}
