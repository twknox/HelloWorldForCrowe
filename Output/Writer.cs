using System;
using System.Diagnostics;

namespace Output
{
/// <summary>
/// Output class.  This expectes the device type to be passed in the constructor
/// </summary>
    public class Writer
    {

        // list of all the valid devices.  These will correspond to derived classed later
        enum DEVICES
        {
            NONE,
            CONSOLE,
            MOBILE,
            SERVICE,
            // DATABASE
        }
        BaseWriter _device = null;

        // Parameterized constructor, simple injection
        // force constructor initializer.  Device is the type of device setting up for output
        // we initialize the output object here to save time in later calls
        public Writer(string device)
        {
            //DEVICES d = DEVICES.NONE;
            var t = Enum.TryParse(device.ToUpper(), out DEVICES d); // device must be valid
            if (!t) throw new ArgumentException();
            switch(d)
            {
                case DEVICES.CONSOLE:
                    _device = new ConsoleWriter();
                    break;
                default:
                    _device = new ConsoleWriter(); // should never hit here due to above assert
                    break;
            }
        }

        /// <summary>
        /// Write method.  This will be called each time something is to be written to the device.
        /// Right now it's simple, just write/append a string to the current output
        /// Could add overrides for more complex data types,
        /// or use a generic write that would call the objects own write method
        /// This will return a bool from the derived class specifying if Write was successful.
        /// </summary>
        /// <param name="theOutput">string to write</param>
        /// <returns>boolean specifying success of write</returns>
        public bool Write(string theOutput)
        {
            return _device.Write(theOutput);

        }

        /// <summary>
        /// Write method.  This will be called each time something is to be written to the device.
        /// Right now it's simple, just write/append a string to the current output
        /// Could add overrides for more complex data types,
        /// or use a generic write that would call the objects own write method
        /// This will return a bool from the derived class specifying if Write was successful.
        /// </summary>
        /// <param name="format">printf-style format string</param>
        /// <param name="args">printf-style arguments</param>
        /// <returns>boolean specifying success of write</returns>
        /// 
        public bool Write(string format, params object[] args)
        {
            return _device.Write(format, args);

        }

        /// <summary>
        /// Next method.  This will advance to next line/record/etc of the output device
        /// </summary>
        /// <returns>boolean specifying success of next</returns>
        public bool Next()
        {
            return _device.Next();
        }
    }
}
