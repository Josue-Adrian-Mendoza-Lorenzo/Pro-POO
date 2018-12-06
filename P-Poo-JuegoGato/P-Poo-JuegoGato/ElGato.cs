using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Poo_JuegoGato
{
    public partial class ElGato : Form
    {
        //Atributos
        int turno = 1;
        int[,] Gato;
        int PuntosPlayer1 = 0;
        int PuntosPlayer2 = 0;
        bool YaHayGanador;
        bool Empate;
        public ElGato()
        {
            InitializeComponent();
            IniciarJuego();
        }
        //Metodo para iniciar juego
        public void IniciarJuego()
        {
            turno = 1;
            Gato = new int[3, 3];
            YaHayGanador = false;
            picGanador.Image = Properties.Resources.P_3;
            FichasGato.Controls.Clear();

            //Arreglo para mostrar fichas  y meter valores a la matris
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var FichaJuego = new PictureBox();
                    FichaJuego.Image = Properties.Resources.P_3;
                    FichaJuego.Name = string.Format("{0}", i + "_" + j);
                    FichaJuego.Dock = DockStyle.Fill;
                    FichaJuego.Cursor = Cursors.Hand;
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;

                    //Cuando el Usuario de click empieza a jugar
                    FichaJuego.Click += Jugar;
                    FichasGato.Controls.Add(FichaJuego, j, i);
                    Gato[i, j] = 0;
                }
            }
        }//Fin metodo IniciarJuego()


        public void Jugar(object sender, EventArgs e)
        {
            var FichaSeleccionadaUsuario = (PictureBox)sender;
            FichaSeleccionadaUsuario.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("P-" + turno);
            String[] Posicion = FichaSeleccionadaUsuario.Name.Split("_".ToCharArray());
            int Fila = Convert.ToInt32(Posicion[0]);
            int Columna = Convert.ToInt32(Posicion[1]);
            Gato[Fila, Columna] = turno;
            VerificarJuego(Fila, Columna);

            turno = (turno == 1) ? 2 : 1;
        }//Fin metodo Jugar

        public void VerificarJuego(int Fila, int Columna)
        {//Contador de fichas en filas y columnas
            int GanoFilas = 0;
            int GanoColumnas = 0;
            int DiagonalPrincipal = 0;
            int DiagonalInversa = 0;
            int TamanioGato = 3;
           
            //Matriz de lectura

            for (var i = 0; i < TamanioGato; i++)
            {
                for (int j = 0; j < TamanioGato; j++)
                {
                    if (i == Fila)
                    {
                        if (Gato[i, j] == turno)
                        {
                            GanoFilas++;
                        }

                    }//Fin if Fila
                   
                    if (j == Columna)
                    {
                        if (Gato[i, j] == turno)
                        {
                            GanoColumnas++;
                        }
                    }//Fin if Columna
                    if (i == j) //Diagonal Principal
                    {
                        if (Gato[i, j] == turno)
                        {
                            DiagonalPrincipal++;
                        }
                    }//Fin if Diagonal principal

                    if ((i + j) == (TamanioGato - 1)) //Diagonal Inversa
                    {
                        if (Gato[i, j] == turno)
                        {
                            DiagonalInversa++;
                        }
                    }//Fin if Diagonal inversa
                }//Fin for j
            }//Fin for i

            //Validacion
            if ((GanoFilas == TamanioGato) || (GanoColumnas == TamanioGato) || (DiagonalInversa == TamanioGato) || (DiagonalPrincipal == TamanioGato))
            {
                YaHayGanador = true;
            }


            if (YaHayGanador)
            {
                picGanador.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("P-" + turno);

                MessageBox.Show("Tenemos un Ganador");

                if (turno == 1)
                {
                    PuntosPlayer1++;
                    lblPlayer1.Text = PuntosPlayer1.ToString();
                }
                else
                {
                    PuntosPlayer2++;
                    lblPlayer2.Text = PuntosPlayer2.ToString();
                }

                IniciarJuego();

            }//Fin if Ya Hay Ganador


                if (Empate)
                {
                    MessageBox.Show("Tenemos un Empate");
                    //IniciarJuego();
                }
            


 //if (((GanoFilas != 2) && (GanoColumnas != 2) && (DiagonalInversa != 2) && (DiagonalPrincipal != 2))||((GanoFilas != 1) && (GanoColumnas != 1) && (DiagonalInversa != 1) && (DiagonalPrincipal != 1)))
                //{
                //    Empate = true;
                //}





        }//Fin metodo verificar

        private void picReiniciar_Click(object sender, EventArgs e)
        {
            IniciarJuego();
            PuntosPlayer1 = 0;
            lblPlayer1.Text = PuntosPlayer1.ToString();

            PuntosPlayer2 = 0;
            lblPlayer2.Text = PuntosPlayer2.ToString();
        }

        private void btnEmpate_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }
    }
}
