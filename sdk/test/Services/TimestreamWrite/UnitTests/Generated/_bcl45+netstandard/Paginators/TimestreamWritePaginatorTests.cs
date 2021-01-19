#if !NETSTANDARD13
/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */

using Amazon.TimestreamWrite;
using Amazon.TimestreamWrite.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class TimestreamWritePaginatorTests
    {
        private static Mock<AmazonTimestreamWriteClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonTimestreamWriteClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TimestreamWrite")]
        public void ListDatabasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDatabasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDatabasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDatabasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDatabases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDatabases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TimestreamWrite")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDatabasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDatabasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDatabasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDatabases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDatabases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TimestreamWrite")]
        public void ListTablesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTablesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTablesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTables(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTables(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TimestreamWrite")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTablesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTablesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTablesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTables(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTables(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif