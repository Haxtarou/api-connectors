# coding: utf-8

"""
    Bybit API

    ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]    # noqa: E501

    OpenAPI spec version: 1.0.0
    Contact: support@bybit.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six


class ExtFields(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'o_req_num': 'float',
        'xreq_type': 'str',
        'xreq_offset': 'float'
    }

    attribute_map = {
        'o_req_num': 'o_req_num',
        'xreq_type': 'xreq_type',
        'xreq_offset': 'xreq_offset'
    }

    def __init__(self, o_req_num=None, xreq_type=None, xreq_offset=None):  # noqa: E501
        """ExtFields - a model defined in Swagger"""  # noqa: E501

        self._o_req_num = None
        self._xreq_type = None
        self._xreq_offset = None
        self.discriminator = None

        if o_req_num is not None:
            self.o_req_num = o_req_num
        if xreq_type is not None:
            self.xreq_type = xreq_type
        if xreq_offset is not None:
            self.xreq_offset = xreq_offset

    @property
    def o_req_num(self):
        """Gets the o_req_num of this ExtFields.  # noqa: E501


        :return: The o_req_num of this ExtFields.  # noqa: E501
        :rtype: float
        """
        return self._o_req_num

    @o_req_num.setter
    def o_req_num(self, o_req_num):
        """Sets the o_req_num of this ExtFields.


        :param o_req_num: The o_req_num of this ExtFields.  # noqa: E501
        :type: float
        """

        self._o_req_num = o_req_num

    @property
    def xreq_type(self):
        """Gets the xreq_type of this ExtFields.  # noqa: E501


        :return: The xreq_type of this ExtFields.  # noqa: E501
        :rtype: str
        """
        return self._xreq_type

    @xreq_type.setter
    def xreq_type(self, xreq_type):
        """Sets the xreq_type of this ExtFields.


        :param xreq_type: The xreq_type of this ExtFields.  # noqa: E501
        :type: str
        """

        self._xreq_type = xreq_type

    @property
    def xreq_offset(self):
        """Gets the xreq_offset of this ExtFields.  # noqa: E501


        :return: The xreq_offset of this ExtFields.  # noqa: E501
        :rtype: float
        """
        return self._xreq_offset

    @xreq_offset.setter
    def xreq_offset(self, xreq_offset):
        """Sets the xreq_offset of this ExtFields.


        :param xreq_offset: The xreq_offset of this ExtFields.  # noqa: E501
        :type: float
        """

        self._xreq_offset = xreq_offset

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(ExtFields, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, ExtFields):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
