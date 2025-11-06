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

public class RequestIdOnExceptionInterceptorTests
{
    private static readonly SpannerClientBuilder.RequestIdOnExceptionInterceptor s_interceptor =
        SpannerClientBuilder.RequestIdOnExceptionInterceptor.Instance;

    private readonly string _fakeRequest = "fake";
    private readonly ClientInterceptorContext<string, string> _unaryContext = CreateContext(MethodType.ClientStreaming);
    private readonly ClientInterceptorContext<string, string> _clientStreamingContext = CreateContext(MethodType.ClientStreaming);
    private readonly ClientInterceptorContext<string, string> _serverStreamingContext = CreateContext(MethodType.ClientStreaming);
    private readonly ClientInterceptorContext<string, string> _duplexStreamingContext = CreateContext(MethodType.ClientStreaming);

    private static readonly string s_requestId = Guid.NewGuid().ToString();
    private static readonly Metadata s_metadata = new() { { "x-goog-spanner-request-id", s_requestId } };
    private static readonly CallOptions s_options = new(headers: s_metadata);
    private static readonly string s_sampleSessionName = "sessionName";

    private static readonly Exception s_exception = new();

    [Fact]
    public void BlockingUnaryCall_ContinuationThrows_ExceptionEnriched() =>
        AssertThrowsEnrichedException(() =>
            s_interceptor.BlockingUnaryCall(_fakeRequest, _unaryContext, (req, ctx) => throw s_exception));

    [Fact]
    public void AsyncUnaryCall_ContinuationThrows_ExceptionEnriched() =>
        AssertThrowsEnrichedException(() =>
            s_interceptor.AsyncUnaryCall(_fakeRequest, _unaryContext, (req, ctx) => throw s_exception));

    [Fact]
    public void AsyncClientStreamingCall_ContinuationThrows_ExceptionEnriched() =>
        AssertThrowsEnrichedException(() =>
            s_interceptor.AsyncClientStreamingCall(_clientStreamingContext, (ctx) => throw s_exception));

    [Fact]
    public void AsyncServerStreamingCall_ContinuationThrows_ExceptionEnriched() =>
        AssertThrowsEnrichedException(() =>
            s_interceptor.AsyncServerStreamingCall(_fakeRequest, _serverStreamingContext, (req, ctx) => throw s_exception));

    [Fact]
    public void AsyncDuplexStreamingCall_ContinuationThrows_ExceptionEnriched() =>
        AssertThrowsEnrichedException(() =>
            s_interceptor.AsyncDuplexStreamingCall(_duplexStreamingContext, (ctx) => throw s_exception));

