using SDK;

namespace x64AIT.Core
{
    public class Registers
    {
        private static List<string> PreClean(string[] instructions)
        {
            string[] splitted = null;
            List<string> clean = new List<string>();

            foreach (string instruction in instructions)
            {
                if (instruction.Contains(",") == true)
                {
                    splitted = instruction.Split(',');
                    foreach (string element in splitted)
                    {
                        clean.Add(element.Trim());
                    }
                } else if (instruction != null && instruction != string.Empty)
                {
                    clean.Add(instruction);
                }
            }
            return (clean);
        }

        public static List<Models.Register?> Search(string[] instructions)
        {
            List<Models.Register?> registers = new List<Models.Register?>();
            int index = 0;
            int required = 2;

            foreach (string instruction in PreClean(instructions))
            {
                if (SDK.Models.Registers.Registers.IsValidRegister(instruction) == true)
                {
                    registers.Add(new Models.Register()
                    {
                        Value = instruction,
                        Index = index
                    });
                }

                index++;
            }

            if (registers.Count() < required)
            {
                registers = Align(registers, required);
            }

            return (registers);
        }

        private static List<Models.Register?> Align(List<Models.Register?> registers, int alignment)
        {
            for (int i = registers.Count(); i < alignment; i++)
            {
                registers.Add(new Models.Register()
                {
                    Value = "__NOT_FOUND__",
                    Index = 0
                });
            }

            return (registers);
        }
    }
}
