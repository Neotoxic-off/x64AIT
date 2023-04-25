using SDK;

namespace x64AIT.Core
{
    public class Directives
    {
        public static Models.Directive? Search(string[] instructions)
        {
            Models.Directive? Directive = null;
            SDK.Models.Directives.Directives.BaseModel Model = null;

            if (instructions.Count() > 0) {
                if (SDK.Models.Directives.Directives.IsValidDirective(instructions[0]) == true)
                {
                    Model = SDK.Models.Directives.Directives.GetDirective(instructions[0]);
                    Directive = new Models.Directive() {
                        Value = Model.Name,
                        Comment = Model.Comment,
                        State = Models.Directive.States.Valid,
                        Parameters = GetParamaters(instructions)
                    };
                } else {
                    Directive = new Models.Directive() {
                        Value = $"{instructions[0]}",
                        Comment = "__NOT_FOUND__",
                        State = Models.Directive.States.Invalid,
                        Parameters = null
                    };
                }
            }

            return (Directive);
        }

        private static List<object?> GetParamaters(string[] instructions)
        {
            List<object?> Parameters = new List<object?>();

            for (int i = 1; i < instructions.Count(); i++) {
                Parameters.Add(Clean(instructions[i]));
            }

            return (Parameters);
        }

        private static string? Clean(object? item)
        {
            string block = item?.ToString().Trim();

            if (block.Length > 0) {
                if (block.EndsWith(',') == true) {
                    block = RemoveItem(block, ",");
                }
            }

            return (block);
        }

        private static string? RemoveItem(string block, string item)
        {
            return (block.Replace($"{item}", ""));
        }
    }
}
