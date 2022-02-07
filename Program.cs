using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Linq;
using TechnicalAssessment.Models;
using TechnicalAssessment.Extension;

namespace TechnicalAssessment
{
    class Program
    {
        HttpClient http = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetUrlData();
        }
        private async Task GetUrlData()
        {
            string json = await http.GetStringAsync("https://raw.githubusercontent.com/tester1-1/testdata/main/data.json");
            Console.WriteLine(json.MaxMinValueFromStudent());         
        }
    }
}
