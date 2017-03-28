using System;
using Com.Aspose.Storage.Api;
using Com.Aspose.Storage.Model;

namespace DiskUsage
{
    class GetDiskUsage
    {
        public static void Run()
        {
            // ExStart:1           
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);           
            string storage = "MyStorageName";            
            try
            {
                // Invoke Aspose.Storage Cloud SDK API to get disc usage
               DiscUsageResponse apiResponse = storageApi.GetDiscUsage(storage);
               if (apiResponse != null && apiResponse.Status.Equals("OK"))
               {
                   Console.WriteLine("Total Size (bytes): " + apiResponse.DiscUsage.TotalSize);
                   Console.WriteLine("Used Size (bytes): " + apiResponse.DiscUsage.UsedSize);
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
