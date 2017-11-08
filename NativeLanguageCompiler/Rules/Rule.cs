using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeLanguageCompiler.Rules
{
    abstract class Rule
    {
        private string ruleName;
        private string expr;
        
        protected string RuleName { get => ruleName; set => ruleName = value; }
        protected string Expr { get => expr; set => expr = value; }
        public Rule()
        {

        }
        public abstract void Execute(string input);
    }
}
