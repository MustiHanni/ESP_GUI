using System; 
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ESP_GUI
{
    public partial class MainPage : Form
    {
        public decimal m_i_Input=0;
        public String m_SelectedPort = null;
        public String[] m_Ports = new String[] { };

        public MainPage()
        {
            InitializeComponent(); 

            try
            {
                this.PortComboBox.Items.Clear();
                this.m_SelectedPort = null;
                this.m_Ports = new String[] { };
                this.m_Ports = SerialPort.GetPortNames(); 

                if (this.m_Ports.Length == 0)
                {
                    this.PortComboBox.Text = "Cann't find any USB-Port";
                }
                else
                {
                    // Display each port name to the console.
                    this.PortComboBox.Text = "Cann't find any USB-Port";
                    this.PortComboBox.Text = this.m_Ports[0];
                    this.m_SelectedPort = this.m_Ports[0];
                      
                    foreach (string port in this.m_Ports)
                    {
                        this.PortComboBox.Items.Add(port);
                    }
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.m_i_Input.ToString());
            this.Output.Text = m_i_Input.ToString();

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                Console.WriteLine(port);
            }

            Console.ReadLine();
        }

        private void InputNrUpDown1_ValueChanged(object sender, EventArgs e)
        {
            m_i_Input = InputNrUpDown.Value;
        }

        private void PortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("seleced"); 
        }
        private void PortComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                this.PortComboBox.Items.Clear();
                this.m_SelectedPort = null;
                this.m_Ports = new String[] { };
                this.m_Ports = SerialPort.GetPortNames();

                if (this.m_Ports.Length == 0)
                {
                    this.PortComboBox.Text = "Cann't find any USB-Port";
                }
                else
                { 
                    this.PortComboBox.Text = "Cann't find any USB-Port";
                    this.PortComboBox.Text = this.m_Ports[0];
                    this.m_SelectedPort = this.m_Ports[0];

                    foreach (string port in this.m_Ports)
                    {
                        this.PortComboBox.Items.Add(port);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
