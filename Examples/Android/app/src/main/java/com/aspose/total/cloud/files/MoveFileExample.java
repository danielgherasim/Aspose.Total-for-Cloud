package com.aspose.total.cloud.files;

import com.aspose.storage.api.StorageApi;
import com.aspose.storage.model.MoveFileResponse;
import com.aspose.total.cloud.Configuration;

public class MoveFileExample {

    public static void main(String[] args) {
      //ExStart: 1
        try
        {
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
            // Upload source file to aspose cloud storage
            MoveFileResponse response=storageApi.PostMoveFile("testfile.txt","newtestfile.txt", "", "","");
            
            if(response!=null && response.getStatus().equals("OK")){
                System.out.println("File Moved");
            }

        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
        //ExEnd: 1

    }

}
