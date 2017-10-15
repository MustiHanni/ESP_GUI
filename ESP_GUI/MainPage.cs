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
        public String m_SelectedPort;

        public MainPage()
        {
            InitializeComponent(); 

            try
            {
                this.PortComboBox.Items.Clear();
                this.m_SelectedPort = null;

                String[] ports = SerialPort.GetPortNames(); 

                if (ports.Length == 0)
                {
                    this.PortComboBox.Text = "Cann't find any USB-Port";
                }
                else
                {
                    // Display each port name to the console.
                    this.PortComboBox.Text = ports[0];
                    this.m_SelectedPort = ports[0];
                      
                    foreach (string p in ports)
                    {
                        this.PortComboBox.Items.Add(p);
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
            Console.WriteLine(this.m_SelectedPort); 
        }

        private void InputNrUpDown1_ValueChanged(object sender, EventArgs e)
        {
            m_i_Input = InputNrUpDown.Value;
        }

        private void PortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo_box = (ComboBox)sender;
            this.m_SelectedPort = (string)combo_box.SelectedItem;
        }

        private void PortComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                this.PortComboBox.Items.Clear();
                this.m_SelectedPort = null;
                String[] ports = SerialPort.GetPortNames();

                if (ports.Length == 0)
                {
                    this.PortComboBox.Text = "Cann't find any USB-Port";
                }
                else
                { 
                    this.PortComboBox.Text = ports[0];
                    this.m_SelectedPort = ports[0];

                    foreach (string p in ports)
                    {
                        this.PortComboBox.Items.Add(p);
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
