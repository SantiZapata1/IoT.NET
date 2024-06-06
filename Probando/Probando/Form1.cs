using System.IO.Ports; // Importa la biblioteca necesaria para la comunicaci�n serial

namespace Probando
{
    public partial class Form1 : Form
    {
        SerialPort m_serialPort = new SerialPort(); // Declara e inicializa un objeto SerialPort

        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        // M�todo que se ejecuta al cargar el formulario
        private void Form1_Load_1(object sender, EventArgs e)
        {
            disableComponents(); // Deshabilita ciertos componentes al iniciar

            string[] portList = SerialPort.GetPortNames(); // Obtiene la lista de puertos seriales disponibles
            comboBoxPort.Items.AddRange(portList); // A�ade la lista de puertos al comboBox
            comboBoxPort.Text = portList[1]; // Selecciona el segundo puerto en la lista por defecto

            string[] rates = { "9600", "115200", "57600" }; // Define un array con diferentes velocidades de baudios
            comboBoxBaud.Items.AddRange(rates); // A�ade las velocidades de baudios al comboBox
            comboBoxBaud.Text = rates[0]; // Selecciona la primera velocidad en la lista por defecto
        }

        // M�todo para deshabilitar ciertos componentes del formulario
        void disableComponents()
        {
            buttonOpen.Enabled = true; // Habilita el bot�n de abrir conexi�n
            buttonClose.Enabled = false; // Deshabilita el bot�n de cerrar conexi�n
            buttonEncender.Enabled = false; // Deshabilita el bot�n de encender
            buttonApagar.Enabled = false; // Deshabilita el bot�n de apagar
            progressBarConnection.Value = 0; // Resetea la barra de progreso
            pictureBoxLed.Image = Properties.Resources.ledOff2; // Muestra la imagen del LED apagado
        }

        // Evento que se ejecuta al presionar el bot�n de encender
        private void buttonEncender_Click_1(object sender, EventArgs e)
        {
            if(m_serialPort.IsOpen) // Verifica si el puerto serial est� abierto
            {
                try
                {
                    m_serialPort.WriteLine("1"); // Env�a el comando "1" por el puerto serial
                    pictureBoxLed.Image = Properties.Resources.ledOn2; // Cambia la imagen del LED a encendido
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); // Muestra un mensaje de error si ocurre una excepci�n
                }
            }
        }

        // Evento que se ejecuta al presionar el bot�n de apagar
        private void buttonApagar_Click_1(object sender, EventArgs e)
        {
            if(m_serialPort.IsOpen) // Verifica si el puerto serial est� abierto
            {
                try
                {
                    m_serialPort.WriteLine("0"); // Env�a el comando "0" por el puerto serial
                    pictureBoxLed.Image = Properties.Resources.ledOff2; // Cambia la imagen del LED a apagado
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); // Muestra un mensaje de error si ocurre una excepci�n
                }
            }
        }

        // Evento que se ejecuta al presionar el bot�n de abrir conexi�n
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                m_serialPort.PortName = comboBoxPort.Text; // Configura el nombre del puerto
                m_serialPort.BaudRate = Convert.ToInt32(comboBoxBaud.Text); // Configura la velocidad de baudios
                m_serialPort.Open(); // Abre el puerto serial
                buttonOpen.Enabled = false; // Deshabilita el bot�n de abrir conexi�n
                buttonClose.Enabled = true; // Habilita el bot�n de cerrar conexi�n
                buttonEncender.Enabled = true; // Habilita el bot�n de encender
                buttonApagar.Enabled = true; // Habilita el bot�n de apagar
                progressBarConnection.Value = 100; // Actualiza la barra de progreso
                comboBoxBaud.Enabled = false; // Deshabilita la selecci�n de velocidad de baudios
                comboBoxPort.Enabled = false; // Deshabilita la selecci�n de puerto
                m_serialPort.WriteLine("0"); // Env�a el comando "0" para asegurarse de que el dispositivo est� apagado al iniciar
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); // Muestra un mensaje de error si ocurre una excepci�n
            }
        }

        // Evento que se ejecuta al presionar el bot�n de cerrar conexi�n
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if(m_serialPort.IsOpen) // Verifica si el puerto serial est� abierto
            {
                try
                {
                    m_serialPort.WriteLine("0"); // Env�a el comando "0" por el puerto serial
                    pictureBoxLed.Image = Properties.Resources.ledOff2; // Cambia la imagen del LED a apagado
                    m_serialPort.Close(); // Cierra el puerto serial

                    buttonOpen.Enabled = true; // Habilita el bot�n de abrir conexi�n
                    buttonClose.Enabled = false; // Deshabilita el bot�n de cerrar conexi�n
                    buttonEncender.Enabled = false; // Deshabilita el bot�n de encender
                    buttonApagar.Enabled = false; // Deshabilita el bot�n de apagar
                    progressBarConnection.Value = 0; // Resetea la barra de progreso
                    comboBoxBaud.Enabled = true; // Habilita la selecci�n de velocidad de baudios
                    comboBoxPort.Enabled = true; // Habilita la selecci�n de puerto
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); // Muestra un mensaje de error si ocurre una excepci�n
                }
            }
        }

        // Evento del temporizador que actualiza la hora en un label
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss"); // Actualiza la hora en formato HH:mm:ss
        }

        // M�todos de eventos de grupo que no tienen implementaci�n
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox4_Enter(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
    }
}