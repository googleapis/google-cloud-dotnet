// Copyright 2020, Google Inc. All rights reserved.
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

using Grpc.Core;
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Spanner.Admin.Instance.V1.Tests
{
    public class ResourcePrefixHeaderTest
    {
        private const string ResourcePrefixHeader = "google-cloud-resource-prefix";
        private const string SampleInstanceName = "projects/proj/instances/inst";
        private const string SampleProjectName = "projects/proj";
        private const string SampleInstanceConfigName = "projects/proj/instanceConfigs/cfg";

        [Fact]
        public void NoHeaderOnGetInstanceIfEmptyInstanceName()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetInstance(new GetInstanceRequest());
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnGetInstanceIfInvalidInstanceName()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetInstance(new GetInstanceRequest { Name = "projects/instances" });
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnGetInstanceConfigIfEmptyInstanceConfigName()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetInstanceConfig(new GetInstanceConfigRequest());
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnGetInstanceConfigIfInvalidInstanceConfigName()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetInstanceConfig(new GetInstanceConfigRequest { Name = "projects/proj/instanceConfigs" });
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnCreateInstanceIfEmptyProjectName()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.CreateInstance(new CreateInstanceRequest());
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void NoHeaderOnCreateInstanceIfInvalidProjectName()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.CreateInstance(new CreateInstanceRequest { Parent = "projects" });
            Assert.Null(invoker.Metadata.FirstOrDefault(e => e.Key == ResourcePrefixHeader));
        }

        [Fact]
        public void SetsHeaderOnListInstanceConfigs()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.ListInstanceConfigs(new ListInstanceConfigsRequest { Parent = SampleProjectName }).AsRawResponses().First();
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleProjectName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnGetInstanceConfig()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetInstanceConfig(new GetInstanceConfigRequest { Name = SampleInstanceConfigName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleProjectName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnListInstances()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.ListInstances(new ListInstancesRequest { Parent = SampleProjectName }).AsRawResponses().First();
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleProjectName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnGetInstance()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.GetInstance(new GetInstanceRequest { Name = SampleInstanceName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnCreateInstance()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.CreateInstance(new CreateInstanceRequest { Parent = SampleProjectName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleProjectName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnUpdateInstance()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.UpdateInstance(new UpdateInstanceRequest
            {
                Instance = new Instance { Name = SampleInstanceName }
            });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        [Fact]
        public void SetsHeaderOnDeleteInstance()
        {
            var invoker = new FakeCallInvoker();
            var client = new InstanceAdminClientBuilder { CallInvoker = invoker }.Build();
            client.DeleteInstance(new DeleteInstanceRequest { Name = SampleInstanceName });
            Metadata.Entry entry = Assert.Single(invoker.Metadata, e => e.Key == ResourcePrefixHeader);
            Assert.Equal(SampleInstanceName, entry.Value);
        }

        private class FakeCallInvoker : CallInvoker
        {
            public Metadata Metadata { get; private set; }

            public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
                throw new NotImplementedException();

            public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
                throw new NotImplementedException();

            public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
                throw new NotImplementedException();

            public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
                throw new NotImplementedException();

            public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
            {
                Metadata = options.Headers;
                return (TResponse) Activator.CreateInstance(typeof(TResponse));
            }
        }
    }
}
