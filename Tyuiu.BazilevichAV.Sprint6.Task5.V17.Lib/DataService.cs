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

            List<double> negativeNumbers = new List<double>();

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
                                // Округляем до трех знаков после запятой
                                double roundedNumber = Math.Round(number, 3);
                                negativeNumbers.Add(roundedNumber);

                                // Выводим в консоль с 3 знаками после запятой
                                Console.WriteLine(roundedNumber.ToString("F3", CultureInfo.InvariantCulture));
                            }
                        }
                    }
                }
            }

            return negativeNumbers.ToArray();
        }
    }
}

