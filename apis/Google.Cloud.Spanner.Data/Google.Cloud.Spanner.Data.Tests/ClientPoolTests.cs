// Copyright 2017 Google Inc. All Rights Reserved.
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

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Moq;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class ClientPoolTests
    {
        public ClientPoolTests(ITestOutputHelper outputHelper)
        {
            TestLogger.TestOutputHelper = outputHelper;
            TestLogger.Install();
            Logger.DefaultLogger.LogLevel = V1.Internal.Logging.LogLevel.Debug;
        }

        private static MockClientFactory SetupMockClientFactory(Mock<SpannerClient> firstClient = null)
        {
            if (firstClient == null)
            {
                firstClient = new Mock<SpannerClient>();
            }
            return new MockClientFactory(firstClient.Object);
        }

        private static async Task<SpannerClient> GetSpannerClientAsync(ClientPool pool)
        {
            //immediately yield to increase contention for stress testing.
            await Task.Yield();
            return await pool.AcquireClientAsync(Logger.DefaultLogger);
        }

        [Fact]
        public async Task ClientsCreatedOnDemandAsync()
        {
            //SpannerClients should not be precreated, but be created lazily.
            var mockClientFactory = SetupMockClientFactory();

            var testPool = new ClientPool(mockClientFactory);
            var clientAcquired = await testPool.AcquireClientAsync(Logger.DefaultLogger);
            testPool.ReleaseClient(clientAcquired);

            Assert.Equal(1, mockClientFactory.Invocations);
            var s = new StringBuilder();
            Assert.Equal(0, testPool.GetPoolInfo(s));
            Logger.DefaultLogger.Info(() => s.ToString());
        }

        [Fact]
        public async Task ConcurrencyStress()
        {
            const int multiplier = 10;
            var mockClientFactory = SetupMockClientFactory();

            //A mini stress test that hits the client pool with multiple concurrent client requests.
            var concurrentQueries = new List<Task<SpannerClient>>();
            var testPool = new ClientPool(mockClientFactory);

            for (var i = 0; i < SpannerOptions.Instance.MaximumGrpcChannels * multiplier; i++)
            {
                concurrentQueries.Add(GetSpannerClientAsync(testPool));
            }

            await Task.WhenAll(concurrentQueries);
            Assert.Equal(SpannerOptions.Instance.MaximumGrpcChannels, mockClientFactory.Invocations);

            var grouping = concurrentQueries.GroupBy(x => x.Result).ToList();
            Assert.Equal(SpannerOptions.Instance.MaximumGrpcChannels, grouping.Count);
            foreach (var group in grouping)
            {
                Assert.Equal(multiplier, group.Count());
            }

            foreach (var client in concurrentQueries.Select(x => x.Result))
            {
                testPool.ReleaseClient(client);
            }
            var s = new StringBuilder();
            Assert.Equal(0, testPool.GetPoolInfo(s));
            Logger.DefaultLogger.Info(() => s.ToString());
        }

        [Fact]
        public async Task RoundRobin()
        {
            var mockClientFactory = SetupMockClientFactory();

            var testPool = new ClientPool(mockClientFactory);

            var clientList = new List<SpannerClient>();
            for (var i = 0; i < SpannerOptions.Instance.MaximumGrpcChannels; i++)
            {
                var newClient = await testPool.AcquireClientAsync(Logger.DefaultLogger);
                Assert.DoesNotContain(newClient, clientList);
                clientList.Add(newClient);
            }

            //now we wrap around.
            var firstReusedClient = await testPool.AcquireClientAsync(Logger.DefaultLogger);
            Assert.Same(clientList[0], firstReusedClient);
            testPool.ReleaseClient(firstReusedClient);

            foreach (var client in clientList)
            {
                testPool.ReleaseClient(client);
            }
            var s = new StringBuilder();
            Assert.Equal(0, testPool.GetPoolInfo(s));
            Logger.DefaultLogger.Info(() => s.ToString());

            //now that everything got released, lets ensure the client order is preserved so
            //that we again get the first client.
            Assert.Same(firstReusedClient, await testPool.AcquireClientAsync(Logger.DefaultLogger));
            testPool.ReleaseClient(firstReusedClient);

            Assert.Equal(SpannerOptions.Instance.MaximumGrpcChannels, mockClientFactory.Invocations);
        }

        [Fact]
        public async Task SequentialCreatesOnlyUseOneChannel()
        {
            //SpannerClients if created sequentially should only use a single channel.
            //This is to faciliate good session pool hits (which is per channel).  If we always
            //round robin'd clients, then we would get hard cache misses until we populated all
            //of the caches per channel.
            //Since channels are lazily created, this also saves resources for scenarios like rich clients
            //that may only need a single session for multiple sequential workloads.
            //Our default setting for # channels = 4 needs to work well for all scenarios.
            var firstReturnedClient = new Mock<SpannerClient>();
            var mockClientFactory = SetupMockClientFactory(firstReturnedClient);

            var testPool = new ClientPool(mockClientFactory);
            var expectedClient = firstReturnedClient.Object;

            Assert.Same(expectedClient, await testPool.AcquireClientAsync(Logger.DefaultLogger));
            testPool.ReleaseClient(expectedClient);

            Assert.Same(expectedClient, await testPool.AcquireClientAsync(Logger.DefaultLogger));
            testPool.ReleaseClient(expectedClient);

            Assert.Same(expectedClient, await testPool.AcquireClientAsync(Logger.DefaultLogger));
            testPool.ReleaseClient(expectedClient);

            var s = new StringBuilder();
            Assert.Equal(0, testPool.GetPoolInfo(s));
            Logger.DefaultLogger.Info(() => s.ToString());
            Assert.Equal(1, mockClientFactory.Invocations);
        }
    }
}
