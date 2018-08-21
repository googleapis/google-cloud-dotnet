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
using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(SpannerDatabaseFixture))]
    public class MultiChannelTest
    {
        private readonly SpannerDatabaseFixture _fixture;

        public MultiChannelTest(SpannerDatabaseFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task SeparateSubchannels()
        {
            // Clear current session/client pools
            Task.Run(SessionPool.Default.ReleaseAllAsync).Wait(SessionPool.Default.ShutDownTimeout);
            ClientPool.Default.Reset();

            int originalSubchannelCount = GrpcInfo.SubchannelCount;
            var maximumChannels = SpannerOptions.Instance.MaximumGrpcChannels;

            var connections = new List<SpannerConnection>();
            for (int i = 0; i < maximumChannels + 1; i++)
            {
                var connection = _fixture.GetConnection();
                var cmd = connection.CreateInsertCommand("T", new SpannerParameterCollection
                    {
                        new SpannerParameter("k", SpannerDbType.String, Guid.NewGuid().ToString())
                    });

                await cmd.ExecuteNonQueryAsync();
                connections.Add(connection);
            }

            // Dispose the connections at the end so their clients can't be reused during the test.
            connections.ForEach(connection => connection.Dispose());

            int subchannelsCreated = GrpcInfo.SubchannelCount - originalSubchannelCount;
            Assert.Equal(maximumChannels, subchannelsCreated);
        }
    }
}
