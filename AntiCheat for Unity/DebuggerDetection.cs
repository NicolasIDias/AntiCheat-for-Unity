using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCheat
{
    class DebuggerDetection
    {
        public static List<string> runningDbg = new List<string>();
        public static bool detected;
        public static String[] debuggers = { "x64dbg", "IDA Pro", "ida64", "dbg64", "Debugger" };

        public static void detectDebugger()
        {

            foreach (Process run in Process.GetProcesses())
            {
                runningDbg.Add(run.ProcessName);
            }

            for (int i = 0; i < debuggers.Length; i++)
            {
                if (runningDbg.Contains(debuggers[i]))
                {
                    detected = true;
                    Console.WriteLine("Debugger detected: " + debuggers[i]);
                    return;
                }
            }
        }

    }
}
