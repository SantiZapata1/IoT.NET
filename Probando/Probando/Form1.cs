using System.IO.Ports;

namespace Probando
{
    public partial class Form1 : Form
    {
        SerialPort m_serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void labelLed_Click(object sender, EventArgs e)
        {

        }


        private void buttonEncender_Click(object sender, EventArgs e)
        {
            try
            {

                m_serialPort.WriteLine("$On");
                labelLed.Text = "On";
                labelLed.BackColor = Color.Lime;
                buttonEncender.Enabled = false;
                buttonApagar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Cargado exitosamente");
            buttonApagar.Enabled = false;
            try
            {

                m_serialPort.PortName = "COM3";
                m_serialPort.BaudRate = 9600;
                m_serialPort.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            try
            {
                buttonApagar.Enabled=false;
                buttonEncender.Enabled=true;
                m_serialPort.WriteLine("$Off");
                labelLed.Text = "Off";
                labelLed.BackColor = Color.LightCoral;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
