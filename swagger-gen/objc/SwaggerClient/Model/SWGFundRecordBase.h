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


#import "SWGFundingRecords.h"
@protocol SWGFundingRecords;
@class SWGFundingRecords;



@protocol SWGFundRecordBase
@end

@interface SWGFundRecordBase : SWGObject


@property(nonatomic) NSNumber* retCode;

@property(nonatomic) NSString* retMsg;

@property(nonatomic) NSString* extCode;

@property(nonatomic) NSString* extInfo;

@property(nonatomic) NSArray<SWGFundingRecords>* result;

@property(nonatomic) NSString* timeNow;

@end
