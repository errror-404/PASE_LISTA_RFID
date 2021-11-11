using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RFID_PASE_LISTA
{
    public partial class Form1 : Form
        
    {
        SerialPort puertoAr;
        public Form1()
        {
            puertoAr = new SerialPort();
            InitializeComponent();
            puertoAr.PortName = "COM4";
            puertoAr.BaudRate = 9600;
            puertoAr.DtrEnable = true;

            try
            {
                puertoAr.Open();
            }
            catch (Exception x)
            {

                MessageBox.Show("Se debe de conectar Arduino " + x);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Genera los numeros aleatorios
            Random random = new Random();
            int aleatorio = random.Next(1, 4);

            //Se crean los AQrreglos de pruebas
            string[] Nombres = {"Itzel Corrales","Alan Rodriguez","Miguel Arturo","Eliam Vazquez" };
            int[] noEmpleado = { 1, 2, 3, 4 };
            double[] noTarjeta = { 100001, 100002, 100003, 100004 };

            //Se asignan los valores a los componentes
            txtNombre.Text = Nombres[aleatorio];
            txtEmpleado.Text = Convert.ToString( noEmpleado[aleatorio]);
            txtTarjeta.Text = Convert.ToString(noTarjeta[aleatorio]);
            txtFechaHora.Text = DateTime.Now.ToString();

            puertoAr.Write("a");



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            txtNombre.Text = "";
            txtEmpleado.Text = "";
            txtTarjeta.Text = "";
            txtFechaHora.Text = "";

            puertoAr.Write("b");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
