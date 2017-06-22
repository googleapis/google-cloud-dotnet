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
using System.Text;
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
            var key = new ClientCredentialKey(credentials, endpoint);
            var poolEntry = s_clientPoolByCredential.GetOrAdd(key, k => new CredentialClientPool(k));
            var result = await poolEntry.AcquireClientAsync().ConfigureAwait(false);
            Logger.LogPerformanceCounter("SpannerClient.TotalCount", () => s_clientPoolByCredential.Count);
            return result;
        }

        // ReSharper disable once UnusedMember.Global
        internal static void DumpPoolContents(StringBuilder s)
        {
            s.AppendLine("ClientPool.Contents:");
            int i = 0;
            foreach (var kvp in s_clientPoolByCredential)
            {
                s.AppendLine($"s_clientPoolByCredential({i}) Key:${kvp.Key}");
                kvp.Value.DumpCredentialPoolContents(s);
                i++;
            }
        }

        public static void ReleaseClient(SpannerClient spannerClient,
            ITokenAccess credentials = null,
            ServiceEndpoint endpoint = null)
        {
            if (spannerClient != null)
            {
                var key = new ClientCredentialKey(credentials, endpoint);
                var poolEntry = s_clientPoolByCredential.GetOrAdd(key, k => new CredentialClientPool(k));
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
                Endpoint = serviceEndpoint ?? SpannerClient.DefaultEndpoint;
            }

            public bool Equals(ClientCredentialKey other) => Equals(Credential, other.Credential) &&
                Equals(Endpoint, other.Endpoint);

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj))
                {
                    return false;
                }

                return obj is ClientCredentialKey other && Equals(other);
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

            /// <inheritdoc />
            public override string ToString()
            {
                return $"Credential:{Credential?.ToString() ?? "null"} EndPoint:{Endpoint}";
            }
        }

        private class CredentialClientPool
        {
            private readonly ClientCredentialKey _key;
            private readonly PriorityList<SpannerClientCreator> _clientPriorityList =
                new PriorityList<SpannerClientCreator>();
            private readonly object _sync = new object();


            public CredentialClientPool(ClientCredentialKey key) => _key = key;

            internal void DumpCredentialPoolContents(StringBuilder stringBuilder)
            {
                lock (_sync)
                {
                    int i = 0;
                    foreach (var item in _clientPriorityList.GetSnapshot())
                    {
                        stringBuilder.AppendLine($"  {i}:{item}");
                        i++;
                    }
                }
            }

            public Task<SpannerClient> AcquireClientAsync()
            {
                Task<SpannerClient> result;

                lock (_sync)
                {
                    //first ensure that the pool is of the correct size.
                    while (_clientPriorityList.Count > SpannerOptions.Instance.MaximumGrpcChannels)
                    {
                        _clientPriorityList.RemoveLast();
                    }
                    while (_clientPriorityList.Count < SpannerOptions.Instance.MaximumGrpcChannels)
                    {
                        var newEntry = new SpannerClientCreator(_key);
                        _clientPriorityList.Add(newEntry);
                    }

                    //now grab the first item in the sorted list, increment refcnt, re-sort and return.
                    result = _clientPriorityList.GetTop().AcquireClientAsync();
                }
                return result;
            }

            public void ReleaseClient(SpannerClient client)
            {
                lock (_sync)
                {
                    //find the entry and release refcnt and re-sort
                    SpannerClientCreator match;
                    if (_clientPriorityList.TryFindLinear(x => x.MatchesClient(client), out match)) {
                        match.Release();
                    }
                }
            }
        }

        private class SpannerClientCreator : IPriorityListItem<SpannerClientCreator>
        {
            private Lazy<Task<SpannerClient>> _creationTask;
            private int _refCount = 0;
            private readonly ClientCredentialKey _parentKey;

            public SpannerClientCreator(ClientCredentialKey parentKey)
            {
                _parentKey = parentKey;
                _creationTask = new Lazy<Task<SpannerClient>>(AcquireClientImplAsync);
            }

            public bool MatchesClient(SpannerClient client) => _creationTask.IsValueCreated &&
                !_creationTask.Value.IsFaulted &&
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
                var endpoint = _parentKey.Endpoint;
                ChannelCredentials channelCredentials;

                if (_parentKey.Credential == null)
                {
                    channelCredentials = await CreateDefaultChannelCredentialsAsync().ConfigureAwait(false);
                }
                else
                {
                    channelCredentials = _parentKey.Credential.ToChannelCredentials();
                }

                var channel = new Channel(
                    endpoint.Host,
                    endpoint.Port,
                    channelCredentials);
                Logger.LogPerformanceCounterFn("SpannerClient.RawCreateCount", (x) => x + 1);

                return SpannerClient.Create(channel);
            }

            public async Task<SpannerClient> AcquireClientAsync()
            {
                if (_creationTask.Value.IsFaulted)
                {
                    //retry an already failed task.
                    _creationTask = new Lazy<Task<SpannerClient>>(AcquireClientImplAsync);
                }

                var spannerClient = await _creationTask.Value.ConfigureAwait(false);
                Interlocked.Increment(ref _refCount);
                OnPriorityChanged();

                return spannerClient;
            }

            public void Release()
            {
                Interlocked.Decrement(ref _refCount);
                OnPriorityChanged();
            }

            /// <inheritdoc />
            public int CompareTo(SpannerClientCreator other)
            {
                if (ReferenceEquals(this, other))
                {
                    return 0;
                }
                if (ReferenceEquals(null, other))
                {
                    return 1;
                }
                int refCountComparison = _refCount.CompareTo(other._refCount);
                if (refCountComparison != 0)
                {
                    return refCountComparison;
                }
                // This has a chance of returning 0 even if the object is different.
                // That is fine and is handled by the PriorityHeap.
                return GetHashCode().CompareTo(other.GetHashCode());
            }

            /// <inheritdoc />
            public override string ToString()
            {
                return $"RefCount:{_refCount}. ParentHashCode{GetHashCode()}";
            }
            private void OnPriorityChanged()
            {
                PriorityChanged?.Invoke(this, EventArgs.Empty);
            }

            /// <inheritdoc />
            public event EventHandler<EventArgs> PriorityChanged;
        }
    }
}
