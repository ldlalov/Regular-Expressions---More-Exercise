using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string patern = @"(?<symbols>[A-Z\W]+)[\d]";
            MatchCollection matches = Regex.Matches(input, patern);
            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                int counts = int.Parse(match.Value.Last().ToString());
                for (int i = 0; i < counts; i++)
                {
                    result.Append(match.Groups["symbols"].Value);
                }
            }
            string patern1 = @"[\w\W]";
            MatchCollection match1 = Regex.Matches(result.ToString(), patern1);
            int unique = match1.Count();
        }
    }
}
