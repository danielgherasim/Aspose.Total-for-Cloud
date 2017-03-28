using System;
using Com.Aspose.Storage.Api;
using Com.Aspose.Storage.Model;

namespace Files
{
    class CheckFilePresence
    {
        public static void Run()
        {
            // ExStart:1           
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string Path = "testfile.txt";
            string versionId = null;
            string storage = null;
           
            try
            {
                // Invoke Aspose.Storage Cloud SDK API to check file presence                
                Com.Aspose.Storage.Model.FileExistResponse apiResponse = storageApi.GetIsExist(Path, versionId, storage);
                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine(apiResponse.FileExist.ToString());
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
