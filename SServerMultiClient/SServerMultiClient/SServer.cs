using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SServerMultiClient
{
    public partial class SServer : Form
    {
        private TcpListener server;
        private Socket[] socket = new Socket[100];
        private IPAddress ipAd;
        private int port;
        private int counter = 0;
        private byte[] dataIn = new byte[100];
        private byte[] dataOut;

        public SServer()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            InitServer();

            /* This thread is always listen the request to connect to server from clients*/
            Thread t = new Thread(SetConnection);
            t.Start();
        }

        private void InitServer()
        {
            try
            {
                // get ip address
                ipAd = IPAddress.Parse(tbAddress.Text);
                // get port
                port = int.Parse(tbPort.Text);

                // set server
                server = new TcpListener(ipAd, port);

                // start server
                server.Start();                
            }
            catch
            {
                //MessageBox.Show("Cannot init server!");
            }
            
        }

        private void SetConnection(object obj)
        {
            while (true)
            {
                try
                {
                    // Set connection to client
                    socket[counter] = server.AcceptSocket();
                    // get ip of client which've just connected to server
                    String str = socket[counter].RemoteEndPoint.ToString();
                    str += " vừa kết nối." + Environment.NewLine;

                    // Show this str to textbox to show that having a client is connected
                    tbConnect.AppendText(str);

                    /* Set the thread that always listen the data from client with thí index*/
                    Thread t = new Thread(Listener);
                    t.Start(counter);

                    /* Set connection for the next client*/
                    counter++;
                }
                catch
                {
                    break;
                }
            }
        }

        private void Listener(object obj)
        {
            while (true)
            {
                int index = (int)obj;

                try
                {
                    //dataIn = new byte[100];

                    // Get message from client
                    // k: length of message
                    int k = socket[index].Receive(dataIn);

                    /* If client disconnect to server */
                    if (k == 0)
                        return;

                    // Create buffer
                    String message = null;

                    // Transfer the message to string
                    // Fill buffer
                    for (int i = 0; i < k; i++)
                        message += Convert.ToChar(dataIn[i]);

                    String str1 = socket[index].RemoteEndPoint.ToString();
                    str1 += ": " + message + Environment.NewLine;

                    /* solve and send the result to client */
                    Process(message, index);
                    tbCommute.AppendText(str1);
                }
                catch
                {
                    //break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param> the message
        /// <param name="index"></param> the port 
        private void Process(String str, int index)
        {
            /* Calculation*/
            char temp = ' ';
            int i;

            for (i = 0; i < str.Length; i++)
            {
                if ((str[i] == '+') || (str[i] == '-') || (str[i] == '*') || (str[i] == '/'))
                {
                    /* 
                        If getting operator have index = 0,
                        this is stamp of the operand,
                        skip that
                     */
                    if (i == 0)
                        continue;
                    else
                    {
                        // Get the operator
                        temp = str[i];

                        break;
                    }
                }
            }

            /*
                String[] num = str.Split(temp);

                This above instrument have a bug that
                when the input like "-12--5" or "20--9"
                Server will convert wrong way we think
                So that the result send to client is empty
             */

            /* So hope this bottom code is working */
            String[] num = new String[2];

            // Get the first operand
            num[0] = str.Substring(0, i);
            // Get the last one
            num[1] = str.Substring(i + 1);

            int result = Calculate(num, temp);

            /* Send the result to the client*/
            try
            {
                ASCIIEncoding asen = new ASCIIEncoding();

                // put to buffer
                dataOut = asen.GetBytes(result.ToString());

                // send result to client
                socket[index].Send(dataOut);
            }
            catch
            {
                MessageBox.Show("Error: Cannot calculate the result!");
            }            
        }

        private int Calculate(string[] str, char operate)
        {
            // The result
            int temp = 0;

            // Get the first operand
            int num1 = int.Parse(str[0]);
            // Get the last one
            int num2 = int.Parse(str[1]);

            switch(operate)
            {
                case '+':
                    temp =  num1 + num2;
                    break;
                case '-':
                    temp = num1 - num2;
                    break;
                case '*':
                    temp = num1 * num2;
                    break;
                case '/':
                    temp = num1 / num2;
                    break;
                default:
                    break;
            }

            return temp;
        }

        private void SServer_Load(object sender, EventArgs e)
        {
            /* Enable this to use the multi thread */
            CheckForIllegalCrossThreadCalls = false;
        }

        private void SServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                server.Stop();
            }
            catch
            {
                MessageBox.Show("Cannot turn off server!");
            }
        }
    }
}
