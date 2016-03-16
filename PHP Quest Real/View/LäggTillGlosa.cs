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
    public partial class LäggTillGlosa : Form
    {
        MasterControl master = new MasterControl();

        public LäggTillGlosa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            master.RegistreraGlosaVailid(glosa.Text, glosaSv.Text, språk.Text, master.CurrentUser);
        }
    }
}
