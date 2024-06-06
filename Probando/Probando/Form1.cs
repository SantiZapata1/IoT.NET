using System.IO.Ports; // Importa la biblioteca necesaria para la comunicación serial

namespace Probando
{
    public partial class Form1 : Form
    {
        SerialPort m_serialPort = new SerialPort(); // Declara e inicializa un objeto SerialPort

        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        // Método que se ejecuta al cargar el formulario
        private void Form1_Load_1(object sender, EventArgs e)
        {
            disableComponents(); // Deshabilita ciertos componentes al iniciar

            string[] portList = SerialPort.GetPortNames(); // Obtiene la lista de puertos seriales disponibles
            comboBoxPort.Items.AddRange(portList); // Añade la lista de puertos al comboBox
            comboBoxPort.Text = portList[1]; // Selecciona el segundo puerto en la lista por defecto

            string[] rates = { "9600", "115200", "57600" }; // Define un array con diferentes velocidades de baudios
            comboBoxBaud.Items.AddRange(rates); // Añade las velocidades de baudios al comboBox
            comboBoxBaud.Text = rates[0]; // Selecciona la primera velocidad en la lista por defecto
        }

        // Método para deshabilitar ciertos componentes del formulario
        void disableComponents()
        {
            buttonOpen.Enabled = true; // Habilita el botón de abrir conexión
            buttonClose.Enabled = false; // Deshabilita el botón de cerrar conexión
            buttonEncender.Enabled = false; // Deshabilita el botón de encender
            buttonApagar.Enabled = false; // Deshabilita el botón de apagar
            progressBarConnection.Value = 0; // Resetea la barra de progreso
            pictureBoxLed.Image = Properties.Resources.ledOff2; // Muestra la imagen del LED apagado
        }

        // Evento que se ejecuta al presionar el botón de encender
        private void buttonEncender_Click_1(object sender, EventArgs e)
        {
            if(m_serialPort.IsOpen) // Verifica si el puerto serial está abierto
            {
                try
                {
                    m_serialPort.WriteLine("1"); // Envía el comando "1" por el puerto serial
                    pictureBoxLed.Image = Properties.Resources.ledOn2; // Cambia la imagen del LED a encendido
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); // Muestra un mensaje de error si ocurre una excepción
                }
            }
        }

        // Evento que se ejecuta al presionar el botón de apagar
        private void buttonApagar_Click_1(object sender, EventArgs e)
        {
            if(m_serialPort.IsOpen) // Verifica si el puerto serial está abierto
            {
                try
                {
                    m_serialPort.WriteLine("0"); // Envía el comando "0" por el puerto serial
                    pictureBoxLed.Image = Properties.Resources.ledOff2; // Cambia la imagen del LED a apagado
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); // Muestra un mensaje de error si ocurre una excepción
                }
            }
        }

        // Evento que se ejecuta al presionar el botón de abrir conexión
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                m_serialPort.PortName = comboBoxPort.Text; // Configura el nombre del puerto
                m_serialPort.BaudRate = Convert.ToInt32(comboBoxBaud.Text); // Configura la velocidad de baudios
                m_serialPort.Open(); // Abre el puerto serial
                buttonOpen.Enabled = false; // Deshabilita el botón de abrir conexión
                buttonClose.Enabled = true; // Habilita el botón de cerrar conexión
                buttonEncender.Enabled = true; // Habilita el botón de encender
                buttonApagar.Enabled = true; // Habilita el botón de apagar
                progressBarConnection.Value = 100; // Actualiza la barra de progreso
                comboBoxBaud.Enabled = false; // Deshabilita la selección de velocidad de baudios
                comboBoxPort.Enabled = false; // Deshabilita la selección de puerto
                m_serialPort.WriteLine("0"); // Envía el comando "0" para asegurarse de que el dispositivo está apagado al iniciar
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); // Muestra un mensaje de error si ocurre una excepción
            }
        }

        // Evento que se ejecuta al presionar el botón de cerrar conexión
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if(m_serialPort.IsOpen) // Verifica si el puerto serial está abierto
            {
                try
                {
                    m_serialPort.WriteLine("0"); // Envía el comando "0" por el puerto serial
                    pictureBoxLed.Image = Properties.Resources.ledOff2; // Cambia la imagen del LED a apagado
                    m_serialPort.Close(); // Cierra el puerto serial

                    buttonOpen.Enabled = true; // Habilita el botón de abrir conexión
                    buttonClose.Enabled = false; // Deshabilita el botón de cerrar conexión
                    buttonEncender.Enabled = false; // Deshabilita el botón de encender
                    buttonApagar.Enabled = false; // Deshabilita el botón de apagar
                    progressBarConnection.Value = 0; // Resetea la barra de progreso
                    comboBoxBaud.Enabled = true; // Habilita la selección de velocidad de baudios
                    comboBoxPort.Enabled = true; // Habilita la selección de puerto
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); // Muestra un mensaje de error si ocurre una excepción
                }
            }
        }

        // Evento del temporizador que actualiza la hora en un label
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss"); // Actualiza la hora en formato HH:mm:ss
        }

        // Métodos de eventos de grupo que no tienen implementación
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox4_Enter(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
    }
}