using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRgstr_Using_LambdaExprsn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Validating using Regular Expression!");
            RegexSample regexSample = new RegexSample();
            regexSample.Validating();
        }
    }
}