#ExStart:
require 'aspose_storage_cloud'

class Files
    
  include AsposeStorageCloud

  def initialize
    # Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("da77c9f5da014d91faf2961ecec2de66", "B01A15E5-1B83-4B9A-8EB3-0F2BFA6AC766")
    @storage_api = StorageApi.new
  end
  
  def upload_file
    file_name = "SampleWordDocument.docx"
    response = @storage_api.put_create(file_name, File.open("../../../data/" << file_name,"r") { |io| io.read } )
  end

end

files = Files.new()
puts files.upload_file
#ExEnd:
