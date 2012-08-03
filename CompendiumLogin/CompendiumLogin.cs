using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CompendiumLogin
{
    public partial class CompendiumLogin : Form
    {
        public CompendiumLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("You must enter your Compendium username. Usually this is your email address.", "Username Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("You must enter your Compendium password.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Compendium.SetRootURL(@"http://www.domain.com");
                Compendium.Login(txtUsername.Text, txtPassword.Text);

                MessageBox.Show(
                    Compendium.Fetch(Compendium.CompendiumType.NPCS),
                    "Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                );
            }
            catch (Exception ex) // Bad, bad. :(
            {
                MessageBox.Show("There was an error while trying to login or fetch content.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
