#ExStart:
require 'aspose_storage_cloud'

class DiskUsage
    
  include AsposeStorageCloud

  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("da77c9f5da014d91faf2961ecec2de66", "B01A15E5-1B83-4B9A-8EB3-0F2BFA6AC766")
    @storage_api = StorageApi.new
  end
  
  def get_disk_usage
    response = @storage_api.get_disc_usage()
  end

end

diskUsage = DiskUsage.new()
puts diskUsage.get_disk_usage
#ExEnd:
