//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Storage\StorageApi;
use Aspose\Storage\AsposeApp;

class Files {

	public $storageApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->storageApi = new StorageApi();
	}

	public function deleteFile() {
		// Upload file to Aspose Cloud Storage
		$fileName = "testfile.txt";
		Utils::uploadFile($fileName);

        $result = $this->storageApi->DeleteFile($Path=$fileName, $versionId = null, $storage = "MyDropboxStorage");
        print_r($result);
	}
}

$files = new Files();
$files->deleteFile();

?>
//ExEnd:
