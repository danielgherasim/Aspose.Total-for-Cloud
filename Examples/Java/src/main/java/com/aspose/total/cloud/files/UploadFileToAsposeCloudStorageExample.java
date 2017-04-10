package com.aspose.total.cloud.files;

import java.nio.file.Path;

import com.aspose.storage.api.StorageApi;
import com.aspose.total.cloud.Configuration;
import com.aspose.total.cloud.Utils;

public class UploadFileToAsposeCloudStorageExample {

    public static void main(String[] args) {
      //ExStart: 1
        Path inputFile = Utils.getPath(UploadFileToAsposeCloudStorageExample.class, "testfile.txt");
        System.out.println(inputFile.toFile().getAbsolutePath());
        try
        {
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
            // Upload source file to aspose cloud storage
            storageApi.PutCreate("testfile.txt", "", "",inputFile.toFile());

        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
        //ExEnd: 1

    }

}
