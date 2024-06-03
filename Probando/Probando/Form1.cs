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
            buttonOpen.Enabled = true;
            buttonClose.Enabled = false;
            buttonEncender.Enabled = false;
            buttonApagar.Enabled = false;
            comboBoxBaud.Text = "9600";
            progressBarConnection.Value = 0;
            pictureBoxLed.Image = Properties.Resources.ledOff2;

            string[] portList = SerialPort.GetPortNames();
            comboBoxPort.Items.AddRange(portList);

            
        }





        private void buttonEncender_Click_1(object sender, EventArgs e)
        {
            if (m_serialPort.IsOpen)
            {
                try
                {

                    m_serialPort.WriteLine("$On");
                    pictureBoxLed.Image = Properties.Resources.ledOn2;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void buttonApagar_Click_1(object sender, EventArgs e)
        {
            if (m_serialPort.IsOpen)
            {
                try
                {

                    m_serialPort.WriteLine("$Off");
                    pictureBoxLed.Image = Properties.Resources.ledOff2;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                m_serialPort.PortName= comboBoxPort.Text;
                m_serialPort.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                m_serialPort.Open();
                buttonOpen.Enabled = false;
                buttonClose.Enabled = true;
                buttonEncender.Enabled = true;
                buttonApagar.Enabled = true;
                progressBarConnection.Value = 100;
                comboBoxBaud.Enabled = false;
                comboBoxPort.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (m_serialPort.IsOpen)
            {
                try
                {
                    m_serialPort.WriteLine("#OFF");
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            



        }
    }
}
