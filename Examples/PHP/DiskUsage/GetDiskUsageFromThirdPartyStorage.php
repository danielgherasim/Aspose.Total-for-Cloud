//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Storage\StorageApi;
use Aspose\Storage\AsposeApp;

class DiskUsage {

	public $storageApi;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->storageApi = new StorageApi();
	}

	public function getDiskUsage() {
        $result = $this->storageApi->GetDiscUsage($storage = "MyDropboxStorage");        
        print_r($result);
	}
}

$diskUsage = new DiskUsage();
$diskUsage->getDiskUsage();

?>
//ExEnd:
