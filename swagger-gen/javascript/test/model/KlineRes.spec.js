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
    instance = new BybitApi.KlineRes();
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

  describe('KlineRes', function() {
    it('should create an instance of KlineRes', function() {
      // uncomment below and update the code to test KlineRes
      //var instance = new BybitApi.KlineRes();
      //expect(instance).to.be.a(BybitApi.KlineRes);
    });

    it('should have the property symbol (base name: "symbol")', function() {
      // uncomment below and update the code to test the property symbol
      //var instance = new BybitApi.KlineRes();
      //expect(instance).to.be();
    });

    it('should have the property interval (base name: "interval")', function() {
      // uncomment below and update the code to test the property interval
      //var instance = new BybitApi.KlineRes();
      //expect(instance).to.be();
    });

    it('should have the property openTime (base name: "open_time")', function() {
      // uncomment below and update the code to test the property openTime
      //var instance = new BybitApi.KlineRes();
      //expect(instance).to.be();
    });

    it('should have the property open (base name: "open")', function() {
      // uncomment below and update the code to test the property open
      //var instance = new BybitApi.KlineRes();
      //expect(instance).to.be();
    });

    it('should have the property high (base name: "high")', function() {
      // uncomment below and update the code to test the property high
      //var instance = new BybitApi.KlineRes();
      //expect(instance).to.be();
    });

    it('should have the property low (base name: "low")', function() {
      // uncomment below and update the code to test the property low
      //var instance = new BybitApi.KlineRes();
      //expect(instance).to.be();
    });

    it('should have the property close (base name: "close")', function() {
      // uncomment below and update the code to test the property close
      //var instance = new BybitApi.KlineRes();
      //expect(instance).to.be();
    });

    it('should have the property volume (base name: "volume")', function() {
      // uncomment below and update the code to test the property volume
      //var instance = new BybitApi.KlineRes();
      //expect(instance).to.be();
    });

  });

}));