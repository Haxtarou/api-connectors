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
 * Object.h
 *
 * This is the implementation of a JSON object.
 */

#ifndef IO_SWAGGER_CLIENT_MODEL_Object_H_
#define IO_SWAGGER_CLIENT_MODEL_Object_H_


#include "ModelBase.h"

#include <cpprest/details/basic_types.h>
#include <cpprest/json.h>

namespace io {
namespace swagger {
namespace client {
namespace model {

class  Object : public ModelBase
{
public:
    Object();
    virtual ~Object();

    /////////////////////////////////////////////
    /// ModelBase overrides
    void validate() override;

    web::json::value toJson() const override;
    void fromJson(web::json::value& json) override;

    void toMultipart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& namePrefix) const override;
    void fromMultiPart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& namePrefix) override;

    /////////////////////////////////////////////
    /// Object manipulation
    web::json::value getValue(const utility::string_t& key) const;
    void setValue(const utility::string_t& key, const web::json::value& value);

private:
    web::json::value m_object;
};

}
}
}
}

#endif /* IO_SWAGGER_CLIENT_MODEL_Object_H_ */
