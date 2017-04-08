//
//  Folder.m
//  Aspose.Storage
//
//  Created on 03/04/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Folder.h"
#import "ASPStorageApi.h"
#import "Utils.h"

@implementation Folder

- (id)init {
    self = [super init];
    
    self.storageApi = [[ASPStorageApi alloc] init];
    
    return self;
}

- (void)createFolder {
    //ExStart:CreateFolder
    
    [self.storageApi putCreateFolderWithCompletionBlock:@"testfolder"
                                                storage:nil
                                            destStorage:nil
                                      completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                          NSLog(@"%@", output);
                                      }];
    //ExEnd:CreateFolder
}

- (void)createFolderOnThirdPartyStorage {
    //ExStart:CreateFolderOnThirdPartyStorage
    
    [self.storageApi putCreateFolderWithCompletionBlock:@"testfolder"
                                                storage:nil
                                            destStorage:@"MyDropboxStorage"
                                      completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                          NSLog(@"%@", output);
                                      }];
    //ExEnd:CreateFolderOnThirdPartyStorage
}

- (void)deleteFolder {
    //ExStart:DeleteFolder
    
    NSString *folderName = @"testfolder";
    
    // First create folder
    [Utils createFolder:folderName storageName:nil];
    
    // Now delete folder
    [self.storageApi deleteFolderWithCompletionBlock:folderName
                                             storage:nil
                                           recursive:[NSNumber numberWithBool:YES]
                                   completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                       NSLog(@"%@", output);
                                   }];
    //ExEnd:DeleteFolder
}

- (void)deleteFolderFromThirdPartyStorage {
    //ExStart:DeleteFolderFromThirdPartyStorage
    
    NSString *folderName = @"testfolder";
    NSString *storageName = @"MyDropboxStorage";
    
    // First create folder
    [Utils createFolder:folderName storageName:storageName];
    
    // Now delete folder
    [self.storageApi deleteFolderWithCompletionBlock:folderName
                                             storage:nil
                                           recursive:[NSNumber numberWithBool:YES]
                                   completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                       NSLog(@"%@", output);
                                   }];
    //ExEnd:DeleteFolderFromThirdPartyStorage
}

@end
