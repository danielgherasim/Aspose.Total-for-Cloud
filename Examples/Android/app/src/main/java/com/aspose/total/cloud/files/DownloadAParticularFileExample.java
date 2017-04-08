package com.aspose.total.cloud.files;

import java.io.BufferedOutputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import com.aspose.storage.api.StorageApi;
import com.aspose.storage.model.ResponseMessage;
import com.aspose.total.cloud.Configuration;

import org.apache.commons.io.IOUtils;

public class DownloadAParticularFileExample {

    public static void main(String[] args) throws Exception {
      //ExStart: 1
        StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
        // Upload source file to aspose cloud storage
        ResponseMessage rm= storageApi.GetDownload("testfile.txt", "", "");
        InputStream responseStream = rm.getInputStream();
        writeToFile(responseStream);
        //ExEnd: 1
    }



    static void writeToFile(InputStream in) throws Exception{
        String path = "file.txt";
        OutputStream stream = new BufferedOutputStream(new FileOutputStream(path));
        int bufferSize = 1024;
        byte[] buffer = new byte[bufferSize];
        int len = 0;
        while ((len = in.read(buffer)) != -1) {
            stream.write(buffer, 0, len);
        }
        if(stream!=null)
            stream.close();
    }

}
