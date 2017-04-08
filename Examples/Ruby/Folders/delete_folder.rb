#ExStart:
require 'aspose_storage_cloud'

class Folder
    
  include AsposeStorageCloud

  def initialize
    # Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("App Key", "App SID")
    @storage_api = StorageApi.new
  end

  def create_folder(folder_name)
  	response = @storage_api.put_create_folder(folder_name)
  end

  def delete_folder
    folder_name = "testfolder"

    # First create folder
	  create_folder(folder_name)

  	# Now delete this folder
	  response = @storage_api.delete_folder(folder_name)
  end

end

folder = Folder.new()
puts folder.delete_folder
#ExEnd: