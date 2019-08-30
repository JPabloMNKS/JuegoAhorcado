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


        private string[] oraciones = { "arwacewly jpwqq","no te preocupes si no funciona bien si todo lo hiciera no tendrias trabajo",
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
        }
        int aux=0;
        private void Llenando()
        {
            arr = oraciones[0].ToCharArray();
            arr2 = new char[oraciones[0].Length];

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

        private void BtnA_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                
                if (letra == 'a')
                {
//                    textBox1.Text += "a ";
                    arr2[aux] = 'a';
                    si = 1;
//                    btnA.BackColor = Color.Lime;
                }
                else
                {
  //                  textBox1.Text += "__ ";
//                    btnA.BackColor = Color.Red;
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
            btnA.Enabled = false;
            aux = 0;
            si = 0;
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
//                    btnQ.BackColor = Color.Lime;

                }
                else
                {
//                    btnQ.BackColor = Color.Red;
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            btnQ.Enabled = false;
            aux = 0;
            if (si == 1)
                btnQ.BackColor = Color.Lime;
            else
                btnQ.BackColor = Color.Red;
            si = 0;

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
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            btnW.Enabled = false;
            aux = 0;
            if (si == 1)
                btnW.BackColor = Color.Lime;
            else
                btnW.BackColor = Color.Red;
            si = 0;
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
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            btnE.Enabled = false;
            aux = 0;
            if (si == 1)
                btnE.BackColor = Color.Lime;
            else
                btnE.BackColor = Color.Red;
            si = 0;
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
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            btnR.Enabled = false;
            aux = 0;
            if (si == 1)
                btnR.BackColor = Color.Lime;
            else
                btnR.BackColor = Color.Red;
            si = 0;
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
                }
                aux++;
            }
            foreach (char le in arr2)
            {
                textBox1.Text += le;
            }
            btnT.Enabled = false;
            aux = 0;
            if (si == 1)
                btnT.BackColor = Color.Lime;
            else
                btnT.BackColor = Color.Red;
            si = 0;
        }

        private void BtnY_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letra in arr)
            {
                if (letra == 'y')
                {
                    textBox1.Text += "y ";
                    btnA.BackColor = Color.Lime;
                }
                else
                {
                    textBox1.Text += "__ ";
                    btnA.BackColor = Color.Red;
                }
            }
            btnA.Enabled = false;

        }

        private void BtnU_Click(object sender, EventArgs e)
        {

        }

        private void BtnI_Click(object sender, EventArgs e)
        {

        }

        private void BtnO_Click(object sender, EventArgs e)
        {

        }

        private void BtnP_Click(object sender, EventArgs e)
        {

        }

        private void BtnS_Click(object sender, EventArgs e)
        {

        }

        private void BtnD_Click(object sender, EventArgs e)
        {

        }

        private void BtnF_Click(object sender, EventArgs e)
        {

        }

        private void BtnG_Click(object sender, EventArgs e)
        {

        }

        private void BtnH_Click(object sender, EventArgs e)
        {
               
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {

        }

        private void BtnK_Click(object sender, EventArgs e)
        {

        }

        private void BtnL_Click(object sender, EventArgs e)
        {

        }

        private void BtnÑ_Click(object sender, EventArgs e)
        {

        }

        private void BtnZ_Click(object sender, EventArgs e)
        {

        }

        private void BtnX_Click(object sender, EventArgs e)
        {

        }

        private void BtnC_Click(object sender, EventArgs e)
        {

        }

        private void BtnV_Click(object sender, EventArgs e)
        {

        }

        private void BtnB_Click(object sender, EventArgs e)
        {

        }

        private void BtnN_Click(object sender, EventArgs e)
        {

        }

        private void BtnM_Click(object sender, EventArgs e)
        {

        }
    }
}
