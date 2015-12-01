using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Com.Aspose.Storage.Api;

namespace AsposeStorage
{
    class Storage
    {
        public static void Main(String[] args){

            try
            {
                System.Diagnostics.Debug.WriteLine("\n\nFetching the results...");
                StorageApi storageApi = new StorageApi("xxx", "xxx", "http://api.aspose.com/v1.1");

                string fileName = "test_multi_pages.docx";

                System.Diagnostics.Debug.WriteLine(storageApi.PutCreate(fileName,null, null, System.IO.File.ReadAllBytes("\\temp\\"+fileName)));

                //storageApi.PutCreate(fileName, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + fileName));

                ////System.Diagnostics.Debug.WriteLine(storageApi.GetDownload(fileName, null, null)+"\n\nthese were the file contents");


                byte[] responseStream = storageApi.GetDownload(fileName, null, null).ResponseStream;
                System.IO.File.WriteAllBytes("\\temp\\new_" + fileName, responseStream);

                //System.Diagnostics.Debug.WriteLine(storageApi.GetListFiles("", ""));

                //System.IO.File.WriteAllBytes("\\temp\\new_" + fileName, System.IO.File.ReadAllBytes("\\temp\\"+fileName));

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("\nError:"+ex.Message+"\n" + ex.StackTrace + "\n");
            }
        }
    }
}

