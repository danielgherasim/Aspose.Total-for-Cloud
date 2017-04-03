//
//  Utils.m
//  Aspose.Barcode
//
//  Created on 12/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Utils.h"
#import "ASPStorageApi.h"

@implementation Utils

+ (void) setAppKeyAndAppSID {
    //Get App key and App SID from https://cloud.aspose.com
    [ASPApiClient setAppKey:@"" andAppSID:@""];
}

+ (void)uploadFile:(NSString *) fileName {
    
    ASPStorageApi *storageApi = [[ASPStorageApi alloc] init];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:[fileName stringByDeletingPathExtension]
                                                withExtension:[fileName pathExtension]];
    
    [storageApi putCreateWithCompletionBlock:fileName
                                        file:pathToFile
                                   versionId:nil
                                     storage:nil
                           completionHandler:^(ASPBaseResponse *output, NSError *error) {
                               NSLog(@"UploadFile Code: %@ Status: %@", output.code, output.status);
                           }];
}

+ (void)createFolder:(NSString *) folderName storageName:(NSString *)storageName {
    ASPStorageApi *storageApi = [[ASPStorageApi alloc] init];
    
    [storageApi putCreateFolderWithCompletionBlock:folderName
                                                storage:nil
                                            destStorage:storageName
                                      completionHandler:^(ASPBaseResponse *output, NSError *error) {
                                          NSLog(@"%@", output);
                                      }];
}

@end
