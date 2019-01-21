using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        TcpClient client;
        public Form1()
        {
            InitializeComponent();
            //client = new TcpClient("localhost", 9999);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void sendMessageBtm_Click(object sender, EventArgs e)
        {
            client = new TcpClient("localhost", 9999);
            int byteCount = Encoding.ASCII.GetByteCount(MessageBox.Text);
            byte[] sendMessageBytes = new byte[byteCount];
            sendMessageBytes = Encoding.ASCII.GetBytes(MessageBox.Text);
            //MessageBox.Paste(MessageBox.Text);
            NetworkStream stream = client.GetStream();
            stream.Write(sendMessageBytes, 0, sendMessageBytes.Length);
            stream.Close();
            client.Close();
        }
    }
}
