#import <Foundation/Foundation.h>
#import "SWGObject.h"

/**
* Bybit API
* ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]  
*
* OpenAPI spec version: 1.0.0
* Contact: support@bybit.com
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/


#import "SWGSymbolInfo.h"
@protocol SWGSymbolInfo;
@class SWGSymbolInfo;



@protocol SWGSymbols
@end

@interface SWGSymbols : SWGObject


@property(nonatomic) NSNumber* retCode;

@property(nonatomic) NSString* retMsg;

@property(nonatomic) NSString* extCode;

@property(nonatomic) NSString* extInfo;

@property(nonatomic) NSArray<SWGSymbolInfo>* result;

@property(nonatomic) NSString* timeNow;

@end
