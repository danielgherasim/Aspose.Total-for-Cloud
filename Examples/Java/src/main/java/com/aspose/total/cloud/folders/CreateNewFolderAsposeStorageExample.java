package com.aspose.total.cloud.folders;

import com.aspose.storage.api.StorageApi;
import com.aspose.total.cloud.Configuration;

public class CreateNewFolderAsposeStorageExample {

    public static void main(String[] args) {
      //ExStart: 1
     // For complete examples and data files, please go to https://github.com/aspose-total/Aspose.Total-for-Cloud
        StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
        String Path = "testfolder";
        String storage = null;
        String destStorage = null;   
        try
        {
            // Invoke Aspose.Storage Cloud SDK API to create folder
            storageApi.PutCreateFolder(Path, storage, destStorage);
        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
        //ExEnd: 1
       
    }

}
