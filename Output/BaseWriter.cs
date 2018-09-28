using System;
using System.Collections.Generic;
using System.Text;

namespace Output
{
    /// <summary>
    /// Base class for writing to devices
    /// </summary>
    abstract class BaseWriter : IWriter
    {
        /// <summary>
        /// write a string to output device
        /// </summary>
        /// <param name="output"></param>
        /// <returns>boolean specifying if successful</returns>
        public abstract bool Write(string output);

        /// <summary>
        /// write a string to output device using formatted output
        /// </summary>
        /// <param name="output"></param>
        /// <returns>boolean specifying if successful</returns>
        public abstract bool Write(string format, params object[] arg);

        /// <summary>
        /// Advance to the next line/row/etc
        /// </summary>
        /// <returns></returns>
        public abstract bool Next();

    }
}
