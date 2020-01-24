/**
 * Bybit API
 * ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]  
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@bybit.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.8
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.BybitApi);
  }
}(this, function(expect, BybitApi) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new BybitApi.PositionsApi();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('PositionsApi', function() {
    describe('positionsChangeMargin', function() {
      it('should call positionsChangeMargin successfully', function(done) {
        //uncomment below and update the code to test positionsChangeMargin
        //instance.positionsChangeMargin(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('positionsMyPosition', function() {
      it('should call positionsMyPosition successfully', function(done) {
        //uncomment below and update the code to test positionsMyPosition
        //instance.positionsMyPosition(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('positionsMyPositionV2', function() {
      it('should call positionsMyPositionV2 successfully', function(done) {
        //uncomment below and update the code to test positionsMyPositionV2
        //instance.positionsMyPositionV2(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('positionsSaveLeverage', function() {
      it('should call positionsSaveLeverage successfully', function(done) {
        //uncomment below and update the code to test positionsSaveLeverage
        //instance.positionsSaveLeverage(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('positionsTradingStop', function() {
      it('should call positionsTradingStop successfully', function(done) {
        //uncomment below and update the code to test positionsTradingStop
        //instance.positionsTradingStop(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('positionsUserLeverage', function() {
      it('should call positionsUserLeverage successfully', function(done) {
        //uncomment below and update the code to test positionsUserLeverage
        //instance.positionsUserLeverage(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
  });

}));