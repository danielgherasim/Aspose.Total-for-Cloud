# Aspose.Storage_Cloud_SDK_For_Ruby
This SDK lets users use Aspose Cloud Storage APIs in their web app.

##Installing
You can simply install AsposeStorageCloud with gem:

`gem install aspose_storage_cloud`

##Usage
```ruby
class AsposeStorage

  include AsposeStorageCloud
  
  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("APP_KEY", "APP_SID")
		@storage_api = StorageApi.new  
  end
  
  def get_aspose_disc_usage
	 	disc_usage_response = @storage_api.get_disc_usage()
	 	puts "Used Size: #{disc_usage_response.disc_usage.used_size} Total Size: #{disc_usage_response.disc_usage.total_size}"
	end
  
end
```

## Contact
Your feedback is very important to us. Please email us all your queries and feedback at marketplace@aspose.com.

## License
Aspose-Storage-SDK is available under the MIT license. See the [LICENSE](https://github.com/asposetotal/Aspose_Total_Cloud/blob/master/SDKs/Aspose.Storage_Cloud_SDK_For_Ruby/LICENSE) file for more info.
