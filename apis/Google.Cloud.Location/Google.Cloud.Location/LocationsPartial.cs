// Copyright 2019 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using sc = System.Collections;
using scg = System.Collections.Generic;

namespace Google.Cloud.Location
{
    public partial class ListLocationsRequest : gaxgrpc::IPageRequest { }
    public partial class ListLocationsResponse : gaxgrpc::IPageResponse<gcl::Location>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<gcl::Location> GetEnumerator() => Locations.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
