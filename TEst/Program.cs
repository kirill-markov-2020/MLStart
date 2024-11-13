using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.IO;

namespace TEst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filename = "ML.json";
            var content = @"{""Test"": ""123""}";
            File.WriteAllText(filename, content);
            IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(filename).Build();
            string testConfig = configuration["Test"];
            Console.WriteLine(testConfig);
        }
    }
}
