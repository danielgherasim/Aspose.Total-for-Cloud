using System;
using Com.Aspose.Storage.Api;
using Com.Aspose.Storage.Model;

namespace Files
{
    class GetListFilesFromThirdPartyStorage
    {
        public static void Run()
        {
            // ExStart:1           
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string Path = "files";
            string storage = "MyStorageName"; 
            try
            {
                // Invoke Aspose.Storage Cloud SDK API to get list of files
                ResponseMessage apiResponse = storageApi.GetListFiles(Path, storage);
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
