// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Insights.Models;

namespace Microsoft.Azure.Insights.Models
{
    /// <summary>
    /// Log definition class specifies the metadata for a log.
    /// </summary>
    public partial class LogDefinition
    {
        private BlobLocation _blobLocation;
        
        /// <summary>
        /// Optional. Gets or sets the location of the blob.
        /// </summary>
        public BlobLocation BlobLocation
        {
            get { return this._blobLocation; }
            set { this._blobLocation = value; }
        }
        
        private LocalizableString _category;
        
        /// <summary>
        /// Optional. Gets or sets the category of the log.
        /// </summary>
        public LocalizableString Category
        {
            get { return this._category; }
            set { this._category = value; }
        }
        
        private string _resourceId;
        
        /// <summary>
        /// Optional. Gets or sets the resource identifier of the resource that
        /// has emitted the log.
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }
        
        private TimeSpan _retention;
        
        /// <summary>
        /// Optional. Gets or sets the retention.
        /// </summary>
        public TimeSpan Retention
        {
            get { return this._retention; }
            set { this._retention = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LogDefinition class.
        /// </summary>
        public LogDefinition()
        {
        }
    }
}
