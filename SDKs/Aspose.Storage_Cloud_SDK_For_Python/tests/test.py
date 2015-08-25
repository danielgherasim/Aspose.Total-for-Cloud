import unittest
import os.path
import json

from asposecloudstorage.ApiClient import ApiClient
from asposecloudstorage.StorageApi import StorageApi
from asposecloudstorage.ApiClient import ApiException
from asposecloudstorage.models import ResponseMessage
from asposecloudstorage.models import DiscUsageResponse
from asposecloudstorage.models import FileExistResponse
from asposecloudstorage.models import MoveFileResponse
from asposecloudstorage.models import MoveFolderResponse
from asposecloudstorage.models import StorageExistResponse
from asposecloudstorage.models import FileVersionsResponse
from asposecloudstorage.models import RemoveFolderResponse
from asposecloudstorage.models import RemoveFileResponse

class TestAsposeStorage(unittest.TestCase):

    def setUp(self):

        with open('setup.json') as json_file:
            data = json.load(json_file)

        self.apiClient = ApiClient(apiKey=str(data['app_key']),appSid=str(data['app_sid']),debug=True,apiServer=str(data['product_uri']))
        self.storageApi = StorageApi(self.apiClient)

        self.output_path = str(data['output_location'])

    def testGetListFiles(self):
        
        response = self.storageApi.GetListFiles(Path='')
        self.assertIsInstance(response,ResponseMessage.ResponseMessage)
        self.assertEqual(response.Code,200)

    def testGetDiscUsage(self):
        try:
            response = self.storageApi.GetDiscUsage()

            self.assertIsInstance(response,DiscUsageResponse.DiscUsageResponse)
            self.assertEqual(response.Code,200)
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

    def testPutCreate(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            self.assertIsInstance(response,ResponseMessage.ResponseMessage)
            self.assertEqual(response.Code,200)
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

    def testGetDownload(self):
        try:
            response = self.storageApi.GetDownload('SampleWordDocument.docx')

            #self.assertIsInstance(response,ResponseMessage.ResponseMessage)
            self.assertEqual(response.Code,200)

            with open("./output/" + 'SampleWordDocument.docx', 'wb') as f:
                for chunk in response.InputStream:
                    f.write(chunk)


            self.assertTrue(True, os.path.exists("./output/" + 'SampleWordDocument.docx'))

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

    def testGetIsExist(self):
        try:
            response = self.storageApi.GetIsExist('testfile.txt')

            self.assertIsInstance(response,FileExistResponse.FileExistResponse)
            self.assertEqual(response.Code,200)
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

    def testPutCreateFolder(self):
        try:
            response = self.storageApi.PutCreateFolder('mytestfolder')

            self.assertIsInstance(response,ResponseMessage.ResponseMessage)
            self.assertEqual(response.Code,200)
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

    def testPostMoveFile(self):
        try:
            response = self.storageApi.PutCreate('testfile.txt','./data/testfile.txt')
            response = self.storageApi.PostMoveFile('testfile.txt','mytestfolder/testfile.txt')

            self.assertIsInstance(response,MoveFileResponse.MoveFileResponse)
            self.assertEqual(response.Code,200)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

    def testPostMoveFolder(self):
        try:
            response = self.storageApi.PostMoveFolder('mytestfolder','mytestfolder_new')

            self.assertIsInstance(response,MoveFolderResponse.MoveFolderResponse)
            self.assertEqual(response.Code,200)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

    def testPutCopy(self):
        try:
            response = self.storageApi.PutCopy('testfile.txt','new_testfile.txt','./data/testfile.txt')

            self.assertIsInstance(response,ResponseMessage.ResponseMessage)
            self.assertEqual(response.Code,200)
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
    def testPutCopyFolder(self):
        try:
            response = self.storageApi.PutCopyFolder('mytestfolder','mytestfolder1')
            self.assertIsInstance(response,ResponseMessage.ResponseMessage)
            self.assertEqual(response.Code,200)
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

    def testGetIsStorageExist(self):
        try:
            response = self.storageApi.GetIsStorageExist('Aspose123')
            self.assertIsInstance(response,StorageExistResponse.StorageExistResponse)
            self.assertEqual(response.Code,200)
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

    def testGetListFileVersions(self):
        try:
            response = self.storageApi.PutCreate('testfile.txt','./data/testfile.txt')
            response = self.storageApi.GetListFileVersions('testfile.txt')

            self.assertIsInstance(response,FileVersionsResponse.FileVersionsResponse)
            self.assertEqual(response.Code,200)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

    def testDeleteFolder(self):
        try:
            response = self.storageApi.DeleteFolder('mytestfolder')
            self.assertIsInstance(response,RemoveFolderResponse.RemoveFolderResponse)
            self.assertEqual(response.Code,200)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

    def testDeleteFile(self):
        try:
            response = self.storageApi.DeleteFile('testfile.txt')

            self.assertIsInstance(response,RemoveFileResponse.RemoveFileResponse)
            self.assertEqual(response.Code,200)
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message

