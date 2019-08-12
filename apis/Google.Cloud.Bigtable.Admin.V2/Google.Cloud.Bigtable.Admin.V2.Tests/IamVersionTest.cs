// Copyright 2019 Google LLC
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

using Google.Cloud.Iam.V1;
using Grpc.Core;
using System;
using Xunit;

namespace Google.Cloud.Bigtable.Admin.V2.Tests
{
    public class IamVersionTest
    {
        [Theory]
        [InlineData(null, 1, 1)]
        [InlineData(null, null, null)]
        [InlineData(3, 1, 1)]
        [InlineData(3, null, 3)]
        [InlineData(1, 3, 3)]
        [InlineData(1, null, 1)]
        public void GetIamPolicyWithVersions(int? settingsVersion, int? callerRequestVersion, int? expectedRpcVersion)
        {
            var settings = new BigtableInstanceAdminSettings { SupportedIamPolicyVersion = settingsVersion };
            var callInvoker = new FakeCallInvoker();
            
            var client = new BigtableInstanceAdminClientBuilder
            {
                Settings = new BigtableInstanceAdminSettings { SupportedIamPolicyVersion = settingsVersion },
                CallInvoker = callInvoker
            }.Build();

            var callerRequest = new GetIamPolicyRequest
            {
                // TODO: Specify the caller request version
            };

            client.GetIamPolicy(callerRequest);
            var lastRequest = callInvoker.LastRequest;

            // TODO: Assertions around the version in lastRequest            
            if (callerRequestVersion != expectedRpcVersion)
            {
                Assert.NotSame(callerRequest, lastRequest);
            }
        }

        private class FakeCallInvoker : CallInvoker
        {
            public GetIamPolicyRequest LastRequest { get; set; }
            
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
                if (typeof(TRequest) == typeof(GetIamPolicyRequest))
                {
                    LastRequest = (GetIamPolicyRequest) (object) request;
                    return (TResponse) Activator.CreateInstance(typeof(TResponse));
                }
                throw new NotImplementedException();
            }
        }
    }
}
