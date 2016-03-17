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
    public partial class LäggTillGlosa : Form
    {
        MasterControl master = new MasterControl();
        CurrentUser currentUser;
        
        public LäggTillGlosa()
        {
            InitializeComponent();
            currentUser = master.CurrentUser; 
            språk.Items.Add("Engelska");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (språk.Text != "Välj språk")
            {
                master.RegistreraGlosaVailid(glosa.Text, glosaSv.Text, språk.Text, CurrentUser.GetUser);
            }
            else
            {
                lblStatus.Text = "Error.";
            }
        }
    }
}
