//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Storage\StorageApi;
use Aspose\Storage\AsposeApp;

class Folder {

	public $storageApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->storageApi = new StorageApi();
	}

	public function deleteFolder() {
		// First create folder
		$result = $this->storageApi->PutCreateFolder($Path="testfolder", $storage = null, $destStorage = null);

		// Now delete folder
        $result = $this->storageApi->DeleteFolder($Path="testfolder", $storage = null, $recursive = null);
        print_r($result);
	}
}

$folder = new Folder();
$folder->deleteFolder();

?>
//ExEnd:
