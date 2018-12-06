using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gato
{
    public partial class Nombre : Form
    {
        public Nombre()
        {
            InitializeComponent();
        }

        private void btnempezar_Click(object sender, EventArgs e)
        {
            if (txtjugador1.Text == null || txtjugador1.Text == "")
            {
                txtjugador1.Text = "Jugador 1";
            }
            if (txtjugador2.Text == null || txtjugador2.Text == "")
            {
                txtjugador2.Text = "Jugador 2";
            }

            Gato.nombrejugadores(txtjugador1.Text, txtjugador2.Text);
            

            this.Close();
        }

        private void txtjugador1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                btnempezar.PerformClick();
        }

        private void Nombre_Load(object sender, EventArgs e)
        {

        }
    }
}
