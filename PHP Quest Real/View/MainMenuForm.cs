using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHP_Quest_Real.View;

namespace PHP_Quest_Real
{
    public partial class MainMenuForm : Form
    {
        LäggTillGlosa addGlosa = new LäggTillGlosa();
        MasterControl master = new MasterControl();
        public MainMenuForm()
        {
            InitializeComponent();
            
        }

        private void btnNyGlosa_Click(object sender, EventArgs e)
        {
            addGlosa.Show();
        }
    }
}
