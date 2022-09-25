using System.Net;
using System.Windows.Forms;
using System.IO.Compression;
using System.Linq.Expressions;
using System.Diagnostics;
using System.Xml.Linq;

namespace Grass
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            ApplicationConfiguration.Initialize();
            
            Application.Run(new Mower());

           

                
            


            // Specifies the directory to be created.
            string path = @"GrasscutterServer\Grasscutter-development";
            
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                // Delete the directory.
                di.Delete();
                Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }


        }




    }
}