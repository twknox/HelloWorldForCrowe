using System;
using System.Collections.Generic;
using System.Text;

namespace Output
{
    public interface IWriter
    {
         bool Write(string output);

        /// <summary>
        /// write a string to output device using formatted output
        /// </summary>
        /// <param name="output"></param>
        /// <returns>boolean specifying if successful</returns>
        bool Write(string format, params object[] args);

        /// <summary>
        /// Advance to the next line/row/etc
        /// </summary>
        /// <returns></returns>
        bool Next();

    }
}
