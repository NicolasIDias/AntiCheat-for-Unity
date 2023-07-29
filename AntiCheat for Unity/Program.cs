namespace AntiCheat { 
class Program
{
    private static Thread thread;
    static void Main(String[] args)
    {
        thread = new Thread(ConsoleThread);
        thread.Name = "Anti Cheat";
        thread.Start();
    }
    public static void ConsoleThread()
    {
        while (true)
        {
            ProcessDetection.UptProcess();
            ProcessDetection.FindProcess();
            DebuggerDetection.detectDebugger();
            Thread.Sleep(3000);
        }
    }
}
}
