using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo4_Guia2_LabPED
{
    public partial class Form1 : Form
    {
        int total = 0; //cantidad de elementos en cola
        Random numeros = new Random(); //los valores serán random

        public Form1()
        {
            InitializeComponent();
            txttotal.Text = Convert.ToString(total);
            //en textbox superior se mostrará el conteo total
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (total == 5)
            {
                MessageBox.Show("La cola está llena");
            }
            else
            {
                total++; //incrementamos cantidad de elementos en cola
                txttotal.Text = Convert.ToString(total);
                switch (total) //dependiendo de cuantos números hay en cola
                {
                    case 1:
                        txtn1.Text = Convert.ToString(numeros.Next(1, 99));
                        txtn1.Visible = true;
                        break;
                    case 2:
                        txtn2.Text = Convert.ToString(numeros.Next(1, 99));
                        txtn2.Visible = true;
                        break;
                    case 3:
                        txtn3.Text = Convert.ToString(numeros.Next(1, 99));
                        txtn3.Visible = true;
                        break;
                    case 4:
                        txtn4.Text = Convert.ToString(numeros.Next(1, 99));
                        txtn4.Visible = true;
                        break;
                    case 5:
                        txtn5.Text = Convert.ToString(numeros.Next(1, 99));
                        txtn5.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Error en la cola");
                        break;
                }
                timer1.Enabled = true;

            }
        }

        private void btnextraer_Click(object sender, EventArgs e)
        {
            if (total == 0)
            { MessageBox.Show("Cola vacia, no puede eliminar datos"); }
            else
            { //en realidad pasamos la informacion de un cuadro a otro
                txtn1.Text = txtn2.Text;
                txtn2.Text = txtn3.Text;
                txtn3.Text = txtn4.Text;
                txtn4.Text = txtn5.Text;

                //descartamos los nodos que no usamos, los dejamos no visibles
                if (total == 1) txtn1.Visible = false;
                if (total == 2) txtn2.Visible = false;
                if (total == 3) txtn3.Visible = false;
                if (total == 4) txtn4.Visible = false;
                if (total == 5) txtn5.Visible = false;
                total--;
                txtn1.Text = Convert.ToString(total);

                timer2.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btningresar.Enabled = false; //deshabilitamos el botón agregar
            if (total == 1)
            {
                pictureBox1.Left = pictureBox1.Left + 5; //hacemos que se dezplace de 5 en 5
                if (pictureBox1.Left >= 300) timer1.Enabled = false; //detenemos el timer cuando llegue a 300
            }
            if (total == 2)
            {
                pictureBox2.Left = pictureBox2.Left + 5;
                if (pictureBox2.Left >= 250) timer1.Enabled = false; //detenemos el timer cuando llegue a 250
            }
            if (total == 3)
            {
                pictureBox3.Left = pictureBox3.Left + 5;
                if (pictureBox3.Left >= 200) timer1.Enabled = false; //detenemos el timer cuando llegue a 200
            }
            if (total == 4)
            {
                pictureBox4.Left = pictureBox4.Left + 5;
                if (pictureBox4.Left >= 150) timer1.Enabled = false; //detenemos el timer cuando llegue a 150
            }
            if (total == 5)
            {
                pictureBox5.Left = pictureBox5.Left + 5;
                if (pictureBox5.Left >= 150) timer1.Enabled = false; //detenemos el timer cuando llegue a 100
            }
            if (timer1.Enabled == false) btningresar.Enabled = true; //timer apagado, enciende botón
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnextraer.Enabled = false; //deshabilitamos extraer 
            pictureBox1.Left = pictureBox1.Left + 5; //movemos la imagen a la derecha
            if (pictureBox1.Left >= 600) //al esconderse a la derecha   
            {
                pictureBox1.Left = 300; //regresamos el primer picturebox a la primera posición
                if (total == 4) pictureBox5.Left = -50; //escondo el picturebox5
                if (total == 3) pictureBox4.Left = -50; //escondo el picturebox4
                if (total == 2) pictureBox4.Left = -50; //escondo el picturebox3
                if (total == 1) pictureBox2.Left = -50; //escondo el picturebox2
                if (total == 0) pictureBox1.Left = -50; //escondo el picturebox1           
                timer2.Enabled = false; //deshabilito timer 
            }
            if (timer2.Enabled == false) btnextraer.Enabled = true; //habilito botón de nuevo
        }
    }
}
