// Copyright 2018 Google Inc. All Rights Reserved.
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
using System;
using Xunit;

namespace Google.Cloud.Logging.Log4Net.IntegrationTests
{
    [CollectionDefinition(nameof(Log4NetFixture))]
    public sealed class Log4NetFixture : CloudProjectFixtureBase, ICollectionFixture<Log4NetFixture>
    {
        public string GoogleApplicationCredentials => Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");
    }
}
