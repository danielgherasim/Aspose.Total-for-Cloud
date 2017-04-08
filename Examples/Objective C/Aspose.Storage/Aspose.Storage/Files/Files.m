//
//  Files.m
//  Aspose.Storage
//
//  Created on 03/04/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Files.h"
#import "ASPStorageApi.h"
#import "Utils.h"

@implementation Files

- (id)init {
    self = [super init];
    
    self.storageApi = [[ASPStorageApi alloc] init];
    
    return self;
}

- (void)checkFilePresence {
    //ExStart:CheckFilePresence
    
    // Upload file to Aspose Cloud Storage
    NSString *fileName = @"testfile.txt";
    [Utils uploadFile:fileName];
    
    [self.storageApi getIsExistWithCompletionBlock:fileName
                                         versionId:nil
                                           storage:nil
                                 completionHandler:^(ASPFileExistResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:CheckFilePresence
}

- (void)copyFile {
    //ExStart:CopyFile
    
    // Upload file to Aspose Cloud Storage
    NSString *fileName = @"testfile.txt";
    [Utils uploadFile:fileName];
    
    [self.storageApi putCopyWithCompletionBlock:fileName
                                        newdest:@"copy-testfile.txt"
                                      versionId:nil
                                        storage:nil
                                    destStorage:nil
                                           file:nil
                              completionHandler:^(ASPBaseResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:CopyFile
}

- (void)deleteFile {
    //ExStart:DeleteFile
    
    // Upload file to Aspose Cloud Storage
    NSString *fileName = @"testfile.txt";
    [Utils uploadFile:fileName];
    
    [self.storageApi deleteFileWithCompletionBlock:fileName
                                         versionId:nil
                                           storage:nil
                                 completionHandler:^(ASPBaseResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:DeleteFile
}

- (void)deleteFileFromThirdPartyStorage {
    //ExStart:DeleteFileFromThirdPartyStorage
    
    // Upload file to Aspose Cloud Storage
    NSString *fileName = @"testfile.txt";
    [Utils uploadFile:fileName];
    
    [self.storageApi deleteFileWithCompletionBlock:fileName
                                         versionId:nil
                                           storage:@"MyDropboxStorage"
                                 completionHandler:^(ASPBaseResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:DeleteFileFromThirdPartyStorage
}

- (void)downloadFile {
    //ExStart:DownloadFile
    
    // Upload file to Aspose Cloud Storage
    NSString *fileName = @"testfile.txt";
    [Utils uploadFile:fileName];
    
    [self.storageApi getDownloadWithCompletionBlock:fileName
                                          versionId:nil
                                            storage:nil
                                  completionHandler:^(NSURL *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:DownloadFile
}

- (void)getListFiles {
    //ExStart:GetListFiles
    
    [self.storageApi getListFilesWithCompletionBlock:@""
                                             storage:nil
                                   completionHandler:^(ASPFolderResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:GetListFiles
}

- (void)getListFilesFromThirdPartyStorage {
    //ExStart:GetListFilesFromThirdPartyStorage
    
    [self.storageApi getListFilesWithCompletionBlock:@"Files"
                                             storage:@"MyDropboxStorage"
                                   completionHandler:^(ASPFolderResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:GetListFilesFromThirdPartyStorage
}

- (void)moveFile {
    //ExStart:MoveFile
    
    // Upload file to Aspose Cloud Storage
    NSString *fileName = @"testfile.txt";
    [Utils uploadFile:fileName];
    
    NSString *folderName = @"Files";
    [Utils createFolder:folderName storageName:nil];
    
    [self.storageApi postMoveFileWithCompletionBlock:fileName
                                                dest:[NSString stringWithFormat:@"%@/%@", folderName, fileName]
                                           versionId:nil
                                             storage:nil
                                         destStorage:nil
                                   completionHandler:^(ASPBaseResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:MoveFile
}

- (void)uploadFile {
    //ExStart:UploadFile
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"testfile" withExtension:@"txt"];
    [self.storageApi putCreateWithCompletionBlock:@"testfile.txt"
                                             file:pathToFile
                                        versionId:nil
                                          storage:nil
                                completionHandler:^(ASPBaseResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:UploadFile
}

- (void)uploadFileToThirdPartyStorage {
    //ExStart:UploadFileToThirdPartyStorage
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:@"testfile" withExtension:@"txt"];
    [self.storageApi putCreateWithCompletionBlock:@"testfile.txt"
                                             file:pathToFile
                                        versionId:nil
                                          storage:@"MyDropboxStorage"
                                completionHandler:^(ASPBaseResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:UploadFileToThirdPartyStorage
}


@end
