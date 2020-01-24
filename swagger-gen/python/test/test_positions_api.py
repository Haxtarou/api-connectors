# coding: utf-8

"""
    Bybit API

    ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]    # noqa: E501

    OpenAPI spec version: 1.0.0
    Contact: support@bybit.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.positions_api import PositionsApi  # noqa: E501
from swagger_client.rest import ApiException


class TestPositionsApi(unittest.TestCase):
    """PositionsApi unit test stubs"""

    def setUp(self):
        self.api = swagger_client.api.positions_api.PositionsApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_positions_change_margin(self):
        """Test case for positions_change_margin

        Update margin.  # noqa: E501
        """
        pass

    def test_positions_my_position(self):
        """Test case for positions_my_position

        Get my position list.  # noqa: E501
        """
        pass

    def test_positions_my_position_v2(self):
        """Test case for positions_my_position_v2

        Get my position list.  # noqa: E501
        """
        pass

    def test_positions_save_leverage(self):
        """Test case for positions_save_leverage

        Change user leverage.  # noqa: E501
        """
        pass

    def test_positions_trading_stop(self):
        """Test case for positions_trading_stop

        Set Trading-Stop Condition.  # noqa: E501
        """
        pass

    def test_positions_user_leverage(self):
        """Test case for positions_user_leverage

        Get user leverage setting.  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
