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


class FundingRecords(object):
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
        'id': 'float',
        'user_id': 'float',
        'coin': 'str',
        'wallet_id': 'float',
        'type': 'str',
        'amount': 'str',
        'tx_id': 'str',
        'address': 'str',
        'wallet_balance': 'str',
        'exec_time': 'str',
        'cross_seq': 'float'
    }

    attribute_map = {
        'id': 'id',
        'user_id': 'user_id',
        'coin': 'coin',
        'wallet_id': 'wallet_id',
        'type': 'type',
        'amount': 'amount',
        'tx_id': 'tx_id',
        'address': 'address',
        'wallet_balance': 'wallet_balance',
        'exec_time': 'exec_time',
        'cross_seq': 'cross_seq'
    }

    def __init__(self, id=None, user_id=None, coin=None, wallet_id=None, type=None, amount=None, tx_id=None, address=None, wallet_balance=None, exec_time=None, cross_seq=None):  # noqa: E501
        """FundingRecords - a model defined in Swagger"""  # noqa: E501

        self._id = None
        self._user_id = None
        self._coin = None
        self._wallet_id = None
        self._type = None
        self._amount = None
        self._tx_id = None
        self._address = None
        self._wallet_balance = None
        self._exec_time = None
        self._cross_seq = None
        self.discriminator = None

        if id is not None:
            self.id = id
        if user_id is not None:
            self.user_id = user_id
        if coin is not None:
            self.coin = coin
        if wallet_id is not None:
            self.wallet_id = wallet_id
        if type is not None:
            self.type = type
        if amount is not None:
            self.amount = amount
        if tx_id is not None:
            self.tx_id = tx_id
        if address is not None:
            self.address = address
        if wallet_balance is not None:
            self.wallet_balance = wallet_balance
        if exec_time is not None:
            self.exec_time = exec_time
        if cross_seq is not None:
            self.cross_seq = cross_seq

    @property
    def id(self):
        """Gets the id of this FundingRecords.  # noqa: E501


        :return: The id of this FundingRecords.  # noqa: E501
        :rtype: float
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this FundingRecords.


        :param id: The id of this FundingRecords.  # noqa: E501
        :type: float
        """

        self._id = id

    @property
    def user_id(self):
        """Gets the user_id of this FundingRecords.  # noqa: E501


        :return: The user_id of this FundingRecords.  # noqa: E501
        :rtype: float
        """
        return self._user_id

    @user_id.setter
    def user_id(self, user_id):
        """Sets the user_id of this FundingRecords.


        :param user_id: The user_id of this FundingRecords.  # noqa: E501
        :type: float
        """

        self._user_id = user_id

    @property
    def coin(self):
        """Gets the coin of this FundingRecords.  # noqa: E501


        :return: The coin of this FundingRecords.  # noqa: E501
        :rtype: str
        """
        return self._coin

    @coin.setter
    def coin(self, coin):
        """Sets the coin of this FundingRecords.


        :param coin: The coin of this FundingRecords.  # noqa: E501
        :type: str
        """

        self._coin = coin

    @property
    def wallet_id(self):
        """Gets the wallet_id of this FundingRecords.  # noqa: E501


        :return: The wallet_id of this FundingRecords.  # noqa: E501
        :rtype: float
        """
        return self._wallet_id

    @wallet_id.setter
    def wallet_id(self, wallet_id):
        """Sets the wallet_id of this FundingRecords.


        :param wallet_id: The wallet_id of this FundingRecords.  # noqa: E501
        :type: float
        """

        self._wallet_id = wallet_id

    @property
    def type(self):
        """Gets the type of this FundingRecords.  # noqa: E501


        :return: The type of this FundingRecords.  # noqa: E501
        :rtype: str
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this FundingRecords.


        :param type: The type of this FundingRecords.  # noqa: E501
        :type: str
        """

        self._type = type

    @property
    def amount(self):
        """Gets the amount of this FundingRecords.  # noqa: E501


        :return: The amount of this FundingRecords.  # noqa: E501
        :rtype: str
        """
        return self._amount

    @amount.setter
    def amount(self, amount):
        """Sets the amount of this FundingRecords.


        :param amount: The amount of this FundingRecords.  # noqa: E501
        :type: str
        """

        self._amount = amount

    @property
    def tx_id(self):
        """Gets the tx_id of this FundingRecords.  # noqa: E501


        :return: The tx_id of this FundingRecords.  # noqa: E501
        :rtype: str
        """
        return self._tx_id

    @tx_id.setter
    def tx_id(self, tx_id):
        """Sets the tx_id of this FundingRecords.


        :param tx_id: The tx_id of this FundingRecords.  # noqa: E501
        :type: str
        """

        self._tx_id = tx_id

    @property
    def address(self):
        """Gets the address of this FundingRecords.  # noqa: E501


        :return: The address of this FundingRecords.  # noqa: E501
        :rtype: str
        """
        return self._address

    @address.setter
    def address(self, address):
        """Sets the address of this FundingRecords.


        :param address: The address of this FundingRecords.  # noqa: E501
        :type: str
        """

        self._address = address

    @property
    def wallet_balance(self):
        """Gets the wallet_balance of this FundingRecords.  # noqa: E501


        :return: The wallet_balance of this FundingRecords.  # noqa: E501
        :rtype: str
        """
        return self._wallet_balance

    @wallet_balance.setter
    def wallet_balance(self, wallet_balance):
        """Sets the wallet_balance of this FundingRecords.


        :param wallet_balance: The wallet_balance of this FundingRecords.  # noqa: E501
        :type: str
        """

        self._wallet_balance = wallet_balance

    @property
    def exec_time(self):
        """Gets the exec_time of this FundingRecords.  # noqa: E501


        :return: The exec_time of this FundingRecords.  # noqa: E501
        :rtype: str
        """
        return self._exec_time

    @exec_time.setter
    def exec_time(self, exec_time):
        """Sets the exec_time of this FundingRecords.


        :param exec_time: The exec_time of this FundingRecords.  # noqa: E501
        :type: str
        """

        self._exec_time = exec_time

    @property
    def cross_seq(self):
        """Gets the cross_seq of this FundingRecords.  # noqa: E501


        :return: The cross_seq of this FundingRecords.  # noqa: E501
        :rtype: float
        """
        return self._cross_seq

    @cross_seq.setter
    def cross_seq(self, cross_seq):
        """Sets the cross_seq of this FundingRecords.


        :param cross_seq: The cross_seq of this FundingRecords.  # noqa: E501
        :type: float
        """

        self._cross_seq = cross_seq

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
        if issubclass(FundingRecords, dict):
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
        if not isinstance(other, FundingRecords):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
