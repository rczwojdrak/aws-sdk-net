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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a load balancer attribute.
    /// </summary>
    public partial class LoadBalancerAttribute
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the attribute.
        /// </para>
        ///  
        /// <para>
        /// The following attribute is supported by all load balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>deletion_protection.enabled</code> - Indicates whether deletion protection
        /// is enabled. The value is <code>true</code> or <code>false</code>. The default is <code>false</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported by both Application Load Balancers and Network
        /// Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>access_logs.s3.enabled</code> - Indicates whether access logs are enabled.
        /// The value is <code>true</code> or <code>false</code>. The default is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>access_logs.s3.bucket</code> - The name of the S3 bucket for the access logs.
        /// This attribute is required if access logs are enabled. The bucket must exist in the
        /// same region as the load balancer and have a bucket policy that grants Elastic Load
        /// Balancing permissions to write to the bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>access_logs.s3.prefix</code> - The prefix for the location in the S3 bucket
        /// for the access logs.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes are supported by only Application Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>idle_timeout.timeout_seconds</code> - The idle timeout value, in seconds. The
        /// valid range is 1-4000 seconds. The default is 60 seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>routing.http.desync_mitigation_mode</code> - Determines how the load balancer
        /// handles requests that might pose a security risk to your application. The possible
        /// values are <code>monitor</code>, <code>defensive</code>, and <code>strictest</code>.
        /// The default is <code>defensive</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>routing.http.drop_invalid_header_fields.enabled</code> - Indicates whether
        /// HTTP headers with invalid header fields are removed by the load balancer (<code>true</code>)
        /// or routed to targets (<code>false</code>). The default is <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>routing.http2.enabled</code> - Indicates whether HTTP/2 is enabled. The value
        /// is <code>true</code> or <code>false</code>. The default is <code>true</code>. Elastic
        /// Load Balancing requires that message header names contain only alphanumeric characters
        /// and hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>waf.fail_open.enabled</code> - Indicates whether to allow a WAF-enabled load
        /// balancer to route requests to targets if it is unable to forward the request to AWS
        /// WAF. The value is <code>true</code> or <code>false</code>. The default is <code>false</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attribute is supported by Network Load Balancers and Gateway Load Balancers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>load_balancing.cross_zone.enabled</code> - Indicates whether cross-zone load
        /// balancing is enabled. The value is <code>true</code> or <code>false</code>. The default
        /// is <code>false</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}