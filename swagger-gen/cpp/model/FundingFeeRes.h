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
 * FundingFeeRes.h
 *
 * Get the last funding fee
 */

#ifndef IO_SWAGGER_CLIENT_MODEL_FundingFeeRes_H_
#define IO_SWAGGER_CLIENT_MODEL_FundingFeeRes_H_


#include "../ModelBase.h"

#include <cpprest/details/basic_types.h>

namespace io {
namespace swagger {
namespace client {
namespace model {

/// <summary>
/// Get the last funding fee
/// </summary>
class  FundingFeeRes
    : public ModelBase
{
public:
    FundingFeeRes();
    virtual ~FundingFeeRes();

    /////////////////////////////////////////////
    /// ModelBase overrides

    void validate() override;

    web::json::value toJson() const override;
    void fromJson(web::json::value& json) override;

    void toMultipart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& namePrefix) const override;
    void fromMultiPart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& namePrefix) override;

    /////////////////////////////////////////////
    /// FundingFeeRes members

    /// <summary>
    /// 
    /// </summary>
    utility::string_t getSymbol() const;
    bool symbolIsSet() const;
    void unsetSymbol();
    void setSymbol(utility::string_t value);
    /// <summary>
    /// 
    /// </summary>
    utility::string_t getSide() const;
    bool sideIsSet() const;
    void unsetSide();
    void setSide(utility::string_t value);
    /// <summary>
    /// 
    /// </summary>
    double getSize() const;
    bool sizeIsSet() const;
    void unsetSize();
    void setSize(double value);
    /// <summary>
    /// 
    /// </summary>
    utility::string_t getFundingRate() const;
    bool fundingRateIsSet() const;
    void unsetFunding_rate();
    void setFundingRate(utility::string_t value);
    /// <summary>
    /// 
    /// </summary>
    double getExecFee() const;
    bool execFeeIsSet() const;
    void unsetExec_fee();
    void setExecFee(double value);
    /// <summary>
    /// 
    /// </summary>
    double getExecTimestamp() const;
    bool execTimestampIsSet() const;
    void unsetExec_timestamp();
    void setExecTimestamp(double value);

protected:
    utility::string_t m_Symbol;
    bool m_SymbolIsSet;
    utility::string_t m_Side;
    bool m_SideIsSet;
    double m_Size;
    bool m_SizeIsSet;
    utility::string_t m_Funding_rate;
    bool m_Funding_rateIsSet;
    double m_Exec_fee;
    bool m_Exec_feeIsSet;
    double m_Exec_timestamp;
    bool m_Exec_timestampIsSet;
};

}
}
}
}

#endif /* IO_SWAGGER_CLIENT_MODEL_FundingFeeRes_H_ */
