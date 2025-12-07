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

            string content = File.ReadAllText(path);

            var numbers = new List<double>();
            string currentNumber = "";

            for (int i = 0; i < content.Length; i++)
            {
                char c = content[i];

               
                if (char.IsDigit(c) || c == '.' || c == '-' || c == ',')
                {
                    currentNumber += c;
                }
                else if (!string.IsNullOrEmpty(currentNumber))
                {
                    if (TryParseNumber(currentNumber, out double number))
                    {
                        numbers.Add(number);
                    }
                    currentNumber = "";
                }
            }

            if (!string.IsNullOrEmpty(currentNumber) && TryParseNumber(currentNumber, out double lastNumber))
            {
                numbers.Add(lastNumber);
            }

            return numbers.Where(n => n < 0).ToArray();
        }

        private bool TryParseNumber(string str, out double result)
        {
            string normalized = str.Replace(',', '.');

            if (normalized.Count(c => c == '-') > 1)
            {
                normalized = normalized.Replace("-", "");
                normalized = "-" + normalized;
            }

            return double.TryParse(normalized, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out result);
        }
    }
}

