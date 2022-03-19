using System;
using System.Text;
using System.Text.RegularExpressions;


namespace _1._Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex0 = new Regex(@"[^,]+");
            MatchCollection tickets = regex0.Matches(input);
            Regex regex1 = new Regex(@"(?<win>[\@]{6,}|[\#]{6,}|[\$]{6,}|[\^]{6,})");
            foreach (Match ticket in tickets)
            {
                string ticket1 = ticket.Value.Trim();
                string ticket2 = regex1.Match(ticket1).ToString();
                StringBuilder firstMatch = new StringBuilder();
                StringBuilder secondMatch = new StringBuilder();
                if (ticket1.Length > 0)
                {
                    if (ticket1.Length == 20)
                    {
                        string firstPart = regex1.Match(ticket1.Substring(0, 10)).ToString();
                        string secondPart = regex1.Match(ticket1.Substring(10, 10)).ToString();
                        if (firstPart.Length >= 6 && secondPart.Length >= 6)
                        {
                            if (firstPart[0].ToString() == secondPart[0].ToString() && firstPart.Length == 10 && secondPart.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket1}\" - {firstPart.Length}{firstPart[0]} Jackpot!");
                            }

                            else if (firstPart[0].ToString() == secondPart[0].ToString())
                            {
                                if (firstPart.Length<secondPart.Length)
                                {
                                    Console.WriteLine($"ticket \"{ticket1}\" - {firstPart.Length}{firstPart[0]}");
                                }
                                else
                                {
                                    Console.WriteLine($"ticket \"{ticket1}\" - {secondPart.Length}{secondPart[0]}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket1}\" - no match");
                        }

                    }
                    else
                    {
                        Console.WriteLine("invalid ticket");

                    }
                }

            }
        }
    }
}
