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
        // Forms
        LäggTillSpråk addSpråk = new LäggTillSpråk();
        LäggTillGlosa addGlosa = new LäggTillGlosa();
        GlostestStart startGlostTest = new GlostestStart();

        // Klasser och listor
        MasterControl master = new MasterControl();
        GlosLista listGlosor = new GlosLista();
        public MainMenuForm()
        {
            InitializeComponent();
            listGlosor.TestData();
            for (int i = 0; i < master.SizeGlostList(); i++)
            {
                glosLista.Items.Add(master.ShowGlosorSv(i));
            }
            
        }

        private void btnNyGlosa_Click(object sender, EventArgs e)
        {
            addGlosa.Show();
        }

        private void btnNySpråk_Click(object sender, EventArgs e)
        {
            addSpråk.Show();
        }

        private void btnGlostestStart_Click(object sender, EventArgs e)
        {
            startGlostTest.Show();
        }
    }
}
