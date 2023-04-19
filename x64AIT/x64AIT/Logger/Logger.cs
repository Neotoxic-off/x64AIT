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
                { "wait", ("WAIT", ConsoleColor.Cyan) },
                { "information", ("INFO", ConsoleColor.Yellow) },
                { "done", ("DONE", ConsoleColor.Green) },
                { "warn", ("WARN", ConsoleColor.Magenta) },
                { "fail", ("FAIL", ConsoleColor.Red) },
                { "item", ("INFO", ConsoleColor.Yellow) }
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

            Console.Write("[ ");
            Console.ForegroundColor = results.Item2;
            for (int i = 0; i < results.Item1.Length; i++)
            {
                Console.Write(results.Item1[i]);
            }
            Console.ResetColor();
            Console.Write(" ]");

            return ($" {message}");
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
