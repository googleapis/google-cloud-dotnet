// Copyright 2025 Google LLC
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
using Grpc.Core.Interceptors;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests;

public class SpannerRequestIdCallInterceptorTest
{
    private static readonly Method<string, string> s_unaryMethod = new Method<string, string>(MethodType.Unary, "service", "method", Marshallers.StringMarshaller, Marshallers.StringMarshaller);
    private static readonly Method<string, string> s_clientStreamingMethod = new Method<string, string>(MethodType.ClientStreaming, "service", "method", Marshallers.StringMarshaller, Marshallers.StringMarshaller);
    private static readonly Method<string, string> s_serverStreamingMethod = new Method<string, string>(MethodType.ServerStreaming, "service", "method", Marshallers.StringMarshaller, Marshallers.StringMarshaller);
    private static readonly Method<string, string> s_duplexStreamingMethod = new Method<string, string>(MethodType.DuplexStreaming, "service", "method", Marshallers.StringMarshaller, Marshallers.StringMarshaller);

    public static TheoryData<Func<CallInvoker, CallOptions, Task>> CallInvokerActions { get; } = new TheoryData<Func<CallInvoker, CallOptions, Task>>
    {
        (invoker, options) => Task.Run(() => invoker.BlockingUnaryCall(s_unaryMethod, null, options, "")),
        (invoker, options) => invoker.AsyncUnaryCall(s_unaryMethod, null, options, "").ResponseAsync,
        (invoker, options) => invoker.AsyncClientStreamingCall(s_clientStreamingMethod, null, options).ResponseAsync,
        (invoker, options) => invoker.AsyncServerStreamingCall(s_serverStreamingMethod, null, options, "").ResponseStream.MoveNext(),
        (invoker, options) => invoker.AsyncDuplexStreamingCall(s_duplexStreamingMethod, null, options).ResponseStream.MoveNext()
    };

    [Theory]
    [MemberData(nameof(CallInvokerActions))]
    public async Task RpcCall_ExceptionContainsRequestId(Func<CallInvoker, CallOptions, Task> action)
    {
        var invoker = new ThrowingCallInvoker();
        var interceptedInvoker = invoker.Intercept(new SpannerRequestIdCallInterceptor());
        var headers = new Metadata { { SpannerRequestId.HeaderKey, "test-request-id" } };
        var options = new CallOptions(headers);

        var exception = await Assert.ThrowsAsync<RpcException>(() => action(interceptedInvoker, options));

        Assert.True(exception.Data.Contains(SpannerRequestId.HeaderKey));
        Assert.Equal("test-request-id", exception.Data[SpannerRequestId.HeaderKey]);
    }

    private class ThrowingCallInvoker : CallInvoker
    {
        public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
            throw new RpcException(new Status(StatusCode.Internal, "Test exception"));

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
            new AsyncUnaryCall<TResponse>(
                Task.FromException<TResponse>(new RpcException(new Status(StatusCode.Internal, "Test exception"))),
                Task.FromResult(new Metadata()), () => Status.DefaultSuccess, () => new Metadata(), () => { });

        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
            new AsyncClientStreamingCall<TRequest, TResponse>(
                new MockClientStreamWriter<TRequest>(),
                Task.FromException<TResponse>(new RpcException(new Status(StatusCode.Internal, "Test exception"))),
                Task.FromResult(new Metadata()), () => Status.DefaultSuccess, () => new Metadata(), () => { });

        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
            new AsyncServerStreamingCall<TResponse>(
                new ThrowingStreamReader<TResponse>(),
                Task.FromResult(new Metadata()), () => Status.DefaultSuccess, () => new Metadata(), () => { });

        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
            new AsyncDuplexStreamingCall<TRequest, TResponse>(
                new MockClientStreamWriter<TRequest>(),
                new ThrowingStreamReader<TResponse>(),
                Task.FromResult(new Metadata()), () => Status.DefaultSuccess, () => new Metadata(), () => { });
    }

    private class MockClientStreamWriter<T> : IClientStreamWriter<T>
    {
        public WriteOptions WriteOptions { get; set; }
        public Task CompleteAsync() => Task.CompletedTask;
        public Task WriteAsync(T message) => Task.CompletedTask;
    }

    private class ThrowingStreamReader<T> : IAsyncStreamReader<T>
    {
        public T Current => default;

        public Task<bool> MoveNext(CancellationToken cancellationToken) =>
            Task.FromException<bool>(new RpcException(new Status(StatusCode.Internal, "Test exception")));
    }
}
