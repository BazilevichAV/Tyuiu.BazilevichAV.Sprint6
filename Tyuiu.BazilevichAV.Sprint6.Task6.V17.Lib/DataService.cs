using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BazilevichAV.Sprint6.Task6.V17.Lib
{
    public class DataService : ISprint6Task6V17
    {
        public string CollectTextFromFile(string path)
        {

            var lines = File.ReadAllLines(path);
            var thirdWords = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                var words = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (words.Length >= 3)
                {
                    string thirdWord = words[2];
                    thirdWords.Add(thirdWord);
                }
            }

            return string.Join(" ", thirdWords);
        }
    }
}

