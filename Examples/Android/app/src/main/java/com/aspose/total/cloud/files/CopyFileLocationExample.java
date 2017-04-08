package com.aspose.total.cloud.files;

import com.aspose.storage.api.StorageApi;
import com.aspose.storage.model.ResponseMessage;
import com.aspose.total.cloud.Configuration;

public class CopyFileLocationExample {

    public static void main(String[] args) {
      //ExStart: 1
        try
        {
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
            // Upload source file to aspose cloud storage
            ResponseMessage response=storageApi.PutCopy("testfile.txt","newtestfile.txt", "", "","",null);
            
            if(response!=null && response.getStatus().equals("OK")){
                System.out.println("File Copied");
            }

        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
        //ExEnd: 1
    }
}
