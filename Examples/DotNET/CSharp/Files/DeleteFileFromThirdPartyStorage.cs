using System;
using Com.Aspose.Storage.Api;
using Com.Aspose.Storage.Model;

namespace Files
{
    class DeleteFileFromThirdPartyStorage
    {
        public static void Run()
        {
            // ExStart:1           
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string Path = "testfile.txt";
            string versionId = null;
            string storage = "MyStorageName";            
            byte[] file = System.IO.File.ReadAllBytes(Common.GetDataDir() + Path);
            try
            {
                // Invoke Aspose.Storage Cloud SDK API to upload and delete file
                storageApi.PutCreate(Path, versionId, storage, file);
                storageApi.DeleteFile(Path, versionId, storage);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);
            }
            // ExEnd:1
        }
    }
}
