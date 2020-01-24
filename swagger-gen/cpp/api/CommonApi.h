/**
 * Bybit API
 * ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]  
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@bybit.com
 *
 * NOTE: This class is auto generated by the swagger code generator 2.4.8.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

/*
 * CommonApi.h
 *
 * 
 */

#ifndef IO_SWAGGER_CLIENT_API_CommonApi_H_
#define IO_SWAGGER_CLIENT_API_CommonApi_H_


#include "../ApiClient.h"

#include "Object.h"

#include <boost/optional.hpp>

namespace io {
namespace swagger {
namespace client {
namespace api {

using namespace io::swagger::client::model;

class  CommonApi
{
public:
    CommonApi( std::shared_ptr<ApiClient> apiClient );
    virtual ~CommonApi();
    /// <summary>
    /// Get bybit server time.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    pplx::task<std::shared_ptr<Object>> common_get(
    );

protected:
    std::shared_ptr<ApiClient> m_ApiClient;
};

}
}
}
}

#endif /* IO_SWAGGER_CLIENT_API_CommonApi_H_ */

