using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeLanguageCompiler
{
    class TokenTable
    {
        private List<TokenRow> rows;

        public List<TokenRow> Rows { get => rows; }
        public TokenTable() { }
        public TokenTable(string data)
        {
            Parse(data);
        }
        public void Parse(string data, char separatorRow = '\n', char separator ='|')
        {
            rows = new List<TokenRow>();
            string[] dataRow = data.Split(separatorRow);
            foreach(string row in dataRow)
            {
                rows.Add(new TokenRow(row));
            }
        }
        public bool checkOnRow(int index, string data, Func<string, string, bool> testFunc)
        {
            if (index > rows.Count)
                return false;
            bool result = false;
            foreach (string token in rows[index].Tokens)
            {
                result |= testFunc(data, token);
            }
            return result;
        }
        public bool checkOnColumn(List<string> data, Func<string,string, bool> testFunc)
        {
            if (rows.Count != data.Count)
                return false;
            bool result = true;
            for (int i = 0; i < data.Count; i++)
            {
                result &= checkOnRow(i, data[i], testFunc);
            }
            return result;
        }
    }
    class TokenRow
    {
        private List<string> tokens;

        public List<string> Tokens { get => tokens;}
        public TokenRow(string data)
        {
            Parse(data);
        }
        public void Parse(string data, char separator = '|')
        {
            tokens = data.Split(separator).ToList<string>();
        }
    }
    class TokenHelper
    {
        public static bool TestEqual(string str1, string str2)
        {
            return str1 == str2;
        }
        public static bool TestContaining(string container,string contained)
        {
            return container.Contains(contained);
        }
    }
}
