# Aspose.Storage Cloud SDK for NodeJS

This repository contains Aspose.Storage Cloud SDK for NodeJS source code. This SDK allows you to work with Aspose.Storage Cloud REST APIs in your NodeJS applications quickly and easily. 

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