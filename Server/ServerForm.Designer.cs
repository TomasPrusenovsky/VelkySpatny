namespace Server
{
    partial class ServerForm
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
            StartButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            MessagesBox = new RichTextBox();
            RefreshButton = new Button();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(345, 88);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(112, 34);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 93);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 2;
            label1.Text = "PORT";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            // 
            // MessagesBox
            // 
            MessagesBox.Location = new Point(106, 179);
            MessagesBox.Name = "MessagesBox";
            MessagesBox.Size = new Size(583, 234);
            MessagesBox.TabIndex = 3;
            MessagesBox.Text = "";
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(551, 88);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(112, 34);
            RefreshButton.TabIndex = 4;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // backgroundWorker3
            // 
            backgroundWorker3.DoWork += this.backgroundWorker3_DoWork;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RefreshButton);
            Controls.Add(MessagesBox);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(StartButton);
            Name = "ServerForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button StartButton;
        private TextBox textBox1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private RichTextBox MessagesBox;
        private Button RefreshButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}
