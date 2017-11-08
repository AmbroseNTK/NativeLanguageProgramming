using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeLanguageCompiler
{
    public class Compiler
    {
        private string input;
        private string output;
        private string workspaceDir;
        private bool toBinary;
        private string ruleDir;
        public string Output => output;

        public string Input { get => input; set => input = value; }
        public string WorkspaceDir { get => workspaceDir; set => workspaceDir = value; }
        public bool ToBinary { get => toBinary; set => toBinary = value; }
        public string RuleDir { get => ruleDir; set => ruleDir = value; }

        public Compiler()
        {
            input = "";
            output = "";
        }
        public void Setup(string workspaceDir, bool toBinary)
        {
            WorkspaceDir = workspaceDir;
            ToBinary = toBinary;
        }
        public void Compile()
        {

        }
    }
}
