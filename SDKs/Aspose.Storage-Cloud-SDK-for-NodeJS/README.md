## Aspose.Storage Cloud SDK for NodeJS

This repository contains Aspose.Storage for Cloud Java NodeJS source code. This SDK allows you to work with Aspose.Storage for Cloud REST APIs in your NodeJS applications quickly and easily.
<p align="center">
  <a title="Download complete Aspose.Tasks for Cloud source code" href="https://github.com/asposetasks/Aspose_tasks_Cloud/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

## How to use the SDK?
The complete source code is available in this repository folder. For more details, please visit our [documentation website](http://www.aspose.com/docs/display/totalcloud/Available+SDKs).



## Quick SDK Tutorial
```javascript
var StorageApi =require("asposestoragecloud")

var AppSID = 'XXX';
var AppKey = 'XXX';

var config = {'appSid':AppSID,'apiKey':AppKey};

//Instantiate Aspose.Storage API SDK
var storageApi = new StorageApi(config);

//invoke Aspose.Storage Cloud SDK API to get Disc Usage
storageApi.GetDiscUsage('', function(responseMessage) {
	console.log('status:', responseMessage.status);
	console.log('body:', responseMessage.body);
	console.log('DiscUsage:', responseMessage.body.DiscUsage.UsedSize);	
});
```

##Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://www.aspose.com/community/forums/).
