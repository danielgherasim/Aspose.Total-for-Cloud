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

	public function downloadFile() {
		// Upload file to Aspose Cloud Storage
		$fileName = "AutoFilter.xlsx";
		//Utils::uploadFile($fileName);

		$result = $this->storageApi->GetDownload($Path=$fileName, $versionId = null, $storage = null);
        $fh = fopen(realpath(__DIR__ . '/../../..'). '/Data/Output/test_cells.xlsx', 'w');
        fwrite($fh, $result);
        fclose($fh);
	}
}

$files = new Files();
$files->downloadFile();

?>
//ExEnd: