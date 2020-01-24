#import <Foundation/Foundation.h>
#import "SWGApi.h"

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



@interface SWGMarketApi: NSObject <SWGApi>

extern NSString* kSWGMarketApiErrorDomain;
extern NSInteger kSWGMarketApiMissingParamErrorCode;

-(instancetype) initWithApiClient:(SWGApiClient *)apiClient NS_DESIGNATED_INITIALIZER;

/// Get the orderbook.
/// 
///
/// @param symbol Contract type.
/// 
///  code:200 message:"Request was successful"
///
/// @return NSObject*
-(NSURLSessionTask*) marketOrderbookWithSymbol: (NSString*) symbol
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;


/// Get the latest information for symbol.
/// 
///
/// @param symbol Contract type. (optional)
/// 
///  code:200 message:"Request was successful"
///
/// @return NSObject*
-(NSURLSessionTask*) marketSymbolInfoWithSymbol: (NSString*) symbol
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;



@end
