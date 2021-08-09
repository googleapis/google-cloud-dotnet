// Copyright 2021 Google LLC
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
using System.Threading.Tasks;

namespace Google.Cloud.Compute.V1
{
    /// <summary>
    /// Non-generic static class just for generic type inference.
    /// </summary>
    internal static class ForwardingCallInvoker<TSourceRequest> where TSourceRequest : class
    {
        internal static ForwardingCallInvoker<TSourceRequest, TSourceResponse, TTargetRequest, TTargetResponse> Create<TSourceResponse, TTargetRequest, TTargetResponse>(
            CallInvoker originalInvoker, string sourceMethodFullName, Method<TTargetRequest, TTargetResponse> targetMethod,
            Func<TSourceRequest, TTargetRequest> requestConverter,
            Func<TSourceRequest, TTargetResponse, TSourceResponse> responseConverter)            
            where TSourceResponse : class
            where TTargetRequest : class
            where TTargetResponse : class =>
            new ForwardingCallInvoker<TSourceRequest, TSourceResponse, TTargetRequest, TTargetResponse>(originalInvoker, sourceMethodFullName, targetMethod, requestConverter, responseConverter);
    }
    
    /// <summary>
    /// CallInvoker which proxies all calls, but for a single method (identified by name) can adapt to use a different method,
    /// with a custom conversion. This allows us to proxy calls between the "standard" OperationsClient and the Compute zonal/regional/global clients.
    /// It would be cleaner to write an interceptor, but that doesn't allow for the request/response types to be changed.
    /// </summary>
    internal sealed class ForwardingCallInvoker<TSourceRequest, TSourceResponse, TTargetRequest, TTargetResponse> : CallInvoker
        where TSourceRequest : class
        where TSourceResponse : class
        where TTargetRequest : class
        where TTargetResponse : class
    {
        private CallInvoker _targetInvoker;
        private string _sourceMethodFullName;
        private Method<TTargetRequest, TTargetResponse> _targetMethod;
        private Func<TSourceRequest, TTargetRequest> _requestConverter;
        private Func<TSourceRequest, TTargetResponse, TSourceResponse> _responseConverter;

        internal ForwardingCallInvoker(
            CallInvoker originalInvoker, string sourceMethodFullName, Method<TTargetRequest, TTargetResponse> targetMethod,
            Func<TSourceRequest, TTargetRequest> requestConverter,
            Func<TSourceRequest, TTargetResponse, TSourceResponse> responseConverter)
        {
            _targetInvoker = originalInvoker;
            _sourceMethodFullName = sourceMethodFullName;
            _targetMethod = targetMethod;
            _requestConverter = requestConverter;
            _responseConverter = responseConverter;
        }

        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
            _targetInvoker.AsyncClientStreamingCall(method, host, options);

        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
            _targetInvoker.AsyncDuplexStreamingCall(method, host, options);

        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
            _targetInvoker.AsyncServerStreamingCall(method, host, options, request);

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
        {
            if (method.FullName != _sourceMethodFullName)
            {
                return _targetInvoker.AsyncUnaryCall(method, host, options, request);
            }

            var sourceRequest = (TSourceRequest)(object)request;
            var targetRequest = _requestConverter(sourceRequest);
            var targetCall = _targetInvoker.AsyncUnaryCall(_targetMethod, host, options, targetRequest);

            return new AsyncUnaryCall<TResponse>(ConvertResponse(sourceRequest, targetCall.ResponseAsync), targetCall.ResponseHeadersAsync, targetCall.GetStatus, targetCall.GetTrailers, targetCall.Dispose);

            async Task<TResponse> ConvertResponse(TSourceRequest sourceRequest, Task<TTargetResponse> targetResponseTask)
            {
                var targetResponse = await targetResponseTask.ConfigureAwait(false);
                var sourceResponse = _responseConverter(sourceRequest, targetResponse);
                return (TResponse)(object)sourceResponse;
            }
        }

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
        {
            if (method.FullName != _sourceMethodFullName)
            {
                return _targetInvoker.BlockingUnaryCall(method, host, options, request);
            }

            var sourceRequest = (TSourceRequest)(object)request;
            var targetRequest = _requestConverter(sourceRequest);
            var targetResponse = _targetInvoker.BlockingUnaryCall(_targetMethod, host, options, targetRequest);
            var sourceResponse = _responseConverter(sourceRequest, targetResponse);
            return (TResponse)(object) sourceResponse;
        }
    }
}
