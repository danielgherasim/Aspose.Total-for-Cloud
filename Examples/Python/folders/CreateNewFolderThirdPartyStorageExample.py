import asposestoragecloud
from asposestoragecloud.StorageApi import StorageApi
from asposestoragecloud.ApiClient import ApiException
from asposestoragecloud.models import FileExistResponse

apiKey = "b125f13bf6b76ed81ee990142d841195"  # sepcify App Key
appSid = "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9"  # sepcify App SID
apiServer = "http://api.aspose.com/v1.1"
data_folder = "../../../data/"


try:
    # Instantiate Aspose Storage API SDK
    storage_apiClient = asposestoragecloud.ApiClient.ApiClient(apiKey, appSid, True)
    storageApi = StorageApi(storage_apiClient)
  
    
    # upload file to aspose cloud storage
    response = storageApi.PutCreateFolder("newfolder")
    

    if response.Status == "OK":
        print("Folder Created  " + response.Status)


except ApiException as ex:
    print ("ApiException:")
    print ("Code:" + str(ex.code))
    print ("Message:" +ex.message)


