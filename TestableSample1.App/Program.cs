﻿using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestableSample1.App
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.Write("カンマ区切りの値を入力：");
            var valueStrs = Console.ReadLine();

            var splittedStrs = valueStrs.Split(",", StringSplitOptions.None);

            foreach (var str in splittedStrs)
            {
                await Task.Delay(1000);

                if (Regex.IsMatch(str, @"^(|null)$"))
                {
                    Console.WriteLine($"{str} : null");
                }
                else if (Regex.IsMatch(str, @"^(true|false)$"))
                {
                    Console.WriteLine($"{str} : bool");
                }
                else if (Regex.IsMatch(str, @"^-?[0-9]+(\.[0-9]+)?$"))
                {
                    Console.WriteLine($"{str} : number");
                }
                else
                {
                    Console.WriteLine($"{str} : string");
                }
            }
        }
    }
}
