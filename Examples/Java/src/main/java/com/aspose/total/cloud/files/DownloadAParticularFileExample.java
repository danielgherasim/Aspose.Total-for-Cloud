package com.aspose.total.cloud.files;

import java.io.IOException;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

import com.aspose.storage.api.StorageApi;
import com.aspose.storage.model.ResponseMessage;
import com.aspose.total.cloud.Configuration;

public class DownloadAParticularFileExample {

    public static void main(String[] args) throws IOException {
      //ExStart: 1
        StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
        // Upload source file to aspose cloud storage
        ResponseMessage rm= storageApi.GetDownload("testfile.txt", "", "");
        
        InputStream responseStream = rm.getInputStream();
        final Path destination = Paths.get("testfile.txt");
        Files.copy(responseStream, destination, StandardCopyOption.REPLACE_EXISTING);
        //ExEnd: 1
    }

}
