package com.aspose.total.cloud.files;

import android.content.Context;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import com.aspose.storage.api.StorageApi;
import com.aspose.total.cloud.Configuration;
import com.aspose.total.cloud.R;
import org.apache.commons.io.IOUtils;

public class UploadFileToAsposeCloudStorageExample {

    public static void execute(Context context) {
      //ExStart: 1
        try
        {
            File f=stream2file("testfile","txt",context.getResources().openRawResource(R.raw.testfile));
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
            // Upload source file to aspose cloud storage
            storageApi.PutCreate("testfile.txt", "", "",f);
            System.out.println("file created");

        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
        //ExEnd: 1

    }


    private  static File stream2file (final String PREFIX, final String SUFFIX, InputStream in) throws IOException {
        final File tempFile = File.createTempFile(PREFIX, SUFFIX);
        tempFile.deleteOnExit();
        try (FileOutputStream out = new FileOutputStream(tempFile)) {
            IOUtils.copy(in, out);
        }
        return tempFile;
    }


}
