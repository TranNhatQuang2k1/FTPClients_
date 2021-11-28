using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FTPClients_
{
    
    public partial class Clients : Form
    {
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            this.label3.Text=text;
        }
        public Clients()
        {
            InitializeComponent();
        }
        int x = 9;
        int y = 308;
        Socket socketForClient;
        string targetIP;
        string targetName;
        private Thread notification;
        NotificationForm f2;
        int flag = 0;
        String fileName = "";
        int fileReceived=0;
        private string IP = "127.0.0.1";
        String senderIP = "";
        String senderMachineName = "";
        long Lenght;
        String savePath = "";
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files|*.*";
            openFileDialog1.Title = "Select a File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLabel.Text = openFileDialog1.FileName;  //file path
                fileNameLabel.Tag = openFileDialog1.SafeFileName; //file name only.
            }
            timer1.Start();
        }

        void showNotification()
        {
            //f2 = new NotificationForm(targetName, targetIP);
            //f2.ShowDialog();
        }
        private void sendFileButton_Click(object sender, EventArgs e)
        {
            long length;
            targetIP = null;
            targetName = null;
            if ((ipBox.Text != "") && fileNameLabel.Text != ".")
            {
                if (ipBox.Text != "")
                {
                    targetIP = ipBox.Text;
                    targetName = "";
                }
                try
                {
                    Ping p = new Ping();
                    PingReply r;
                    r = p.Send(targetIP);
                    if (!(r.Status == IPStatus.Success))
                    {
                        MessageBox.Show("Target computer is not available.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        notification = new Thread(new ThreadStart(showNotification));
                        notification.Start();
                        //notificationPanel.Visible = true;
                        //notificationTempLabel.Text = "File sending to " + targetIP + " " + targetName + "...";
                        fileNotificationLabel.Text = "Please don't do other tasks. File sending to " + targetIP + " " + targetName + "...";
                        //closing the server
                        
                        //now making this program a client
                        //socketForClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        //socketForClient.Connect(new IPEndPoint(IPAddress.Parse(targetIP), 11000));
                        string fileName = fileNameLabel.Tag.ToString();
                        //long fileSize = new FileInfo(fileNameLabel.Text).Length;
                        using (FileStream fsRead = new FileStream(fileNameLabel.Text, FileMode.OpenOrCreate, FileAccess.Read))
                        {
                            length = fsRead.Length;
                        }
                        byte[] fileNameData = Encoding.Default.GetBytes(fileName + "@" + this.IP + "@" + Environment.MachineName+"@"+length.ToString());
                        socketForClient.Send(fileNameData);
                        //socketForClient.Shutdown(SocketShutdown.Both);
                        //socketForClient.Close();
                        //socketForClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        //socketForClient.Connect(new IPEndPoint(IPAddress.Parse(targetIP), 11000));
                        //socketForClient.SendFile(fileNameLabel.Text);                          
                        socketForClient.SendFile(fileNameLabel.Text);
                         // MessageBox.Show("Hoàn Thành!", send.ToString());
                        MessageBox.Show("Hoàn Thành!");
                        fileNameLabel.Text = "";
                        //socketForClient.Close();
                        notification.Abort();
                        notification.Join();
                        notificationTempLabel.Text = "";
                        notificationPanel.Visible = false;
                        
                        //MessageBox.Show("File sent to " + targetIP + " " + targetName, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Lỗi Truyền File!");
                }
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            x = x - 5;
            fileNameLabel.Location = new Point(x, y);
            if (x < (fileNameLabel.Text.Length * (-1)))
                x = 545;
        }
       
            private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                socketForClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
                IPAddress ip = IPAddress.Parse("192.168.189.1"); 
                IPEndPoint port = new IPEndPoint(ip, 8903);
                socketForClient.Connect(port);
                CreateNewKeys();
                byte[] fileNameData = Encoding.Default.GetBytes(txtPublickey.Text);
                //MessageBox.Show(fileNameData.Length.ToString());
                socketForClient.Send(fileNameData);
                //MessageBox.Show("Ket noi thanh cong!");
                Thread td = new Thread(AcceptMgs);
                td.IsBackground = true;
                td.Start(socketForClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AcceptMgs(object o)
        {
            Socket socketfile = (Socket)o;
            try
            {

                while (true)
                {
                    if (fileReceived == 1)
                    {
                        if (MessageBox.Show("Save File?", "File received", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            File.Delete(savePath);
                            fileReceived = 0;
                            flag = 0;
                        }
                        else
                        {

                            fileReceived = 0;
                        }
                    }

                    // MessageBox.Show(socketSend.RemoteEndPoint.ToString());
                    //clientList.Add(client);
                    NetworkStream stream = new NetworkStream(socketfile);
                    // IPEndPoint remoteIpEndPoint = client.Client.RemoteEndPoint as IPEndPoint;
                    //MessageBox.Show(remoteIpEndPoint.ToString());
                    //ListViewItem item = new ListViewItem();
                    //String ClientIp = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                    //MessageBox.Show(ClientIp);

                    //MessageBox.Show(flag.ToString());
                    //MessageBox.Show(isConnected.ToString());
                    //NetworkStream stream = myNetworkStream.get

                    if (flag == 1)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            notificationPanel.Visible = true;
                            notificationTempLabel.Text = "File coming..." + "\n" + fileName + "\n" + "From: " + senderIP + " " + senderMachineName;
                            fileNotificationLabel.Text = "File Coming from " + senderIP + " " + senderMachineName;
                        });
                        //MessageBox.Show("doc file hoan tat!");
                        flag = 0;
                        int count = 0;
                        fileReceived = 1;
                        savePath = savePathLabel.Text + "\\" + fileName;
                        using (var output = File.Create(savePath))
                        {
                            output.SetLength(0);
                            /*var buffer = new byte[1024];
                            int bytesRead = 0;
                            long t = 0;
                            //MessageBox.Show(Lenght.ToString());
                            while (t < Lenght)
                            {
                                //MessageBox.Show(t.ToString());
                                bytesRead = stream.Read(buffer, 0, buffer.Length);
                                t += bytesRead;
                                output.Write(buffer, 0, bytesRead);
                            };*/
                            try
                            {
                                
                                byte[] bin, encryptedData;
                                long rdlen = 0;
                                int len=0;
                                this.progressBar1.Minimum = 0;
                                this.progressBar1.Maximum = 100;

                                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                                RSA.FromXmlString(UsingPrivateKey()); //dùng khóa riêng để giải mã

                                int maxBytesCanEncrypted;
                                maxBytesCanEncrypted = (RSA.KeySize / 8);
                                long t = 0;
                                while (rdlen < Lenght)
                                {
                                    if (Lenght - t < maxBytesCanEncrypted) maxBytesCanEncrypted = (int)(Lenght - rdlen);
                                    bin = new byte[maxBytesCanEncrypted];
                                    len = stream.Read(bin, 0, bin.Length);
                                    //len = socketfile.Receive(bin, 0, SocketFlags.None);
                                    encryptedData = RSA.Decrypt(bin, false); //Giải mã
                                    //output.Write(buffer, 0, bytesRead);
                                    output.Write(encryptedData, 0, encryptedData.Length);
                                    rdlen = rdlen + len;
                                    //t = t + encryptedData.Length;
                                    
                                    this.progressBar1.Value =(int)((rdlen * 100) / Lenght);//thanh tiến trình
                                   /* if (this.label3.InvokeRequired)
                                    {
                                        SetTextCallback d = new SetTextCallback(SetText);
                                        this.Invoke(d, new object[] { "Tên tệp xử lý : " + Path.GetFileName(fileNameLabel.Text) + "\t Thành công: " + ((long)(rdlen * 100) / Lenght).ToString() + " %" });
                                        this.label3.Update();
                                        this.label3.Refresh();

                                    }
                                    else
                                    {
                                        // It's on the same thread, no need for Invoke
                                        //this.cboUsers.Text = text + " (No Invoke)";
                                        this.label3.Text= "Tên tệp xử lý : " + Path.GetFileName(fileNameLabel.Text) + "\t Thành công: " + ((long)(rdlen * 100) / Lenght).ToString() + " %";
                                        this.label3.Update();
                                        this.label3.Refresh();
                                    }*/
                                    this.label3.Text = "Tên tệp xử lý : " + Path.GetFileName(fileNameLabel.Text) + "\t Thành công: " + ((long)(rdlen * 100) / Lenght).ToString() + " %";
                                    this.label3.Update();
                                    this.label3.Refresh();
                                }
                                this.label3.Text = "";
                                this.progressBar1.Value = 0;

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Failed: " + ex.Message);
                            }
                            MessageBox.Show("Nhận Thành Công!");

                        }
                        fileName = "";
                        fileReceived = 1;
                        senderIP = "";
                        senderMachineName = "";
                        Invoke((MethodInvoker)delegate
                        {
                            notificationTempLabel.Text = "";
                            notificationPanel.Visible = false;
                            fileNotificationLabel.Text = "";
                        });
                        this.progressBar1.Value = 0;

                        //MessageBox.Show("doc file hoan tat!");
                    }
                    else if (flag == 0)
                    {
                        Byte[] bytes = new Byte[256];
                        String data = null;
                        int i;
                        // Loop to receive all the data sent by the client.
                        if ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            data = System.Text.Encoding.UTF8.GetString(bytes, 0, i);
                            //MessageBox.Show(data.ToString());
                            flag = 1;
                        }
                        if (data != null)
                        {
                            string[] msg = data.Split('@');
                            fileName = msg[0];
                            senderIP = msg[1];
                            senderMachineName = msg[2];
                            Lenght = long.Parse(msg[3].ToString());
                        }
                        // MessageBox.Show(fileName, senderIP);
                        //client.Close();
                        // isConnected = false;

                        //MessageBox.Show(Lenght.ToString());
                    }
                    stream.Close();
                    stream.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = 0;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fileNameLabel.Text = ".";
            timer1.Stop();
        }
        private string GetPublicKey()
        {
            string KeyfromClient = txtPublickey.Text;
            return KeyfromClient;
        }
        private string UsingPrivateKey()
        {
            string ServerPrivateKey = txtPrivatekey.Text;
            return ServerPrivateKey;
        }
        void AddMesseagePublickey(string s)
        {

            txtPublickey.Text = s;
            //textBox1.Clear();
        }
        void AddMesseagePrivatekey(string s)
        {
            txtPrivatekey.Text = s;
            //textBox1.Clear();
        }
        private void CreateNewKeys()
        {
            // độ dài khóa 512
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(512);
            //how to get the private key
            RSAParameters privKey = csp.ExportParameters(true);
            //and the public key ...
            RSAParameters pubKey = csp.ExportParameters(false);
            //converting the public key into a string representation
            string pubKeyString;
            {
                //we need some buffer
                var sw = new StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, pubKey);
                //get the string from the stream
                pubKeyString = sw.ToString();                   //right
                AddMesseagePublickey(pubKeyString);             //right
                //return pubKeyString;
            }
            string privKeyString;
            {
                //we need some buffer
                var sw = new StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, privKey);
                //get the string from the stream
                privKeyString = sw.ToString();
                AddMesseagePrivatekey(privKeyString);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewKeys();
        }

        private void changeSaveLocButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            if (browse.ShowDialog() == DialogResult.OK)
            {
                savePath = browse.SelectedPath;
                savePathLabel.Text = savePath;
            }
        }
    }
}
