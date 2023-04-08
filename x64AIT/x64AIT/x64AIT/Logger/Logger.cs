using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x64AIT.Logger
{
    public class Logger
    {
        private string? Path { get; set; }
        private string? Session { get; set; }
        private string FullPath { get; set; }
        private List<string> Records { get; set; }
        private Dictionary<string, (string, ConsoleColor)> LogTypes { get; set; }

        public Logger()
        {
            Path = $"Logs";
            Session = $"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss").GetHashCode()}.txt";
            FullPath = $"{Path}/{Session}";
            Records = new List<string>()
            {
                Capacity = 100
            };
            LogTypes = new Dictionary<string, (string, ConsoleColor)>()
            {
                { "action", (" ->", ConsoleColor.Cyan) },
                { "information", ("==>", ConsoleColor.Yellow) },
                { "actionSuccess", ("==>", ConsoleColor.Green) },
                { "actionFail", ("==>", ConsoleColor.Red) },
                { "item", ("    -", ConsoleColor.White) }
            };
            Setup();
        }

        private void Setup()
        {
            if (Directory.Exists(Path) == false)
            {
                Directory.CreateDirectory(Path);
            }
        }

        public string Format(string type, string message)
        {
            (string, ConsoleColor) results = LogTypes[type];

            Console.ForegroundColor = results.Item2;

            return ($"{results.Item1} {message}");
        }

        public void Log(string type, string message)
        {
            message = Format(type, message);

            Record(message);
        }

        public void Log(string type, string[] messages)
        {
            string? current = null;

            foreach (string message in messages)
            {
                current = Format(type, message);
                Record(current);
            }
        }

        private void Record(string message)
        {
            Records.Add($"[{DateTime.Now.ToString("hh:mm:ss")}] {message}");
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;

            if (Records.Count % Records.Capacity == 0)
            {
                Save();
                Purge();
            }
        }

        public void Save()
        {
            if (File.Exists(FullPath))
            {
                File.Delete(FullPath);
            }
            File.AppendAllLines(FullPath, Records);
        }

        public void Purge()
        {
            Records.Clear();
        }
    }
}
