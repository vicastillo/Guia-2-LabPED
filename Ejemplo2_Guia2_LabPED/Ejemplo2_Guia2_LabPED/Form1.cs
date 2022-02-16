using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2_Guia2_LabPED
{
    public partial class Form1 : Form
    {
        Random random = new Random(); //crear un objeto random
        //utilizamos una lista de C# con elementos de tipo string
        //los valores de la lista ya estarán predeterminados.

        List<string> iconos = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        //Primer label al que se la ha dado click 
        Label primerclick = null;
        //Segundo label al que se le ha dado click
        Label segundoclick = null;

        //método para asignar iconos a los label
        private void Asignar()
        {//realiza esta accion para cada label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                int numeroRandom = random.Next(iconos.Count);
                iconLabel.Text = iconos[numeroRandom];
                iconos.RemoveAt(numeroRandom);
                }
                iconLabel.ForeColor = iconLabel.BackColor;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            Asignar(); //llamamos al método
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        timer1.Stop(); //detener timer
        primerclick.ForeColor = primerclick.BackColor; //color fondo click 1
        segundoclick.ForeColor = segundoclick.BackColor; //color fondo click 2
        primerclick = null; //retorna el primer click a null
        segundoclick = null; //retorna el segundo click a null
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
            //si ese label en concreto ha sido seleccionado (no está nulo)

            if(clickedLabel != null)
            {//el forecolor será negro
                

            }
        }

    }
}
