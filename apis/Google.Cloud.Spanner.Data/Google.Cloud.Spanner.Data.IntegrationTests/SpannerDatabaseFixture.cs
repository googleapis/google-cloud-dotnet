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

using Google.Cloud.Spanner.Data.CommonTesting;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    // Note: this class must be in the same assemblies as the tests, as otherwise xUnit can't find it.

    /// <summary>
    /// A fixture for tests that need a database to be present, but don't need any tables.
    /// </summary>
    [CollectionDefinition(nameof(SpannerDatabaseFixture))]
    public class SpannerDatabaseFixture : SpannerFixtureBase, ICollectionFixture<SpannerDatabaseFixture>
    {
    }
}