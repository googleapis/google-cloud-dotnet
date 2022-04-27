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

#if NET462_OR_GREATER
using Google.Cloud.ClientTesting;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    [Collection(nameof(BigtableFixture))]
    public class MultiChannelTest
    {
        private readonly BigtableFixture _fixture;

        public MultiChannelTest(BigtableFixture fixture) => _fixture = fixture;

        [SkippableFact(Skip = "See issue 2675")]
        public async Task SeparateSubchannels()
        {
            Skip.If(_fixture.RunningAgainstEmulator);

            int originalSubchannelCount = GrpcInfo.SubchannelCount;
            int clientCount = 2;

            var settings = new BigtableServiceApiSettings
            {
                PreferredMaxStreamsPerChannel = 1,
                MaxChannels = (uint)clientCount
            };
            var client = await new BigtableClientBuilder { Settings = settings }.BuildAsync();

            var tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(client.ReadRowAsync(_fixture.TableName, "abc"));
            }

            await Task.WhenAll(tasks);

            int subchannelsCreated = GrpcInfo.SubchannelCount - originalSubchannelCount;
            Assert.Equal(clientCount, subchannelsCreated);
        }
    }
}
#endif