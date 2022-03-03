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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Common.V1;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    /// <summary>
    /// Base classes for test fixtures for Spanner.
    /// </summary>
    public abstract class SpannerFixtureBase : CloudProjectFixtureBase
    {
        public SpannerTestDatabase Database { get; }

        public SpannerFixtureBase()
        {
            GrpcInfo.EnableSubchannelCounting();
            Database = SpannerTestDatabase.GetInstance(ProjectId);
        }

        public DatabaseName DatabaseName => Database.DatabaseName;
        public SpannerConnection GetConnection() => Database.GetConnection();
        public string ConnectionString => Database.ConnectionString;
        public bool RunningOnEmulator => SpannerClientCreationOptions.UsesEmulator;
        internal SpannerClientCreationOptions SpannerClientCreationOptions => Database.SpannerClientCreationOptions;
    }
}
