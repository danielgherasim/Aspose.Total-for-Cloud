using System;
using Com.Aspose.Storage.Api;
using Com.Aspose.Storage.Model;

namespace Files
{
    class CopyFile
    {
        public static void Run()
        {
            // ExStart:1           
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string Path = "testfile.txt";
            string newdest = "new-testfile.txt";            
            string versionId = null;
            string storage = null;
            string destStorage = null;        
            byte[] file = System.IO.File.ReadAllBytes(Common.GetDataDir() + Path);
            try
            {
                // Invoke Aspose.Storage Cloud SDK API to upload and copy file
                storageApi.PutCreate(Path, versionId, storage, file);
                ResponseMessage apiResponse = storageApi.PutCopy(Path, newdest, versionId, storage, destStorage,null);
                if (apiResponse != null && apiResponse.Status.Equals("Ok"))
                {
                    Console.WriteLine(apiResponse.Message);
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
