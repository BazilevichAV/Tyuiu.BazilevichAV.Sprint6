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

            StringBuilder result = new StringBuilder();
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
                            out double number))
                        {
                            if (number < 0)
                            {
                                // Округляем до трех знаков и добавляем в список
                                double roundedNumber = Math.Round(number, 3);
                                negnum.Add(roundedNumber);
                            }
                        }
                    }
                }
            }

            // Вывод отрицательных чисел в консоль (уже округленных)
            foreach (double number in negnum)
            {
                Console.WriteLine(number.ToString("F3", CultureInfo.InvariantCulture));
            }

            return negnum.ToArray();
        }
    }
}

