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
            string Path = "testfile.txt"; 
            string versionId = null; 
            string storage = null;

            target.PutCreate(Path, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + Path));
            Com.Aspose.Storage.Model.RemoveFileResponse actual;
            actual = target.DeleteFile(Path, versionId, storage);
            Assert.AreEqual("200", actual.Code);            
        }

        /// <summary>
        ///A test for DeleteFolder
        ///</summary>
        [TestMethod()]
        public void TestDeleteFolder()
        {    
            string Path = "testfolder";
            string storage = null; 
            bool recursive = false;

            target.PutCreateFolder(Path, null, null);

            Com.Aspose.Storage.Model.RemoveFolderResponse actual;
            actual = target.DeleteFolder(Path, storage, recursive);
            Assert.AreEqual("200", actual.Code);
            
        }

        /// <summary>
        ///A test for GetDiscUsage
        ///</summary>
        [TestMethod()]
        public void TestGetDiscUsage()
        {    
            string storage = null; 

            Com.Aspose.Storage.Model.DiscUsageResponse actual;
            actual = target.GetDiscUsage(storage);

            Assert.AreEqual("200", actual.Code);
            
        }

        /// <summary>
        ///A test for GetDownload
        ///</summary>
        [TestMethod()]
        public void TestGetDownload()
        {
            string Path = "testfile.txt"; 
            string versionId = null; 
            string storage = null;

            target.PutCreate(Path, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + Path));            
            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.GetDownload(Path, versionId, storage);

            Assert.AreNotEqual("", actual);
            
        }

        /// <summary>
        ///A test for GetIsExist
        ///</summary>
        [TestMethod()]
        public void TestGetIsExist()
        {
            string Path = "testfile.txt"; 
            string versionId = null; 
            string storage = null;

            target.PutCreate(Path, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + Path)); 
            Com.Aspose.Storage.Model.FileExistResponse actual;
            actual = target.GetIsExist(Path, versionId, storage);
            Assert.AreEqual("200", actual.Code);
            
        }

        /// <summary>
        ///A test for GetIsStorageExist
        ///</summary>
        [TestMethod()]
        public void TestGetIsStorageExist()
        {
            string name = "AsposeDropboxStorage"; 

            
            Com.Aspose.Storage.Model.StorageExistResponse actual;
            actual = target.GetIsStorageExist(name);
            Assert.AreEqual("200", actual.Code);
            
        }

        /// <summary>
        ///A test for GetListFileVersions
        ///</summary>
        [TestMethod()]
        public void TestGetListFileVersions()
        {
            string Path = "files"; 
            string storage = null; 

            
            Com.Aspose.Storage.Model.FileVersionsResponse actual;

            actual = target.GetListFileVersions(Path, storage);
            Assert.AreEqual("200", actual.Code);
            
        }

        /// <summary>
        ///A test for GetListFiles
        ///</summary>
        [TestMethod()]
        public void TestGetListFiles()
        {
            string Path = "files"; 
            string storage = null; 

            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.GetListFiles(Path, storage);
            Assert.AreEqual("Ok", actual.Status);
            
        }

        /// <summary>
        ///A test for PostMoveFile
        ///</summary>
        [TestMethod()]
        public void TestPostMoveFile()
        {
            string name = "testfile.txt"; 
            string dest = "new-testfile.txt"; 
            string versionId = null; 
            string storage = null; 
            string destStorage = null;

            target.PutCreate(name, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + name)); 
            Com.Aspose.Storage.Model.MoveFileResponse actual;
            actual = target.PostMoveFile(name, dest, versionId, storage, destStorage);
            Assert.AreEqual("200", actual.Code);
            
        }

        /// <summary>
        ///A test for PostMoveFolder
        ///</summary>
        [TestMethod()]
        public void TestPostMoveFolder()
        {
            string src = "test0"; 
            string dest = "test1"; 
            string storage = null; 
            string destStorage = null;

            target.PutCreateFolder(src, storage, destStorage);

            Com.Aspose.Storage.Model.MoveFolderResponse actual;
            actual = target.PostMoveFolder(src, dest, storage, destStorage);
            Assert.AreEqual("200", actual.Code);
            
        }

        /// <summary>
        ///A test for PutCopy
        ///</summary>
        [TestMethod()]
        public void TestPutCopy()
        {
            string Path = "testfile.txt";
            string newdest = "new-testfile.txt"; 
            string versionId = null; 
            string storage = null; 
            string destStorage = null;
            byte[] file = System.IO.File.ReadAllBytes("\\temp\\resources\\" + Path);

            target.PutCreate(Path, null, null, System.IO.File.ReadAllBytes("\\temp\\resources\\" + Path)); 
            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.PutCopy(Path, newdest, versionId, storage, destStorage, file);
            Assert.AreNotEqual("", actual);
            
        }

        /// <summary>
        ///A test for PutCopyFolder
        ///</summary>
        [TestMethod()]
        public void TestPutCopyFolder()
        {
            string Path = "testfolder";
            string newdest = "new-testfolder"; 
            string storage = null; 
            string destStorage = null;

            target.PutCreateFolder(Path, storage, destStorage);

            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.PutCopyFolder(Path, newdest, storage, destStorage);
            Assert.AreNotEqual("", actual);
            
        }

        /// <summary>
        ///A test for PutCreate
        ///</summary>
        [TestMethod()]
        public void TestPutCreate()
        {
            string Path = "testfile.txt"; 
            string versionId = null; 
            string storage = null;
            byte[] file = System.IO.File.ReadAllBytes("\\temp\\resources\\" + Path); 

            
            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.PutCreate(Path, versionId, storage, file);
            Assert.AreEqual(200, actual.Code);
            
        }

        /// <summary>
        ///A test for PutCreateFolder
        ///</summary>
        [TestMethod()]
        public void TestPutCreateFolder()
        {
            string Path = "NewFolder_one"; 
            string storage = null; 
            string destStorage = null; 
            
            Com.Aspose.Storage.Model.ResponseMessage actual;
            actual = target.PutCreateFolder(Path, storage, destStorage);
            Assert.AreNotEqual("", actual);
            
        }

    }
}
