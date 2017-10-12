// Copyright 2017 Google Inc. All rights reserved.
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

namespace Google.Cloud.Bigtable.Admin.V2
{
    public partial class BigtableTableAdminClientImpl
    {
        private const string ResourcePrefixHeader = "google-cloud-resource-prefix";

        partial void Modify_CreateTableRequest(ref CreateTableRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_ListTablesRequest(ref ListTablesRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.Parent);

        partial void Modify_GetTableRequest(ref GetTableRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        partial void Modify_DeleteTableRequest(ref DeleteTableRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        partial void Modify_ModifyColumnFamiliesRequest(ref ModifyColumnFamiliesRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        partial void Modify_DropRowRangeRequest(ref DropRowRangeRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        private static void ApplyResourcePrefixHeader(ref CallSettings settings, TableName tableName)
        {
            ApplyResourcePrefixHeader(ref settings, tableName.ToString());
        }
        
        private static void ApplyResourcePrefixHeader(ref CallSettings settings, string resource)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, resource);
        }
    }
}
