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
    public partial class Gato : Form
    {
        bool turno = true;// true= X turno; false = O turno
        int turnocontador = 0;
        static String jugador1, jugador2;

        public Gato()
        {
            InitializeComponent();
        }
        public static void nombrejugadores(String n1, String n2)
        {
            jugador1 = n1;
            jugador2 = n2;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cada jugador tiene su turno \n1. Cada jugador solo debe colocar su símbolo una vez por turno. \n2. No debe colocar su símbolo sobre una casilla ya jugada. \n3. Se debe conseguir realizar una línea recta con su símbolo. \n4. En otro caso realizando una línea diagonal con su símbolo. \na) Al tener 3 figuras iguales ganaras \nb) En caso de que nadie gane, será empate.  ");
        }
        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turno = true;
            turnocontador = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button bo = (Button)c;
                    bo.Enabled = true;
                    bo.Text = "";
                    bo.BackColor = Color.White;
                }
                catch
                {
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turno)

            {
                b.Text = "X";
                b.BackColor = Color.Red;
            }

            else
            {
                b.Text = "O";
                b.BackColor = Color.Blue;
            }
            turno = !turno;
            b.Enabled = false;

            turnocontador++;
            comprobarganador();
        }

        private void comprobarganador()
        {
            //Fila horizontal
            bool ganador_fila = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                ganador_fila = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                ganador_fila = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                ganador_fila = true;

            //Fila vertical
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                ganador_fila = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                ganador_fila = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                ganador_fila = true;

            //Diagonal vertical
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                ganador_fila = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                ganador_fila = true;

            if (ganador_fila)
            {
                
                String ganador = "";
                if (turno)
                {
                    ganador = jugador2;
                    lblgandor_o.Text = (Int32.Parse(lblgandor_o.Text) + 1).ToString();
                }

                else
                {
                    ganador = jugador1;
                    lblganador_x.Text = (Int32.Parse(lblgandor_o.Text) + 1).ToString();
                }


                var o = MessageBox.Show(ganador + "\n Ganador!", "Yay!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (o == DialogResult.Yes)
                {
                    turno = true;
                    turnocontador = 0;

                    foreach (Control c in Controls)
                    {
                        try
                        {
                            Button bo = (Button)c;
                            bo.Enabled = true;
                            bo.Text = "";
                            bo.BackColor = Color.White;
                            btnCerrar.BackColor = Color.DarkRed;
                            btnCerrar.ForeColor = Color.White;
                        }
                        catch
                        {
                        }
                        finally
                        {
                            btnCerrar.BackColor = Color.DarkRed;
                            btnCerrar.Text = "Cerrar Juego";
                            btnCerrar.ForeColor = Color.White;

                        }
                    }
                }


                if (o == DialogResult.No)
                {
                    MessageBox.Show("El juego se reiniciara");

                    turno = true;
                    turnocontador = 0;

                    foreach (Control c in Controls)
                    {
                        try
                        {
                            Button bo = (Button)c;
                            bo.Enabled = true;
                            bo.Text = "";
                            bo.BackColor = Color.White;

                            lblgandor_o.Text = "0";
                            lblganador_x.Text = "0";
                            lblempate.Text = "0";

                        }
                        catch
                        {
                        }
                        finally
                        {
                            btnCerrar.BackColor = Color.DarkRed;
                            btnCerrar.Text = "Cerrar Juego";
                            btnCerrar.ForeColor = Color.White;
                        }
                    }
                }
            } //fin if 
            else
            {
                if (turnocontador == 9)
                {
                    lblempate.Text = (Int32.Parse(lblempate.Text) + 1).ToString();

                    var r = MessageBox.Show("Empate!", "Oh mira!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        turno = true;
                        turnocontador = 0;

                        foreach (Control c in Controls)
                        {
                            try
                            {
                                Button bo = (Button)c;
                                bo.Enabled = true;
                                bo.Text = "";
                                bo.BackColor = Color.White;
                                btnCerrar.BackColor = Color.DarkRed;
                                btnCerrar.ForeColor = Color.White;
                            }
                            catch
                            {
                            }
                            finally
                            {
                                btnCerrar.BackColor = Color.DarkRed;
                                btnCerrar.Text = "Cerrar Juego";
                                btnCerrar.ForeColor = Color.White;
                            }
                        }
                    }


                    if (r == DialogResult.No)
                    {
                        MessageBox.Show("El juego se reiniciara");

                        turno = true;
                        turnocontador = 0;

                        foreach (Control c in Controls)
                        {
                            try
                            {
                                Button bo = (Button)c;
                                bo.Enabled = true;
                                bo.Text = "";
                                bo.BackColor = Color.White;

                                lblgandor_o.Text = "0";
                                lblganador_x.Text = "0";
                                lblempate.Text = "0";

                                btnCerrar.BackColor = Color.DarkRed;
                                btnCerrar.Text = "Cerrar Juego";
                                btnCerrar.ForeColor = Color.White;
                            }
                            catch
                            {
                            }
                            finally
                            {
                                btnCerrar.BackColor = Color.DarkRed;
                                btnCerrar.Text = "Cerrar Juego";
                                btnCerrar.ForeColor = Color.White;
                            }
                        }
                    }
                }
            }
        } // fin de comprobar filas ganadora 

        //private void inhabilitarbotones()
        //{
        //    try
        //    {
        //        foreach (Control c in Controls)
        //        {
        //            Button b = (Button)c;
        //            b.Enabled = false;

        //        }
        //    }
        //    catch
        //    {
        //    }
        //}

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turno)
                {
                    b.Text = "X";
                    b.ForeColor = Color.Red;
                }
                else
                {
                    b.Text = "O";
                    b.ForeColor = Color.Blue;
                }
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {

                b.Text = "";
            }
        }

        private void reiniciarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblgandor_o.Text = "0";
            lblganador_x.Text = "0";
            lblempate.Text = "0";

        }
        //Boton Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Nombre nombre = new Nombre();
            {
                nombre.ShowDialog();
                label1.Text = jugador1;
                label2.Text = jugador2;
            }

            btnCerrar.BackColor = Color.DarkRed;

        }
    }
}



