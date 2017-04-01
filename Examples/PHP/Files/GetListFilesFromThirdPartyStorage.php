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

	public function getListFiles() {
        $result = $this->storageApi->GetListFiles($Path = "Files", $storage = "MyDropboxStorage");
        print_r($result);
	}
}

$files = new Files();
$files->getListFiles();

?>
//ExEnd:
