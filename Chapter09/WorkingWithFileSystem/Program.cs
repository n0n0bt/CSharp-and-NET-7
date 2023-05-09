﻿using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;


WriteLine("Welcome");

SectionTitle("Handling cross-platform enviorments and file systems");
WriteLine("{0,-39} {1}", arg0: "Path.Separator", arg1: PathSeparator);
WriteLine("{0,-39} {1}", arg0: "Path.DirectorySeparatorChar", arg1: DirectorySeparatorChar);
WriteLine("{0,-39} {1}", arg0: "Path.Directory.GetCurrentDirectory()", arg1: GetCurrentDirectory());
WriteLine("{0,-39} {1}", arg0: "Enviorment.CurrentDirectory", arg1: CurrentDirectory);
WriteLine("{0,-39} {1}", arg0: "Enviorment.SystemDirectory", arg1: CurrentDirectory);
WriteLine("{0,-39} {1}", arg0: "Path.GetTempPath()", arg1: GetTempPath());
WriteLine("GetFolderPath(SpecialFolder");
WriteLine("{0,-39} {1}", arg0: " .System", arg1: SpecialFolder.System);
WriteLine("{0,-39} {1}", arg0: " .ApplicationData", arg1: SpecialFolder.ApplicationData);
WriteLine("{0,-39} {1}", arg0: " .MyDocuments", arg1: SpecialFolder.MyDocuments);
WriteLine("{0,-39} {1}", arg0: " .Personal", arg1: SpecialFolder.Desktop);



SectionTitle("Managing drives");
WriteLine("{0,-30} | {1,-10} | {2,-7} | {3,18} | {4,18}",
"NAME", "TYPE", "FORMAT", "SIZE (BYTES)", "FREE SPACE");
foreach (DriveInfo drive in DriveInfo.GetDrives())
{
    if (drive.IsReady)
    {
        WriteLine(
        "{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}",
        drive.Name, drive.DriveType, drive.DriveFormat,
        drive.TotalSize, drive.AvailableFreeSpace);
    }
    else
    {
        WriteLine("{0,-30} | {1,-10}", drive.Name, drive.DriveType);
    }
}

SectionTitle("Maniging directories");
string newFolder = Combine(GetFolderPath(SpecialFolder.Personal), "NewFolder");

WriteLine($"Working with: {newFolder}");

WriteLine($"Does it exist? {Path.Exists(newFolder)}");

WriteLine("Creating it...");
CreateDirectory(newFolder);
WriteLine($"Does it exist? {Path.Exists(newFolder)}");

Write("Confirm the directory exists, and then pres ENTER:");
ReadLine();

WriteLine("Deliting it...");

Delete(newFolder, recursive: true);
WriteLine($"Does it exists? {Path.Exists(newFolder)}");
///////////////////////////////////////////////////////////////////////////

SectionTitle("Managing files");
// define a directory path to output files
// starting in the user's folder
string dir = Combine(
GetFolderPath(SpecialFolder.Personal), "OutputFiles");
CreateDirectory(dir);

string textFile = Combine(dir, "Dummy.txt");
string backupFile = Combine(dir, "Dummy.bak");

WriteLine($"Working with: {textFile}");

WriteLine($"Does it exists? {File.Exists(textFile)}");
// create a new file 
StreamWriter textWriter = File.CreateText(textFile);
textWriter.WriteLine("Hello, C#!");
textWriter.Close();
WriteLine($"Does it exists? {File.Exists(textFile)}");

File.Copy(sourceFileName: textFile, destFileName: backupFile, overwrite: true);

WriteLine($"Does {backupFile} exists? {File.Exists(backupFile)}");

Write("Confirm the files exists, and then press ENTER:");
ReadLine();

File.Delete(textFile);
WriteLine($"Does it exists? {File.Exists(textFile)}");

WriteLine($"Reading contents of {backupFile}:");
StreamReader textReader = File.OpenText(backupFile);
WriteLine(textReader.ReadToEnd());
textReader.Close();

/////////////////////////////////////////////////////////////////////


SectionTitle("Managing paths");
WriteLine($"Folder Name: {GetDirectoryName(textFile)}");
WriteLine($"File Name: {GetFileName(textFile)}");
WriteLine("File Name without Extension: {0}",
GetFileNameWithoutExtension(textFile));
WriteLine($"File Extension: {GetExtension(textFile)}");
WriteLine($"Random File Name: {GetRandomFileName()}");
WriteLine($"Temporary File Name: {GetTempFileName()}");


string root = GetParent(GetParent(GetCurrentDirectory()).Parent.FullName).FullName;
string myFileCs = Combine(root, "MyFile.cs");
WriteLine($"Does MyFile exist? {File.Exists(myFileCs)}");
StreamWriter myFileCsWriter = File.CreateText(myFileCs);
myFileCsWriter.WriteLine($"namespace WorkingWithFileSystems {System.Environment.NewLine} {{ {System.Environment.NewLine} internal class MyFile {System.Environment.NewLine} {{ {System.Environment.NewLine}}} {System.Environment.NewLine} }}");
myFileCsWriter.Close();

SectionTitle("Getting file information");
FileInfo info = new(myFileCs);
WriteLine($"{myFileCs}:");
WriteLine($"Contains {info.Length} bytes");
WriteLine($"Last accessed {info.LastAccessTime}");
WriteLine($"Has readonly set to {info.IsReadOnly}");

/////////////////////////////////////////////////////////////////////////////////

string myFileInfoTest = @"C:\Users\Privat\Documents\Visual Studio 2022\Visualizers\attribcache140.bin";

FileInfo myFileInfo = new FileInfo(myFileInfoTest);

WriteLine($"{myFileInfo}:");
WriteLine($"Contains {myFileInfo.Length} bytes");
WriteLine($"Last accessed {myFileInfo.LastAccessTime}");
WriteLine($"Has readonly set to {myFileInfo.IsReadOnly}");
