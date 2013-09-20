/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>Volume Recovery Point Info
    /// </summary>
    public class VolumeRecoveryPointInfo
    {
        
        private string volumeARN;
        private long? volumeSizeInBytes;
        private long? volumeUsageInBytes;
        private string volumeRecoveryPointTime;
        public string VolumeARN
        {
            get { return this.volumeARN; }
            set { this.volumeARN = value; }
        }

        // Check to see if VolumeARN property is set
        internal bool IsSetVolumeARN()
        {
            return this.volumeARN != null;
        }
        public long VolumeSizeInBytes
        {
            get { return this.volumeSizeInBytes ?? default(long); }
            set { this.volumeSizeInBytes = value; }
        }

        // Check to see if VolumeSizeInBytes property is set
        internal bool IsSetVolumeSizeInBytes()
        {
            return this.volumeSizeInBytes.HasValue;
        }
        public long VolumeUsageInBytes
        {
            get { return this.volumeUsageInBytes ?? default(long); }
            set { this.volumeUsageInBytes = value; }
        }

        // Check to see if VolumeUsageInBytes property is set
        internal bool IsSetVolumeUsageInBytes()
        {
            return this.volumeUsageInBytes.HasValue;
        }
        public string VolumeRecoveryPointTime
        {
            get { return this.volumeRecoveryPointTime; }
            set { this.volumeRecoveryPointTime = value; }
        }

        // Check to see if VolumeRecoveryPointTime property is set
        internal bool IsSetVolumeRecoveryPointTime()
        {
            return this.volumeRecoveryPointTime != null;
        }
    }
}
