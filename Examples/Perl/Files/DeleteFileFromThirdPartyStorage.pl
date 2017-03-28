#ExStart:1
use lib 'lib';
use strict;
use warnings;
use utf8;
use File::Slurp; # From CPAN
use JSON;

use AsposeStorageCloud::StorageApi;
use AsposeStorageCloud::ApiClient;
use AsposeStorageCloud::Configuration;

my $configFile = '../Config/config.json';
my $configPropsText = read_file($configFile);
my $configProps = decode_json($configPropsText);
my $data_path = '../../../Data/';
my $out_path = $configProps->{'out_folder'};

$AsposeStorageCloud::Configuration::app_sid = $configProps->{'app_sid'};
$AsposeStorageCloud::Configuration::api_key = $configProps->{'api_key'};

# Instantiate Aspose.Storage Cloud API SDK
my $storageApi = AsposeStorageCloud::StorageApi->new();

# Invoke Aspose.Storage Cloud SDK API to delete file from third party storage  
my $storage = 'MySorageName';    		                           
my $response = $storageApi->PutCreate(Path => 'testfile.txt', file => $data_path.'testfile.txt', Storage =>$storage);
$response = $storageApi->DeleteFile(Path => 'testfile.txt', Storage =>$storage);
print $response->{'Status'};
#ExEnd:1