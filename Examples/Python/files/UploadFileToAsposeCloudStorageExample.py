import asposestoragecloud
from asposestoragecloud.StorageApi import StorageApi
from asposestoragecloud.ApiClient import ApiException
from asposestoragecloud.models import FileExistResponse

apiKey = "a165298dc077f8852d5eb6e5bf49310d"  # sepcify App Key
appSid = "1c7a12ca-efa8-466e-b83d-234d9d5e2309"  # sepcify App SID
apiServer = "http://api.aspose.com/v1.1"
data_folder = ""


try:
    # Instantiate Aspose Storage API SDK
    storage_apiClient = asposestoragecloud.ApiClient.ApiClient(apiKey, appSid, True)
    storageApi = StorageApi(storage_apiClient)
  
    
    # upload file to aspose cloud storage
    response = storageApi.PutCreate("testfile.txt" ,"testfile.txt")

    if response.Status == "OK":
        print("Put Create File Done " + response.Status)


except ApiException as ex:
    print ("ApiException:")
    print ("Code:" + str(ex.code))
    print ("Message:" +ex.message)

