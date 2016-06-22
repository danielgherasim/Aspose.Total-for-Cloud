//
//  ASPStorageTestCase.m
//  Aspose.Storage_Cloud_SDK_For_ObjC
//
//  Created by Muhammad Sohail Ismail on 15/09/2015.
//  Copyright © 2015 M. Sohail. All rights reserved.
//

#import <XCTest/XCTest.h>
#import "ASPStorageApi.h"

@interface ASPStorageTestCase : XCTestCase
@property(nonatomic, strong) ASPStorageApi *storageApi;
@end

@implementation ASPStorageTestCase

- (void)setUp {
    [super setUp];
    // Put setup code here. This method is called before the invocation of each test method in the class.
    self.storageApi = [[ASPStorageApi alloc] init];
}

- (void)tearDown {
    // Put teardown code here. This method is called after the invocation of each test method in the class.
    [super tearDown];
}

- (void)testGetDiscUsage {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi getDiscUsageWithCompletionBlock:nil completionHandler:^(ASPDiscUsageResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to check the disk usage of the current account.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetIsExist {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi getIsExistWithCompletionBlock:@"barcode.png" versionId:nil storage:nil completionHandler:^(ASPFileExistResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to check if a specific file or folder exists.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDownload {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi getDownloadWithCompletionBlock:@"barcode.png" versionId:nil storage:nil completionHandler:^(NSURL *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to download a specific file.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutCopy {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi putCopyWithCompletionBlock:@"Creative.jpg" newdest:@"copyTo" versionId:nil storage:nil destStorage:nil file:nil completionHandler:^(ASPBaseResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to copy a specific file.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutCreate {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"Creative" withExtension:@"jpg"];
    [self.storageApi putCreateWithCompletionBlock:@"Creative.jpg" file:pathToFile versionId:nil storage:nil completionHandler:^(ASPBaseResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to upload a specific file.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];

}

- (void)testDeleteFile {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi deleteFileWithCompletionBlock:@"barcode.png" versionId:nil storage:nil completionHandler:^(ASPBaseResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to remove a specific file.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostMoveFile {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi postMoveFileWithCompletionBlock:@"barcode.png" dest:@"moveTo" versionId:nil storage:nil destStorage:nil completionHandler:^(ASPBaseResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to move a specific file.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];

}

- (void)testGetListFiles {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi getListFilesWithCompletionBlock:@"" storage:nil completionHandler:^(ASPFolderResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to get the file listing of a specific folder.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}


- (void)testPutCopyFolder {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi putCopyFolderWithCompletionBlock:@"moveFrom" newdest:@"moveTo" storage:nil destStorage:nil completionHandler:^(ASPBaseResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to create the folder.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}


- (void)testPutCreateFolder {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi putCreateFolderWithCompletionBlock:@"newFolder" storage:nil destStorage:nil completionHandler:^(ASPBaseResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to create the folder.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testDeleteFolder {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi deleteFolderWithCompletionBlock:@"Pictures" storage:nil recursive:[NSNumber numberWithBool:YES] completionHandler:^(ASPBaseResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to remove a specific folder.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostMoveFolder {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi postMoveFolderWithCompletionBlock:@"moveFrom" dest:@"moveTo" storage:nil destStorage:nil completionHandler:^(ASPBaseResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to move a specific folder.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetListFileVersions {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi getListFileVersionsWithCompletionBlock:@"barcode.png" storage:nil completionHandler:^(ASPFileVersionsResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to get the file's versions list.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetIsStorageExist {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.storageApi getIsStorageExistWithCompletionBlock:@"MyDropboxStorage" completionHandler:^(ASPStorageExistResponse *output, NSError *error) {
        XCTAssertNotNil(output, @"Failed to check if a specific storage exists.");
        [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:10.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];

}

@end