## Aspose.Storage Cloud SDK for NodeJS



## How to use the SDK?
The complete source code is available in this repository folder. For more details, please visit our [documentation website](http://www.aspose.com/docs/display/totalcloud/How+to+Setup+Aspose.Storage+Cloud+SDK+for+Node.js).

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
