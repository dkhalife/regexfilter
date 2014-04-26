using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Regex_Filter {
    class Program {
        static void Main(string[] args){
            String input = File.ReadAllText(args[0]);
            String pattern = @"[a-zA-Z]{3,4}\d{3,5}[a-zA-Z]?";

            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(input);

            StringBuilder o = new StringBuilder();

            foreach (Match match in matches){
                o.Append(match.Value.ToUpper() + "\r\n");
            }

            File.WriteAllText(args[1], o.ToString(), ASCIIEncoding.ASCII);
        }
    }
}
