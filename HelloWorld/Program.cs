using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Output;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize our writer using App.config for now.  Could be set for anything in the future
            var writer = new Writer(ConfigurationManager.AppSettings["Writer"]);

            // we could have multiple type of writers initialized at once, allowing multiple output streams
            //var writer2 = new Writer("mobile"); //if we wanted a second stream for mobile

            // write Hello World
            writer.Write("Hello World!");
            // advance (to next line/record/etc)
            writer.Next();


        }
    }
}
