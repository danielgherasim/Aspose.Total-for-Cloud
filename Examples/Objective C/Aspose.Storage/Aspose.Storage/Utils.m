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
    [ASPApiClient setAppKey:@"da77c9f5da014d91faf2961ecec2de66" andAppSID:@"B01A15E5-1B83-4B9A-8EB3-0F2BFA6AC766"];
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
