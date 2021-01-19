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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// Paginators for the CognitoIdentity service
    ///</summary>
    public class CognitoIdentityPaginatorFactory : ICognitoIdentityPaginatorFactory
    {
        private readonly IAmazonCognitoIdentity client;

        internal CognitoIdentityPaginatorFactory(IAmazonCognitoIdentity client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListIdentityPools operation
        ///</summary>
        public IListIdentityPoolsPaginator ListIdentityPools(ListIdentityPoolsRequest request) 
        {
            return new ListIdentityPoolsPaginator(this.client, request);
        }
    }
}
#endif