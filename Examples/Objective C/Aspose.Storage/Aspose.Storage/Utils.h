//
//  Utils.h
//  Aspose.Barcode
//
//  Created on 12/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Utils : NSObject

+ (void)setAppKeyAndAppSID;
+ (void)uploadFile:(NSString *) fileName;
+ (void)createFolder:(NSString *) folderName storageName:(NSString *)storageName;

@end
