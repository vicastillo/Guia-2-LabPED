using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo5_Guia2_LabPED
{
    public partial class Form1 : Form
    {
        Queue<Empleados> Trabajadores = new Queue<Empleados>();
        //creamos objeto de la clase cola, del tipo de la clase empleado (lo que almacena son objetos)

        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados(); //creamos instancia de la clase empleado
            //capturamos los datos del empleado:
            empleado.Carnet = txtcarnet.Text;
            empleado.Nombre = txtnombre.Text;
            empleado.Salario = Decimal.Parse(txtsalario.Text);
            empleado.Fecha = dtpfecha.Value;
            Trabajadores.Enqueue(empleado); //1lamamos al método encolar para meter a la estructura
            dgvCola.DataSource = null; //iniciamos el datagridview con null
            dgvCola.DataSource = Trabajadores.ToArray(); //para pasarlo al dgv convertimos la cola en arreglo
            Limpiar(); //se limpian los textbox
            txtcarnet.Focus(); //se coloca el cursor sobre el primer textbox
        }

        public void Limpiar() //limpia los TextBox
        {
            txtcarnet.Clear();
            txtnombre.Clear();
            txtsalario.Clear();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Trabajadores.Count != 0) //mientras haya trabajadores en la cola
            {
                Empleados empleado = new Empleados(); //instanciamos de la clase empleado
                /*este objeto se usa para poder recuperar los datos y mostrarlos en los
                textbox al momento de ser eliminados de la cola*/
                empleado = Trabajadores.Dequeue(); //llamamos al método desencolar
                //colocamos los datos en sus textbox
                txtcarnet.Text = empleado.Carnet;
                txtnombre.Text = empleado.Nombre;
                txtsalario.Text = empleado.Salario.ToString();
                dtpfecha.Value = empleado.Fecha;
                //la estructura convertida en lista se le pasa al dgv (ahora tiene un empleado menos)
                dgvCola.DataSource = Trabajadores.ToList();
                MessageBox.Show("Se eliminó el registro en cola", "AVISO");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No hay empleados en cola", "AVISO");
                Limpiar();
            }
            txtcarnet.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //salir de la aplicación
        }
    }
}
