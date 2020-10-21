using System;
using Assembly_BrowserLib;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Xiaomi\source\repos\Faker\Faker\bin\Debug\netcoreapp3.1\Faker.dll";
            string result = JsonConvert.SerializeObject((new AssemblyBrowser()).GetAssemblyInfo(path), Formatting.Indented);
            Console.WriteLine(result);
        }
    }
}
