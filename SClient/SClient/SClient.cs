using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SClient
{
    public partial class SClient : Form
    {
        private TcpClient tcp;
        private Stream stm;
        private byte[] dataIn;
        private byte[] dataOut;

        public SClient()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            InitClient();

            Thread t = new Thread(Listener);
            t.Start();

            /* In this moment the feature buttons are available for using */
            btAdd.Enabled = true;
            btSub.Enabled = true;
            btMulti.Enabled = true;
            btDivide.Enabled = true;
        }

        private void InitClient()
        {
            try
            {
                // Create client
                tcp = new TcpClient();
                // get ip address
                String ip = tbAddress.Text;
                // get port number
                int port = int.Parse(tbPort.Text);
                // start connection
                tcp.Connect(ip, port);
                // set stream for this client
                stm = tcp.GetStream();

                /* until the connection is accepted the feature buttons cannot used */
                btAdd.Enabled = false;
                btSub.Enabled = false;
                btMulti.Enabled = false;
                btDivide.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Cannot connect to server!");
            }            
        }

        /******** Receive data ********/
        private void Listener(object obj)
        {
            while (true)
            {
                try
                {
                    String message = null;
                    dataIn = new byte[100];

                    // get message from server
                    int k = stm.Read(dataIn, 0, 100);

                    // fill each character of message
                    for (int i = 0; i < k; i++)
                        message += Convert.ToChar(dataIn[i]);

                    tbResult.Text = message;
                }
                catch
                {
                    break;
                }
            }
        }

        #region Functions process kinds of sending data to server

        /******** Function add ********/
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!IsFilledOperate())
                return;

            String str = null;

            str = tbNum1.Text + "+" + tbNum2.Text;

            Send_Message(str);
        }

        /******** Function sub ********/
        private void btSub_Click(object sender, EventArgs e)
        {
            if (!IsFilledOperate())
                return;

            String str = null;

            str = tbNum1.Text + "-" + tbNum2.Text;

            Send_Message(str);
        }

        /******** Function multi ********/
        private void btMulti_Click(object sender, EventArgs e)
        {
            if (!IsFilledOperate())
                return;

            String str = null;

            str = tbNum1.Text + "*" + tbNum2.Text;

            Send_Message(str);
        }

        /******** Function divide ********/
        private void btDivide_Click(object sender, EventArgs e)
        {
            if (!IsFilledOperate())
                return;

            String str = null;

            str = tbNum1.Text + "/" + tbNum2.Text;

            Send_Message(str);
        }

        /// <summary>
        /// return true if tbNum1 & tbNum2 is filled,
        /// return false if having missed the filling between tbNum1 & tbNum2
        /// </summary>
        /// <returns></returns>
        private bool IsFilledOperate()
        {
            if (tbNum1.Text == null)
            {
                MessageBox.Show("Miss Number 1!");

                tbNum1.Focus();

                return false;
            }

            if (tbNum2.Text == null)
            {
                MessageBox.Show("Miss Number 2!");

                tbNum2.Focus();

                return false;
            }

            return true;
        }

        /// <summary>
        /// Send data with request that server receive and process this,
        /// after that server auto send the result to this client.
        /// </summary>
        /// <param name="str">data in string type</param>
        private void Send_Message(String str)
        {
            try
            {
                // Create buffer
                dataOut = new byte[100];

                // Encode the message to byte[]
                ASCIIEncoding asen = new ASCIIEncoding();
                dataOut = asen.GetBytes(str);

                // Send the request to server
                stm.Write(dataOut, 0, dataOut.Length);
            }
            catch
            {
                MessageBox.Show("Cannot send the requirement!");
            }
            
        }

        #endregion

        private void SClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //stm.Close();
                tcp.Close();
            }
            catch
            {
                MessageBox.Show("Cannot close client!");
            }
        }

        private void SClient_Load(object sender, EventArgs e)
        {
            /* Enable this it is possible to use multi thread in this win form app. */
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
