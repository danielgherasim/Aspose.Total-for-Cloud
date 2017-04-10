package com.aspose.total.cloud;

import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import com.aspose.total.cloud.files.CheckPresenceOfFileExample;
import com.aspose.total.cloud.files.UploadFileToAsposeCloudStorageExample;

import java.net.URL;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        new RetrieveFeedTask().execute();

    }


    class RetrieveFeedTask extends AsyncTask<Void, Void, Integer> {

        private Exception exception;

        protected Integer doInBackground(Void... urls) {
            UploadFileToAsposeCloudStorageExample.execute(MainActivity.this);
            return 1;
        }

        protected void onPostExecute(Void feed) {

        }
    }

}