    [Fact]
    public async Task AsyncUnaryCall_ResponseAsyncThrows_ExceptionEnriched()
    {
        var call = CreateAsyncUnaryCall(response: Task.FromException<string>(s_exception));
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncUnaryCall(_fakeRequest, _unaryContext, (req, ctx) => call).ResponseAsync);
    }

    [Fact]
    public async Task AsyncUnaryCall_ResponseHeadersAsyncThrows_ExceptionEnriched()
    {
        var call = CreateAsyncUnaryCall(headers: Task.FromException<Metadata>(s_exception));
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncUnaryCall(_fakeRequest, _unaryContext, (req, ctx) => call).ResponseHeadersAsync);
    }

    [Fact]
    public async Task AsyncClientStreamingCall_ResponseAsyncThrows_ExceptionEnriched()
    {
        var call = CreateAsyncClientStreamingCall(response: Task.FromException<string>(s_exception));
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncClientStreamingCall(_clientStreamingContext, (ctx) => call).ResponseAsync);
    }

    [Fact]
    public async Task AsyncClientStreamingCall_ResponseHeadersAsyncThrows_ExceptionEnriched()
    {
        var call = CreateAsyncClientStreamingCall(headers: Task.FromException<Metadata>(s_exception));
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncClientStreamingCall(_clientStreamingContext, (ctx) => call).ResponseHeadersAsync);
    }

    [Fact]
    public async Task AsyncClientStreamingCall_RequestStreamWriteThrows_ExceptionEnriched()
    {
        var call = CreateAsyncClientStreamingCall(requestStream: new ThrowingClientStreamWriter<string>(s_exception));
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncClientStreamingCall(_clientStreamingContext, (ctx) => call).RequestStream.WriteAsync("1"));
    }

    [Fact]
    public async Task AsyncClientStreamingCall_RequestStreamCompleteThrows_ExceptionEnriched()
    {
        var call = CreateAsyncClientStreamingCall(requestStream: new ThrowingClientStreamWriter<string>(s_exception));
        var context = CreateContext(MethodType.ClientStreaming);
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncClientStreamingCall(_clientStreamingContext, (ctx) => call).RequestStream.CompleteAsync());
    }

    [Fact]
    public async Task AsyncServerStreamingCall_ResponseHeadersAsyncThrows_ExceptionEnriched()
    {
        var call = CreateAsyncServerStreamingCall(headers: Task.FromException<Metadata>(s_exception));
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncServerStreamingCall("1", _serverStreamingContext, (req, ctx) => call).ResponseHeadersAsync);
    }

    [Fact]
    public async Task AsyncServerStreamingCall_ResponseStreamMoveNextThrows_ExceptionEnriched()
    {
        var call = CreateAsyncServerStreamingCall(responseStream: new ThrowingAsyncStreamReader<string>(s_exception));
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncServerStreamingCall(_fakeRequest, _serverStreamingContext, (req, ctx) => call).ResponseStream.MoveNext(default));
    }

    [Fact]
    public async Task AsyncDuplexStreamingCall_ResponseHeadersAsyncThrows_ExceptionEnriched()
    {
        var call = CreateAsyncDuplexStreamingCall(headers: Task.FromException<Metadata>(s_exception));
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncDuplexStreamingCall(_duplexStreamingContext, (ctx) => call).ResponseHeadersAsync);
    }

    [Fact]
    public async Task AsyncDuplexStreamingCall_RequestStreamWriteThrows_ExceptionEnriched()
    {
        var call = CreateAsyncDuplexStreamingCall(requestStream: new ThrowingClientStreamWriter<string>(s_exception));
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncDuplexStreamingCall(_duplexStreamingContext, (ctx) => call).RequestStream.WriteAsync("1"));
    }

    [Fact]
    public async Task AsyncDuplexStreamingCall_RequestStreamCompleteThrows_ExceptionEnriched()
    {
        var call = CreateAsyncDuplexStreamingCall(requestStream: new ThrowingClientStreamWriter<string>(s_exception));
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncDuplexStreamingCall(_duplexStreamingContext, (ctx) => call).RequestStream.CompleteAsync());
    }

    [Fact]
    public async Task AsyncDuplexStreamingCall_ResponseStreamMoveNextThrows_ExceptionEnriched()
    {
        var call = CreateAsyncDuplexStreamingCall(responseStream: new ThrowingAsyncStreamReader<string>(s_exception));
        await AssertThrowsEnrichedExceptionAsync(() =>
            s_interceptor.AsyncDuplexStreamingCall(_duplexStreamingContext, (ctx) => call).ResponseStream.MoveNext(default));
    }

    /// <summary>
    /// This test validates when a gRPC error is thrown while using the <see cref="SpannerClient"/>
    /// the exception is enriched with the RequestId. We do not cover the full set of exception flows
    /// because <see cref="SpannerClient"/> does not implement all gRPC call types (i.e. no DuplexStreaming
    /// and ClientStreaming) and we have already covered all cases with direct unit tests on
    /// <see cref="SpannerClientBuilder.RequestIdOnExceptionInterceptor"/>. This test serves to validate
    /// <see cref="SpannerClientBuilder"/> attaches the interceptor on build.
    /// </summary>
    [Fact]
    public async Task SpannerClient_Throws_ExceptionEnriched()
    {
        var callInvoker = new FakeThrowingCallInvoker(s_exception);
        var client = new SpannerClientBuilder { CallInvoker = callInvoker }.Build();

        var stream = client.ExecuteStreamingSql(new ExecuteSqlRequest { Session = s_sampleSessionName, Sql = "SELECT 1" });
        await AssertThrowsEnrichedExceptionAsync(async () => await stream.GrpcCall.ResponseStream.MoveNext(default));
    }

    // Verification Helpers

    private static void AssertThrowsEnrichedException(Action action) =>
        AssertEnrichedException(Assert.Throws<Exception>(action));

    private static async Task AssertThrowsEnrichedExceptionAsync(Func<Task> action) =>
        AssertEnrichedException(await Assert.ThrowsAsync<Exception>(action));

    private static void AssertEnrichedException(Exception ex)
    {
        // The Exception.Data property should contain a non-empty Request ID field
        Assert.Same(s_exception, ex);
        Assert.True(s_exception.Data.Contains("x-goog-spanner-request-id"));
        Assert.False(string.IsNullOrEmpty((string)s_exception.Data["x-goog-spanner-request-id"]));
    }

    // Creation Helpers

    private static ClientInterceptorContext<string, string> CreateContext(MethodType methodType) =>
        new ClientInterceptorContext<string, string>(
            new Method<string, string>(methodType, "s", "m", Marshallers.StringMarshaller, Marshallers.StringMarshaller),
            null,
            s_options);

    private static AsyncUnaryCall<string> CreateAsyncUnaryCall(Task<string> response = null, Task<Metadata> headers = null) =>
        new AsyncUnaryCall<string>(
            response ?? Task.FromResult("1"),
            headers ?? Task.FromResult(new Metadata()),
            () => Status.DefaultSuccess,
            () => new Metadata(),
            () => { });

    private static AsyncClientStreamingCall<string, string> CreateAsyncClientStreamingCall(
        IClientStreamWriter<string> requestStream = null,
        Task<string> response = null,
        Task<Metadata> headers = null) =>
        new AsyncClientStreamingCall<string, string>(
            requestStream ?? new ThrowingClientStreamWriter<string>(null),
            response ?? Task.FromResult("1"),
            headers ?? Task.FromResult(new Metadata()),
            () => Status.DefaultSuccess,
            () => new Metadata(),
            () => { });

    private static AsyncServerStreamingCall<string> CreateAsyncServerStreamingCall(
        IAsyncStreamReader<string> responseStream = null,
        Task<Metadata> headers = null) =>
        new AsyncServerStreamingCall<string>(
            responseStream ?? new ThrowingAsyncStreamReader<string>(null),
            headers ?? Task.FromResult(new Metadata()),
            () => Status.DefaultSuccess,
            () => new Metadata(),
            () => { });

    private static AsyncDuplexStreamingCall<string, string> CreateAsyncDuplexStreamingCall(
        IClientStreamWriter<string> requestStream = null,
        IAsyncStreamReader<string> responseStream = null,
        Task<Metadata> headers = null) =>
        new AsyncDuplexStreamingCall<string, string>(
            requestStream ?? new ThrowingClientStreamWriter<string>(null),
            responseStream ?? new ThrowingAsyncStreamReader<string>(null),
            headers ?? Task.FromResult(new Metadata()),
            () => Status.DefaultSuccess,
            () => new Metadata(),
            () => { });

    private class ThrowingAsyncStreamReader<T> : IAsyncStreamReader<T>
    {
        private readonly Exception _exception;
        public ThrowingAsyncStreamReader(Exception exception) => _exception = exception;
        public T Current => default;
        public Task<bool> MoveNext(CancellationToken cancellationToken) =>
            _exception != null ? Task.FromException<bool>(_exception) : Task.FromResult(false);
    }

    private class ThrowingClientStreamWriter<T> : IClientStreamWriter<T>
    {
        private readonly Exception _exception;
        public ThrowingClientStreamWriter(Exception exception) => _exception = exception;
        public WriteOptions WriteOptions { get; set; }
        public Task CompleteAsync() => _exception != null ? Task.FromException(_exception) : Task.CompletedTask;
        public Task WriteAsync(T message) => _exception != null ? Task.FromException(_exception) : Task.CompletedTask;
    }

    private class FakeThrowingCallInvoker : CallInvoker
    {
        private readonly Exception _exceptionToThrow;

        public FakeThrowingCallInvoker(Exception exceptionToThrow)
        {
            _exceptionToThrow = exceptionToThrow;
        }

        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
        {
            return new AsyncServerStreamingCall<TResponse>(
                new ThrowingAsyncStreamReader<TResponse>(_exceptionToThrow),
                Task.FromException<Metadata>(_exceptionToThrow),
                () => Status.DefaultSuccess,
                () => new Metadata(),
                () => { });
        }

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) => throw new NotImplementedException();
        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) => throw new NotImplementedException();
        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) => throw new NotImplementedException();
        public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) => throw new NotImplementedException();
    }
}
