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
        GlostestSvår gtSvår;
        
        
        public GlostestStart()
        {
            InitializeComponent();
            MasterControl master = new MasterControl();
            for (int i = 0; i < master.SizeSpråkList(); i++)
            {
                lbSpråk.Items.Add(master.ShowSpråk(i));
            }                      
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Kontrollerar att du valt ett språk i listan
            if (lbSpråk.SelectedItem != null)
            {
                if (rbLätt.Checked == true)
                {
                    gtLätt = new GlostestLätt(lbSpråk.SelectedItem.ToString());
                    gtLätt.Språk = lbSpråk.SelectedItem.ToString();
                    gtLätt.Show();
                }

                if (rbSvår.Checked == true)
                {
                    gtSvår = new GlostestSvår();
                    gtSvår.Show();
                    this.Hide();
                }
            }
            else
            {
                lblStatus.Text = "Error!";
            }     
        }
    }
}
