//
//  Files.h
//  Aspose.Storage
//
//  Created on 03/04/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPStorageApi;

@interface Files : NSObject

@property(nonatomic, strong) ASPStorageApi *storageApi;

- (void)checkFilePresence;
- (void)copyFile;
- (void)deleteFile;
- (void)deleteFileFromThirdPartyStorage;
- (void)downloadFile;
- (void)getListFiles;
- (void)getListFilesFromThirdPartyStorage;
- (void)moveFile;
- (void)uploadFile;
- (void)uploadFileToThirdPartyStorage;

@end
