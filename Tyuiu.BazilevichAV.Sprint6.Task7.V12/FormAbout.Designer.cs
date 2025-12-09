namespace Tyuiu.BazilevichAV.Sprint6.Task7.V12
{
    partial class FormAbout
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
            buttonME_BAV = new Button();
            label1 = new Label();
            pictureBoxME_BAV = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxME_BAV).BeginInit();
            SuspendLayout();
            // 
            // buttonME_BAV
            // 
            buttonME_BAV.Location = new Point(694, 409);
            buttonME_BAV.Name = "buttonME_BAV";
            buttonME_BAV.Size = new Size(94, 29);
            buttonME_BAV.TabIndex = 0;
            buttonME_BAV.Text = "OK";
            buttonME_BAV.UseVisualStyleBackColor = true;
            buttonME_BAV.Click += buttonME_BAV_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(422, 107);
            label1.Name = "label1";
            label1.Size = new Size(347, 135);
            label1.TabIndex = 1;
            label1.Text = "Таск 7 выполнила студентка группы ИБКСб-25-1 Базилевич А.В.\r\n\r\nПрограмма выполнена на языке программирования C#.\r\n";
            label1.Click += label1_Click;
            // 
            // pictureBoxME_BAV
            // 
            pictureBoxME_BAV.Image = Properties.Resources.Screenshot_6;
            pictureBoxME_BAV.Location = new Point(12, 12);
            pictureBoxME_BAV.Name = "pictureBoxME_BAV";
            pictureBoxME_BAV.Size = new Size(327, 426);
            pictureBoxME_BAV.TabIndex = 2;
            pictureBoxME_BAV.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxME_BAV);
            Controls.Add(label1);
            Controls.Add(buttonME_BAV);
            Name = "FormAbout";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxME_BAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonME_BAV;
        private Label label1;
        private PictureBox pictureBoxME_BAV;
    }
}