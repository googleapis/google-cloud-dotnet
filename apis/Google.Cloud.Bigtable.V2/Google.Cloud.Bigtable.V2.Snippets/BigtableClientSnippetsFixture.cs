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

using Google.Cloud.Bigtable.Admin.V2;
using Google.Cloud.Bigtable.V2.IntegrationTests;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Snippets
{
    // Note: this does not use CloudProjectFixtureBase as a base class, as an emulator can be used as an alternative.
    // If that pattern becomes more widespread, we can bring that into CloudProjectFixtureBase.
    [CollectionDefinition(nameof(BigtableClientSnippetsFixture))]
    public class BigtableClientSnippetsFixture : BigtableFixtureBase, ICollectionFixture<BigtableClientSnippetsFixture>
    {
        protected override Table CreateDefaultTable() =>
            new Table
            {
                Granularity = Table.Types.TimestampGranularity.Millis,
                ColumnFamilies =
                {
                    { "Address", new ColumnFamily { GcRule = new GcRule { MaxNumVersions = 3 } } },
                    { "Score", new ColumnFamily { GcRule = new GcRule { MaxNumVersions = 3 } } },
                    { "metrics", new ColumnFamily { GcRule = new GcRule { MaxNumVersions = 3 } } }
                }
            };
    }
}
