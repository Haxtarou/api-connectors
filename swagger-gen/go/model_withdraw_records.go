/*
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]  
 *
 * API version: 1.0.0
 * Contact: support@bybit.com
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */

package swagger

// Get withdraw records response
type WithdrawRecords struct {
	Id float32 `json:"id,omitempty"`
	UserId float32 `json:"user_id,omitempty"`
	Coin string `json:"coin,omitempty"`
	Status string `json:"status,omitempty"`
	Amount string `json:"amount,omitempty"`
	Fee string `json:"fee,omitempty"`
	Address string `json:"address,omitempty"`
	TxId string `json:"tx_id,omitempty"`
	SubmitedAt string `json:"submited_at,omitempty"`
	UpdatedAt string `json:"updated_at,omitempty"`
}
