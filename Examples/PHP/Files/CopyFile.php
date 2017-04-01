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

	public function copyFile() {
		// Upload file to Aspose Cloud Storage
		$fileName = "testfile.txt";
		//Utils::uploadFile($fileName);

		$file = realpath(__DIR__ . '/../../..') . '/Data/' . $fileName;
        $result = $this->storageApi->PutCopy($Path=$fileName, $newdest="copy-testfile.txt", $versionId = null, $storage = null, $destStorage = null, $file);
        print_r($result);
	}
}

$files = new Files();
$files->copyFile();

?>
//ExEnd: