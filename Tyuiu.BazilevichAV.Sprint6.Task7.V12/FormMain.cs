using System.Resources;
using System.Text;
using System.Windows.Forms;
using Tyuiu.BazilevichAV.Sprint6.Task7.V12.Lib;
using Tyuiu.BazilevichAV.Sprint6.Task7.V12.Properties;
namespace Tyuiu.BazilevichAV.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonOpenFile_BAV.Image = Resources.folder_page;
            buttonDoTask_BAV.Image = Resources.page_go;
            buttonDoneSave_BAV.Image = Resources.page_save;
            buttonDoHelp_BAV.Image = Resources.help;

            openFileDialogTask_BAV.Filter = "Значения, разделённые точкой с запятой (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogTask_BAV.Filter = "Значения, разделённые точкой с запятой (*.csv)|*.csv|Все файлы (*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            // Разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Определяем количество строк и столбцов
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            // Выделяем массив данных
            int[,] arrayValues = new int[rows, columns];

            // Заполняем массив данными
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }

        private void buttonOpenFile_BAV_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора файла
            if (openFileDialogTask_BAV.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask_BAV.FileName;

                try
                {
                    // Загружаем данные из файла
                    int[,] arrayValues = LoadFromFileData(openFilePath);

                    // Настраиваем DataGridView для ввода
                    dataGridViewInput_BAV.ColumnCount = columns;
                    dataGridViewInput_BAV.RowCount = rows;

                    // Настраиваем DataGridView для вывода
                    dataGridViewOutput_BAV.ColumnCount = columns;
                    dataGridViewOutput_BAV.RowCount = rows;

                    // Задаем ширину столбцов
                    for (int i = 0; i < columns; i++)
                    {
                        dataGridViewInput_BAV.Columns[i].Width = 50;
                        dataGridViewOutput_BAV.Columns[i].Width = 50;
                    }

                    // Добавляем данные в dataGridViewIn
                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInput_BAV.Rows[r].Cells[c].Value = arrayValues[r, c];
                        }
                    }

                    // Активируем кнопку "Выполнить"
                    buttonDoTask_BAV.Enabled = true;

                    // Показываем информацию
                    textBoxForTask_BAV.Text = $"Файл загружен. Строк: {rows}, Столбцов: {columns}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDoTask_BAV_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем преобразованную матрицу
                int[,] transformedMatrix = ds.GetMatrixAndTransform(openFilePath);

                // Выводим преобразованные данные в dataGridViewOut
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOutput_BAV.Rows[r].Cells[c].Value = transformedMatrix[r, c];
                    }
                }

                // Подсвечиваем 9-й столбец (индекс 8)
                for (int r = 0; r < rows; r++)
                {
                    dataGridViewOutput_BAV.Rows[r].Cells[8].Style.BackColor = Color.LightYellow;
                }

                // Активируем кнопку "Сохранить"
                buttonDoneSave_BAV.Enabled = true;

                // Показываем информацию
                textBoxForTask_BAV.Text = "Матрица преобразована. 9-й столбец изменён.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при преобразовании матрицы: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDoneSave_BAV_Click(object sender, EventArgs e)
        {
            try
            {
                // Всегда сохраняем в C:\DataSprint6\
                string directoryPath = @"C:\DataSprint6\";
                string fileName = "OutPutFileTask7V12.csv";
                string fullPath = Path.Combine(directoryPath, fileName);

                // Сохраняем
                using (StreamWriter writer = new StreamWriter(fullPath, false, Encoding.UTF8))
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            writer.Write(dataGridViewOutput_BAV.Rows[i].Cells[j].Value);
                            if (j < columns - 1)
                            {
                                writer.Write(";");
                            }
                        }
                        writer.WriteLine();
                    }
                }

                // Проверяем и показываем результат
                if (File.Exists(fullPath))
                {
                    MessageBox.Show($"Файл сохранен:\n{fullPath}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start("explorer.exe", directoryPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDoHelp_BAV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void dataGridViewInput_BAV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOutput_BAV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Устанавливаем начальные размеры как у преподавателя
            dataGridViewInput_BAV.ColumnCount = 50;
            dataGridViewOutput_BAV.ColumnCount = 50;
            dataGridViewInput_BAV.RowCount = 50;
            dataGridViewOutput_BAV.RowCount = 50;

            // Настраиваем ширину столбцов
            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_BAV.Columns[i].Width = 50;
                dataGridViewOutput_BAV.Columns[i].Width = 50;
            }
        }

    }
}
