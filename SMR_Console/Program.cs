using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentry;

namespace SMR_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SentrySdk.Init(o => { o.Dsn = "https://eb18e953812b41c3aeb042e666fd3b5c@o447951.ingest.sentry.io/5428537"; o.Debug = true; });
            SentrySdk.CaptureMessage("a");
            Console.ReadKey();
        }
    }
}
