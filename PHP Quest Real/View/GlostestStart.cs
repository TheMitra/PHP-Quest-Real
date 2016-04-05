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
    public partial class GlostestStart : Form
    {

        //Forms
        GlostestLätt gtLätt;
        GlostestSvår gtSvår = new GlostestSvår();
        
        public GlostestStart()
        {
            InitializeComponent(); 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbLätt.Checked == true)
            {
                gtLätt.Språk = lbSpråk.SelectedItem.ToString();
                gtLätt.Show();
                this.Hide();
            }
            if (rbSvår.Checked == true)
            {
                gtSvår.Show();
                this.Hide();
            }
        }
    }
}
