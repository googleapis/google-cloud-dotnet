using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Api.Gax.Grpc
{
    public abstract class BidirectionalStreamingBase<TRequest, TResponse>
    {
        public virtual AsyncDuplexStreamingCall<TRequest, TResponse> GrpcCall { get; }

        // Streaming requests

        public virtual Task TryWriteAsync(TRequest message)
        {
            throw new NotImplementedException();
        }

        public virtual Task WriteAsync(TRequest message)
        {
            throw new NotImplementedException();
        }

        public virtual Task TryWriteAsync(TRequest message, WriteOptions options)
        {
            throw new NotImplementedException();
        }

        public virtual Task WriteAsync(TRequest message, WriteOptions options)
        {
            throw new NotImplementedException();
        }

        public virtual Task WriteCompleteAsync()
        {
            throw new NotImplementedException();
        }

        // Streaming responses

        public virtual IAsyncEnumerator<TResponse> ResponseStream { get; }
    }

    internal static class ApiBidirectionalStreamingCall
    {
        internal static ApiBidirectionalStreamingCall<TRequest, TResponse> Create<TRequest, TResponse>(
            Func<CallOptions, AsyncDuplexStreamingCall<TRequest, TResponse>> grpcCall,
            CallSettings baseCallSettings,
            BidirectionalStreamingSettings streamingSettings,
            IClock clock)
        {
            return new ApiBidirectionalStreamingCall<TRequest, TResponse>(
                cs => grpcCall(cs.ToCallOptions(null, clock)),
                baseCallSettings,
                streamingSettings);
        }
    }

    public sealed class ApiBidirectionalStreamingCall<TRequest, TResponse>
    {
        internal ApiBidirectionalStreamingCall(
            Func<CallSettings, AsyncDuplexStreamingCall<TRequest, TResponse>> call,
            CallSettings baseCallSettings,
            BidirectionalStreamingSettings streamingSettings)
        {
            _call = call;
            _baseCallSettings = baseCallSettings;
            StreamingSettings = streamingSettings;
        }

        private readonly Func<CallSettings, AsyncDuplexStreamingCall<TRequest, TResponse>> _call;
        private readonly CallSettings _baseCallSettings;

        public BidirectionalStreamingSettings StreamingSettings { get; }

        public AsyncDuplexStreamingCall<TRequest, TResponse> Call(CallSettings perCallCallSettings) =>
            _call(_baseCallSettings.MergedWith(perCallCallSettings));

        internal ApiBidirectionalStreamingCall<TRequest, TResponse> WithUserAgent(string userAgent) =>
            new ApiBidirectionalStreamingCall<TRequest, TResponse>(
                _call,
                CallSettings.FromHeader(UserAgentBuilder.HeaderName, userAgent).MergedWith(_baseCallSettings),
                StreamingSettings);
    }

    public sealed class BidirectionalStreamingSettings
    {
        public static BidirectionalStreamingSettings FromBufferCapacity(int bufferCapacity) =>
            new BidirectionalStreamingSettings(bufferCapacity);

        public BidirectionalStreamingSettings(
            int bufferedClientWriterCapacity)
        {
            BufferedClientWriterCapacity = bufferedClientWriterCapacity;
        }

        public int BufferedClientWriterCapacity { get; }
    }

    // This already exists in GAX, but it's internal.
    public static class CallSettingsExtensions
    {
        internal static CallOptions ToCallOptions(this CallSettings baseSettings, CallSettings callSettings, IClock clock)
        {
            // Is implemented in GAX already
            throw new NotImplementedException();
        }
    }

    // This already exists in GAX, but it's internal.
    internal sealed class UserAgentBuilder
    {
        internal const string HeaderName = "x-goog-api-client";
    }
}
