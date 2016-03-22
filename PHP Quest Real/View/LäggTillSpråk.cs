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
    public partial class LäggTillSpråk : Form
    {
        MasterControl master = new MasterControl();
        public LäggTillSpråk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            master.RegistreraSpråkValid(txbSpråk.Text.ToString());
        }
    }
}
