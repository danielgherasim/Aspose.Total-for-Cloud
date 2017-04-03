//
//  DiskUsage.m
//  Aspose.Storage
//
//  Created on 03/04/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "DiskUsage.h"
#import "ASPStorageApi.h"
#import "Utils.h"

@implementation DiskUsage

- (id)init {
    self = [super init];
    
    self.storageApi = [[ASPStorageApi alloc] init];
    
    return self;
}

- (void)getDiscUsage {
    //ExStart:GetDiscUsage
    
    [self.storageApi getDiscUsageWithCompletionBlock:nil completionHandler:^(ASPDiscUsageResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:GetDiscUsage
}

- (void)getDiskUsageFromThirdPartyStorage {
    //ExStart:GetDiskUsageFromThirdPartyStorage
    
    [self.storageApi getDiscUsageWithCompletionBlock:@"MyDropboxStorage" completionHandler:^(ASPDiscUsageResponse *output, NSError *error) {
        NSLog(@"%@", output);
    }];
    //ExEnd:GetDiskUsageFromThirdPartyStorage
}

@end
