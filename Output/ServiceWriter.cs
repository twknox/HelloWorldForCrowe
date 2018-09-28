using System;
using System.Collections.Generic;
using System.Text;

namespace Output
{
    /// <summary>
    /// Service writer class -- will throw NotImplementedException for all methods for now
    /// </summary>

    abstract class ServiceWriter : BaseWriter
    {
        public override bool Write(string output)
        {
            throw new NotImplementedException();
        }

        public override bool Write(string format, params object[] arg)
        {
            throw new NotImplementedException();
        }

        public override bool Next()
        {
            throw new NotImplementedException();
        }

    }
}
