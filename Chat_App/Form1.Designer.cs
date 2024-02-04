namespace Chat_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ServerIP = new TextBox();
            ServerPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ClientPort = new TextBox();
            ClientIP = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ConnectClient = new Button();
            StartServer = new Button();
            MessText = new TextBox();
            Send = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            nameBox = new TextBox();
            label7 = new Label();
            Change = new Button();
            Messages = new RichTextBox();
            Local = new Button();
            SuspendLayout();
            // 
            // ServerIP
            // 
            ServerIP.Location = new Point(123, 80);
            ServerIP.Name = "ServerIP";
            ServerIP.Size = new Size(240, 31);
            ServerIP.TabIndex = 0;
            // 
            // ServerPort
            // 
            ServerPort.Location = new Point(449, 80);
            ServerPort.Name = "ServerPort";
            ServerPort.Size = new Size(180, 31);
            ServerPort.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 83);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 3;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 80);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 4;
            label2.Text = "PORT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 163);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 8;
            label3.Text = "PORT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 166);
            label4.Name = "label4";
            label4.Size = new Size(27, 25);
            label4.TabIndex = 7;
            label4.Text = "IP";
            // 
            // ClientPort
            // 
            ClientPort.Location = new Point(449, 163);
            ClientPort.Name = "ClientPort";
            ClientPort.Size = new Size(180, 31);
            ClientPort.TabIndex = 6;
            // 
            // ClientIP
            // 
            ClientIP.Location = new Point(123, 163);
            ClientIP.Name = "ClientIP";
            ClientIP.Size = new Size(240, 31);
            ClientIP.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 37);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 9;
            label5.Text = "Server";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 135);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 10;
            label6.Text = "Client";
            // 
            // ConnectClient
            // 
            ConnectClient.Location = new Point(687, 161);
            ConnectClient.Name = "ConnectClient";
            ConnectClient.Size = new Size(112, 34);
            ConnectClient.TabIndex = 11;
            ConnectClient.Text = "Connect";
            ConnectClient.UseVisualStyleBackColor = true;
            ConnectClient.Click += ConnectClient_Click;
            // 
            // StartServer
            // 
            StartServer.Location = new Point(687, 78);
            StartServer.Name = "StartServer";
            StartServer.Size = new Size(112, 34);
            StartServer.TabIndex = 12;
            StartServer.Text = "Start";
            StartServer.UseVisualStyleBackColor = true;
            StartServer.Click += StartServer_Click;
            // 
            // MessText
            // 
            MessText.AllowDrop = true;
            MessText.Location = new Point(71, 572);
            MessText.Name = "MessText";
            MessText.Size = new Size(585, 31);
            MessText.TabIndex = 14;
            // 
            // Send
            // 
            Send.Location = new Point(687, 570);
            Send.Name = "Send";
            Send.Size = new Size(112, 34);
            Send.TabIndex = 15;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(71, 3);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(115, 31);
            nameBox.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 6);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 18;
            label7.Text = "Name:";
            // 
            // Change
            // 
            Change.Location = new Point(208, 1);
            Change.Name = "Change";
            Change.Size = new Size(112, 34);
            Change.TabIndex = 19;
            Change.Text = "Change";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // Messages
            // 
            Messages.Location = new Point(71, 219);
            Messages.Name = "Messages";
            Messages.ReadOnly = true;
            Messages.Size = new Size(728, 328);
            Messages.TabIndex = 20;
            Messages.Text = "";
            // 
            // Local
            // 
            Local.Location = new Point(556, 12);
            Local.Name = "Local";
            Local.Size = new Size(112, 34);
            Local.TabIndex = 21;
            Local.Text = "Local\r\n";
            Local.UseVisualStyleBackColor = true;
            Local.Click += Local_Click;
            // 
            // Form1
            // 
            AcceptButton = Send;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(837, 632);
            Controls.Add(Local);
            Controls.Add(Messages);
            Controls.Add(Change);
            Controls.Add(label7);
            Controls.Add(nameBox);
            Controls.Add(Send);
            Controls.Add(MessText);
            Controls.Add(StartServer);
            Controls.Add(ConnectClient);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(ClientPort);
            Controls.Add(ClientIP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ServerPort);
            Controls.Add(ServerIP);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ServerIP;
        private TextBox ServerPort;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ClientPort;
        private TextBox ClientIP;
        private Label label5;
        private Label label6;
        private Button ConnectClient;
        private Button StartServer;
        private TextBox MessText;
        private Button Send;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private TextBox nameBox;
        private Label label7;
        private Button Change;
        private RichTextBox Messages;
        private Button Local;
    }
}
