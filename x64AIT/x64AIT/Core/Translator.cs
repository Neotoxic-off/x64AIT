using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SDK;
using x64AIT.Models;

namespace x64AIT.Core
{
    public class Translator
    {
        public int TotalInstructions { get; set; }
        public string[]? Lines { get; set; }
        public Models.Report? Report { get; set; }
        private Logger.Logger Logger { get; set; }

        public Translator(Logger.Logger logger)
        {
            TotalInstructions = SDK.Models.Instructions.Instructions.CountInstructions();
            Report = new Models.Report();
            Logger = logger;
        }

        public string? GetComment(string instruction)
        {
            dynamic? asmInstruction = SDK.Models.Instructions.Instructions.GetInstruction(instruction);

            return (asmInstruction?.Comment);
        }

        public void Load(string filename)
        {
            Lines = File.ReadAllLines(filename);
        }

        public List<string>? Translate()
        {
            Report = new Models.Report()
            {
                Lines = Lines.Count(),
                Instructions = 0,
                Blocks = 0
            };

            return (Parse());
        }

        public List<string>? Parse()
        {
            string[]? currentLine = null;
            List<string>? cleanned = new List<string>();

            foreach (string line in Lines)
            {
                currentLine = Separator(line);
                cleanned.Add(TranslateLine(currentLine));
            }

            return (cleanned);
        }

        public string TranslateLine(string[] instructions)
        {
            Models.Architecture architecture = new Models.Architecture();
            List<string?> buffer = new List<string?>();
            string? cleannedBlock = null;
            dynamic? instruction = null;
            string[]? parameters = null;
            int index = 0;

            Report.Blocks += instructions.Length;

            foreach (string block in instructions)
            {
                cleannedBlock = block;
                if (IsComment(block) == false && Skip(block) == false && IsOffset(block) == false)
                {
                    instruction = SDK.Models.Instructions.Instructions.GetInstruction(block);
                    if (instruction != null)
                    {
                        architecture.Instruction = instruction;
                        architecture.InstructionIndex = index;
                        Report.Instructions++;
                    }
                    else
                    {
                        parameters = Parameters(block);
                        if (parameters != null && architecture.Instruction != null)
                        {
                            if (architecture.Instruction.Source != null && architecture.Instruction.Destination != null)
                            {
                                architecture.Instruction.Source = parameters[0];
                                architecture.Instruction.Destination = parameters[1];
                            }
                        }
                    }
                }
                buffer.Add(cleannedBlock);
                index++;
            }
            if (architecture.Instruction != null)
            {
                //if (architecture.InstructionIndex + 2 < instructions.Length && architecture.Instruction.Source == null && architecture.Instruction.Destination == null)
                //{
                //    architecture.Instruction.Source = instructions[architecture.InstructionIndex + 1];
                //    architecture.Instruction.Destination = instructions[architecture.InstructionIndex + 2];
                //}
                architecture.Instruction.Render();
            }

            buffer.Add($"// {architecture.Instruction?.Comment}");

            return (string.Join(" ", buffer));
        }

        public bool IsOffset(string instruction)
        {
            if (instruction != null)
            {
                if (instruction.Length == 16)
                {
                    return (IsHex(instruction));
                }
            }

            return (false);
        }

        public bool IsHex(string instruction)
        {
            string characters = "0123456789ABCDEF";

            if (instruction != null)
            {
                foreach (char c in instruction)
                {
                    if (characters.Contains(c) == false)
                    {
                        return (false);
                    }
                }
                return (true);
            }
            return (false);
        }

        public bool Skip(string instruction)
        {
            if (instruction != null)
            {
                return (instruction.Length < 2);
            }
            return (false);
        }

        public bool IsComment(string instruction)
        {
            string comment = "//";

            return (instruction.StartsWith(comment));
        }

        public string[]? Separator(string line)
        {
            if (line != null)
            {
                return (line.Trim().Split(' '));
            }
            return (null);
        }

        public string[]? Parameters(string data)
        {
            if (data != null)
            {
                if (data.Contains(',') == true)
                {
                    return (data.Split(','));
                }
            }
            return (null);
        }
    }
}
