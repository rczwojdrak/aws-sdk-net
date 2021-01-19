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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the ListInstanceStorageConfigs operation.
    /// </summary>
    public partial class ListInstanceStorageConfigsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<InstanceStorageConfig> _storageConfigs = new List<InstanceStorageConfig>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConfigs. 
        /// <para>
        /// A valid storage type.
        /// </para>
        /// </summary>
        public List<InstanceStorageConfig> StorageConfigs
        {
            get { return this._storageConfigs; }
            set { this._storageConfigs = value; }
        }

        // Check to see if StorageConfigs property is set
        internal bool IsSetStorageConfigs()
        {
            return this._storageConfigs != null && this._storageConfigs.Count > 0; 
        }

    }
}