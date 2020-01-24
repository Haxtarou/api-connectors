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
 * KlineApi.h
 *
 * 
 */

#ifndef IO_SWAGGER_CLIENT_API_KlineApi_H_
#define IO_SWAGGER_CLIENT_API_KlineApi_H_


#include "../ApiClient.h"

#include "Object.h"
#include <cpprest/details/basic_types.h>

#include <boost/optional.hpp>

namespace io {
namespace swagger {
namespace client {
namespace api {

using namespace io::swagger::client::model;

class  KlineApi
{
public:
    KlineApi( std::shared_ptr<ApiClient> apiClient );
    virtual ~KlineApi();
    /// <summary>
    /// Query historical kline.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <param name="symbol">Contract type.</param>
    /// <param name="interval">Kline interval.</param>
    /// <param name="from">from timestamp.</param>
    /// <param name="limit">Contract type. (optional)</param>
    pplx::task<std::shared_ptr<Object>> kline_get(
        utility::string_t symbol,
        utility::string_t interval,
        double from,
        boost::optional<utility::string_t> limit
    );

protected:
    std::shared_ptr<ApiClient> m_ApiClient;
};

}
}
}
}

#endif /* IO_SWAGGER_CLIENT_API_KlineApi_H_ */

