=begin
#Bybit API

### REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]  

OpenAPI spec version: 1.0.0
Contact: support@bybit.com
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 2.4.8

=end

require 'spec_helper'
require 'json'

# Unit tests for SwaggerClient::FundingApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'FundingApi' do
  before do
    # run before each test
    @instance = SwaggerClient::FundingApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of FundingApi' do
    it 'should create an instance of FundingApi' do
      expect(@instance).to be_instance_of(SwaggerClient::FundingApi)
    end
  end

  # unit tests for funding_get_rate
  # Funding settlement occurs every 8 hours at 00:00 UTC, 08:00 UTC and 16:00 UTC. The current interval&#39;s fund fee settlement is based on the previous interval&#39;s fund rate. For example, at 16:00, the settlement is based on the fund rate generated at 8:00. The fund rate generated at 16:00 will be used at 0:00 on the next day.
  # @param symbol Contract type.
  # @param [Hash] opts the optional parameters
  # @return [Object]
  describe 'funding_get_rate test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for funding_predicted
  # Get predicted funding rate and funding fee.
  # @param symbol Contract type.
  # @param [Hash] opts the optional parameters
  # @return [Object]
  describe 'funding_predicted test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for funding_predicted_rate
  # Get predicted funding rate and funding fee.
  # @param symbol Contract type.
  # @param [Hash] opts the optional parameters
  # @return [Object]
  describe 'funding_predicted_rate test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
