=begin
#Bybit API

### REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]  

OpenAPI spec version: 1.0.0
Contact: support@bybit.com
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 2.4.8

=end

require 'uri'

module SwaggerClient
  class PositionsApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Update margin.
    # @param symbol Contract type which you want update its margin
    # @param margin New margin you want set
    # @param [Hash] opts the optional parameters
    # @return [Object]
    def positions_change_margin(symbol, margin, opts = {})
      data, _status_code, _headers = positions_change_margin_with_http_info(symbol, margin, opts)
      data
    end

    # Update margin.
    # @param symbol Contract type which you want update its margin
    # @param margin New margin you want set
    # @param [Hash] opts the optional parameters
    # @return [Array<(Object, Fixnum, Hash)>] Object data, response status code and response headers
    def positions_change_margin_with_http_info(symbol, margin, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: PositionsApi.positions_change_margin ...'
      end
      # verify the required parameter 'symbol' is set
      if @api_client.config.client_side_validation && symbol.nil?
        fail ArgumentError, "Missing the required parameter 'symbol' when calling PositionsApi.positions_change_margin"
      end
      # verify the required parameter 'margin' is set
      if @api_client.config.client_side_validation && margin.nil?
        fail ArgumentError, "Missing the required parameter 'margin' when calling PositionsApi.positions_change_margin"
      end
      # resource path
      local_var_path = '/position/change-position-margin'

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json', 'application/x-www-form-urlencoded'])

      # form parameters
      form_params = {}
      form_params['symbol'] = symbol
      form_params['margin'] = margin

      # http body (model)
      post_body = nil
      auth_names = ['apiKey', 'apiSignature', 'timestamp']
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Object')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: PositionsApi#positions_change_margin\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get my position list.
    # @param [Hash] opts the optional parameters
    # @return [Object]
    def positions_my_position(opts = {})
      data, _status_code, _headers = positions_my_position_with_http_info(opts)
      data
    end

    # Get my position list.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Object, Fixnum, Hash)>] Object data, response status code and response headers
    def positions_my_position_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: PositionsApi.positions_my_position ...'
      end
      # resource path
      local_var_path = '/position/list'

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json', 'application/x-www-form-urlencoded'])

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      auth_names = ['apiKey', 'apiSignature', 'timestamp']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Object')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: PositionsApi#positions_my_position\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get my position list.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :symbol Contract type which you want update its margin
    # @return [Object]
    def positions_my_position_v2(opts = {})
      data, _status_code, _headers = positions_my_position_v2_with_http_info(opts)
      data
    end

    # Get my position list.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :symbol Contract type which you want update its margin
    # @return [Array<(Object, Fixnum, Hash)>] Object data, response status code and response headers
    def positions_my_position_v2_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: PositionsApi.positions_my_position_v2 ...'
      end
      # resource path
      local_var_path = '/v2/private/position/list'

      # query parameters
      query_params = {}
      query_params[:'symbol'] = opts[:'symbol'] if !opts[:'symbol'].nil?

      # header parameters
      header_params = {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json', 'application/x-www-form-urlencoded'])

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      auth_names = ['apiKey', 'apiSignature', 'timestamp']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Object')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: PositionsApi#positions_my_position_v2\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Change user leverage.
    # @param symbol A symbol which you want change its leverage
    # @param leverage New leverage you want set
    # @param [Hash] opts the optional parameters
    # @return [Object]
    def positions_save_leverage(symbol, leverage, opts = {})
      data, _status_code, _headers = positions_save_leverage_with_http_info(symbol, leverage, opts)
      data
    end

    # Change user leverage.
    # @param symbol A symbol which you want change its leverage
    # @param leverage New leverage you want set
    # @param [Hash] opts the optional parameters
    # @return [Array<(Object, Fixnum, Hash)>] Object data, response status code and response headers
    def positions_save_leverage_with_http_info(symbol, leverage, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: PositionsApi.positions_save_leverage ...'
      end
      # verify the required parameter 'symbol' is set
      if @api_client.config.client_side_validation && symbol.nil?
        fail ArgumentError, "Missing the required parameter 'symbol' when calling PositionsApi.positions_save_leverage"
      end
      # verify the required parameter 'leverage' is set
      if @api_client.config.client_side_validation && leverage.nil?
        fail ArgumentError, "Missing the required parameter 'leverage' when calling PositionsApi.positions_save_leverage"
      end
      # resource path
      local_var_path = '/user/leverage/save'

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json', 'application/x-www-form-urlencoded'])

      # form parameters
      form_params = {}
      form_params['symbol'] = symbol
      form_params['leverage'] = leverage

      # http body (model)
      post_body = nil
      auth_names = ['apiKey', 'apiSignature', 'timestamp']
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Object')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: PositionsApi#positions_save_leverage\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Set Trading-Stop Condition.
    # @param symbol Contract type
    # @param [Hash] opts the optional parameters
    # @option opts [String] :take_profit Not less than 0, 0 means cancel TP
    # @option opts [String] :stop_loss Not less than 0, 0 means cancel SL
    # @option opts [String] :trailing_stop Not less than 0, 0 means cancel TS
    # @return [Object]
    def positions_trading_stop(symbol, opts = {})
      data, _status_code, _headers = positions_trading_stop_with_http_info(symbol, opts)
      data
    end

    # Set Trading-Stop Condition.
    # @param symbol Contract type
    # @param [Hash] opts the optional parameters
    # @option opts [String] :take_profit Not less than 0, 0 means cancel TP
    # @option opts [String] :stop_loss Not less than 0, 0 means cancel SL
    # @option opts [String] :trailing_stop Not less than 0, 0 means cancel TS
    # @return [Array<(Object, Fixnum, Hash)>] Object data, response status code and response headers
    def positions_trading_stop_with_http_info(symbol, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: PositionsApi.positions_trading_stop ...'
      end
      # verify the required parameter 'symbol' is set
      if @api_client.config.client_side_validation && symbol.nil?
        fail ArgumentError, "Missing the required parameter 'symbol' when calling PositionsApi.positions_trading_stop"
      end
      # resource path
      local_var_path = '/open-api/position/trading-stop'

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json', 'application/x-www-form-urlencoded'])

      # form parameters
      form_params = {}
      form_params['symbol'] = symbol
      form_params['take_profit'] = opts[:'take_profit'] if !opts[:'take_profit'].nil?
      form_params['stop_loss'] = opts[:'stop_loss'] if !opts[:'stop_loss'].nil?
      form_params['trailing_stop'] = opts[:'trailing_stop'] if !opts[:'trailing_stop'].nil?

      # http body (model)
      post_body = nil
      auth_names = ['apiKey', 'apiSignature', 'timestamp']
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Object')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: PositionsApi#positions_trading_stop\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get user leverage setting.
    # @param [Hash] opts the optional parameters
    # @return [Object]
    def positions_user_leverage(opts = {})
      data, _status_code, _headers = positions_user_leverage_with_http_info(opts)
      data
    end

    # Get user leverage setting.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Object, Fixnum, Hash)>] Object data, response status code and response headers
    def positions_user_leverage_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: PositionsApi.positions_user_leverage ...'
      end
      # resource path
      local_var_path = '/user/leverage'

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json', 'application/x-www-form-urlencoded'])

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      auth_names = ['apiKey', 'apiSignature', 'timestamp']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Object')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: PositionsApi#positions_user_leverage\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end