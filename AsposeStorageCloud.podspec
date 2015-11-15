Pod::Spec.new do |s|
  s.name         = "AsposeStorageCloud"
  s.version      = "0.0.2"
  s.summary      = "A powerful API for iOS apps that work with files."
  s.description  = <<-DESC
                   This SDK allows you to perform storage operations like download a specific file, upload a specific file, remove a specific file, move a specific file, get the file listing of a specific folder etc. on Aspose Cloud Storage. 
                   DESC

  s.homepage     = "http://www.aspose.com"
  s.license = { :type => 'MIT', :file => 'LICENSE'}
  s.author = { "Muhammad Sohail Ismail" => "muhammad.sohail@aspose.com" }
  s.social_media_url = "https://www.facebook.com/asposeplugins/"
  s.platform = :ios, "7.0"
  s.source       = { :git => "https://github.com/asposetotal/Aspose_Total_Cloud.git", :tag => "0.0.2" }
  
  s.subspec 'storage' do |ss|
    ss.subspec 'model' do |sss|
        sss.source_files = 'SDKs/Aspose.Storage_Cloud_SDK_For_Objective_C/Aspose.Storage_Cloud_SDK_For_Objective_C/storage/model/*.{h,m}'
    end
    ss.subspec 'client' do |sss|
        sss.dependency 'AsposeStorageCloud/storage/model'
        sss.source_files = 'SDKs/Aspose.Storage_Cloud_SDK_For_Objective_C/Aspose.Storage_Cloud_SDK_For_Objective_C/storage/client/*.{h,m}'
    end
    
    ss.subspec 'api' do |sss|
        sss.dependency 'AsposeStorageCloud/storage/client'
        sss.source_files = 'SDKs/Aspose.Storage_Cloud_SDK_For_Objective_C/Aspose.Storage_Cloud_SDK_For_Objective_C/storage/api/*.{h,m}'
    end
  end

  s.dependency "AFNetworking", "~> 2.0"
  s.dependency "JSONModel", "~> 1.1"
  s.dependency "ISO8601", "~> 0.3"

  s.requires_arc = true
  
end