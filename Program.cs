using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LazyScript1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops Program.
            while (true)
            {
                //Gets current users login name
                string userName = Environment.UserName;
                //Gets Directory of Curse Mods Folder
                string destDir = ("C:\\Users\\" + userName + "\\Documents\\Curse\\Minecraft\\Instances\\Tekkit+\\mods\\");
                //promt user to enter jar file location.
                Console.WriteLine("Enter Your jar file location: ");
                string sourceFile = Console.ReadLine();
                //check if jar file can be found.
                if (System.IO.File.Exists(sourceFile))
                {
                    //check if curse mods folder can be found.
                    if (Directory.Exists(destDir))
                    {
                        //try move the file
                        try
                        {
                            File.Copy
                                (sourceFile, destDir + Path.GetFileName(sourceFile));
                            Console.WriteLine("File successfully moved to the mod file: " + Path.GetFileName(sourceFile));
                        }
                        //catch error
                        catch (Exception)
                        {
                            Console.WriteLine("Can't move the source file to the destination file! The file may already exist in the folder." );
                        }
                    }
                    //cannot find mods folder
                    else
                    {
                        Console.WriteLine("Cannot find Mods folder.");
                    }
                }
                //cannot find jar file.
                else
                {
                    Console.WriteLine("Cannot find jar file.");
                }
            }
        }
    }
}
