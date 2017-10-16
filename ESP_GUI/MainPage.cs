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
        public long m_MoveSteps = 0;
        public short m_Speed = 0;
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

            //byte[] output_stream = new byte[ HEADER_SIZE + PAYLOAD_SIZE];
            //Array.Reverse(this.m_msgPayload);
            //Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            //Buffer.BlockCopy(this.m_msgPayload, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE); 

            m_msgHeader = new byte[HEADER_SIZE];
            m_msgPayload = new byte[PAYLOAD_SIZE];
            this.MoveToInputNrUpDown.Value = 0;
            this.MoveToInputNrUpDown.Enabled = false;
            this.MoveToCheckBox.Enabled = true;
            this.MoveToCheckBox.Checked = false;
            this.SpeedInputNrUpDown.Value = 0;
            this.SpeedInputNrUpDown.Enabled = false;
            this.SpeedCheckBox.Enabled = true;
            this.SpeedCheckBox.Checked = false;
            this.ReadCounterCheckBox.Enabled = true;
            this.ReadCounterCheckBox.Checked = false;
            this.LefCheckBox.Enabled = true;
            this.LefCheckBox.Checked = false;
            this.StopCheckBox.Enabled = true;
            this.StopCheckBox.Checked = false;
            this.ResetCheckBox.Enabled = true;
            this.ResetCheckBox.Checked = false;
            this.RightCheckBox.Enabled = true;
            this.RightCheckBox.Checked = false;
            this.OutputLabel.Text = "XX-XX-XX-XX-XX-XX-XX-XX-XX";
            this.SendButton.Enabled = false;
        }

        private void MoveStepInputNrUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.m_MoveSteps = (long)MoveToInputNrUpDown.Value;
            try
            {
                this.m_msgPayload = BitConverter.GetBytes((long)this.m_MoveSteps);
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException: Cannot convert {0}", this.m_MoveSteps);
            }

            byte[] output_stream = new byte[HEADER_SIZE + PAYLOAD_SIZE];
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(this.m_msgPayload);
            }
            Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            Buffer.BlockCopy(this.m_msgPayload, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE);
            this.OutputLabel.Text = BitConverter.ToString(output_stream);
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

        private void SpeedInputNrUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.m_Speed = (short)this.SpeedInputNrUpDown.Value;
            try
            {
                this.m_msgPayload = BitConverter.GetBytes((long)this.m_Speed); 
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException: Cannot convert: ", this.m_Speed);
            }
            byte[] output_stream = new byte[HEADER_SIZE + PAYLOAD_SIZE];
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(this.m_msgPayload);
            }
            Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            Buffer.BlockCopy(this.m_msgPayload, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE);
            this.OutputLabel.Text = BitConverter.ToString(output_stream);
        }

        private void MoveToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.MoveToCheckBox.Checked)
            {
                this.SendButton.Enabled = true;
                this.MoveToInputNrUpDown.Enabled = true;
                this.ReadCounterCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false;
                this.StopCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
            }
            else
            {
                this.SendButton.Enabled = false;
                this.MoveToInputNrUpDown.Enabled = false;
                this.MoveToInputNrUpDown.Value = 0;
                this.ReadCounterCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true; 
            }
            byte[] output_stream = new byte[HEADER_SIZE + PAYLOAD_SIZE];
            this.m_msgHeader = new byte[] { (byte)HeaderType.MOVE };
            this.m_msgPayload = new byte[PAYLOAD_SIZE];
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(this.m_msgPayload);
            }
            Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            Buffer.BlockCopy(this.m_msgPayload, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE);
            this.OutputLabel.Text = BitConverter.ToString(output_stream);
        }

        private void ReadCounterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ReadCounterCheckBox.Checked)
            {
                this.SendButton.Enabled = true;
                this.MoveToCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false;
                this.StopCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
            }
            else
            {
                this.SendButton.Enabled = false;
                this.MoveToCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true;
            }
            this.m_msgHeader = new byte[] { (byte)HeaderType.READ };
            this.m_msgPayload = new byte[PAYLOAD_SIZE]; 
            byte[] output_stream = new byte[HEADER_SIZE + PAYLOAD_SIZE];
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(this.m_msgPayload);
            }
            Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            Buffer.BlockCopy(this.m_msgPayload, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE);
            this.OutputLabel.Text = BitConverter.ToString(output_stream);
        }

        private void LefCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.LefCheckBox.Checked)
            {
                this.SendButton.Enabled = true;
                this.MoveToCheckBox.Enabled = false;
                this.ReadCounterCheckBox.Enabled = false;
                this.StopCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
            }
            else
            {
                this.SendButton.Enabled = false;
                this.MoveToCheckBox.Enabled = true;
                this.ReadCounterCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true;
            }
            this.m_msgHeader = new byte[] { (byte)HeaderType.LEFT };
            this.m_msgPayload = new byte[PAYLOAD_SIZE];
            byte[] output_stream = new byte[HEADER_SIZE + PAYLOAD_SIZE];
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(this.m_msgPayload);
            }
            Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            Buffer.BlockCopy(this.m_msgPayload, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE);
            this.OutputLabel.Text = BitConverter.ToString(output_stream);
        }

        private void StopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.StopCheckBox.Checked)
            {
                this.SendButton.Enabled = true;
                this.MoveToCheckBox.Enabled = false;
                this.ReadCounterCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
            }
            else
            {
                this.SendButton.Enabled = false;
                this.MoveToCheckBox.Enabled = true;
                this.ReadCounterCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true;
            }
            this.m_msgHeader = new byte[] { (byte)HeaderType.STOP };
            this.m_msgPayload = new byte[PAYLOAD_SIZE];
            byte[] output_stream = new byte[HEADER_SIZE + PAYLOAD_SIZE];
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(this.m_msgPayload);
            }
            Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            Buffer.BlockCopy(this.m_msgPayload, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE);
            this.OutputLabel.Text = BitConverter.ToString(output_stream);
        }

        private void ResetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ResetCheckBox.Checked)
            {
                this.SendButton.Enabled = true;
                this.MoveToCheckBox.Enabled = false;
                this.ReadCounterCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false;
                this.StopCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
            }
            else
            {
                this.SendButton.Enabled = false;
                this.MoveToCheckBox.Enabled = true;
                this.ReadCounterCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true;
            }
            this.m_msgHeader = new byte[] { (byte)HeaderType.RESET };
            this.m_msgPayload = new byte[PAYLOAD_SIZE];
            byte[] output_stream = new byte[HEADER_SIZE + PAYLOAD_SIZE];
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(this.m_msgPayload);
            }
            Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            Buffer.BlockCopy(this.m_msgPayload, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE);
            this.OutputLabel.Text = BitConverter.ToString(output_stream);
        }

        private void SpeedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SpeedCheckBox.Checked)
            {
                this.SendButton.Enabled = true;
                this.SpeedInputNrUpDown.Enabled = true;
                this.MoveToCheckBox.Enabled = false;
                this.ReadCounterCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false;
                this.StopCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.RightCheckBox.Enabled = false;
            }
            else
            {
                this.SendButton.Enabled = false;
                this.SpeedInputNrUpDown.Enabled = false;
                this.SpeedInputNrUpDown.Value = 0;
                this.MoveToCheckBox.Enabled = true;
                this.ReadCounterCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.RightCheckBox.Enabled = true;
            }
            this.m_msgHeader = new byte[] { (byte)HeaderType.SPEED };
            byte[] output_stream = new byte[HEADER_SIZE + PAYLOAD_SIZE];
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(this.m_msgPayload);
            }
            Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            Buffer.BlockCopy(this.m_msgPayload, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE);
            this.OutputLabel.Text = BitConverter.ToString(output_stream);
        }

        private void RightCheckBox_CheckedChanged(object sender, EventArgs e)
        { 
           if (this.RightCheckBox.Checked)
            {
                this.SendButton.Enabled = true;
                this.MoveToCheckBox.Enabled = false;
                this.ReadCounterCheckBox.Enabled = false;
                this.LefCheckBox.Enabled = false; 
                this.StopCheckBox.Enabled = false;
                this.ResetCheckBox.Enabled = false;
                this.SpeedCheckBox.Enabled = false;
            }
            else
            {
                this.SendButton.Enabled = false;
                this.MoveToCheckBox.Enabled = true;
                this.ReadCounterCheckBox.Enabled = true;
                this.LefCheckBox.Enabled = true;
                this.StopCheckBox.Enabled = true;
                this.ResetCheckBox.Enabled = true;
                this.SpeedCheckBox.Enabled = true;
            }
            this.m_msgHeader = new byte[] { (byte)HeaderType.RIGHT };
            this.m_msgPayload = new byte[PAYLOAD_SIZE];
            byte[] output_stream = new byte[HEADER_SIZE + PAYLOAD_SIZE];
            if (BitConverter.IsLittleEndian) {
                Array.Reverse(this.m_msgPayload);
            }
            Buffer.BlockCopy(this.m_msgHeader, 0, output_stream, 0, HEADER_SIZE);
            Buffer.BlockCopy(this.m_msgPayload, 0, output_stream, HEADER_SIZE, PAYLOAD_SIZE);
            this.OutputLabel.Text = BitConverter.ToString(output_stream);
        }         
    }
}
