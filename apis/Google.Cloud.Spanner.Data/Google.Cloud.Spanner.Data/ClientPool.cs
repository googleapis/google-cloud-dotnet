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

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Logging;
using Grpc.Auth;
using Grpc.Core;

namespace Google.Cloud.Spanner.Data
{

    internal static class ClientPool
    {
        private static readonly ConcurrentDictionary<ClientCredentialKey, CredentialClientPool> s_clientPoolByCredential =
            new ConcurrentDictionary<ClientCredentialKey, CredentialClientPool>();

        public static async Task<SpannerClient> AcquireClientAsync(
            ITokenAccess credentials = null,
            ServiceEndpoint endpoint = null)
        {
            var key = new ClientCredentialKey(credentials, endpoint ?? SpannerClient.DefaultEndpoint);
            var poolEntry = s_clientPoolByCredential.GetOrAdd(key, k => new CredentialClientPool(key));
            var result = await poolEntry.AcquireClientAsync().ConfigureAwait(false);
            Logger.LogPerformanceCounter("SpannerClient.Count", () => s_clientPoolByCredential.Count);
            return result;
        }

        public static void ReleaseClient(SpannerClient spannerClient,
            ITokenAccess credentials = null,
            ServiceEndpoint endpoint = null)
        {
            if (spannerClient != null)
            {
                var key = new ClientCredentialKey(credentials, endpoint ?? SpannerClient.DefaultEndpoint);
                var poolEntry = s_clientPoolByCredential.GetOrAdd(key, k => new CredentialClientPool(key));
                poolEntry.ReleaseClient(spannerClient);
            }
        }

        private struct ClientCredentialKey : IEquatable<ClientCredentialKey>
        {
            public ITokenAccess Credential { get; }
            public ServiceEndpoint Endpoint { get; }

            public ClientCredentialKey(ITokenAccess tokenAccess, ServiceEndpoint serviceEndpoint) : this()
            {
                Credential = tokenAccess;
                Endpoint = serviceEndpoint;
            }

            public bool Equals(ClientCredentialKey other) => Equals(Credential, other.Credential) &&
                Equals(Endpoint, other.Endpoint);

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj))
                {
                    return false;
                }

                return obj is ClientCredentialKey && Equals((ClientCredentialKey) obj);
            }

            /// <inheritdoc />
            public override int GetHashCode()
            {
                unchecked
                {
                    return ((Credential?.GetHashCode() ?? 0) * 397) ^
                        (Endpoint?.GetHashCode() ?? 0);
                }
            }
        }

        private class CredentialClientPool
        {
            private readonly ClientCredentialKey _key;
            private SortedList<SpannerClientCreator, SpannerClientCreator> _multiClientPool = 
                new SortedList<SpannerClientCreator, SpannerClientCreator>();
            private readonly object _sync = new object();


            public CredentialClientPool(ClientCredentialKey key) => _key = key;

            public Task<SpannerClient> AcquireClientAsync()
            {
                Task<SpannerClient> result;

                lock (_sync)
                {
                    //first ensure that the pool is of the correct size.
                    while (_multiClientPool.Count > SpannerOptions.Instance.MaximumGrpcChannels)
                    {
                        _multiClientPool.RemoveAt(_multiClientPool.Count - 1);
                    }
                    while (_multiClientPool.Count < SpannerOptions.Instance.MaximumGrpcChannels)
                    {
                        var newEntry = new SpannerClientCreator(_key);
                        _multiClientPool.Add(newEntry, newEntry);
                    }

                    //now grab the first item in the sorted list, increment refcnt, re-sort and return.
                    var first = _multiClientPool.First();
                    result = first.Value.AcquireClientAsync();
                    _multiClientPool.Remove(first.Key);
                    _multiClientPool.Add(first.Key, first.Value);
                }
                return result;
            }

            public void ReleaseClient(SpannerClient client)
            {
                lock (_sync)
                {
                    //find the entry and release refcnt and re-sort
                    var match = _multiClientPool.FirstOrDefault(x => x.Key.MatchesClient(client));
                    if (match.Key != null)
                    {
                        match.Value.Release();
                        _multiClientPool.Remove(match.Key);
                        _multiClientPool.Add(match.Key, match.Value);
                    }
                }
            }
        }

        private class SpannerClientCreator : IComparable<SpannerClientCreator>, IComparable
        {
            private  Lazy<Task<SpannerClient>> _creationTask;
            private int _refCount = 0;
            private ClientCredentialKey _key;

            public SpannerClientCreator(ClientCredentialKey key)
            {
                _key = key;
                _creationTask = new Lazy<Task<SpannerClient>>(AcquireClientImplAsync);
            }

            public bool MatchesClient(SpannerClient client) => _creationTask.IsValueCreated &&
                ReferenceEquals(_creationTask.Value.ResultWithUnwrappedExceptions(), client);

            private async Task<ChannelCredentials> CreateDefaultChannelCredentialsAsync()
            {
                var appDefaultCredentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
                if (appDefaultCredentials.IsCreateScopedRequired)
                {
                    appDefaultCredentials = appDefaultCredentials.CreateScoped(SpannerClient.DefaultScopes);
                }
                return appDefaultCredentials.ToChannelCredentials();
            }

            private async Task<SpannerClient> AcquireClientImplAsync()
            {
                var endpoint = _key.Endpoint ?? SpannerClient.DefaultEndpoint;
                ChannelCredentials channelCredentials;

                if (_key.Credential == null)
                {
                    channelCredentials = await CreateDefaultChannelCredentialsAsync().ConfigureAwait(false);
                }
                else
                {
                    channelCredentials = _key.Credential.ToChannelCredentials();
                }

                var channel = new Channel(
                    endpoint.Host,
                    endpoint.Port,
                    channelCredentials);
                return SpannerClient.Create(channel);
            }

            public Task<SpannerClient> AcquireClientAsync()
            {
                Interlocked.Increment(ref _refCount);
                return _creationTask.Value;
            }

            public void Release()
            {
                Interlocked.Decrement(ref _refCount);
            }

            /// <inheritdoc />
            public int CompareTo(SpannerClientCreator other)
            {
                GaxPreconditions.CheckNotNull(other, nameof(other));

                if (ReferenceEquals(this, other))
                {
                    return 0;
                }
                var result = _refCount.CompareTo(other._refCount);
                if (result == 0)
                {
                    // consistent (random) tie breaker.
                    result = GetHashCode().CompareTo(other.GetHashCode());
                }
                return result;
            }

            /// <inheritdoc />
            public int CompareTo(object obj)
            {
                return CompareTo((SpannerClientCreator) obj);
            }
        }
    }
}
