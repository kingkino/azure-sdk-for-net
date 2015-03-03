﻿// 
// Copyright (c) Microsoft.  All rights reserved. 
// 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
//   http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License. 
// 

using System;
using System.Net.Http.Headers;

namespace Microsoft.Azure.Search
{
    public static partial class SearchServiceClientExtensions
    {
        private const string ClientRequestIdHeaderName = "client-request-id";

        /// <summary>
        /// Adds the given tracking ID to the HTTP request headers.
        /// </summary>
        /// <param name="guid">Tracking ID to add to the request.</param>
        public static void SetClientRequestId(this SearchServiceClient client, Guid guid)
        {
            HttpRequestHeaders headers = client.HttpClient.DefaultRequestHeaders;

            if (headers.Contains(ClientRequestIdHeaderName))
            {
                headers.Remove(ClientRequestIdHeaderName);
            }

            headers.Add(ClientRequestIdHeaderName, guid.ToString());
        }
    }
}
