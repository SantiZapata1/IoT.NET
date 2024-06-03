namespace Probando
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
            if(disposing && (components != null))
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
            LED1 = new GroupBox();
            progressBarConnection = new ProgressBar();
            buttonClose = new Button();
            buttonOpen = new Button();
            comboBoxBaud = new ComboBox();
            comboBoxPort = new ComboBox();
            labelBaud = new Label();
            labelPort = new Label();
            groupBox1 = new GroupBox();
            buttonApagar = new Button();
            buttonEncender = new Button();
            pictureBoxLed = new PictureBox();
            label1 = new Label();
            LED1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLed).BeginInit();
            SuspendLayout();
            // 
            // LED1
            // 
            LED1.Controls.Add(progressBarConnection);
            LED1.Controls.Add(buttonClose);
            LED1.Controls.Add(buttonOpen);
            LED1.Controls.Add(comboBoxBaud);
            LED1.Controls.Add(comboBoxPort);
            LED1.Controls.Add(labelBaud);
            LED1.Controls.Add(labelPort);
            LED1.ForeColor = SystemColors.ButtonFace;
            LED1.Location = new Point(35, 71);
            LED1.Name = "LED1";
            LED1.Size = new Size(351, 280);
            LED1.TabIndex = 5;
            LED1.TabStop = false;
            LED1.Text = "CONFIGURACION PUERTO COM";
            // 
            // progressBarConnection
            // 
            progressBarConnection.Location = new Point(54, 207);
            progressBarConnection.Name = "progressBarConnection";
            progressBarConnection.Size = new Size(247, 42);
            progressBarConnection.TabIndex = 10;
            // 
            // buttonClose
            // 
            buttonClose.ForeColor = SystemColors.ActiveCaptionText;
            buttonClose.Location = new Point(189, 149);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(112, 42);
            buttonClose.TabIndex = 10;
            buttonClose.Text = "CERRAR";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.ForeColor = SystemColors.ActiveCaptionText;
            buttonOpen.Location = new Point(54, 149);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(119, 42);
            buttonOpen.TabIndex = 7;
            buttonOpen.Text = "ABRIR";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // comboBoxBaud
            // 
            comboBoxBaud.FormattingEnabled = true;
            comboBoxBaud.Location = new Point(163, 100);
            comboBoxBaud.Name = "comboBoxBaud";
            comboBoxBaud.Size = new Size(138, 23);
            comboBoxBaud.TabIndex = 9;
            // 
            // comboBoxPort
            // 
            comboBoxPort.FormattingEnabled = true;
            comboBoxPort.Location = new Point(163, 67);
            comboBoxPort.Name = "comboBoxPort";
            comboBoxPort.Size = new Size(138, 23);
            comboBoxPort.TabIndex = 7;
            // 
            // labelBaud
            // 
            labelBaud.AutoSize = true;
            labelBaud.Location = new Point(54, 108);
            labelBaud.Name = "labelBaud";
            labelBaud.Size = new Size(70, 15);
            labelBaud.TabIndex = 8;
            labelBaud.Text = "BAUD RATE:";
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(54, 70);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(69, 15);
            labelPort.TabIndex = 7;
            labelPort.Text = "COM PORT:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonApagar);
            groupBox1.Controls.Add(buttonEncender);
            groupBox1.Controls.Add(pictureBoxLed);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(424, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 280);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "CONTROL LED";
            // 
            // buttonApagar
            // 
            buttonApagar.ForeColor = SystemColors.ActiveCaptionText;
            buttonApagar.Location = new Point(189, 207);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(119, 42);
            buttonApagar.TabIndex = 9;
            buttonApagar.Text = "APAGAR";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click_1;
            // 
            // buttonEncender
            // 
            buttonEncender.ForeColor = SystemColors.ActiveCaptionText;
            buttonEncender.Location = new Point(43, 207);
            buttonEncender.Name = "buttonEncender";
            buttonEncender.Size = new Size(121, 42);
            buttonEncender.TabIndex = 8;
            buttonEncender.Text = "ENCENDER";
            buttonEncender.UseVisualStyleBackColor = true;
            buttonEncender.Click += buttonEncender_Click_1;
            // 
            // pictureBoxLed
            // 
            pictureBoxLed.Image = Properties.Resources.ledOn2;
            pictureBoxLed.Location = new Point(90, 22);
            pictureBoxLed.Name = "pictureBoxLed";
            pictureBoxLed.Size = new Size(181, 169);
            pictureBoxLed.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLed.TabIndex = 3;
            pictureBoxLed.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 100);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(LED1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Control Led";
            Load += Form1_Load_1;
            LED1.ResumeLayout(false);
            LED1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLed).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelLed;
        private GroupBox LED1;
        private ComboBox comboBoxBaud;
        private ComboBox comboBoxPort;
        private Label labelBaud;
        private Label labelPort;
        private GroupBox groupBox1;
        private Label label1;
        private Button buttonClose;
        private Button buttonOpen;
        private PictureBox pictureBoxLed;
        private Button buttonApagar;
        private Button buttonEncender;
        private ProgressBar progressBarConnection;
    }
}
