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

using Google.Cloud.ClientTesting;
using Xunit;

namespace Google.Cloud.Logging.Log4Net.Snippets
{
    [CollectionDefinition(nameof(Log4NetSnippetFixture))]
    public sealed class Log4NetSnippetFixture : CloudProjectFixtureBase, ICollectionFixture<Log4NetSnippetFixture>
    {
        public string LogId { get; } = "Log4NetTestLog";

        // No clean-up, because:
        // - We can't assert log entries in tests, so it's useful to be able to check them manually later.
        // - If the log entries haven't arrived yet, deleting them would cause an exception anyway.
    }
}
