// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Cloud.ClientTesting;
using Xunit;

namespace Google.Cloud.Debugger.V2.Snippets
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// (Currently this fixture does nothing more than providing the project ID.)
    /// </summary>
    [CollectionDefinition(nameof(DebuggerServiceFixture))]
    public sealed class DebuggerServiceFixture : CloudProjectFixtureBase, ICollectionFixture<DebuggerServiceFixture>
    {
    }
}
