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
            components = new System.ComponentModel.Container();
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            labelHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitulo = new Label();
            pictureBoxLogo = new PictureBox();
            LED1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLed).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // LED1
            // 
            LED1.BackColor = Color.FromArgb(34, 34, 34);
            LED1.Controls.Add(progressBarConnection);
            LED1.Controls.Add(buttonClose);
            LED1.Controls.Add(buttonOpen);
            LED1.Controls.Add(comboBoxBaud);
            LED1.Controls.Add(comboBoxPort);
            LED1.Controls.Add(labelBaud);
            LED1.Controls.Add(labelPort);
            LED1.ForeColor = SystemColors.ButtonFace;
            LED1.Location = new Point(12, 110);
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
            groupBox1.BackColor = Color.FromArgb(34, 34, 34);
            groupBox1.Controls.Add(buttonApagar);
            groupBox1.Controls.Add(buttonEncender);
            groupBox1.Controls.Add(pictureBoxLed);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(369, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 373);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "CONTROL LED";
            // 
            // buttonApagar
            // 
            buttonApagar.BackColor = Color.FromArgb(255, 192, 192);
            buttonApagar.ForeColor = SystemColors.ActiveCaptionText;
            buttonApagar.Location = new Point(194, 269);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(127, 59);
            buttonApagar.TabIndex = 9;
            buttonApagar.Text = "APAGAR";
            buttonApagar.UseVisualStyleBackColor = false;
            buttonApagar.Click += buttonApagar_Click_1;
            // 
            // buttonEncender
            // 
            buttonEncender.BackColor = Color.FromArgb(192, 255, 192);
            buttonEncender.ForeColor = SystemColors.ActiveCaptionText;
            buttonEncender.Location = new Point(39, 269);
            buttonEncender.Name = "buttonEncender";
            buttonEncender.Size = new Size(133, 59);
            buttonEncender.TabIndex = 8;
            buttonEncender.Text = "ENCENDER";
            buttonEncender.UseVisualStyleBackColor = false;
            buttonEncender.Click += buttonEncender_Click_1;
            // 
            // pictureBoxLed
            // 
            pictureBoxLed.Image = Properties.Resources.ledOn2;
            pictureBoxLed.Location = new Point(93, 67);
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
            label1.Location = new Point(150, 145);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(34, 34, 34);
            groupBox2.Controls.Add(labelHora);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(12, 396);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 87);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Time";
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Arial", 34F);
            labelHora.ForeColor = Color.Red;
            labelHora.Location = new Point(75, 19);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(204, 52);
            labelHora.TabIndex = 0;
            labelHora.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 39F);
            labelTitulo.ForeColor = Color.PaleTurquoise;
            labelTitulo.Location = new Point(130, 15);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(333, 70);
            labelTitulo.TabIndex = 12;
            labelTitulo.Text = "DASHBOARD";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logoIot1;
            pictureBoxLogo.Location = new Point(478, 5);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(135, 99);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 10;
            pictureBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 68, 68);
            ClientSize = new Size(745, 492);
            Controls.Add(pictureBoxLogo);
            Controls.Add(labelTitulo);
            Controls.Add(groupBox2);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private Label labelHora;
        private Label labelTitulo;
        private PictureBox pictureBoxLogo;
    }
}
