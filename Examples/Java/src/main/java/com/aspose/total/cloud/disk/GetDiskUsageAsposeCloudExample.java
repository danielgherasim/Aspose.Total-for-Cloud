package com.aspose.total.cloud.disk;

import com.aspose.storage.api.StorageApi;
import com.aspose.storage.model.DiscUsageResponse;
import com.aspose.total.cloud.Configuration;

public class GetDiskUsageAsposeCloudExample {

    public static void main(String[] args) {
        //ExStart: 1
        try {
            StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
            DiscUsageResponse apiResponse = storageApi.GetDiscUsage("MyStorage");
            if (apiResponse != null && apiResponse.getStatus().equals("OK")) {
                System.out.println("Total Size (bytes): " + apiResponse.getDiscUsage().getTotalSize());
                System.out.println("Used Size (bytes): " + apiResponse.getDiscUsage().getUsedSize());
            }

        } catch (Exception ex) {
            ex.printStackTrace();
        }
        //ExEnd: 1
    }
}
