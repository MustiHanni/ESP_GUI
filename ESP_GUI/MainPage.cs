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
        public byte[] m_msgFrame = new byte[HEADER_SIZE+PAYLOAD_SIZE];
        public long m_MoveSteps = 0;
        public short m_Speed = 0;
        public String m_SelectedPort = null;

        public MainPage()
        {
            InitializeComponent();
            this.update_combobox_portsList();
        }

        private void MoveToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.MoveToCheckBox.Checked)
            { 
                this.MoveToInputNrUpDown.Enabled = true;
                this.ReadCounterCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false;
                this.StopCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
                this.SendButton.Enabled = true;
            }
            else
            {  
                this.MoveToInputNrUpDown.Enabled = false;
                this.MoveToInputNrUpDown.Value = 0;
                this.ReadCounterCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true;
                this.SendButton.Enabled = false;
            }  
                this.m_msgHeader = new byte[] { (byte)HeaderType.MOVE };
                this.m_msgPayload = new byte[PAYLOAD_SIZE];
                this.OutputLabel.Text = this.msg_byteToString();
        }

        private void MoveStepInputNrUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.m_msgPayload = BitConverter.GetBytes((long)this.MoveToInputNrUpDown.Value);
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException: Cannot convert {0}", this.m_MoveSteps);
            }
            this.OutputLabel.Text = this.msg_byteToString();
        }

        private void ReadCounterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ReadCounterCheckBox.Checked)
            { 
                this.MoveToCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false;
                this.StopCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
                this.SendButton.Enabled = true;
            }
            else
            { 
                this.MoveToCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true;
                this.SendButton.Enabled = false;
            } 
                this.m_msgHeader = new byte[] { (byte)HeaderType.READ };
                this.m_msgPayload = new byte[PAYLOAD_SIZE];
                this.OutputLabel.Text = this.msg_byteToString();
        }

        private void LefCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.LefCheckBox.Checked)
            {  
                this.MoveToCheckBox.Enabled = false;
                this.ReadCounterCheckBox.Enabled = false;
                this.StopCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
                this.SendButton.Enabled = true;
            }
            else
            { 
                this.MoveToCheckBox.Enabled = true;
                this.ReadCounterCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true;
                this.SendButton.Enabled = false;
            } 
                this.m_msgHeader = new byte[] { (byte)HeaderType.LEFT };
                this.m_msgPayload = new byte[PAYLOAD_SIZE];
                this.OutputLabel.Text = this.msg_byteToString();
        }
        private void RightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RightCheckBox.Checked)
            {
                this.MoveToCheckBox.Enabled = false;
                this.ReadCounterCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false;
                this.StopCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
                this.SendButton.Enabled = true;
            }
            else
            {
                this.MoveToCheckBox.Enabled = true;
                this.ReadCounterCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
                this.SendButton.Enabled = false;
            }
                this.m_msgHeader = new byte[] { (byte)HeaderType.RIGHT };
                this.m_msgPayload = new byte[PAYLOAD_SIZE];
                this.OutputLabel.Text = this.msg_byteToString();
        }

        private void StopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.StopCheckBox.Checked)
            { 
                this.MoveToCheckBox.Enabled = false;
                this.ReadCounterCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
                this.SendButton.Enabled = true;
            }
            else
            {  
                this.MoveToCheckBox.Enabled = true;
                this.ReadCounterCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true;
                this.SendButton.Enabled = false;
            } 
                this.m_msgHeader = new byte[] { (byte)HeaderType.STOP };
                this.m_msgPayload = new byte[PAYLOAD_SIZE];
                this.OutputLabel.Text = this.msg_byteToString();
        }

        private void ResetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ResetCheckBox.Checked)
            { 
                this.MoveToCheckBox.Enabled = false;
                this.ReadCounterCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false;
                this.StopCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
                this.SendButton.Enabled = true;
            }
            else
            { 
                this.MoveToCheckBox.Enabled = true;
                this.ReadCounterCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true;
                this.SendButton.Enabled = false;
            } 
                this.m_msgHeader = new byte[] { (byte)HeaderType.RESET };
                this.m_msgPayload = new byte[PAYLOAD_SIZE];
                this.OutputLabel.Text = this.msg_byteToString();
        }

        private void SpeedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SpeedCheckBox.Checked)
            { 
                this.SpeedInputNrUpDown.Enabled = true;
                this.MoveToCheckBox.Enabled = false;
                this.ReadCounterCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false;
                this.StopCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
                this.SendButton.Enabled = true;
            }
            else
            { 
                this.SpeedInputNrUpDown.Enabled = false;
                this.SpeedInputNrUpDown.Value = 0;
                this.MoveToCheckBox.Enabled = true;
                this.ReadCounterCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true;
                this.SendButton.Enabled = false;
            }
            this.m_msgHeader = new byte[] { (byte)HeaderType.SPEED };
            this.m_msgPayload = new byte[PAYLOAD_SIZE];
            this.OutputLabel.Text = this.msg_byteToString();
        }
        private void SpeedInputNrUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.m_msgPayload = BitConverter.GetBytes((long)this.SpeedInputNrUpDown.Value);
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException: Cannot convert: ", this.m_Speed);
            }
            this.OutputLabel.Text = this.msg_byteToString();
        }

        private void PortComboBox_Click(object sender, EventArgs e)
        {
            this.update_combobox_portsList();
        }

        private void PortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo_box = (ComboBox)sender;
            this.m_SelectedPort = (string)combo_box.SelectedItem;
        }

        public bool portStillAvailable() {
            try
            {
                if (this.m_SelectedPort == null) { 
                    return false;
                }
                else {
                    String[] ports = SerialPort.GetPortNames();
                    if (ports.Length == 0) { return false; }

                    int index = Array.FindIndex(ports, s => s.StartsWith(this.m_SelectedPort, StringComparison.OrdinalIgnoreCase));
                    if (index == -1)
                    { 
                        return false;
                    }
                    else {
                        return true;
                    }
                } 
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            } 
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (portStillAvailable())
            {
                this.send_usbMSG();
                this.resetAfterSend();
            }
            else {
                MessageBox.Show("Unvalid Port!", "Warning", MessageBoxButtons.OK);
                this.m_SelectedPort = null;
                this.update_combobox_portsList();
            }
        }
        public void send_usbMSG() {
            // Create the serial port with basic settings
            SerialPort SerialPort = new SerialPort(this.m_SelectedPort,9600, Parity.None, 8, StopBits.One);
            try {
                SerialPort.Open(); 
                byte[] bytestosend = this.m_msgFrame;
                SerialPort.Write(bytestosend, 0, bytestosend.Length);
                SerialPort.Close();
                SerialPort.Dispose();
                SerialPort = null;

            } catch (System.Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(this.m_SelectedPort); 
            Console.WriteLine(msg_byteToString()); 
        }
        public string msg_byteToString()
        {
            byte[] payload_cpy = this.m_msgPayload.ToArray(); 
            byte[] output_stream = new byte[HEADER_SIZE + PAYLOAD_SIZE];
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(payload_cpy);
            }
            Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            Buffer.BlockCopy(payload_cpy, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE);
            //this.OutputLabel.Text = BitConverter.ToString(output_stream);
            return BitConverter.ToString(output_stream);
        }
        public void resetAfterSend()
        {
            m_msgHeader = new byte[HEADER_SIZE];
            m_msgPayload = new byte[PAYLOAD_SIZE];
            this.MoveToInputNrUpDown.Value = 0;
            this.MoveToInputNrUpDown.Enabled = false;
            this.MoveToCheckBox.Checked = false;
            this.MoveToCheckBox.Enabled = true;

            this.SpeedInputNrUpDown.Value = 0;
            this.SpeedInputNrUpDown.Enabled = false;
            this.SpeedCheckBox.Checked = false;
            this.SpeedCheckBox.Enabled = true;

            this.ReadCounterCheckBox.Checked = false;
            this.ReadCounterCheckBox.Enabled = true;
            this.LefCheckBox.Checked = false;
            this.LefCheckBox.Enabled = true;
            this.RightCheckBox.Checked = false;
            this.RightCheckBox.Enabled = true;
            this.StopCheckBox.Checked = false;
            this.StopCheckBox.Enabled = true;
            this.ResetCheckBox.Checked = false;
            this.ResetCheckBox.Enabled = true;

            this.SendButton.Enabled = false; 
        }
        public void update_combobox_portsList()
        {
            try
            {
                this.PortComboBox.Items.Clear();

                String[] ports = SerialPort.GetPortNames();

                if (ports.Length == 0)
                {
                    this.m_SelectedPort = null;
                    this.PortComboBox.Text = "Can't find any USB-Port";
                }
                else
                {
                    if (this.m_SelectedPort == null) {
                        this.m_SelectedPort = ports[0];
                    }
                    this.PortComboBox.Text = this.m_SelectedPort;
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
    }
}
