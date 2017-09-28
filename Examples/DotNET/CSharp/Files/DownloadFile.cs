using System;
using Com.Aspose.Storage.Api;
using Com.Aspose.Storage.Model;

namespace Files
{
    class DownloadFile
    {
        public static void Run()
        {
            // ExStart:1           
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string Path = "Book1.xlsx";
            string versionId = null;
            string storage = null;            
            byte[] file = System.IO.File.ReadAllBytes(Common.GetDataDir() + Path);
            try
            {
                // Invoke Aspose.Storage Cloud SDK API to upload and download file
                storageApi.PutCreate(Path, versionId, storage, file);
                Com.Aspose.Storage.Model.ResponseMessage storageRes = storageApi.GetDownload(Path, versionId, storage);                
                System.Diagnostics.Debug.WriteLine("response:" + storageRes.ResponseStream);
                System.IO.File.WriteAllBytes(Common.GetDataDir() + Path, storageRes.ResponseStream);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);
            }
            // ExEnd:1
        }
    }
}
