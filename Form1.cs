using System.Drawing.Text;
using System.IO.Ports;
using System.Runtime.Serialization;

namespace MaxiALARMA
{
    public partial class Form1 : Form
    {
        SerialPort puertoArduino;
        SerialPort puertoBT;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string nombrePuerto;
            foreach (string nombrePuerto in SerialPort.GetPortNames())
            {
                this.Puertos.Items.Add(nombrePuerto);
                this.comboBt.Items.Add(nombrePuerto);

            }


            if (this.Puertos.Items.Count > 0)
            {
                this.Puertos.SelectedIndex = 0;
                this.comboBt.SelectedIndex = 0;
            }


            //abrir puerto bt



        }

        void mostrarMensaje(string msg)
        {
            testDatos.Text = msg;
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            String comando;
            comando = puertoBT.ReadLine();
            this.Invoke(this.mostrarMensaje, comando);
            puertoArduino.WriteLine(comando);
        }


        private void AbrirPertoBT_Click(object sender, EventArgs e)
        {
            string puerto = this.Puertos.Text;
            this.puertoBT = new SerialPort(puerto);

            //Config puerto Arduino
            puertoBT.BaudRate = 9600;
            puertoBT.Parity = Parity.None;
            puertoBT.StopBits = StopBits.One;
            puertoBT.DataBits = 8;
            puertoBT.Handshake = Handshake.None;
            puertoBT.RtsEnable = false;
            puertoBT.ReadTimeout = 10000;

            puertoBT.DataReceived += DataReceivedHandler; //vinculamos el evento de llegada de datos al puerto BT
            try
            {
                this.puertoBT.Open();

            }
            catch
            {
                this.EstadoPuerto.Text = "Error al abrir el puerto seleccionado" + puerto;
                return;
            }
            this.EstadoPuerto.Text = $" Puerto {puerto} abirto correctamente";
        }





        private void CerrarPuerto_Click(object sender, EventArgs e)
        {
            this.puertoArduino.Close();
        }

        private void ActivarSemaforo_Click(object sender, EventArgs e)
        {
            this.puertoArduino.WriteLine("ON");

        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            this.puertoArduino.WriteLine("OFF");

        }

        private void ArirPuertoBt_Click(object sender, EventArgs e)
        {


            string puerto = this.comboBt.Text;
            this.puertoBT = new SerialPort(puerto);

            //Config puerto Arduino
            puertoBT.BaudRate = 9600;
            puertoBT.Parity = Parity.None;
            puertoBT.StopBits = StopBits.One;
            puertoBT.DataBits = 8;
            puertoBT.Handshake = Handshake.None;
            puertoBT.RtsEnable = false;
            puertoBT.ReadTimeout = 10000;

            puertoBT.DataReceived += this.DataReceivedHandler;

            try
            {
                this.puertoBT.Open();

            }
            catch
            {
                this.EstadoPuerto1.Text = "Error al abrir el puerto seleccionado" + puerto;
                return;
            }
            this.EstadoPuerto1.Text = $" Puerto {puerto} abirto correctamente";


        }

        private void btnAbrirPurto_Click(object sender, EventArgs e)
        {
            string puerto = this.Puertos.Text;
            this.puertoBT = new SerialPort(puerto);

            //Config puerto Arduino
            puertoArduino.BaudRate = 9600;
            puertoArduino.Parity = Parity.None;
            puertoArduino.StopBits = StopBits.One;
            puertoArduino.DataBits = 8;
            puertoArduino.Handshake = Handshake.None;
            puertoArduino.RtsEnable = false;
            puertoArduino.ReadTimeout = 10000;

            //puertoBT.DataReceived += DataReceivedHandler; //vinculamos el evento de llegada de datos al puerto BT
            try
            {
                this.puertoArduino.Open();

            }
            catch
            {
                this.EstadoPuerto.Text = "Error al abrir el puerto seleccionado" + puerto;
                return;
            }

        }
    }
}
