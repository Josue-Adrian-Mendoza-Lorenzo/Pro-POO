using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPoo
{
    public partial class ElGato : Form
    {
        //Atributos
        int turno = 1;
        int[,] Gato;
        int PuntosPlayer1 = 0;
        int PuntosPlayer2 = 0;
        bool YaHayGanador;
        public ElGato()
        {
            InitializeComponent();
        }

        public void IniciarJuego()
        { }

        public void Jugar()
        { }

        public void VerificarJuego()
        { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
