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

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Datastore.V1.Tests
{
    public class DatastoreDbTest : AbstractClientTester<DatastoreDb, DatastoreDbTest.DerivedDatastoreDb>
    {
        public class DerivedDatastoreDb : DatastoreDb
        {
            public override string ProjectId => "proj";
        }

        // The Get*Reference methods are actually implemented...
        public static IEnumerable<object[]> NotImplementedMethods => AllInstanceMethods;

        [Theory]
        [MemberData(nameof(NotImplementedMethods))]
        public void NotImplementedMethodsThrow(MethodInfo method)
        {
            AssertNotImplemented(method);
        }

        protected override object GetArgument(ParameterInfo parameter)
        {
            if (parameter.ParameterType == typeof(Entity))
            {
                return new Entity();
            }
            if (parameter.ParameterType == typeof(Key))
            {
                return new Key();
            }
            return base.GetArgument(parameter);
        }

        [Fact]
        public async Task LookupMultipleCalls()
        {
            await TestLookup((db, keys) => Task.FromResult(db.Lookup(keys)));
        }

        [Fact]
        public async Task LookupAsyncMultipleCalls()
        {
            await TestLookup((db, keys) => db.LookupAsync(keys));
        }
        
        private async Task TestLookup(Func<DatastoreDb, IEnumerable<Key>, Task<IReadOnlyList<Entity>>> lookupFunc)
        {
            KeyFactory factory = new KeyFactory("project", "ns", "kind");
            var keys = Enumerable.Range(0, 6).Select(i => factory.CreateKey(i)).ToList();

            // Return two at a time, in the order { 3, 1, 2, 5 } - no entry 0 or 4.
            var client = new FakeDatastoreClient(2, 3, 1, 2, 5);
            var db = DatastoreDb.Create("project", "ns", client);
            var lookup = await lookupFunc(db, keys);
            Assert.Null(lookup[0]);
            Assert.Null(lookup[4]);
            for (int i = 0; i < lookup.Count; i++)
            {
                if (lookup[i] != null)
                {
                    Assert.Equal(CreateEntity(factory.CreateKey(i)), lookup[i]);
                }
            }
            // Check that the requests were reasonable too.
            Assert.Equal(2, client.requests.Count);
            Assert.Equal(new[] { 0, 1, 2, 3, 4, 5 }, client.requests[0].Keys.Select(k => (int)k.Path.Last().Id));
            Assert.Equal(new[] { 2, 5 }, client.requests[1].Keys.Select(k => (int)k.Path.Last().Id));
        }

        private static Entity CreateEntity(Key key) =>
            new Entity
            {
                Key = key,
                ["human_key"] = RenderKey(key)
            };

        private static LookupRequest NormalizeRequest(LookupRequest input)
            => new LookupRequest
            {
                Keys = { input.Keys.Select(k => k.Clone()).OrderBy(RenderKey) },
                ProjectId = input.ProjectId,
                ReadOptions = input.ReadOptions
            };

        // TODO: Should we have something like this to create a canonical key format?
        private static string RenderKey(Key key)
        {
            string path = string.Join("/", key.Path.Select(pe => $"{pe.Kind}={pe.Id}"));
            return $"{key.PartitionId.ProjectId}:{key.PartitionId.NamespaceId}/{path}";
        }
        
        private class FakeDatastoreClient : DatastoreClient
        {
            private readonly KeyFactory keyFactory;
            private readonly List<Key> keys;
            private readonly int maxPerRequest;
            internal List<LookupRequest> requests = new List<LookupRequest>();

            internal FakeDatastoreClient(int maxPerRequest, params long[] ids)
            {
                this.maxPerRequest = maxPerRequest;
                keyFactory = new KeyFactory("project", "ns", "kind");
                keys = ids.Select(id => keyFactory.CreateKey(id)).ToList();
            }

            public override LookupResponse Lookup(LookupRequest request, CallSettings callSettings = null)
            {                
                requests.Add(NormalizeRequest(request));
                // Report "found" entities in the order they were presented in the constructor.
                // Report everything else as deferred. Ignore "missing"...
                var validKeys = keys.Where(k => request.Keys.Contains(k));
                var response = new LookupResponse
                {
                    Found = { validKeys.Take(maxPerRequest).Select(CreateEntityResult) },
                    Deferred = { validKeys.Skip(maxPerRequest) }
                };
                return response;
            }

            private static EntityResult CreateEntityResult(Key key) =>
                new EntityResult
                {
                    Entity = CreateEntity(key)
                };

            public override Task<LookupResponse> LookupAsync(LookupRequest request, CallSettings callSettings = null)
            {
                return Task.FromResult(Lookup(request, callSettings));
            }
        }
    }
}
