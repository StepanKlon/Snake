using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneak.Services
{
    class FileService : IDataService
    {
        public string FilePath { get; private set; }

        public FileService()
        {
            FilePath = "..\\Sneak\\Score.txt";
        }

        public int GetTheHighestScore()
        {
            var scoreList = new List<int>();
            var lines = File.ReadAllLines(FilePath);
            foreach (var line in lines)
            {
                scoreList.Add(Int32.Parse(line.Split(".")[1]));
            }
            return scoreList.Max();
        }

        public void WriteTheHighestScore(int score)
        {
            if (score > GetTheHighestScore())
            {
                var countRow = File.ReadAllLines(FilePath).Length;
                File.WriteAllText(FilePath,$"{countRow + 1}.{score}");
            }
        }
    }
}
