using System;
using Com.Aspose.Storage.Api;
using Com.Aspose.Storage.Model;

namespace Files
{
    class MoveFile
    {
        public static void Run()
        {
            // ExStart:1           
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string Path = "testfile.txt";
            string dest = "new-testfile.txt";
            string versionId = null;
            string storage = null;
            string destStorage = null;        
            byte[] file = System.IO.File.ReadAllBytes(Common.GetDataDir() + Path);
            try
            {
                // Invoke Aspose.Storage Cloud SDK API to upload and move file
                storageApi.PutCreate(Path, versionId, storage, file);
                MoveFileResponse apiResponse  = storageApi.PostMoveFile(Path, dest, versionId, storage, destStorage);
                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("File moved successfully.");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);
            }
            // ExEnd:1
        }
    }
}
