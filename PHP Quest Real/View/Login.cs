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

namespace PHP_Quest_Real
{
    public partial class LogInForm : Form
    {
        MasterControl master = new MasterControl();
        MainMenuForm mainMenu = new MainMenuForm();

        public LogInForm()
        {            
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Check if the login information is valid
            if (master.ValidLogin(txbUsername.Text, txbPassword.Text))
            {
                CurrentUser currentUser = new CurrentUser(txbUsername.Text, txbPassword.Text);
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Status: Error";
            }
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            if (master.Register(txbUsername.Text, txbPassword.Text))
            {
                lblMessage.Text = "Status: Användare registrerad";
            }
            else
            {
                lblMessage.Text = "Status: Error";
            }
        }
    }
}
