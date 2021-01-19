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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePredictorBacktestExportJob operation.
    /// Exports backtest forecasts and accuracy metrics generated by the <a>CreatePredictor</a>
    /// operation. Two folders containing CSV files are exported to your specified S3 bucket.
    /// 
    ///  
    /// <para>
    ///  The export file names will match the following conventions:
    /// </para>
    ///  
    /// <para>
    ///  <code>&lt;ExportJobName&gt;_&lt;ExportTimestamp&gt;_&lt;PartNumber&gt;.csv</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// The &lt;ExportTimestamp&gt; component is in Java SimpleDate format (yyyy-MM-ddTHH-mm-ssZ).
    /// </para>
    ///  
    /// <para>
    /// You must specify a <a>DataDestination</a> object that includes an Amazon S3 bucket
    /// and an AWS Identity and Access Management (IAM) role that Amazon Forecast can assume
    /// to access the Amazon S3 bucket. For more information, see <a>aws-forecast-iam-roles</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>Status</code> of the export job must be <code>ACTIVE</code> before you can
    /// access the export in your Amazon S3 bucket. To get the status, use the <a>DescribePredictorBacktestExportJob</a>
    /// operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePredictorBacktestExportJobRequest : AmazonForecastServiceRequest
    {
        private DataDestination _destination;
        private string _predictorArn;
        private string _predictorBacktestExportJobName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Destination.
        /// </summary>
        [AWSProperty(Required=true)]
        public DataDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the predictor that you want to export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string PredictorArn
        {
            get { return this._predictorArn; }
            set { this._predictorArn = value; }
        }

        // Check to see if PredictorArn property is set
        internal bool IsSetPredictorArn()
        {
            return this._predictorArn != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorBacktestExportJobName. 
        /// <para>
        /// The name for the backtest export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string PredictorBacktestExportJobName
        {
            get { return this._predictorBacktestExportJobName; }
            set { this._predictorBacktestExportJobName = value; }
        }

        // Check to see if PredictorBacktestExportJobName property is set
        internal bool IsSetPredictorBacktestExportJobName()
        {
            return this._predictorBacktestExportJobName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata to help you categorize and organize your backtests. Each tag consists
        /// of a key and an optional value, both of which you define. Tag keys and values are
        /// case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The following restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For each resource, each tag key must be unique and each tag key must have one value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum number of tags per resource: 50.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length: 128 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length: 256 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Accepted characters: all letters and numbers, spaces representable in UTF-8, and +
        /// - = . _ : / @. If your tagging schema is used across other services and resources,
        /// the character restrictions of those services also apply. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key prefixes cannot include any upper or lowercase combination of <code>aws:</code>
        /// or <code>AWS:</code>. Values can have this prefix. If a tag value has <code>aws</code>
        /// as its prefix but the key does not, Forecast considers it to be a user tag and will
        /// count against the limit of 50 tags. Tags with only the key prefix of <code>aws</code>
        /// do not count against your tags per resource limit. You cannot edit or delete tag keys
        /// with this prefix.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}