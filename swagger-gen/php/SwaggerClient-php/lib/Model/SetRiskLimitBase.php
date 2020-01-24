<?php
/**
 * SetRiskLimitBase
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 2.4.8
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * SetRiskLimitBase Class Doc Comment
 *
 * @category Class
 * @description Set risk limit.
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class SetRiskLimitBase implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'SetRiskLimitBase';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'ret_code' => 'float',
        'ret_msg' => 'string',
        'ext_code' => 'string',
        'ext_info' => 'string',
        'result' => 'object',
        'time_now' => 'string'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'ret_code' => 'int32',
        'ret_msg' => null,
        'ext_code' => null,
        'ext_info' => null,
        'result' => null,
        'time_now' => null
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'ret_code' => 'ret_code',
        'ret_msg' => 'ret_msg',
        'ext_code' => 'ext_code',
        'ext_info' => 'ext_info',
        'result' => 'result',
        'time_now' => 'time_now'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'ret_code' => 'setRetCode',
        'ret_msg' => 'setRetMsg',
        'ext_code' => 'setExtCode',
        'ext_info' => 'setExtInfo',
        'result' => 'setResult',
        'time_now' => 'setTimeNow'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'ret_code' => 'getRetCode',
        'ret_msg' => 'getRetMsg',
        'ext_code' => 'getExtCode',
        'ext_info' => 'getExtInfo',
        'result' => 'getResult',
        'time_now' => 'getTimeNow'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }

    

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['ret_code'] = isset($data['ret_code']) ? $data['ret_code'] : null;
        $this->container['ret_msg'] = isset($data['ret_msg']) ? $data['ret_msg'] : null;
        $this->container['ext_code'] = isset($data['ext_code']) ? $data['ext_code'] : null;
        $this->container['ext_info'] = isset($data['ext_info']) ? $data['ext_info'] : null;
        $this->container['result'] = isset($data['result']) ? $data['result'] : null;
        $this->container['time_now'] = isset($data['time_now']) ? $data['time_now'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets ret_code
     *
     * @return float
     */
    public function getRetCode()
    {
        return $this->container['ret_code'];
    }

    /**
     * Sets ret_code
     *
     * @param float $ret_code ret_code
     *
     * @return $this
     */
    public function setRetCode($ret_code)
    {
        $this->container['ret_code'] = $ret_code;

        return $this;
    }

    /**
     * Gets ret_msg
     *
     * @return string
     */
    public function getRetMsg()
    {
        return $this->container['ret_msg'];
    }

    /**
     * Sets ret_msg
     *
     * @param string $ret_msg ret_msg
     *
     * @return $this
     */
    public function setRetMsg($ret_msg)
    {
        $this->container['ret_msg'] = $ret_msg;

        return $this;
    }

    /**
     * Gets ext_code
     *
     * @return string
     */
    public function getExtCode()
    {
        return $this->container['ext_code'];
    }

    /**
     * Sets ext_code
     *
     * @param string $ext_code ext_code
     *
     * @return $this
     */
    public function setExtCode($ext_code)
    {
        $this->container['ext_code'] = $ext_code;

        return $this;
    }

    /**
     * Gets ext_info
     *
     * @return string
     */
    public function getExtInfo()
    {
        return $this->container['ext_info'];
    }

    /**
     * Sets ext_info
     *
     * @param string $ext_info ext_info
     *
     * @return $this
     */
    public function setExtInfo($ext_info)
    {
        $this->container['ext_info'] = $ext_info;

        return $this;
    }

    /**
     * Gets result
     *
     * @return object
     */
    public function getResult()
    {
        return $this->container['result'];
    }

    /**
     * Sets result
     *
     * @param object $result result
     *
     * @return $this
     */
    public function setResult($result)
    {
        $this->container['result'] = $result;

        return $this;
    }

    /**
     * Gets time_now
     *
     * @return string
     */
    public function getTimeNow()
    {
        return $this->container['time_now'];
    }

    /**
     * Sets time_now
     *
     * @param string $time_now time_now
     *
     * @return $this
     */
    public function setTimeNow($time_now)
    {
        $this->container['time_now'] = $time_now;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}


