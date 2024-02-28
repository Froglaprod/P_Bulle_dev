using AttentionGet.Display;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttentionGet.Diplay
{
    public partial class Menuprincipale : Form
    {
        public Menuprincipale()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            // Créez une instance de login
            Login login = new Login();


            //Desaffiche le menu
            this.Hide();


            //Affiche le login
            login.Show();
        }


    }
}
