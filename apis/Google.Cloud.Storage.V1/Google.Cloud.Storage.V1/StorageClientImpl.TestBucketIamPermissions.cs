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

using Google.Api.Gax;
using Google.Apis.Util;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Storage.v1.BucketsResource;

namespace Google.Cloud.Storage.V1
{
    public partial class StorageClientImpl
    {
        /// <inheritdoc />
        public override IList<string> TestBucketIamPermissions(string bucket, IEnumerable<string> permissions, TestBucketIamPermissionsOptions options = null) =>
            CreateTestIamPermissionsRequest(bucket, permissions, options).Execute().Permissions;

        /// <inheritdoc />
        public override async Task<IList<string>> TestBucketIamPermissionsAsync(string bucket, IEnumerable<string> permissions,
            TestBucketIamPermissionsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await CreateTestIamPermissionsRequest(bucket, permissions, options).ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return response.Permissions;
        }

        private TestIamPermissionsRequest CreateTestIamPermissionsRequest(string bucket, IEnumerable<string> permissions, TestBucketIamPermissionsOptions options)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(permissions, nameof(permissions));
            List<string> permissionsList = permissions.ToList();
            GaxPreconditions.CheckArgument(permissionsList.Count != 0, nameof(permissions), "List of permissions to test must not be empty");
            var request = Service.Buckets.TestIamPermissions(bucket, new Repeatable<string>(permissionsList));
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            return request;
        }
    }
}
