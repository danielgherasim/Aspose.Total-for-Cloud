package com.aspose.total.cloud.files;

import android.content.Context;

import com.aspose.storage.api.StorageApi;
import com.aspose.storage.model.FileExistResponse;
import com.aspose.total.cloud.Configuration;

public class CheckPresenceOfFileExample {

    public static void execute(Context context) {
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
