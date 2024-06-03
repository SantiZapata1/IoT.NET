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
            buttonEncender = new Button();
            labelLed = new Label();
            LED1 = new GroupBox();
            buttonApagar = new Button();
            LED1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEncender
            // 
            buttonEncender.Location = new Point(8, 216);
            buttonEncender.Name = "buttonEncender";
            buttonEncender.Size = new Size(154, 44);
            buttonEncender.TabIndex = 1;
            buttonEncender.Text = "Encender";
            buttonEncender.UseVisualStyleBackColor = true;
            buttonEncender.Click += buttonEncender_Click;
            // 
            // labelLed
            // 
            labelLed.AutoSize = true;
            labelLed.BackColor = Color.LightCoral;
            labelLed.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLed.Location = new Point(147, 100);
            labelLed.Name = "labelLed";
            labelLed.Size = new Size(51, 31);
            labelLed.TabIndex = 2;
            labelLed.Text = "Off";
            labelLed.Click += labelLed_Click;
            // 
            // LED1
            // 
            LED1.Controls.Add(buttonApagar);
            LED1.Controls.Add(buttonEncender);
            LED1.Controls.Add(labelLed);
            LED1.Location = new Point(211, 123);
            LED1.Name = "LED1";
            LED1.Size = new Size(351, 280);
            LED1.TabIndex = 5;
            LED1.TabStop = false;
            LED1.Text = "LED 1";
            LED1.Enter += groupBox1_Enter_1;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(191, 216);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(154, 44);
            buttonApagar.TabIndex = 3;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LED1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            LED1.ResumeLayout(false);
            LED1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonEncender;
        private Label labelLed;
        private GroupBox LED1;
        private Button buttonApagar;
    }
}
