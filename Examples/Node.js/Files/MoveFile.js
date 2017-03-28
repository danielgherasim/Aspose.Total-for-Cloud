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

var name = 'testfile.txt';	
var dest = 'new-testfile.txt';

try {	
	storageApi.PutCreate(name, versionId=null, storage=null, file= data_path + name , function(responseMessage) {
		assert.equal(responseMessage.status, 'OK', '');
		storageApi.PostMoveFile(name, dest, versionId=null, storage=null, destStorage=null,function(responseMessage) {
			console.log('status:', responseMessage.status);
		});
	});    

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1