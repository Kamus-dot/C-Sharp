using System;
using System.Collections;
using System.Linq;
using System.Diagnostics;

Console.WriteLine("***** Fun With Processes *****");
ListAllProcesses();
GetSpecificProcess();
EnumThreadsForPid(13852);
EnumModsForPid(10340);
// StartAndKillProcess();
// StartAndKillProcess2();
UseApplicationVerbs();
static void ListAllProcesses()
{
    var runningProcs = from proc in Process.GetProcesses(".")
                       orderby proc.Id
                       select proc;
    // Вывести для каждого процесса идентификатор PID и имя.
    foreach (var p in runningProcs)
    {
        string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
        Console.WriteLine(info);
    }
    Console.WriteLine("**************\n");
}
static void GetSpecificProcess()
{
    Process theProc = null;
    try
    {
        theProc = Process.GetProcessById(20680);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
}
static void EnumThreadsForPid(int pID)
{
    Process theProc = null;
    try
    {
        theProc = Process.GetProcessById(pID);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
        return;
    }
    // Вывести статистические сведения по каждому потоку в указанном процессе
    Console.WriteLine("Here are the threads used by: {0}", theProc.ProcessName);
    ProcessThreadCollection theThreads = theProc.Threads;
    foreach (ProcessThread pt in theThreads)
    {
        string info = $"-> Thread ID: {pt.Id} \tStart Time: {pt.StartTime.ToShortTimeString}, Priority: {pt.PriorityLevel}";
        Console.WriteLine(info);
    }
    Console.WriteLine("**********************\n");
}
static void EnumModsForPid(int pID)
{
    Process theProc = null;
    try
    {
        theProc = Process.GetProcessById(pID);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }
    Console.WriteLine("Here are the loaded modules for: {0}",
    theProc.ProcessName);
    ProcessModuleCollection theMods = theProc.Modules;
    foreach (ProcessModule pm in theMods)
    {
        string info = $"-> Mod Name: {pm.ModuleName}";
        Console.WriteLine(info);
    }
    Console.WriteLine("************************************\n");
}
static void StartAndKillProcess()
{
    Process proc = null;
    try
    {
        proc = Process.Start(@"C:\Program Files (x86)/Microsoft/Edge/Application/msedge.exe");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.WriteLine($"-> Hit Enter to kill {proc.ProcessName}");
    Console.ReadLine();
    try
    {
        foreach (var p in Process.GetProcessesByName("MsEdge"))
        {
            p.Kill(true);
        }
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void StartAndKillProcess2()
{
    Process proc = null;
    try
    {
        ProcessStartInfo startInfo = new ProcessStartInfo("MsEdge", "www.twitch.tv");
        startInfo.UseShellExecute = true;
        proc = Process.Start(startInfo);
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void UseApplicationVerbs()
{
    int i = 0;
    ProcessStartInfo si = new ProcessStartInfo(@"c:\Users\Алексей\OneDrive\Документы\C^N explanatory note (автовосстановление).docx");
    foreach (var verb in si.Verbs)
    {
        Console.WriteLine($"{i++}.{verb}");
    }
    si.WindowStyle = ProcessWindowStyle.Maximized;
    si.Verb = "Edit";
    si.UseShellExecute = true;
    Process.Start(si);
}
