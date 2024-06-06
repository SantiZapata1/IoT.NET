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


        private void Form1_Load_1(object sender, EventArgs e)
        {
            disableComponents();

            string[] portList = SerialPort.GetPortNames();
            comboBoxPort.Items.AddRange(portList);
            comboBoxPort.Text = portList[1];

            string[] rates = { "9600", "115200", "57600" };
            comboBoxBaud.Items.AddRange(rates);
            comboBoxBaud.Text = rates[0];

        }

        void disableComponents()
        {
            buttonOpen.Enabled = true;
            buttonClose.Enabled = false;
            buttonEncender.Enabled = false;
            buttonApagar.Enabled = false;
            progressBarConnection.Value = 0;
            pictureBoxLed.Image = Properties.Resources.ledOff2;

        }



        private void buttonEncender_Click_1(object sender, EventArgs e)
        {
            if(m_serialPort.IsOpen)
            {
                try
                {

                    m_serialPort.WriteLine("1");
                    pictureBoxLed.Image = Properties.Resources.ledOn2;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void buttonApagar_Click_1(object sender, EventArgs e)
        {
            if(m_serialPort.IsOpen)
            {
                try
                {

                    m_serialPort.WriteLine("0");
                    pictureBoxLed.Image = Properties.Resources.ledOff2;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                m_serialPort.PortName = comboBoxPort.Text;
                m_serialPort.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                m_serialPort.Open();
                buttonOpen.Enabled = false;
                buttonClose.Enabled = true;
                buttonEncender.Enabled = true;
                buttonApagar.Enabled = true;
                progressBarConnection.Value = 100;
                comboBoxBaud.Enabled = false;
                comboBoxPort.Enabled = false;
                m_serialPort.WriteLine("0");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if(m_serialPort.IsOpen)
            {
                try
                {
                    m_serialPort.WriteLine("0");
                    pictureBoxLed.Image = Properties.Resources.ledOff2;
                    m_serialPort.Close();

                    buttonOpen.Enabled = true;
                    buttonClose.Enabled = false;
                    buttonEncender.Enabled = false;
                    buttonApagar.Enabled = false;
                    progressBarConnection.Value = 0;
                    comboBoxBaud.Enabled = true;
                    comboBoxPort.Enabled = true;


                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }





        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
