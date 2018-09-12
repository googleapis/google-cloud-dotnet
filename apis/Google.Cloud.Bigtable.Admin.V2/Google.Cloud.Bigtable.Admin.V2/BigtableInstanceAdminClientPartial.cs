// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Bigtable.Common.V2;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.Admin.V2
{
    public partial class BigtableInstanceAdminClientImpl
    {
        private static ListAppProfilesResponse ValidateAppProfilesResponse(ListAppProfilesResponse response)
        {
            if (response.FailedLocations.Count != 0)
            {
                // TODO: Should this be a different type? Perhaps a custom type that exposes the FailedLocations collection?
                throw new InvalidOperationException(
                    $"Could not retrieve AppProfile information from the following locations: {string.Join(", ", response.FailedLocations)}");
            }
            return response;
        }

        private class ListAppProfilesEnumerable : PagedEnumerable<ListAppProfilesResponse, AppProfile>
        {
            private readonly FailedLocationBehavior _failedLocationBehavior;
            private readonly PagedEnumerable<ListAppProfilesResponse, AppProfile> _inner;

            public ListAppProfilesEnumerable(
                PagedEnumerable<ListAppProfilesResponse, AppProfile> inner,
                FailedLocationBehavior failedLocationBehavior)
            {
                _inner = inner;
                _failedLocationBehavior = failedLocationBehavior;
            }

            public override IEnumerable<ListAppProfilesResponse> AsRawResponses()
            {
                var result = _inner.AsRawResponses();
                if (_failedLocationBehavior == FailedLocationBehavior.Throw)
                {
                    result = result.Select(ValidateAppProfilesResponse);
                }
                return result;
            }

            public override IEnumerator<AppProfile> GetEnumerator() => _inner.GetEnumerator();

            public override Page<AppProfile> ReadPage(int pageSize) => _inner.ReadPage(pageSize);
        }

        private class ListAppProfilesAsyncEnumerable : PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile>
        {
            private readonly FailedLocationBehavior _failedLocationBehavior;
            private readonly PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> _inner;

            public ListAppProfilesAsyncEnumerable(
                PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> inner,
                FailedLocationBehavior failedLocationBehavior)
            {
                _inner = inner;
                _failedLocationBehavior = failedLocationBehavior;
            }

            public override IAsyncEnumerable<ListAppProfilesResponse> AsRawResponses()
            {
                var result = _inner.AsRawResponses();
                if (_failedLocationBehavior == FailedLocationBehavior.Throw)
                {
                    result = result.Select(ValidateAppProfilesResponse);
                }
                return result;
            }

            public override IAsyncEnumerator<AppProfile> GetEnumerator() => _inner.GetEnumerator();

            public override Task<Page<AppProfile>> ReadPageAsync(
                int pageSize,
                CancellationToken cancellationToken = default) => _inner.ReadPageAsync(pageSize, cancellationToken);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum FailedLocationBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        Continue,
        
        /// <summary>
        /// 
        /// </summary>
        Throw
    }
}
