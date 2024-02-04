namespace Dankord
{
    partial class Dankord
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
            textInput = new TextBox();
            button1 = new Button();
            Zpravy = new Label();
            SuspendLayout();
            // 
            // textInput
            // 
            textInput.Location = new Point(61, 407);
            textInput.Name = "textInput";
            textInput.Size = new Size(471, 31);
            textInput.TabIndex = 0;
            textInput.PreviewKeyDown += textBox1_PreviewKeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(558, 407);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Zpravy
            // 
            Zpravy.AutoSize = true;
            Zpravy.Location = new Point(61, 30);
            Zpravy.Name = "Zpravy";
            Zpravy.Size = new Size(59, 25);
            Zpravy.TabIndex = 3;
            Zpravy.Text = "label1";
            // 
            // Dankord
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Zpravy);
            Controls.Add(button1);
            Controls.Add(textInput);
            Name = "Dankord";
            Text = "Dankord";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textInput;
        private Button button1;
        private Label Zpravy;
    }
}
