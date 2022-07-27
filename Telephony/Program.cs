using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] siteUrl = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

             Regex regex = new Regex("\\D");
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in phoneNumbers)
            {
                if (regex.IsMatch(number))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                if (number.Length == 10)
                {
                    smartphone.CallNumber(number);
                }
                else
                {
                    stationaryPhone.CallNumber(number);
                }

            }

            regex = new Regex("\\d");


            foreach (var url in siteUrl)
            {
                if (regex.IsMatch(url))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }

                smartphone.BrowseWeb(url);
            }
        }
    }
}
