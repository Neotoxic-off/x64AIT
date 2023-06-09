﻿using System;
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
        public int TotalRegisters { get; set; }
        public string[]? Lines { get; set; }
        public Models.Report? Report { get; set; }
        private Logger.Logger Logger { get; set; }

        public Translator(Logger.Logger logger)
        {
            TotalInstructions = SDK.Models.Instructions.Instructions.CountInstructions();
            TotalRegisters = SDK.Models.Registers.Registers.CountRegisters();
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
            UInt128 index = 0;
            string? result = null;

            foreach (string line in Lines)
            {
                if (line.StartsWith("//") == false)
                {
                    currentLine = Separator(line);
                    result = TranslateLine(currentLine, index);
                    if (result != null)
                    {
                        cleanned.Add(result);
                    }
                }
                else
                {
                    cleanned.Add(line);
                }
                index++;
            }

            return (cleanned);
        }

        public string? TranslateLine(string[] instructions, UInt128 line)
        {
            Models.Architecture architecture = new Models.Architecture();
            List<string?> buffer = new List<string?>();
            string? cleannedBlock = null;
            dynamic? instruction = null;
            string[]? parameters = null;
            int index = 0;
            bool comment = false;
            List<Register?> registers = Registers.Search(instructions);
            Models.Directive? directive = Directives.Search(instructions);

            Report.Blocks += instructions.Length;

            foreach (string block in instructions)
            {
                cleannedBlock = block;
                if (comment == false)
                {
                    comment = Tools.Comment.IsComment(block);
                    if (Tools.Skip.CanSkip(block) == false && Tools.Offset.IsOffset(block) == false)
                    {
                        instruction = SDK.Models.Instructions.Instructions.GetInstruction(block);
                        if (instruction != null)
                        {
                            architecture.Instruction = instruction;
                            architecture.InstructionIndex = index;
                            architecture.Instruction.Source = registers?[0]?.Value;
                            architecture.Instruction.Destination = registers?[1]?.Value;
                            Report.Instructions++;
                        }
                    }
                }
                
                index++;
            }
            if (directive.State == Directive.States.Valid) {
                buffer.Add($"line:{line}: {directive.Comment}");
            }
            if (architecture.Instruction != null)
            {
                architecture.Instruction.Render();
                buffer.Add($"line:{line}: {architecture.Instruction?.Comment?.Render}");
            }
            if (buffer.Count() > 0)
                return (string.Join(" ", buffer));
            return (null);
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
