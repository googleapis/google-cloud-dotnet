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

using Google.Api.Gax.Testing;
using Moq;

namespace Google.Cloud.Spanner.V1.PoolRewrite.Tests
{
    /// <summary>
    /// Helpers for tests that need SpannerClient instances.
    /// </summary>
    internal static class SpannerClientHelpers
    {
        /// <summary>
        /// Creates a mock SpannerClient configured with settings that include a fake clock
        /// and a fake scheduler.
        /// </summary>
        internal static Mock<SpannerClient> CreateMockClient(MockBehavior behavior = MockBehavior.Strict)
        {
            var settings = SpannerSettings.GetDefault();
            settings.Clock = new FakeClock();
            settings.Scheduler = new FakeScheduler();
            var mock = new Mock<SpannerClient>(behavior);
            mock.SetupProperty(client => client.Settings, settings);
            return mock;
        }
    }
}
