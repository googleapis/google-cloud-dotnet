// Copyright 2016 Google Inc. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using Xunit;

namespace Google.Cloud.Metadata.V1.IntegrationTests
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// </summary>
    [CollectionDefinition(nameof(MetadataFixture))]
    public class MetadataFixture : MetadataFixtureBase, ICollectionFixture<MetadataFixture>
    {
        public MetadataFixture()
        {
        }
    }
}
