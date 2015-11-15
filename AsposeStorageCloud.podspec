Pod::Spec.new do |s|
  s.name         = "AsposeStorageCloud"
  s.version      = "0.0.1"
  s.summary      = "A powerful API for iOS apps that work with files."
  s.description  = <<-DESC
                   This SDK allows you to perform storage operations like download a specific file, upload a specific file, remove a specific file, move a specific file, get the file listing of a specific folder etc. on Aspose Cloud Storage. 
                   DESC

  s.homepage     = "http://www.aspose.com"
  s.license = { :type => 'MIT', :file => 'LICENSE'}
  s.author = { "Muhammad Sohail Ismail" => "muhammad.sohail@aspose.com" }
  s.social_media_url = "https://www.facebook.com/asposeplugins/"
  s.platform = :ios, "5.0"
  s.source       = { :git => "https://github.com/asposetotal/Aspose_Total_Cloud.git", :tag => "0.0.1" }
  
  s.source_files = 'SDKs/Aspose.Storage_Cloud_SDK_For_Objective_C/Aspose.Storage_Cloud_SDK_For_Objective_C/storage/model'
  
  s.requires_arc = true
  
end
