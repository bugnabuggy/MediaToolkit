using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaToolkit
{
    public class ConversionStartedEventArgs
    {
        /// <summary>
        /// Raises notification once conversion is started
        /// </summary>
        /// <param name="process">The ffmpeg process</param>
        /// <param name="startInfo">The start info for the process</param>
        public ConversionStartedEventArgs(Process process, ProcessStartInfo startInfo)
        {
            Process = process;
            StartInfo = startInfo;
        }

        public Process Process { get; private set; }
        public ProcessStartInfo StartInfo { get; private set; }
        

    }
}
