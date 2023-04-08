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
                Logger?.Log("action", $"loading file {Configuration?.Parameters?[0]}");
                Translator?.Load(Configuration?.Parameters?[0]);
                Logger?.Log("information", $"loading file {Configuration?.Parameters?[0]}");
                Logger?.Log("action", $"translating");
                Result = Translator?.Translate();
                Logger?.Log("item", new string[]
                {
                    $"Lines: {Translator?.Report?.Lines}",
                    $"Instructions: {Translator?.Report?.Instructions}",
                    $"Blocks: {Translator?.Report?.Blocks}",
                });
                Logger?.Log("information", $"translation complete");

                Logger?.Log("action", $"saving");
                File.WriteAllLines($"{Configuration?.Parameters?[0]}.ait", Result);
                Logger?.Log("actionSuccess", $"saved at {$"{Configuration?.Parameters?[0]}.ait"}");

            } else
            {
                Logger?.Log("actionFail", $"no file to translate");
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
            Logger?.Log("action", "Configuration loading");

            Configuration = new Settings.Configuration()
            {
                OS = IntPtr.Size * 8,
                Version = Assembly.GetExecutingAssembly().GetName().Version,
                Parameters = args
            };

            Logger?.Log("item", new string[]
            {
                $"OS: x{Configuration?.OS}",
                $"Version: {Configuration?.Version}",
                $"Parameters: {Configuration?.Parameters?.Count()}"
            });
            Logger?.Log("information", "Configuration loaded");
        }

        private void LoadTranslator()
        {
            Logger?.Log("action", $"Translator loading");
            Translator = new Translator(Logger);
            Logger?.Log("item", new string[]
            {
                $"Total Instructions: {Translator.TotalInstructions}"
            });
            Logger?.Log("information", "Translator loaded");
        }

        private void LoadConsole()
        {
            Logger?.Log("action", $"Console loading");
            Console.Title = $"x64AIT {Configuration?.Version} x{Configuration?.OS}";
            Console.OutputEncoding = Encoding.UTF8;
            Logger?.Log("information", $"Console loaded");
        }
    }
}
