using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalAssessment.Models;

namespace TechnicalAssessment.Extension
{
    public static class MaxMinValue
    {
        internal static string MaxMinValueFromStudent(this string json)
        {
            Dictionary<string, Student> myDictionary = JsonConvert.DeserializeObject<Dictionary<string, Student>>(json);

            var max = myDictionary.Max(x => x.Value.Math1);
            var min = myDictionary.Min(x => x.Value.Math1);
            return String.Format("Maximum Value From Math1 : {0} \nMinimum Value From Math1 : {1}", max, min);
        }
    }
}
