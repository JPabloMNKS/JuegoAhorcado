using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoAhoracado
{
    public partial class Form1 : Form
    {
        // Drag Window Panel
        private bool draggable;
        private int mouseX;
        private int mouseY;

        // Variables de la aplicacion
        char[] arr;
        char[] arr2;
        int si = 0;
        int puntaje = 0;
        int menosVida = 0;


        // Drag Window
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable)
            {
                this.Left = Cursor.Position.X - mouseX;
                this.Top = Cursor.Position.Y - mouseY;
            }
        }
        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            draggable = false;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private string[] oraciones = { "no te preocupes si no funciona bien si todo lo hiciera no tendrias trabajo",
            "cuando alguien dice quiero un lenguaje de programacion en el que solo tenga que decir lo que quiero que haga denle una paleta",
            "cualquiera puede hablar Enseñame el codigo",
        "en teoria la teoría y la práctica son lo mismo en la practica no",
        "medir el progreso en un proyecto de programacion por líneas de codigo es como medir la construccion de un aeroplano por su peso",
        "la mayoria de los buenos programadores programan no porque esperan que les pagen o que el publico los adore, sino porque programar es divertido",
        "controlar la complejidad es la esencia de la programacion"};


        private string actual;

        private void Button1_Click(object sender, EventArgs e)
        {
            //            Random random = new Random();
            //          int aux = random.Next(0, oraciones.Length);
            //        actual = oraciones[aux];
            //      textBox1.Text = actual;
            Llenando();
            gpTeclado.Enabled = true;
            menosVida = 0;
            textBox1.Clear();
            if (textBox_nombre.Text == "")
            {
                txtJugador.Text = "Tu puedes Juagador 1";
            }
            else
            {
                txtJugador.Text = "Tu puedes " + textBox_nombre.Text;
            }
        }
        int aux=0;
        private void Llenando()
        {
            Random random = new Random();
            int numero = random.Next(0, oraciones.Length);
            txtPuntaje.Text = "Puntaje: 0";
            arr = oraciones[numero].ToCharArray();
            arr2 = new char[oraciones[numero].Length];

            foreach (char letra in arr)
            {
                if(letra == ' ')
                {
                    arr2[aux] = ' ';
//                    textBox1.Text += "   ";
                }
                else
                {
                    arr2[aux] = '-';
//                    textBox1.Text += "__ ";
                }
                aux++;
            }
            aux = 0;
            foreach(char le in arr2)
            {
                textBox1.Text += le;
//                textBox1.Text += arr2[1];
            }
        }
        private void perdiendoVida()
        {
            if (menosVida == 1)
                vida5.Visible = false;
            else if (menosVida == 2)
                vida4.Visible = false;
            else if (menosVida == 3)
                vida3.Visible = false;
            else if (menosVida == 4)
                vida2.Visible = false;
            else if (menosVida == 5)
            {
                vida1.Visible = false;
                gpTeclado.Enabled = false;
            }
        }


        private void BtnA_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                
                if (letra == 'a')
                {
//                    textBox1.Text += "a ";
                    arr2[aux] = 'a';
                    puntaje += 10;
                    si = 1;
//                    btnA.BackColor = Color.Lime;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if(si == 1)
                btnA.BackColor = Color.Lime;
            else
                btnA.BackColor = Color.Red;
            if (btnA.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnA.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: "+puntaje;

        }
        private void BtnQ_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'q')
                {
                    arr2[aux] = 'q';
                    si = 1;
                    puntaje += 10;
                    aux++;
                }
            }
            foreach (char le in arr2)
               {
                   textBox1.Text += le;
               }
            if (si == 1)
                btnQ.BackColor = Color.Lime;
            else
                btnQ.BackColor = Color.Red;
            if (btnQ.BackColor == Color.Red)
                menosVida++;
            if (btnQ.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnQ.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;
        }
        private void BtnW_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'w')
                {
                    arr2[aux] = 'w';
                    si = 1;
                    puntaje += 10;
                }
                else
                {
                    menosVida = 1;

                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnW.BackColor = Color.Lime;
            else
                btnW.BackColor = Color.Red;
            if (btnW.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            si = 0;
            btnW.Enabled = false;
            aux = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;
        }
        private void BtnE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'e')
                {
                    arr2[aux] = 'e';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnE.BackColor = Color.Lime;
            else
                btnE.BackColor = Color.Red;
            if (btnE.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnE.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'r')
                {
                    arr2[aux] = 'r';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnR.BackColor = Color.Lime;
            else
                btnR.BackColor = Color.Red;
            if (btnR.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnR.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 't')
                {
                    arr2[aux] = 't';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnT.BackColor = Color.Lime;
            else
                btnT.BackColor = Color.Red;
            if (btnT.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnT.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;
        }

        private void BtnY_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'y')
                {
                    arr2[aux] = 'y';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnY.BackColor = Color.Lime;
            else
                btnY.BackColor = Color.Red;
            if (btnY.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnY.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnU_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'u')
                {
                    arr2[aux] = 'u';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnU.BackColor = Color.Lime;
            else
                btnU.BackColor = Color.Red;
            if (btnU.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnU.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnI_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'i')
                {
                    arr2[aux] = 'i';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnI.BackColor = Color.Lime;
            else
                btnI.BackColor = Color.Red;
            if (btnI.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnI.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'o')
                {
                    arr2[aux] = 'o';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnO.BackColor = Color.Lime;
            else
                btnO.BackColor = Color.Red;
            if (btnO.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnO.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'p')
                {
                    arr2[aux] = 'p';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnP.BackColor = Color.Lime;
            else
                btnP.BackColor = Color.Red;
            if (btnP.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnP.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 's')
                {
                    arr2[aux] = 's';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnS.BackColor = Color.Lime;
            else
                btnS.BackColor = Color.Red;
            if (btnS.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnS.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'd')
                {
                    arr2[aux] = 'd';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnD.BackColor = Color.Lime;
            else
                btnD.BackColor = Color.Red;
            if (btnD.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnD.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'f')
                {
                    arr2[aux] = 'f';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnF.BackColor = Color.Lime;
            else
                btnF.BackColor = Color.Red;
            if (btnF.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnF.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnG_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'g')
                {
                    arr2[aux] = 'g';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnG.BackColor = Color.Lime;
            else
                btnG.BackColor = Color.Red;
            if (btnG.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnG.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'h')
                {
                    arr2[aux] = 'h';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnH.BackColor = Color.Lime;
            else
                btnH.BackColor = Color.Red;
            if (btnH.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnH.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'j')
                {
                    arr2[aux] = 'j';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnJ.BackColor = Color.Lime;
            else
                btnJ.BackColor = Color.Red;
            if (btnJ.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnJ.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnK_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'k')
                {
                    arr2[aux] = 'k';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnK.BackColor = Color.Lime;
            else
                btnK.BackColor = Color.Red;
            if (btnK.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnK.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'l')
                {
                    arr2[aux] = 'l';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnL.BackColor = Color.Lime;
            else
                btnL.BackColor = Color.Red;
            if (btnL.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnL.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnÑ_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'ñ')
                {
                    arr2[aux] = 'ñ';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnÑ.BackColor = Color.Lime;
            else
                btnÑ.BackColor = Color.Red;
            if (btnÑ.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnÑ.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'z')
                {
                    arr2[aux] = 'z';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnZ.BackColor = Color.Lime;
            else
                btnZ.BackColor = Color.Red;
            if (btnZ.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnZ.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'x')
                {
                    arr2[aux] = 'x';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnX.BackColor = Color.Lime;
            else
                btnX.BackColor = Color.Red;
            if (btnX.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnX.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'c')
                {
                    arr2[aux] = 'c';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnC.BackColor = Color.Lime;
            else
                btnC.BackColor = Color.Red;
            if (btnC.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnC.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'v')
                {
                    arr2[aux] = 'v';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnV.BackColor = Color.Lime;
            else
                btnV.BackColor = Color.Red;
            if (btnV.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnV.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'b')
                {
                    arr2[aux] = 'b';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnB.BackColor = Color.Lime;
            else
                btnB.BackColor = Color.Red;
            if (btnB.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnB.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'n')
                {
                    arr2[aux] = 'n';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnN.BackColor = Color.Lime;
            else
                btnN.BackColor = Color.Red;
            if (btnN.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnN.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'm')
                {
                    arr2[aux] = 'm';
                    si = 1;
                    puntaje += 10;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            if (si == 1)
                btnM.BackColor = Color.Lime;
            else
                btnM.BackColor = Color.Red;
            if (btnM.BackColor == Color.Red)
                menosVida++;
            perdiendoVida();
            btnM.Enabled = false;
            aux = 0;
            si = 0;
            txtPuntaje.Text = "Puntaje: " + puntaje;

        }
    }
}
