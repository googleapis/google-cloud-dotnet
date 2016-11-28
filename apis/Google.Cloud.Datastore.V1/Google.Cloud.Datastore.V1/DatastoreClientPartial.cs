// Copyright 2016, Google Inc. All rights reserved.
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

using Google.Api.Gax.Grpc;

namespace Google.Cloud.Datastore.V1
{
    // Partial methods on DatastoreClientImpl to set appropriate client headers.
    public partial class DatastoreClientImpl
    {
        private const string ResourcePrefixHeader = "google-cloud-resource-prefix";
        private const string ResourcePrefixHeaderValuePrefix = "projects/";

        partial void Modify_AllocateIdsRequest(ref AllocateIdsRequest request, ref CallSettings settings)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, "projects/" + request.ProjectId);
        }

        partial void Modify_BeginTransactionRequest(ref BeginTransactionRequest request, ref CallSettings settings)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, "projects/" + request.ProjectId);
        }

        partial void Modify_CommitRequest(ref CommitRequest request, ref CallSettings settings)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, "projects/" + request.ProjectId);
        }

        partial void Modify_LookupRequest(ref LookupRequest request, ref CallSettings settings)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, "projects/" + request.ProjectId);
        }

        partial void Modify_RollbackRequest(ref RollbackRequest request, ref CallSettings settings)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, "projects/" + request.ProjectId);
        }

        partial void Modify_RunQueryRequest(ref RunQueryRequest request, ref CallSettings settings)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, "projects/" + request.ProjectId);
        }
    }
}
