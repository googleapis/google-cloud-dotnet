// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Services;
using System;
using System.IO;
using System.Net.Http;
using static Google.Apis.Storage.v1.ObjectsResource;
using Google.Apis.Upload;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Upload subclass which allows us to modify headers, for customer-supplied encryption keys.
    /// </summary>
    internal sealed class CustomMediaUpload : InsertMediaUpload
    {
        public CustomMediaUpload(IClientService service, Apis.Storage.v1.Data.Object body, string bucket,
            Stream stream, string contentType)
            : base(service, body, bucket, stream, contentType)
        {
        }

        internal new ResumableUploadOptions Options => base.Options;
    }
}
