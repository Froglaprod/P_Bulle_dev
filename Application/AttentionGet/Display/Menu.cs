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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            // Créez une instance de Form1
            Form1 form1 = new Form1();


            //Desaffiche le menu
            this.Hide();


            //Affiche le form1
            form1.Show();
        }
    }
}
