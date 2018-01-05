#ExStart:
require 'aspose_storage_cloud'

class DiskUsage
    
  include AsposeStorageCloud

  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("xxxx", "xxxx")
    @storage_api = StorageApi.new
  end
  
  def get_disk_usage
    response = @storage_api.get_disc_usage()
  end

end

diskUsage = DiskUsage.new()
puts diskUsage.get_disk_usage
#ExEnd:
