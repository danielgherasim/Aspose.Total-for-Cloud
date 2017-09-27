using System;
using Com.Aspose.Storage.Api;
using Com.Aspose.Storage.Model;

namespace Files
{
    class UploadFile
    {
        public static void Run()
        {
            // ExStart:1           
           StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

           string Path = "Rendering.docx";
            string versionId = null;
            string storage = null;            
            byte[] file = System.IO.File.ReadAllBytes(Common.GetDataDir() + Path);
            try
            {               
                // Invoke Aspose.Storage Cloud SDK API to upload file
                storageApi.PutCreate(Path, versionId, storage, file); 
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);
            }
            // ExEnd:1
        }
    }
}
