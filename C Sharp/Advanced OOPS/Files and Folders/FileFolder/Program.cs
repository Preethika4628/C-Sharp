using System;
using System.IO;
namespace FileFolder;
class Program
{
    public static void Main(string[] args)
    {
        string path = @"D:\C Sharp - Programs\Advanced OOPS\Files and Folders\MyFolder";
        string folderpath = path + "/Preethika";
        if (!Directory.Exists(folderpath))
        {
            Console.WriteLine("Creating folder..");
            Directory.CreateDirectory(folderpath);
        }
        else
        {
            Console.WriteLine("Folder already exists");
        }

        string filePath = path + "\\myfile.txt";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Creating file..");
            File.Create(filePath);
        }
        else
        {
            Console.WriteLine("File already exists");
        }

        Console.WriteLine("Select:  1.Create folder  2.Create file  3.Delete folder  4.Delete file");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                {
                    Console.Write("Enter the folder name you want to create: ");
                    string folder = Console.ReadLine();
                    string newPath = path + "/" + folder;
                    if (!Directory.Exists(newPath))
                    {
                        Console.WriteLine("Creating folder " + folder);
                        Directory.CreateDirectory(newPath);
                    }
                    else
                    {
                        Console.WriteLine("Directory already exists");
                    }
                    break;
                }
            case 2:
                {
                    Console.Write("Enter the file name: ");
                    string filename = Console.ReadLine();
                    Console.Write("Enter the file extension: ");
                    string extension = Console.ReadLine();
                    string newFilePath = path + "/" + filename + "." + extension;
                    if (!File.Exists(newFilePath))
                    {
                        Console.WriteLine("Creating file " + filename + "." + extension);
                        File.Create(newFilePath);
                    }
                    else
                    {
                        Console.WriteLine("File already exists");
                    }
                    break;
                }
            case 3:
                {
                    foreach (string path1 in Directory.GetDirectories(path))
                    {
                        Console.WriteLine(path1);
                    }
                    Console.Write("Select the folder you wish to remove: ");
                    string  folder1 = Console.ReadLine();
                    foreach(string path1 in Directory.GetDirectories(path))
                    {
                        if(path1.Contains(folder1))
                        {
                            Directory.Delete(path1);
                            Console.WriteLine("Removed folder " + folder1);
                        }
                    }
                    break;
                }
            case 4:
            {
                foreach(string file1 in Directory.GetFiles(path))
                {
                    Console.WriteLine(file1);
                }
                Console.Write("Enter file name and extension to be removed: ");
                string file2 = Console.ReadLine();
                foreach(string file1 in Directory.GetFiles(path))
                {
                    if(file1.Contains(file2))
                    {
                        Console.WriteLine("Removing file " + file2);
                        File.Delete(file2);
                    }
                }
                break;
            }
        }
    }
}