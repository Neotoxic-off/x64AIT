using System.Reflection;
using System.Text;
using x64AIT.Core;

namespace x64AIT
{
    public class Program
    {
        private Core.Translator? Translator { get; set; }
        private Settings.Configuration? Configuration { get; set; }
        private Logger.Logger? Logger { get; set; }
        private List<string>? Result { get; set; }

        public static void Main(string[] args)
        {
            Program Program = new Program();

            Program.Logger = new Logger.Logger();
            Program.Setup();
            Program.Load(args);
            Program.Launch();
            Console.ReadLine();
        }

        private void Launch()
        {
            if (ValidateParameters() == 1)
            {
                Logger?.Log("wait", $"loading file {Configuration?.Parameters?[0]}");
                Translator?.Load(Configuration?.Parameters?[0]);
                Logger?.Log("done", $"file loaded");
                Logger?.Log("wait", $"translating");
                Result = Translator?.Translate();
                Logger?.Log("done", $"translation complete");
                Logger?.Log("information", $"translated: {Translator?.Report?.Instructions} intructions, {Translator?.Report?.Blocks} blocks");
                Logger?.Log("wait", $"saving");
                File.WriteAllLines($"{Configuration?.Parameters?[0]}.ait", Result);
                Logger?.Log("done", $"saved at {$"{Configuration?.Parameters?[0]}.ait"}");
                Logger?.Log("wait", $"saving logs");
                Logger?.Save();
                Logger?.Log("done", $"logs saved");

            } else
            {
                Logger?.Log("fail", $"no file to translate");
            }

            Console.ReadKey();
        }

        private int ValidateParameters()
        {
            if (Configuration?.Parameters?.Length > 0)
            {
                if (File.Exists(Configuration?.Parameters[0]))
                {
                    return (1);
                }
            }
            return (-1);
        }

        private void Setup()
        {
            
        }

        private void Load(string[] args)
        {
            LoadConfiguration(args);
            LoadTranslator();
            LoadConsole();
        }

        private void LoadConfiguration(string[] args)
        {
            Logger?.Log("wait", "configuration loading");

            Configuration = new Settings.Configuration()
            {
                OS = IntPtr.Size * 8,
                Version = Assembly.GetExecutingAssembly().GetName().Version,
                Parameters = args
            };

            Logger?.Log("item", new string[]
            {
                $"OS: x{Configuration?.OS}",
                $"version: {Configuration?.Version}",
                $"parameters: {Configuration?.Parameters?.Count()}"
            });
            Logger?.Log("done", "configuration loaded");
        }

        private void LoadTranslator()
        {
            Logger?.Log("wait", $"translator loading");
            Translator = new Translator(Logger);
            Logger?.Log("item", new string[]
            {
                $"Instructions: {Translator.TotalInstructions}",
                $"Registers: {Translator.TotalRegisters}"
            });
            Logger?.Log("done", "translator loaded");
        }

        private void LoadConsole()
        {
            Logger?.Log("wait", $"console loading");
            Console.Title = $"x64AIT {Configuration?.Version} x{Configuration?.OS}";
            Console.OutputEncoding = Encoding.UTF8;
            Logger?.Log("done", $"console loaded");
        }
    }
}
