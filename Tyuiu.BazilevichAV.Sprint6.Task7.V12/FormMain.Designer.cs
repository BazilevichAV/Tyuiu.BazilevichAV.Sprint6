namespace Tyuiu.BazilevichAV.Sprint6.Task7.V12
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelForButton_BAV = new Panel();
            buttonDoHelp_BAV = new Button();
            buttonDoneSave_BAV = new Button();
            buttonDoTask_BAV = new Button();
            buttonOpenFile_BAV = new Button();
            panelForText_BAV = new Panel();
            textBoxForTask_BAV = new TextBox();
            panelForInput_BAV = new Panel();
            dataGridViewInput_BAV = new DataGridView();
            labelForInput_BAV = new Label();
            panelForOutput_BAV = new Panel();
            dataGridViewOutput_BAV = new DataGridView();
            labelForOutput_BAV = new Label();
            openFileDialogTask_BAV = new OpenFileDialog();
            saveFileDialogTask_BAV = new SaveFileDialog();
            toolTipTask_BAV = new ToolTip(components);
            splitterIn_BAV = new Splitter();
            panelForButton_BAV.SuspendLayout();
            panelForText_BAV.SuspendLayout();
            panelForInput_BAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_BAV).BeginInit();
            panelForOutput_BAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_BAV).BeginInit();
            SuspendLayout();
            // 
            // panelForButton_BAV
            // 
            panelForButton_BAV.Controls.Add(buttonDoHelp_BAV);
            panelForButton_BAV.Controls.Add(buttonDoneSave_BAV);
            panelForButton_BAV.Controls.Add(buttonDoTask_BAV);
            panelForButton_BAV.Controls.Add(buttonOpenFile_BAV);
            panelForButton_BAV.Dock = DockStyle.Top;
            panelForButton_BAV.Location = new Point(0, 0);
            panelForButton_BAV.Name = "panelForButton_BAV";
            panelForButton_BAV.Size = new Size(800, 70);
            panelForButton_BAV.TabIndex = 1;
            // 
            // buttonDoHelp_BAV
            // 
            buttonDoHelp_BAV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDoHelp_BAV.Image = Properties.Resources.help;
            buttonDoHelp_BAV.Location = new Point(734, 4);
            buttonDoHelp_BAV.Name = "buttonDoHelp_BAV";
            buttonDoHelp_BAV.Size = new Size(60, 60);
            buttonDoHelp_BAV.TabIndex = 0;
            toolTipTask_BAV.SetToolTip(buttonDoHelp_BAV, "Сведения о исполнителе");
            buttonDoHelp_BAV.UseVisualStyleBackColor = true;
            buttonDoHelp_BAV.Click += buttonDoHelp_BAV_Click;
            // 
            // buttonDoneSave_BAV
            // 
            buttonDoneSave_BAV.Image = Properties.Resources.page_save;
            buttonDoneSave_BAV.Location = new Point(135, 4);
            buttonDoneSave_BAV.Name = "buttonDoneSave_BAV";
            buttonDoneSave_BAV.Size = new Size(60, 60);
            buttonDoneSave_BAV.TabIndex = 2;
            toolTipTask_BAV.SetToolTip(buttonDoneSave_BAV, "Сохраняет результат");
            buttonDoneSave_BAV.UseVisualStyleBackColor = true;
            buttonDoneSave_BAV.Click += buttonDoneSave_BAV_Click;
            // 
            // buttonDoTask_BAV
            // 
            buttonDoTask_BAV.Image = Properties.Resources.page_go;
            buttonDoTask_BAV.Location = new Point(69, 4);
            buttonDoTask_BAV.Name = "buttonDoTask_BAV";
            buttonDoTask_BAV.Size = new Size(60, 60);
            buttonDoTask_BAV.TabIndex = 1;
            toolTipTask_BAV.SetToolTip(buttonDoTask_BAV, "Изменить в девятом столбце значения не равные 10 на 0");
            buttonDoTask_BAV.UseVisualStyleBackColor = true;
            buttonDoTask_BAV.Click += buttonDoTask_BAV_Click;
            // 
            // buttonOpenFile_BAV
            // 
            buttonOpenFile_BAV.Image = Properties.Resources.folder_page;
            buttonOpenFile_BAV.Location = new Point(4, 4);
            buttonOpenFile_BAV.Name = "buttonOpenFile_BAV";
            buttonOpenFile_BAV.Size = new Size(60, 60);
            buttonOpenFile_BAV.TabIndex = 1;
            toolTipTask_BAV.SetToolTip(buttonOpenFile_BAV, "Открыть файл");
            buttonOpenFile_BAV.UseVisualStyleBackColor = true;
            buttonOpenFile_BAV.Click += buttonOpenFile_BAV_Click;
            // 
            // panelForText_BAV
            // 
            panelForText_BAV.Controls.Add(textBoxForTask_BAV);
            panelForText_BAV.Dock = DockStyle.Top;
            panelForText_BAV.Location = new Point(0, 70);
            panelForText_BAV.Name = "panelForText_BAV";
            panelForText_BAV.Size = new Size(800, 70);
            panelForText_BAV.TabIndex = 2;
            // 
            // textBoxForTask_BAV
            // 
            textBoxForTask_BAV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxForTask_BAV.Location = new Point(3, 3);
            textBoxForTask_BAV.Multiline = true;
            textBoxForTask_BAV.Name = "textBoxForTask_BAV";
            textBoxForTask_BAV.ReadOnly = true;
            textBoxForTask_BAV.Size = new Size(797, 67);
            textBoxForTask_BAV.TabIndex = 2;
            textBoxForTask_BAV.Text = resources.GetString("textBoxForTask_BAV.Text");
            // 
            // panelForInput_BAV
            // 
            panelForInput_BAV.Controls.Add(dataGridViewInput_BAV);
            panelForInput_BAV.Controls.Add(labelForInput_BAV);
            panelForInput_BAV.Dock = DockStyle.Left;
            panelForInput_BAV.Location = new Point(0, 140);
            panelForInput_BAV.Name = "panelForInput_BAV";
            panelForInput_BAV.Size = new Size(391, 310);
            panelForInput_BAV.TabIndex = 3;
            // 
            // dataGridViewInput_BAV
            // 
            dataGridViewInput_BAV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInput_BAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_BAV.Location = new Point(4, 26);
            dataGridViewInput_BAV.Name = "dataGridViewInput_BAV";
            dataGridViewInput_BAV.ReadOnly = true;
            dataGridViewInput_BAV.RowHeadersWidth = 51;
            dataGridViewInput_BAV.Size = new Size(381, 281);
            dataGridViewInput_BAV.TabIndex = 1;
            dataGridViewInput_BAV.CellContentClick += dataGridViewInput_BAV_CellContentClick;
            // 
            // labelForInput_BAV
            // 
            labelForInput_BAV.AutoSize = true;
            labelForInput_BAV.Location = new Point(4, 3);
            labelForInput_BAV.Name = "labelForInput_BAV";
            labelForInput_BAV.Size = new Size(46, 20);
            labelForInput_BAV.TabIndex = 0;
            labelForInput_BAV.Text = "Ввод:";
            // 
            // panelForOutput_BAV
            // 
            panelForOutput_BAV.Controls.Add(dataGridViewOutput_BAV);
            panelForOutput_BAV.Controls.Add(labelForOutput_BAV);
            panelForOutput_BAV.Dock = DockStyle.Fill;
            panelForOutput_BAV.Location = new Point(391, 140);
            panelForOutput_BAV.Name = "panelForOutput_BAV";
            panelForOutput_BAV.Size = new Size(409, 310);
            panelForOutput_BAV.TabIndex = 4;
            // 
            // dataGridViewOutput_BAV
            // 
            dataGridViewOutput_BAV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOutput_BAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_BAV.Location = new Point(6, 26);
            dataGridViewOutput_BAV.Name = "dataGridViewOutput_BAV";
            dataGridViewOutput_BAV.ReadOnly = true;
            dataGridViewOutput_BAV.RowHeadersWidth = 51;
            dataGridViewOutput_BAV.Size = new Size(399, 281);
            dataGridViewOutput_BAV.TabIndex = 2;
            dataGridViewOutput_BAV.CellContentClick += dataGridViewOutput_BAV_CellContentClick;
            // 
            // labelForOutput_BAV
            // 
            labelForOutput_BAV.AutoSize = true;
            labelForOutput_BAV.Location = new Point(6, 3);
            labelForOutput_BAV.Name = "labelForOutput_BAV";
            labelForOutput_BAV.Size = new Size(57, 20);
            labelForOutput_BAV.TabIndex = 0;
            labelForOutput_BAV.Text = "Вывод:";
            // 
            // toolTipTask_BAV
            // 
            toolTipTask_BAV.IsBalloon = true;
            toolTipTask_BAV.ToolTipTitle = "Подсказка";
            // 
            // splitterIn_BAV
            // 
            splitterIn_BAV.Location = new Point(391, 140);
            splitterIn_BAV.Name = "splitterIn_BAV";
            splitterIn_BAV.Size = new Size(4, 310);
            splitterIn_BAV.TabIndex = 5;
            splitterIn_BAV.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitterIn_BAV);
            Controls.Add(panelForOutput_BAV);
            Controls.Add(panelForInput_BAV);
            Controls.Add(panelForText_BAV);
            Controls.Add(panelForButton_BAV);
            Name = "FormMain";
            Text = "Спринт #6 | Таск 7 | Вариант 12 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
            Load += FormMain_Load;
            panelForButton_BAV.ResumeLayout(false);
            panelForText_BAV.ResumeLayout(false);
            panelForText_BAV.PerformLayout();
            panelForInput_BAV.ResumeLayout(false);
            panelForInput_BAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_BAV).EndInit();
            panelForOutput_BAV.ResumeLayout(false);
            panelForOutput_BAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_BAV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForButton_BAV;
        private Panel panelForText_BAV;
        private Button buttonDoHelp_BAV;
        private Button buttonDoneSave_BAV;
        private Button buttonDoTask_BAV;
        private Button buttonOpenFile_BAV;
        private Panel panelForInput_BAV;
        private Panel panelForOutput_BAV;
        private TextBox textBoxForTask_BAV;
        private Label labelForInput_BAV;
        private Label labelForOutput_BAV;
        private DataGridView dataGridViewInput_BAV;
        private DataGridView dataGridViewOutput_BAV;
        private OpenFileDialog openFileDialogTask_BAV;
        private SaveFileDialog saveFileDialogTask_BAV;
        private ToolTip toolTipTask_BAV;
        private Splitter splitterIn_BAV;
    }
}
