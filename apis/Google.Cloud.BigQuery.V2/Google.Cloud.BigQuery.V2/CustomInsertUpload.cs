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
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Services;
using Google.Apis.Upload;
using System.IO;
using static Google.Apis.Bigquery.v2.JobsResource;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Upload subclass which allows us to modify headers.
    /// </summary>
    internal sealed class CustomMediaUpload : InsertMediaUpload
    {
        public CustomMediaUpload(IClientService service, Job body, string projectId, Stream stream, string contentType)
            : base(service, body, projectId, stream, contentType)
        {
        }

        internal new ResumableUploadOptions Options => base.Options;
    }
}
