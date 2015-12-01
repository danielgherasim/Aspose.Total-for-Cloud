  using System;
  using System.Collections.Generic;
  using System.Text.RegularExpressions;
  using Com.Aspose.Storage;
  using Com.Aspose.Storage.Model;
  namespace Com.Aspose.Storage.Api {
    public class StorageApi {
      string basePath;
      private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

      public StorageApi(String apiKey, String appSid, String basePath = "http://api.aspose.com/v1.1")
      {
	    apiInvoker.addDefaultHeader(apiInvoker.API_KEY,apiKey);
        apiInvoker.addDefaultHeader(apiInvoker.APP_SID, appSid);
        this.basePath = basePath;
      }

      public ApiInvoker getInvoker() {
        return apiInvoker;
      }

      // Sets the endpoint base url for the services being accessed
      public void setBasePath(string basePath) {
        this.basePath = basePath;
      }

      // Gets the endpoint base url for the services being accessed
      public String getBasePath() {
        return basePath;
      }

      /// <summary>
      /// Remove a specific file. Parameters: path - file path e.g. /file.ext, versionID - file's version, storage - user's storage name. Remove a specific file. Parameters: path - file path e.g. /file.ext, versionID - file's version, storage - user's storage name.
      /// </summary>
      /// <param name="Path"></param>
      /// <param name="versionId"></param>
      /// <param name="storage"></param>
      /// <returns></returns>
      public RemoveFileResponse DeleteFile (string Path, string versionId, string storage) {
        // create path and map variables
        var ResourcePath = "/storage/file/{Path}/?appSid={appSid}&amp;versionId={versionId}&amp;storage={storage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (Path == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (Path == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])Path=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "Path" + "}", apiInvoker.ToPathValue(Path)); 
		}
        if (versionId == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])versionId=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "versionId" + "}", apiInvoker.ToPathValue(versionId)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        try {
          if (typeof(RemoveFileResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (RemoveFileResponse) ApiInvoker.deserialize(response, typeof(RemoveFileResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (RemoveFileResponse) ApiInvoker.deserialize(response, typeof(RemoveFileResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Check the disk usage of the current account. Parameters: storage - user's storage name. Check the disk usage of the current account. Parameters: storage - user's storage name.
      /// </summary>
      /// <param name="storage"></param>
      /// <returns></returns>
      public DiscUsageResponse GetDiscUsage (string storage) {
        // create path and map variables
        var ResourcePath = "/storage/disc/?appSid={appSid}&amp;storage={storage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        try {
          if (typeof(DiscUsageResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (DiscUsageResponse) ApiInvoker.deserialize(response, typeof(DiscUsageResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (DiscUsageResponse) ApiInvoker.deserialize(response, typeof(DiscUsageResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Download a specific file. Parameters: path - file path e.g. /file.ext, versionID - file's version, storage - user's storage name. Download a specific file. Parameters: path - file path e.g. /file.ext, versionID - file's version, storage - user's storage name.
      /// </summary>
      /// <param name="Path"></param>
      /// <param name="versionId"></param>
      /// <param name="storage"></param>
      /// <returns></returns>
      public ResponseMessage GetDownload (string Path, string versionId, string storage) {
        // create path and map variables
        var ResourcePath = "/storage/file/{Path}/?appSid={appSid}&amp;versionId={versionId}&amp;storage={storage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (Path == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (Path == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])Path=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "Path" + "}", apiInvoker.ToPathValue(Path)); 
		}
        if (versionId == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])versionId=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "versionId" + "}", apiInvoker.ToPathValue(versionId)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Check if a specific file or folder exists. Parameters: path - file or folder path e.g. /file.ext or /Folder1, versionID - file's version, storage - user's storage name. Check if a specific file or folder exists. Parameters: path - file or folder path e.g. /file.ext or /Folder1, versionID - file's version, storage - user's storage name.
      /// </summary>
      /// <param name="Path"></param>
      /// <param name="versionId"></param>
      /// <param name="storage"></param>
      /// <returns></returns>
      public FileExistResponse GetIsExist (string Path, string versionId, string storage) {
        // create path and map variables
        var ResourcePath = "/storage/exist/{Path}/?appSid={appSid}&amp;versionId={versionId}&amp;storage={storage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (Path == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (Path == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])Path=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "Path" + "}", apiInvoker.ToPathValue(Path)); 
		}
        if (versionId == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])versionId=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "versionId" + "}", apiInvoker.ToPathValue(versionId)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        try {
          if (typeof(FileExistResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FileExistResponse) ApiInvoker.deserialize(response, typeof(FileExistResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (FileExistResponse) ApiInvoker.deserialize(response, typeof(FileExistResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Get the file's versions list. Parameters: path - file path e.g. /file.ext or /Folder1/file.ext, storage - user's storage name. Get the file's versions list. Parameters: path - file path e.g. /file.ext or /Folder1/file.ext, storage - user's storage name.
      /// </summary>
      /// <param name="Path"></param>
      /// <param name="storage"></param>
      /// <returns></returns>
      public FileVersionsResponse GetListFileVersions (string Path, string storage) {
        // create path and map variables
        var ResourcePath = "/storage/version/{Path}/?appSid={appSid}&amp;storage={storage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (Path == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (Path == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])Path=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "Path" + "}", apiInvoker.ToPathValue(Path)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        try {
          if (typeof(FileVersionsResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (FileVersionsResponse) ApiInvoker.deserialize(response, typeof(FileVersionsResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (FileVersionsResponse) ApiInvoker.deserialize(response, typeof(FileVersionsResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Move a specific file. Move a specific file.
      /// </summary>
      /// <param name="src">source file path e.g. /file.ext</param>
      /// <param name="dest"></param>
      /// <param name="versionId">source file's version,</param>
      /// <param name="storage">user's source storage name</param>
      /// <param name="destStorage">user's destination storage name</param>
      /// <returns></returns>
      public MoveFileResponse PostMoveFile (string src, string dest, string versionId, string storage, string destStorage) {
        // create path and map variables
        var ResourcePath = "/storage/file/{src}/?dest={dest}&amp;appSid={appSid}&amp;versionId={versionId}&amp;storage={storage}&amp;destStorage={destStorage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (src == null || dest == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (src == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])src=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "src" + "}", apiInvoker.ToPathValue(src)); 
		}
        if (dest == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])dest=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "dest" + "}", apiInvoker.ToPathValue(dest)); 
		}
        if (versionId == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])versionId=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "versionId" + "}", apiInvoker.ToPathValue(versionId)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (destStorage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])destStorage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "destStorage" + "}", apiInvoker.ToPathValue(destStorage)); 
		}
        try {
          if (typeof(MoveFileResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (MoveFileResponse) ApiInvoker.deserialize(response, typeof(MoveFileResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (MoveFileResponse) ApiInvoker.deserialize(response, typeof(MoveFileResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Copy a specific file. Parameters: path - source file path e.g. /file.ext, versionID - source file's version, storage - user's source storage name, newdest - destination file path, destStorage - user's destination storage name. Copy a specific file. Parameters: path - source file path e.g. /file.ext, versionID - source file's version, storage - user's source storage name, newdest - destination file path, destStorage - user's destination storage name.
      /// </summary>
      /// <param name="Path"></param>
      /// <param name="newdest"></param>
      /// <param name="versionId"></param>
      /// <param name="storage"></param>
      /// <param name="destStorage"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public ResponseMessage PutCopy (string Path, string newdest, string versionId, string storage, string destStorage, byte[] file) {
        // create path and map variables
        var ResourcePath = "/storage/file/{Path}/?appSid={appSid}&amp;newdest={newdest}&amp;versionId={versionId}&amp;storage={storage}&amp;destStorage={destStorage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (Path == null || newdest == null || file == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (Path == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])Path=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "Path" + "}", apiInvoker.ToPathValue(Path)); 
		}
        if (newdest == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])newdest=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "newdest" + "}", apiInvoker.ToPathValue(newdest)); 
		}
        if (versionId == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])versionId=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "versionId" + "}", apiInvoker.ToPathValue(versionId)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (destStorage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])destStorage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "destStorage" + "}", apiInvoker.ToPathValue(destStorage)); 
		}
        if (file != null){
         if(file is byte[]) {
           formParams.Add("file", file);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Upload a specific file. Parameters: path - source file path e.g. /file.ext, versionID - source file's version, storage - user's source storage name, newdest - destination file path, destStorage - user's destination storage name. Upload a specific file. Parameters: path - source file path e.g. /file.ext, versionID - source file's version, storage - user's source storage name, newdest - destination file path, destStorage - user's destination storage name.
      /// </summary>
      /// <param name="Path"></param>
      /// <param name="versionId"></param>
      /// <param name="storage"></param>
      /// <param name="file"></param>
      /// <returns></returns>
      public ResponseMessage PutCreate (string Path, string versionId, string storage, byte[] file) {
        // create path and map variables
        var ResourcePath = "/storage/file/{Path}/?appSid={appSid}&amp;versionId={versionId}&amp;storage={storage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (Path == null || file == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (Path == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])Path=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "Path" + "}", apiInvoker.ToPathValue(Path)); 
		}
        if (versionId == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])versionId=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "versionId" + "}", apiInvoker.ToPathValue(versionId)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (file != null){
         if(file is byte[]) {
           formParams.Add("file", file);
         } else {
           //string paramStr = (file is DateTime) ? ((DateTime)(object)file).ToString("u") : Convert.ToString(file);
		    string paramStr = Convert.ToString(file);
           formParams.Add("file", paramStr);
         }
		}
        try {
          //if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
          //  var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
          //  return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          //} else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          //}
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Remove a specific folder. Parameters: path - folder path e.g. /Folder1, storage - user's storage name, recursive - is subfolders and files must be deleted for specified path. Remove a specific folder. Parameters: path - folder path e.g. /Folder1, storage - user's storage name, recursive - is subfolders and files must be deleted for specified path.
      /// </summary>
      /// <param name="Path"></param>
      /// <param name="storage"></param>
      /// <param name="recursive"></param>
      /// <returns></returns>
      public RemoveFolderResponse DeleteFolder (string Path, string storage, bool recursive) {
        // create path and map variables
        var ResourcePath = "/storage/folder/{Path}/?appSid={appSid}&amp;storage={storage}&amp;recursive={recursive}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (Path == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (Path == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])Path=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "Path" + "}", apiInvoker.ToPathValue(Path)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (recursive == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])recursive=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "recursive" + "}", apiInvoker.ToPathValue(recursive)); 
		}
        try {
          if (typeof(RemoveFolderResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (RemoveFolderResponse) ApiInvoker.deserialize(response, typeof(RemoveFolderResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "DELETE", queryParams, null, headerParams, formParams);
            if(response != null){
               return (RemoveFolderResponse) ApiInvoker.deserialize(response, typeof(RemoveFolderResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Get the file listing of a specific folder. Parametres: path - start with name of storage e.g. root folder '/'or some folder '/folder1/..', storage - user's storage name. Get the file listing of a specific folder. Parametres: path - start with name of storage e.g. root folder '/'or some folder '/folder1/..', storage - user's storage name.
      /// </summary>
      /// <param name="Path"></param>
      /// <param name="storage"></param>
      /// <returns></returns>
      public ResponseMessage GetListFiles (string Path, string storage) {
        // create path and map variables
        var ResourcePath = "/storage/folder/{Path}/?appSid={appSid}&amp;storage={storage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        if (Path == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])Path=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "Path" + "}", apiInvoker.ToPathValue(Path)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Move a specific folder. Parameters: src - source folder path e.g. /Folder1, storage - user's source storage name, dest - destination folder path e.g. /Folder2, destStorage - user's destination storage name. Move a specific folder. Parameters: src - source folder path e.g. /Folder1, storage - user's source storage name, dest - destination folder path e.g. /Folder2, destStorage - user's destination storage name.
      /// </summary>
      /// <param name="src"></param>
      /// <param name="dest"></param>
      /// <param name="storage"></param>
      /// <param name="destStorage"></param>
      /// <returns></returns>
      public MoveFolderResponse PostMoveFolder (string src, string dest, string storage, string destStorage) {
        // create path and map variables
        var ResourcePath = "/storage/folder/{src}/?dest={dest}&amp;appSid={appSid}&amp;storage={storage}&amp;destStorage={destStorage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (src == null || dest == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (src == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])src=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "src" + "}", apiInvoker.ToPathValue(src)); 
		}
        if (dest == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])dest=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "dest" + "}", apiInvoker.ToPathValue(dest)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (destStorage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])destStorage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "destStorage" + "}", apiInvoker.ToPathValue(destStorage)); 
		}
        try {
          if (typeof(MoveFolderResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (MoveFolderResponse) ApiInvoker.deserialize(response, typeof(MoveFolderResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "POST", queryParams, null, headerParams, formParams);
            if(response != null){
               return (MoveFolderResponse) ApiInvoker.deserialize(response, typeof(MoveFolderResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Copy a folder. Parameters: path - source folder path e.g. /Folder1, storage - user's source storage name, newdest - destination folder path e.g. /Folder2, destStorage - user's destination storage name. Copy a folder. Parameters: path - source folder path e.g. /Folder1, storage - user's source storage name, newdest - destination folder path e.g. /Folder2, destStorage - user's destination storage name.
      /// </summary>
      /// <param name="Path"></param>
      /// <param name="newdest"></param>
      /// <param name="storage"></param>
      /// <param name="destStorage"></param>
      /// <returns></returns>
      public ResponseMessage PutCopyFolder (string Path, string newdest, string storage, string destStorage) {
        // create path and map variables
        var ResourcePath = "/storage/folder/{Path}/?appSid={appSid}&amp;newdest={newdest}&amp;storage={storage}&amp;destStorage={destStorage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (Path == null || newdest == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (Path == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])Path=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "Path" + "}", apiInvoker.ToPathValue(Path)); 
		}
        if (newdest == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])newdest=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "newdest" + "}", apiInvoker.ToPathValue(newdest)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (destStorage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])destStorage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "destStorage" + "}", apiInvoker.ToPathValue(destStorage)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Create the folder. Parameters: path - source folder path e.g. /Folder1, storage - user's source storage name, newdest - destination folder path e.g. /Folder2, destStorage - user's destination storage name. Create the folder. Parameters: path - source folder path e.g. /Folder1, storage - user's source storage name, newdest - destination folder path e.g. /Folder2, destStorage - user's destination storage name.
      /// </summary>
      /// <param name="Path"></param>
      /// <param name="storage"></param>
      /// <param name="destStorage"></param>
      /// <returns></returns>
      public ResponseMessage PutCreateFolder (string Path, string storage, string destStorage) {
        // create path and map variables
        var ResourcePath = "/storage/folder/{Path}/?appSid={appSid}&amp;storage={storage}&amp;destStorage={destStorage}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (Path == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (Path == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])Path=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "Path" + "}", apiInvoker.ToPathValue(Path)); 
		}
        if (storage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])storage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "storage" + "}", apiInvoker.ToPathValue(storage)); 
		}
        if (destStorage == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])destStorage=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "destStorage" + "}", apiInvoker.ToPathValue(destStorage)); 
		}
        try {
          if (typeof(ResponseMessage) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "PUT", queryParams, null, headerParams, formParams);
            if(response != null){
               return (ResponseMessage) ApiInvoker.deserialize(response, typeof(ResponseMessage));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// Check if a specific storage exists. Check if a specific storage exists.
      /// </summary>
      /// <param name="name">Storage name</param>
      /// <returns></returns>
      public StorageExistResponse GetIsStorageExist (string name) {
        // create path and map variables
        var ResourcePath = "/storage/{name}/exist/?appSid={appSid}".Replace("{format}","json");
		ResourcePath = Regex.Replace(ResourcePath, "\\*", "").Replace("&amp;", "&").Replace("/?", "?").Replace("toFormat={toFormat}", "format={format}");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (name == null ) {
           throw new ApiException(400, "missing required params");
        }
        if (name == null){
		  ResourcePath = Regex.Replace(ResourcePath, @"([&?])name=", "");
		}else{
		  ResourcePath = ResourcePath.Replace("{" + "name" + "}", apiInvoker.ToPathValue(name)); 
		}
        try {
          if (typeof(StorageExistResponse) == typeof(ResponseMessage)) {
            var response = apiInvoker.invokeBinaryAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            return (StorageExistResponse) ApiInvoker.deserialize(response, typeof(StorageExistResponse));
          } else {
            var response = apiInvoker.invokeAPI(basePath, ResourcePath, "GET", queryParams, null, headerParams, formParams);
            if(response != null){
               return (StorageExistResponse) ApiInvoker.deserialize(response, typeof(StorageExistResponse));
            }
            else {
              return null;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return null;
          }
          else {
            throw ex;
          }
        }
      }
      }
    }
