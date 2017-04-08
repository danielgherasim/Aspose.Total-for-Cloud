package com.aspose.total.cloud.files;

import com.aspose.storage.api.StorageApi;
import com.aspose.storage.model.FileExistResponse;
import com.aspose.total.cloud.Configuration;

public class CheckPresenceOfFileExample {

    public static void main(String[] args) {
      //ExStart: 1
        try
        {
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
            // Upload source file to aspose cloud storage
            FileExistResponse response=storageApi.GetIsExist("testfile.txt", "", "");
            
            if(response!=null && response.getFileExist().getIsExist()){
                System.out.println("File Exists");
            }

        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
        //ExEnd: 1
    }
}
