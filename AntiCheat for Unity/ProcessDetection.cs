
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AntiCheat
{
    class ProcessDetection
    {
        public static bool detected;

        public static List<string> running = new List<string>();
        public static string[] badProcess = { "cheatengine", "Cheat", "artmoney", "gametrainerstudio", "cheatbuddy", "cheathappens", "aimbot", "wallhack" };

        public static string thisProcess = AppDomain.CurrentDomain.FriendlyName;
        public static void UptProcess()
        {
            Process[] process = Process.GetProcesses();
            foreach (Process run in process)
            {
                running.Add(run.ProcessName);
            }
        }
        public static void FindProcess()
        {
            foreach (string processName in running)
            {
                if (processName != thisProcess)
                {
                    for (int i = 0; i < badProcess.Length; i++)
                    {
                        if (processName != thisProcess)
                        {
                            if (processName.Contains(badProcess[i]))
                            {
                                detected = true;
                                Console.WriteLine("\nCheat detected: " + badProcess[i]);
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
