using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using SpinnerPlugin.Wrapper;
using SpinnerPlugin.Model;

namespace SpinnerPlugin.StressTest
{
    /// <summary>
    /// Class for stress testing.
    /// </summary>
    public class StressTest
    {
        /// <summary>
        /// The main class method for running load testing.
        /// </summary>
        private static void Main()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var builder = new SpinnerBuilder();
            var spinnerParameters = new SpinnerParameters();
            var streamWriter = new StreamWriter($"StressTest.txt", true);
            var modelCounter = 0;
            var computerInfo = new ComputerInfo();
            ulong usedMemory = 0;
            while (usedMemory * 0.96 <= computerInfo.TotalPhysicalMemory)
            {
                builder.BuildSpinner(spinnerParameters);
                usedMemory = (computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory);
                streamWriter.WriteLine(
                    $"{++modelCounter}\t{stopWatch.Elapsed:hh\\:mm\\:ss}\t{usedMemory}${computerInfo.TotalPhysicalMemory}");
                streamWriter.Flush();
            }
            stopWatch.Stop();
            streamWriter.WriteLine("END");
            streamWriter.Close();
            streamWriter.Dispose();
        }
    }
}