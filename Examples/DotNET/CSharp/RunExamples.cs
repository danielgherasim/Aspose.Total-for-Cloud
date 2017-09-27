using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using Folders;
using Files;
using DiskUsage;

namespace CSharp
{
    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the one you want to try out

            //// =====================================================
            //// =====================================================
            //// Folders
            //// =====================================================
            //// =====================================================

            //CreateFolder.Run();
            //CreateFolderOnThirdParty.Run();
            //DeleteFolder.Run();
            //DeleteFolderFromThirdParty.Run();

            //// =====================================================
            //// =====================================================
            //// Files
            //// =====================================================
            //// =====================================================

            UploadFile.Run();
            //UploadFileToThirdPartyStorage.Run();
            //DeleteFile.Run();
            //DeleteFileFromThirdPartyStorage.Run();
            //GetListFiles.Run();
            DownloadFile.Run();
            //CheckFilePresence.Run();
            //MoveFile.Run();
            //CopyFile.Run();

            //// =====================================================
            //// =====================================================
            //// DiskUsage
            //// =====================================================
            //// =====================================================

            //GetDiskUsage.Run();
            //GetDiskUsageFromThirdPartyStorage.Run();            
            
            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }
        
    }
}
