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
from swagger_client.api.kline_api import KlineApi  # noqa: E501
from swagger_client.rest import ApiException


class TestKlineApi(unittest.TestCase):
    """KlineApi unit test stubs"""

    def setUp(self):
        self.api = swagger_client.api.kline_api.KlineApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_kline_get(self):
        """Test case for kline_get

        Query historical kline.  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
