using System;
using Com.Aspose.Storage.Api;
using Com.Aspose.Storage.Model;

namespace Folders
{
    class CreateFolder
    {
        public static void Run()
        {
            // ExStart:1           
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            string Path = "testfolder";
            string storage = null;
            string destStorage = null;   
            try
            {
                // Invoke Aspose.Storage Cloud SDK API to create folder
                storageApi.PutCreateFolder(Path, storage, destStorage);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);
            }
            // ExEnd:1
        }
    }
}
