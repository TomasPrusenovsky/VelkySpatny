namespace Server_Chat
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            PortBox = new TextBox();
            Strart = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 58);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 1;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 61);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 3;
            label2.Text = "PORT";
            // 
            // PortBox
            // 
            PortBox.Location = new Point(427, 58);
            PortBox.Name = "PortBox";
            PortBox.Size = new Size(150, 31);
            PortBox.TabIndex = 2;
            // 
            // Strart
            // 
            Strart.Location = new Point(623, 61);
            Strart.Name = "Strart";
            Strart.Size = new Size(112, 34);
            Strart.TabIndex = 4;
            Strart.Text = "Start";
            Strart.UseVisualStyleBackColor = true;
            Strart.Click += Strart_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Strart);
            Controls.Add(label2);
            Controls.Add(PortBox);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox PortBox;
        private Button Strart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
