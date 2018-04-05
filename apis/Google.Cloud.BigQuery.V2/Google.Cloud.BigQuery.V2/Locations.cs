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

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Convenience class for known locations.
    /// </summary>
    /// <remarks>
    /// Locations for datasets and jobs are identified by strings, and these can be passed directly into the API,
    /// for exmaple in <see cref="BigQueryClient.WithDefaultLocation(string)">BigQueryClient.WithDefaultLocation</see>.
    /// This allows you to use additional locations as soon as they are made available via the BigQuery
    /// service, without any libray updates - but it relies on the location strings being known.
    /// This class makes it easy to access locations that were available at the point of release. It will be
    /// updated as new locations become available, but if you wish to use a location that isn't specified here,
    /// that will work with no problems, assuming the location is correctly specified and available to you.
    /// </remarks>
    public static class Locations
    {
        /// <summary>
        /// String value for the United States multi-region location.
        /// </summary>
        public static string UnitedStates { get; } = "US";

        /// <summary>
        /// String value for the European Union multi-region location.
        /// </summary>
        public static string EuropeanUnion { get; } = "EU";

        /// <summary>
        /// String value for the Tokyo regional location.
        /// </summary>
        public static string Tokyo { get; } = "asia-northeast1";
    }
}
