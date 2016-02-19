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

namespace Microsoft.AzureStack.Management.Models
{
    /// <summary>
    /// Your documentation here.
    /// </summary>
    public partial class ResourceProviderEndpoint
    {
        private string _apiVersion;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
            set { this._apiVersion = value; }
        }
        
        private string _authenticationPassword;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string AuthenticationPassword
        {
            get { return this._authenticationPassword; }
            set { this._authenticationPassword = value; }
        }
        
        private string _authenticationUsername;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string AuthenticationUsername
        {
            get { return this._authenticationUsername; }
            set { this._authenticationUsername = value; }
        }
        
        private bool? _enabled;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }
        
        private string _endpointUri;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string EndpointUri
        {
            get { return this._endpointUri; }
            set { this._endpointUri = value; }
        }
        
        private TimeSpan _timeout;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public TimeSpan Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ResourceProviderEndpoint class.
        /// </summary>
        public ResourceProviderEndpoint()
        {
        }
    }
}