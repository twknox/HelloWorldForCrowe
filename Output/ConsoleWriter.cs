using System;
using System.Collections.Generic;
using System.Text;

namespace Output
{
    /// <summary>
    /// Console writer class.  This is the only one implemented at the moment
    /// </summary>
    class ConsoleWriter : BaseWriter
    {
        public override bool Write(string output)
        {
            Console.Write(output);
            return true;
//            throw new NotImplementedException();
        }

        public override bool Write(string format, params object[] args)
        {
            Console.Write(format, args);
            return true;
        }

        public override bool Next()
        {
            Console.WriteLine();
            return true;
        }
    }
}
