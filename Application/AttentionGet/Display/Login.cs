using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttentionGet.Storage;

namespace AttentionGet.Display
{
    
    public partial class Login : Form
    {
        private Pseudo pseudo = new Pseudo();
        public Login()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            // Créez une instance de Form1
            Form1 form1 = new Form1();

            //Changement du pseudo
            form1.pseudotext.Text = pseudo.pseudo;


            //Desaffiche le menu
            this.Hide();


            //Affiche le form1
            form1.Show();
        }

        private void pseudoEnter_TextChanged(object sender, EventArgs e)
        {
            //Stocke le pseudo que l'utilisateur a entré
            pseudo.pseudo = pseudoEnter.Text;
        }
    }
}
