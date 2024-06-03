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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            m_serialPort.WriteLine("$On");
            label2.Text = "On";
            label2.BackColor = Color.Lime;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

            m_serialPort.PortName = "COM3";
            m_serialPort.BaudRate = 9600;
            m_serialPort.Open();
            }catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
