require "minitest/autorun"
require "minitest/unit"

require_relative '../lib/aspose_platform_cloud'

class PlatformTests < Minitest::Test
	include MiniTest::Assertions
	include AsposePlatformCloud

	def setup
        #Get App key and App SID from https://cloud.aspose.com
        AsposeApp.app_key_and_sid("", "")
        #Get Access Token
        AsposeApp.set_access_token(get_access_token)
	end

	def teardown
	end

	def get_access_token
        @o_auth_api = OAuthApi.new
        accessTokenResponse = @o_auth_api.o_auth_post("client_credentials", AsposeApp.app_sid, AsposeApp.app_key)
        assert(accessTokenResponse.access_token, message="Failed to get access token.")
        accessTokenResponse.access_token
    end

	def upload_file(file_name)
		@file_api = FileApi.new
		response = @file_api.file_put_create(file_name, ::File.open("../../../data/" << file_name,"r") { |io| io.read } )
		assert(response, message="Failed to upload {file_name} file.")
	end

	def create_folder(folder_name)
		@folder_api = FolderApi.new
		response = @folder_api.folder_put_create_folder(folder_name)
		assert(response, message="Failed to create the folder.")
	end
    
	def test_storage_get_disc_usage
        @storage_api = StorageApi.new
	 	response = @storage_api.storage_get_disc_usage()
	 	assert(response, message="Failed to check the disk usage of the current account.")
	end

    def test_storage_get_is_exist
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)
		
        @storage_api = StorageApi.new
	 	response = @storage_api.storage_get_is_exist(file_name)
	 	assert(response, message="Failed to check if a specific file or folder exists.")
	end

	def test_file_get_download
		@file_api = FileApi.new

		file_name = "buzz.png"
		upload_file(file_name)

	 	tempfile = @file_api.file_get_download(file_name)
	 	assert(tempfile, message="Failed to download #{file_name} file.")

	 	FileUtils.cp(tempfile.path, '../../../data/output/' << file_name)
	end

	def test_file_put_create
		@file_api = FileApi.new

		file_name = "SampleWordDocument.docx"
		response = @file_api.file_put_create(file_name, ::File.open("../../../data/" << file_name,"r") { |io| io.read } )
		assert(response, message="Failed to upload {file_name} file.")
	end

	def test_file_delete_file
		@file_api = FileApi.new

		file_name = "buzz.png"
		upload_file(file_name)

	 	response = @file_api.file_delete_file(file_name)
	 	assert(response, message="Failed to remove #{file_name} file.")
	end

	def test_file_post_move_file
		@file_api = FileApi.new
		
		file_name = "SampleWordDocument.docx"
		upload_file(file_name)
		dest_folder = "documents"
		create_folder(dest_folder)

	 	response = @file_api.file_post_move_file(file_name, dest_folder)
	 	assert(response, message="Failed to move #{file_name} file.")
	end

	def test_folder_get_list_files
		@folder_api = FolderApi.new

	 	response = @folder_api.folder_get_list_files("")
	 	assert(response, message="Failed to get the file listing of a specific folder.")
	end

	def test_folder_put_create_folder
		@folder_api = FolderApi.new
		
		folder_name = "pictures"
		response = @folder_api.folder_put_create_folder(folder_name)
		assert(response, message="Failed to create the folder.")
	end	

	def test_folder_delete_folder
		@folder_api = FolderApi.new

		folder_name = "pictures"
		create_folder(folder_name)

	 	response = @folder_api.folder_delete_folder(folder_name)
	 	assert(response, message="Failed to remove #{folder_name} folder.")
	end

	def test_folder_post_move_folder
		@folder_api = FolderApi.new

		src_folder = "moveFrom"
		dest_folder = "moveTo"
		create_folder(src_folder)
		create_folder(dest_folder)

	 	response = @folder_api.folder_post_move_folder(src_folder, dest_folder)
	 	assert(response, message="Failed to move a specific folder.")
	end

	def test_storage_get_list_file_versions
		@storage_api = StorageApi.new

		file_name = "buzz.png"
		upload_file(file_name)

	 	response = @storage_api.storage_get_list_file_versions(file_name)
	 	assert(response, message="Failed to get the file's versions list.")
	end

	def test_storage_get_is_storage_exist
        @storage_api = StorageApi.new

        storage_name = "First Storage"
	 	response = @storage_api.storage_get_is_storage_exist(storage_name)
	 	assert(response, message="Failed to check if storage exists.")
	end

	def test_put_copy
		@file_api = FileApi.new

		file_name = "buzz.png"
		upload_file(file_name)

		newdest = "pictures"
		create_folder(newdest)

		response = @file_api.put_copy(file_name, newdest)
		assert(response, message="Failed to copy a specific file.")
	end

	def test_put_copy_folder
		@folder_api = FolderApi.new
		
		src_folder = "/copyFrom"
		create_folder(src_folder)
		dest_folder = "/copyTo"
		create_folder(dest_folder)

		response = @folder_api.put_copy_folder(src_folder, dest_folder)
		assert(response, message="Failed to copy a folder.")
	end

end
