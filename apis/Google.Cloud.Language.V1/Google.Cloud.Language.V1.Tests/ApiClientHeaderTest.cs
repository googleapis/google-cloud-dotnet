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

using Grpc.Core;
using System;
using System.Linq;
using Xunit;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace Google.Cloud.Language.V1.Tests
{
    public class ApiClientHeaderTest
    {
        [Fact]
        public void ClientProvidesHeader()
        {
            var invoker = new FakeCallInvoker();
            var client = new LanguageServiceClientBuilder { CallInvoker = invoker }.Build();
            client.AnnotateText(Document.FromPlainText("Some text"), new Features { ClassifyText = true });
            var metadata = invoker.Metadata;
            var entry = metadata.FirstOrDefault(pair => pair.Key == "x-goog-api-client");
            Assert.NotNull(entry);
            var keys = entry.Value.Split(' ')
                .Select(value => value.Split('/')[0])
                .OrderBy(key => key)
                .ToList();
            string[] expectedKeys = { "gapic", "gax", "gl-dotnet", "grpc", "pb" };
            Assert.Equal(expectedKeys, keys);
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
