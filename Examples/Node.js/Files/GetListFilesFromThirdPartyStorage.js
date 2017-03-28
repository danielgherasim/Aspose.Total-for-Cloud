// ExStart:1
var fs = require('fs');
var assert = require('assert');
var StorageApi = require('asposestoragecloud');
var configProps = require('../config/config.json');
var data_path = '../../../Data/';

var AppSID = configProps.app_sid;
var AppKey = configProps.api_key;
var outFolder = configProps.out_folder;
var config = {'appSid':AppSID,'apiKey':AppKey , 'debug' : true};

// Instantiate Aspose Storage API SDK
var storageApi = new StorageApi(config);

try {	
	storageApi.GetListFiles(Path='files', storage='MyStorageName', function(responseMessage) {
		console.log('status:', responseMessage.status);
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1