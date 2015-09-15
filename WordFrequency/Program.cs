using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordFrequency
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //args = new[] { @"C:\Temp\WarAndPeace.txt" };
            if (args.Any())
            {
                try
                {
                    Console.WriteLine("Start Word Frequency: (case sensitvity is ignored)");
                    var filePath = args[0];

                    var frequentWords = Top10OccuringWords(filePath);
                    foreach (var item in frequentWords)
                    {
                        Console.WriteLine("Word: {0}, Count: {1}", item.Key, item.Value);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("File not found - the app will now exit : {0}", e.InnerException);
                }
                Console.WriteLine("End Word Frequency");
            }
            else
            {
                Console.WriteLine("Please enter a valid file path.");
            }
            Console.ReadKey();
        }

        public static IDictionary<string, int> Top10OccuringWords(string path)
        {
            var result = new ConcurrentDictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            Parallel.ForEach(File.ReadLines(path), line =>
            {
                var words = Regex.Split(line, @"\W");
                foreach (var word in words.Where(word => !string.IsNullOrWhiteSpace(word)))
                {
                    result.AddOrUpdate(word.ToString(), 1, (_, x) => x + 1);
                }
            });
            return result.OrderByDescending(pair => pair.Value).Take(10).ToDictionary(pair => pair.Key, pair => pair.Value);
        }
    }
}