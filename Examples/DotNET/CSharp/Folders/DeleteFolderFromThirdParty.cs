using System;
using Com.Aspose.Storage.Api;
using Com.Aspose.Storage.Model;

namespace Folders
{
    class DeleteFolderFromThirdParty
    {
        public static void Run()
        {
            // ExStart:1           
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            string Path = "testfolder";
            string storage = "MyStorageName";
            string destStorage = null;
            bool recursive = false;
            try
            {
                // Invoke Aspose.Storage Cloud SDK API to create and delete folder
                storageApi.PutCreateFolder(Path, storage, destStorage);
                storageApi.DeleteFolder(Path, storage, recursive);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);
            }
            // ExEnd:1
        }
    }
}
