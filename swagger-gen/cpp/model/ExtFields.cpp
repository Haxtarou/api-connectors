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



#include "ExtFields.h"

namespace io {
namespace swagger {
namespace client {
namespace model {

ExtFields::ExtFields()
{
    m_O_req_num = 0.0;
    m_O_req_numIsSet = false;
    m_Xreq_type = utility::conversions::to_string_t("");
    m_Xreq_typeIsSet = false;
    m_Xreq_offset = 0.0;
    m_Xreq_offsetIsSet = false;
}

ExtFields::~ExtFields()
{
}

void ExtFields::validate()
{
    // TODO: implement validation
}

web::json::value ExtFields::toJson() const
{
    web::json::value val = web::json::value::object();

    if(m_O_req_numIsSet)
    {
        val[utility::conversions::to_string_t("o_req_num")] = ModelBase::toJson(m_O_req_num);
    }
    if(m_Xreq_typeIsSet)
    {
        val[utility::conversions::to_string_t("xreq_type")] = ModelBase::toJson(m_Xreq_type);
    }
    if(m_Xreq_offsetIsSet)
    {
        val[utility::conversions::to_string_t("xreq_offset")] = ModelBase::toJson(m_Xreq_offset);
    }

    return val;
}

void ExtFields::fromJson(web::json::value& val)
{
    if(val.has_field(utility::conversions::to_string_t("o_req_num")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("o_req_num")];
        if(!fieldValue.is_null())
        {
            setOReqNum(ModelBase::doubleFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("xreq_type")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("xreq_type")];
        if(!fieldValue.is_null())
        {
            setXreqType(ModelBase::stringFromJson(fieldValue));
        }
    }
    if(val.has_field(utility::conversions::to_string_t("xreq_offset")))
    {
        web::json::value& fieldValue = val[utility::conversions::to_string_t("xreq_offset")];
        if(!fieldValue.is_null())
        {
            setXreqOffset(ModelBase::doubleFromJson(fieldValue));
        }
    }
}

void ExtFields::toMultipart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix) const
{
    utility::string_t namePrefix = prefix;
    if(namePrefix.size() > 0 && namePrefix.substr(namePrefix.size() - 1) != utility::conversions::to_string_t("."))
    {
        namePrefix += utility::conversions::to_string_t(".");
    }

    if(m_O_req_numIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("o_req_num"), m_O_req_num));
    }
    if(m_Xreq_typeIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("xreq_type"), m_Xreq_type));
        
    }
    if(m_Xreq_offsetIsSet)
    {
        multipart->add(ModelBase::toHttpContent(namePrefix + utility::conversions::to_string_t("xreq_offset"), m_Xreq_offset));
    }
}

void ExtFields::fromMultiPart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& prefix)
{
    utility::string_t namePrefix = prefix;
    if(namePrefix.size() > 0 && namePrefix.substr(namePrefix.size() - 1) != utility::conversions::to_string_t("."))
    {
        namePrefix += utility::conversions::to_string_t(".");
    }

    if(multipart->hasContent(utility::conversions::to_string_t("o_req_num")))
    {
        setOReqNum(ModelBase::doubleFromHttpContent(multipart->getContent(utility::conversions::to_string_t("o_req_num"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("xreq_type")))
    {
        setXreqType(ModelBase::stringFromHttpContent(multipart->getContent(utility::conversions::to_string_t("xreq_type"))));
    }
    if(multipart->hasContent(utility::conversions::to_string_t("xreq_offset")))
    {
        setXreqOffset(ModelBase::doubleFromHttpContent(multipart->getContent(utility::conversions::to_string_t("xreq_offset"))));
    }
}

double ExtFields::getOReqNum() const
{
    return m_O_req_num;
}


void ExtFields::setOReqNum(double value)
{
    m_O_req_num = value;
    m_O_req_numIsSet = true;
}
bool ExtFields::oReqNumIsSet() const
{
    return m_O_req_numIsSet;
}

void ExtFields::unsetO_req_num()
{
    m_O_req_numIsSet = false;
}

utility::string_t ExtFields::getXreqType() const
{
    return m_Xreq_type;
}


void ExtFields::setXreqType(utility::string_t value)
{
    m_Xreq_type = value;
    m_Xreq_typeIsSet = true;
}
bool ExtFields::xreqTypeIsSet() const
{
    return m_Xreq_typeIsSet;
}

void ExtFields::unsetXreq_type()
{
    m_Xreq_typeIsSet = false;
}

double ExtFields::getXreqOffset() const
{
    return m_Xreq_offset;
}


void ExtFields::setXreqOffset(double value)
{
    m_Xreq_offset = value;
    m_Xreq_offsetIsSet = true;
}
bool ExtFields::xreqOffsetIsSet() const
{
    return m_Xreq_offsetIsSet;
}

void ExtFields::unsetXreq_offset()
{
    m_Xreq_offsetIsSet = false;
}

}
}
}
}

