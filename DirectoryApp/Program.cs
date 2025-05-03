using System;
using System.IO;
using System.Security.AccessControl;

Console.WriteLine("***** Fun with Directory(Info) *****");
// ShowWindowsDirectoryInfo();
// DisplayImageFiles();
// ModifyAppDirectory();
FunWithDirectoryType();

static void ShowWindowsDirectoryInfo()
{
    DirectoryInfo dir = new($@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Windows");
    Console.WriteLine("***** Directory Info *****");
    Console.WriteLine("FullName: {0}", dir.FullName);
    Console.WriteLine("Name: {0}", dir.Name);
    Console.WriteLine("Parent: {0}", dir.Parent);
    Console.WriteLine("Creation: {0}", dir.CreationTime);
    Console.WriteLine("Attributes: {0}", dir.Attributes);
    Console.WriteLine("Root: {0}", dir.Root);
    Console.WriteLine("*******************");
}

static void DisplayImageFiles()
{
    DirectoryInfo dir = new(@"C:\Windows\Web\Wallpaper");
    FileInfo[] imageFiles =
    dir.GetFiles("*.jpg", SearchOption.AllDirectories);
    Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);
    foreach (FileInfo f in imageFiles)
    {
        Console.WriteLine("*******************");
        Console.WriteLine("File name: {0}", f.Name);
        Console.WriteLine("File size: {0}", f.Length);
        Console.WriteLine("Creation: {0}", f.CreationTime);
        Console.WriteLine("Attributes: {0}", f.Attributes);
        Console.WriteLine("*******************");
    }
}

static void ModifyAppDirectory()
{
    DirectoryInfo dir = new DirectoryInfo(".");
    // dir.CreateSubdirectory("MyFolder");
    DirectoryInfo myDataFolder = dir.CreateSubdirectory($@"MyFolder2{Path.DirectorySeparatorChar}Data");
    Console.WriteLine("New Folder is: {0}", myDataFolder);
}

static void FunWithDirectoryType()
{
    string[] drives = Directory.GetLogicalDrives();
    Console.WriteLine("Here are your drives:");
    foreach (string s in drives)
    {
        Console.WriteLine("--> {0}", s);
    }
    Console.WriteLine("Press Enter to delete directories:");
    Console.ReadLine();
    DirectoryInfo dir = new("./MyFolder");
    GC.Collect();

    try
    {
        DirectorySecurity dirSecurity = dir.GetAccessControl();
        dirSecurity.AddAccessRule(new FileSystemAccessRule(System.Security.Principal.WindowsIdentity.GetCurrent().Name, FileSystemRights.Delete, AccessControlType.Allow));
        dir.Delete();
    }
    catch (IOException e)
    {
        Console.WriteLine(e.Message);
    }
}