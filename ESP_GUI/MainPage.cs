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
        public enum HeaderType : byte { MOVE, READ, LEFT, RIGHT, STOP, RESET, SPEED };
        public static int HEADER_SIZE = 1;
        public static int PAYLOAD_SIZE = 8;
        public byte[] m_msgHeader = new byte[HEADER_SIZE];
        public byte[] m_msgPayload = new byte[PAYLOAD_SIZE];
        public decimal m_MoveSteps = 0;
        public decimal m_Speed = 0;
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
            Console.WriteLine(this.m_MoveSteps.ToString());
            Console.WriteLine(this.m_SelectedPort);


            byte[] output_stream = new byte[ HEADER_SIZE + PAYLOAD_SIZE];
            Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            Buffer.BlockCopy(this.m_msgPayload, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE);
            //this.OutputLabel.Text = BitConverter.ToString(output_stream).Replace("-", "");
            this.OutputLabel.Text = BitConverter.ToString(output_stream);
        }

        private void MoveStepInputNrUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.m_MoveSteps = MoveToInputNrUpDown.Value;
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

        private void MoveButton_Click(object sender, EventArgs e)
        {
            this.m_msgHeader = new byte[] { (byte)HeaderType.MOVE };
            try
            {
                this.m_msgPayload = BitConverter.GetBytes((double)this.m_MoveSteps);
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException: Cannot convert {0}", this.m_Speed);
            }
            //this.m_msgPayload = new byte[]{0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11, 0x11};
        }

        private void ReadCounterButton_Click(object sender, EventArgs e)
        {
            this.m_msgHeader = new byte[] { (byte)HeaderType.READ };
            this.m_msgPayload = new byte[8];
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            this.m_msgHeader = new byte[] { (byte)HeaderType.LEFT };
            this.m_msgPayload = new byte[8];
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            this.m_msgHeader = new byte[] { (byte)HeaderType.RIGHT };
            this.m_msgPayload = new byte[8];
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.m_msgHeader = new byte[] { (byte)HeaderType.STOP };
            this.m_msgPayload = new byte[8];
        }

        private void ResetCounterButton_Click(object sender, EventArgs e)
        { 
            this.m_msgHeader = new byte[] { (byte)HeaderType.RESET };
            this.m_msgPayload = new byte[8];
    }

        private void SpeedButton_Click(object sender, EventArgs e)
        {
            this.m_msgHeader = new byte[] { (byte)HeaderType.SPEED };
            try
            {                
                this.m_msgPayload = BitConverter.GetBytes((double)this.m_Speed);  
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException: Cannot convert {0}",this.m_Speed);
            }
             //= new byte[] { 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55 };
        }

        private void SpeedInputNrUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.m_Speed = this.SpeedInputNrUpDown1.Value;
        }
    }
}
