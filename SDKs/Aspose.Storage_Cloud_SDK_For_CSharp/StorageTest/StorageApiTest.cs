using Com.Aspose.Storage.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StorageTest
{
    
    
    /// <summary>
    ///This is a test class for TestStorageApi and is intended
    ///to contain all TestStorageApi Unit Tests
    ///</summary>
    [TestClass()]
    public class TestStorageApi
    {
        public StorageApi target;
        public TestStorageApi()
        {
            target = new StorageApi("xxx", "xxx", "http://api.aspose.com/v1.1");
        }


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for DeleteFile
        ///</summary>
        [TestMethod()]
        public void TestDeleteFile()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string Path = string.Empty; // TODO: Initialize to an appropriate value
            string versionId = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.RemoveFileResponse expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.RemoveFileResponse actual;
            actual = target.DeleteFile(Path, versionId, storage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteFolder
        ///</summary>
        [TestMethod()]
        public void TestDeleteFolder()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string Path = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            bool recursive = false; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.RemoveFolderResponse expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.RemoveFolderResponse actual;
            actual = target.DeleteFolder(Path, storage, recursive);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDiscUsage
        ///</summary>
        [TestMethod()]
        public void TestGetDiscUsage()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.DiscUsageResponse expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.DiscUsageResponse actual;
            actual = target.GetDiscUsage(storage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDownload
        ///</summary>
        [TestMethod()]
        public void TestGetDownload()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string Path = string.Empty; // TODO: Initialize to an appropriate value
            string versionId = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.GetDownload(Path, versionId, storage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetIsExist
        ///</summary>
        [TestMethod()]
        public void TestGetIsExist()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string Path = string.Empty; // TODO: Initialize to an appropriate value
            string versionId = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.FileExistResponse expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.FileExistResponse actual;
            actual = target.GetIsExist(Path, versionId, storage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetIsStorageExist
        ///</summary>
        [TestMethod()]
        public void TestGetIsStorageExist()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.StorageExistResponse expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.StorageExistResponse actual;
            actual = target.GetIsStorageExist(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetListFileVersions
        ///</summary>
        [TestMethod()]
        public void TestGetListFileVersions()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string Path = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.FileVersionsResponse expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.FileVersionsResponse actual;
            actual = target.GetListFileVersions(Path, storage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetListFiles
        ///</summary>
        [TestMethod()]
        public void TestGetListFiles()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string Path = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.GetListFiles(Path, storage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PostMoveFile
        ///</summary>
        [TestMethod()]
        public void TestPostMoveFile()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string src = string.Empty; // TODO: Initialize to an appropriate value
            string dest = string.Empty; // TODO: Initialize to an appropriate value
            string versionId = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            string destStorage = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.MoveFileResponse expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.MoveFileResponse actual;
            actual = target.PostMoveFile(src, dest, versionId, storage, destStorage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PostMoveFolder
        ///</summary>
        [TestMethod()]
        public void TestPostMoveFolder()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string src = string.Empty; // TODO: Initialize to an appropriate value
            string dest = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            string destStorage = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.MoveFolderResponse expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.MoveFolderResponse actual;
            actual = target.PostMoveFolder(src, dest, storage, destStorage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PutCopy
        ///</summary>
        [TestMethod()]
        public void TestPutCopy()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string Path = string.Empty; // TODO: Initialize to an appropriate value
            string newdest = string.Empty; // TODO: Initialize to an appropriate value
            string versionId = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            string destStorage = string.Empty; // TODO: Initialize to an appropriate value
            byte[] file = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.PutCopy(Path, newdest, versionId, storage, destStorage, file);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PutCopyFolder
        ///</summary>
        [TestMethod()]
        public void TestPutCopyFolder()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string Path = string.Empty; // TODO: Initialize to an appropriate value
            string newdest = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            string destStorage = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.PutCopyFolder(Path, newdest, storage, destStorage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PutCreate
        ///</summary>
        [TestMethod()]
        public void TestPutCreate()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string Path = string.Empty; // TODO: Initialize to an appropriate value
            string versionId = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            byte[] file = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.PutCreate(Path, versionId, storage, file);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PutCreateFolder
        ///</summary>
        [TestMethod()]
        public void TestPutCreateFolder()
        {
            string apiKey = string.Empty; // TODO: Initialize to an appropriate value
            string appSid = string.Empty; // TODO: Initialize to an appropriate value
            string basePath = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Api.StorageApi target = new Com.Aspose.Storage.Api.StorageApi(apiKey, appSid, basePath); // TODO: Initialize to an appropriate value
            string Path = string.Empty; // TODO: Initialize to an appropriate value
            string storage = string.Empty; // TODO: Initialize to an appropriate value
            string destStorage = string.Empty; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage expected = null; // TODO: Initialize to an appropriate value
            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.PutCreateFolder(Path, storage, destStorage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

    }
}
