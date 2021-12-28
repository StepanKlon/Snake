using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Services
{
    class FileService : IDataService
    {
        public string FilePath { get; private set; }

        public FileService()
        {
            FilePath = "..\\..\\..\\Score.txt";
        }

        public int GetTheHighestScore()
        {
            var scoreList = new List<int>();
            try
            {
                var lines = File.ReadAllLines(FilePath);
                foreach (var line in lines)
                {
                    scoreList.Add(Int32.Parse(line.Split(".")[1]));
                }
                return scoreList.Max();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void WriteScore()
        {
            try
            {
                var countRow = File.ReadAllLines(FilePath).Length;
                //File.WriteAllText(FilePath, $"{countRow + 1}.{Settings.score}\n");
                File.AppendAllText(FilePath, $"{countRow + 1}.{Settings.score}\n");
            }
            catch (Exception)
            {
                Console.WriteLine("It is not possible to write into a file.");
            }
        }
    }
}
