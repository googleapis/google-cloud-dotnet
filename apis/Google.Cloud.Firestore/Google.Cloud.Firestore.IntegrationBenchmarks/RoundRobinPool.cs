// Copyright 2019, Google LLC
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

using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore.V1;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Linq;
using System.Threading;

namespace Google.Cloud.Firestore.IntegrationBenchmarks
{
    /// <summary>
    /// Pool of FirestoreDb objects to be used when running the test.
    /// </summary>
    internal sealed class RoundRobinPool
    {
        private long _counter = 0;
        private FirestoreDb[] _pool;

        internal RoundRobinPool(int size, string projectId)
        {
            ICredential credential = GoogleCredential.GetApplicationDefault();
            _pool = Enumerable
                .Range(0, size)
                .Select(_ => CreateFirestoreDb())
                .ToArray();

            FirestoreDb CreateFirestoreDb()
            {
                // This code forces each channel to really use a different network connection.
                // Without this, different .NET Channel objects can end up using the same underlying
                // connection due to pooling in the C-core layer of gRPC.
                // Note: it would be nice to have a simpler way of doing this.
                var channel = new Channel(
                    FirestoreClient.DefaultEndpoint.ToString(),
                    credential.ToChannelCredentials(),
                    new ChannelOption[] { new ChannelOption("grpc_gcp.client_channel.id", Guid.NewGuid().ToString()) });
                var client = FirestoreClient.Create(channel);
                return FirestoreDb.Create(projectId, client);
            }
        }

        internal FirestoreDb GetFirestoreDb()
        {
            // We'd get an exception if this ever overflowed... but that's not going to happen.
            long count = Interlocked.Increment(ref _counter);
            return _pool[count % _pool.Length];
        }
    }
}
