
namespace FTPClients_
{
    partial class Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.sendFileButton = new System.Windows.Forms.Button();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.fileNotificationLabel = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.notificationTempLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.changeSaveLocButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.onlinePCList = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrivatekey = new System.Windows.Forms.TextBox();
            this.txtPublickey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notificationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendFileButton
            // 
            this.sendFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendFileButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sendFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendFileButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendFileButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sendFileButton.Location = new System.Drawing.Point(404, 474);
            this.sendFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.Size = new System.Drawing.Size(305, 42);
            this.sendFileButton.TabIndex = 32;
            this.sendFileButton.Text = "Send File to Selected Computer";
            this.sendFileButton.UseVisualStyleBackColor = false;
            this.sendFileButton.Click += new System.EventHandler(this.sendFileButton_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Computer Name";
            this.columnHeader2.Width = 263;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(219, 468);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Insert receiver\'s IP";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(219, 494);
            this.ipBox.Margin = new System.Windows.Forms.Padding(4);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(177, 22);
            this.ipBox.TabIndex = 37;
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Location = new System.Drawing.Point(464, 122);
            this.savePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(177, 17);
            this.savePathLabel.TabIndex = 36;
            this.savePathLabel.Text = "C:\\Users\\Public\\Downloads";
            // 
            // fileNotificationLabel
            // 
            this.fileNotificationLabel.AutoSize = true;
            this.fileNotificationLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.fileNotificationLabel.Location = new System.Drawing.Point(73, 427);
            this.fileNotificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNotificationLabel.Name = "fileNotificationLabel";
            this.fileNotificationLabel.Size = new System.Drawing.Size(12, 17);
            this.fileNotificationLabel.TabIndex = 35;
            this.fileNotificationLabel.Text = ".";
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Connect.Location = new System.Drawing.Point(-13, -1);
            this.Connect.Margin = new System.Windows.Forms.Padding(4);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(205, 44);
            this.Connect.TabIndex = 1;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // notificationPanel
            // 
            this.notificationPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.notificationPanel.Controls.Add(this.notificationTempLabel);
            this.notificationPanel.Location = new System.Drawing.Point(56, 256);
            this.notificationPanel.Margin = new System.Windows.Forms.Padding(4);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(664, 111);
            this.notificationPanel.TabIndex = 39;
            this.notificationPanel.UseWaitCursor = true;
            this.notificationPanel.Visible = false;
            // 
            // notificationTempLabel
            // 
            this.notificationTempLabel.AutoSize = true;
            this.notificationTempLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationTempLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.notificationTempLabel.Location = new System.Drawing.Point(5, 31);
            this.notificationTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notificationTempLabel.Name = "notificationTempLabel";
            this.notificationTempLabel.Size = new System.Drawing.Size(229, 24);
            this.notificationTempLabel.TabIndex = 2;
            this.notificationTempLabel.Text = "Please wait. File Sending to";
            this.notificationTempLabel.UseWaitCursor = true;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.Location = new System.Drawing.Point(765, 474);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 42);
            this.clearButton.TabIndex = 34;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(224, 123);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(12, 17);
            this.infoLabel.TabIndex = 33;
            this.infoLabel.Text = ".";
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.browseButton.Location = new System.Drawing.Point(66, 474);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(145, 42);
            this.browseButton.TabIndex = 31;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.fileNameLabel.Location = new System.Drawing.Point(73, 453);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(12, 17);
            this.fileNameLabel.TabIndex = 29;
            this.fileNameLabel.Text = ".";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.changeSaveLocButton);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.Connect);
            this.panel1.Location = new System.Drawing.Point(56, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 44);
            this.panel1.TabIndex = 28;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(559, -1);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 44);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeSaveLocButton
            // 
            this.changeSaveLocButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.changeSaveLocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSaveLocButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSaveLocButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeSaveLocButton.Location = new System.Drawing.Point(375, -1);
            this.changeSaveLocButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeSaveLocButton.Name = "changeSaveLocButton";
            this.changeSaveLocButton.Size = new System.Drawing.Size(185, 44);
            this.changeSaveLocButton.TabIndex = 10;
            this.changeSaveLocButton.Text = "Change Save Location";
            this.changeSaveLocButton.UseVisualStyleBackColor = false;
            this.changeSaveLocButton.Click += new System.EventHandler(this.changeSaveLocButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopButton.Location = new System.Drawing.Point(191, -1);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(185, 44);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop Application";
            this.stopButton.UseVisualStyleBackColor = false;
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Location = new System.Drawing.Point(77, 122);
            this.notificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(12, 17);
            this.notificationLabel.TabIndex = 30;
            this.notificationLabel.Text = ".";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 271;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // onlinePCList
            // 
            this.onlinePCList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.onlinePCList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onlinePCList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.onlinePCList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlinePCList.FullRowSelect = true;
            this.onlinePCList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.onlinePCList.HideSelection = false;
            this.onlinePCList.HoverSelection = true;
            this.onlinePCList.Location = new System.Drawing.Point(56, 142);
            this.onlinePCList.Margin = new System.Windows.Forms.Padding(4);
            this.onlinePCList.MultiSelect = false;
            this.onlinePCList.Name = "onlinePCList";
            this.onlinePCList.Size = new System.Drawing.Size(665, 281);
            this.onlinePCList.TabIndex = 27;
            this.onlinePCList.UseCompatibleStateImageBehavior = false;
            this.onlinePCList.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(890, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 43);
            this.button1.TabIndex = 44;
            this.button1.Text = "Creat and SendKey";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrivatekey
            // 
            this.txtPrivatekey.Location = new System.Drawing.Point(763, 306);
            this.txtPrivatekey.Multiline = true;
            this.txtPrivatekey.Name = "txtPrivatekey";
            this.txtPrivatekey.ReadOnly = true;
            this.txtPrivatekey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivatekey.Size = new System.Drawing.Size(383, 117);
            this.txtPrivatekey.TabIndex = 43;
            // 
            // txtPublickey
            // 
            this.txtPublickey.Location = new System.Drawing.Point(763, 142);
            this.txtPublickey.Multiline = true;
            this.txtPublickey.Name = "txtPublickey";
            this.txtPublickey.ReadOnly = true;
            this.txtPublickey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublickey.Size = new System.Drawing.Size(383, 114);
            this.txtPublickey.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(".VnArial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(769, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "PraviteKey:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font(".VnArial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(769, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "PublicKey:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(227, 550);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(718, 38);
            this.progressBar1.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(529, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Thanh Tiến Trình";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(367, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 55);
            this.panel2.TabIndex = 49;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrivatekey);
            this.Controls.Add(this.txtPublickey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sendFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.savePathLabel);
            this.Controls.Add(this.fileNotificationLabel);
            this.Controls.Add(this.notificationPanel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.onlinePCList);
            this.DoubleBuffered = true;
            this.Name = "Clients";
            this.Text = "Clients";
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendFileButton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.Label fileNotificationLabel;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Panel notificationPanel;
        private System.Windows.Forms.Label notificationTempLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button changeSaveLocButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView onlinePCList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrivatekey;
        private System.Windows.Forms.TextBox txtPublickey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}

