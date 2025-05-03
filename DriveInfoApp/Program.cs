using System;
using System.IO;

DriveInfo[] myDrives = DriveInfo.GetDrives();
foreach(DriveInfo d in myDrives)
{
    Console.WriteLine("Name: {0}", d.Name);
    Console.WriteLine("Type: {0}", d.DriveType);
    if (d.IsReady)
    {
        Console.WriteLine("Free Space: {0}", d.TotalFreeSpace);
        Console.WriteLine("Format: {0}", d.DriveFormat);
        Console.WriteLine("Label: {0}", d.VolumeLabel);
    }
}
