#ExStart:
require 'aspose_storage_cloud'

class Files
    
  include AsposeStorageCloud

  def initialize
    # Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("8581cee5dcf1f68f378ff7b0fa63261d", "A87ADA7A-9A2A-403E-B4BE-2DB7F33BE289")
    @storage_api = StorageApi.new
  end
  
  def upload_file
    file_name = "testfile.txt"
    response = @storage_api.put_create(file_name, File.open("../../../data/" << file_name,"r") { |io| io.read }, {storage: "MyDropboxStorage"})
  end

end

files = Files.new()
puts files.upload_file
#ExEnd:
