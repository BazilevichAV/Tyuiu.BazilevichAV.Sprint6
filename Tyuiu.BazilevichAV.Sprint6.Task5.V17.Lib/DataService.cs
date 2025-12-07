using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BazilevichAV.Sprint6.Task5.V17.Lib
{
    public class DataService : ISprint6Task5V17
    {
        public double[] LoadFromDataFile(string path)
        {

            string tempPath = Path.GetTempPath();
            string outputPath = Path.Combine(tempPath, "OutPutFileTask5V17.txt");

            List<double> negnum = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(new char[] { ' ', '\t', ',', ';' },
                                                  StringSplitOptions.RemoveEmptyEntries);

                    foreach (string numberStr in numbers)
                    {
                        if (double.TryParse(numberStr.Replace(',', '.'),
                            NumberStyles.Any,
                            CultureInfo.InvariantCulture,
                            out double number) && number < 0)
                        {
                            double roundedNumber = Math.Round(number, 3);
                            negnum.Add(roundedNumber);
                        }
                    }
                }
            }

            // Запись результата в файл
            using (StreamWriter writer = new StreamWriter(outputPath, false))
            {
                foreach (double number in negnum)
                {
                    string formattedNumber = number.ToString("F3", CultureInfo.InvariantCulture);
                    writer.WriteLine(formattedNumber);
                    Console.WriteLine(formattedNumber); // Вывод в консоль для проверки
                }
            }

            return negnum.ToArray();
        }
    }
}

