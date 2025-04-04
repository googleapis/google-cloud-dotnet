// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1beta1/feature_online_store_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2025 Google LLC
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
//
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.AIPlatform.V1Beta1 {
  /// <summary>
  /// A service for fetching feature values from the online store.
  /// </summary>
  public static partial class FeatureOnlineStoreService
  {
    static readonly string __ServiceName = "google.cloud.aiplatform.v1beta1.FeatureOnlineStoreService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesRequest> __Marshaller_google_cloud_aiplatform_v1beta1_FetchFeatureValuesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesResponse> __Marshaller_google_cloud_aiplatform_v1beta1_FetchFeatureValuesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesRequest> __Marshaller_google_cloud_aiplatform_v1beta1_StreamingFetchFeatureValuesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesResponse> __Marshaller_google_cloud_aiplatform_v1beta1_StreamingFetchFeatureValuesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesRequest> __Marshaller_google_cloud_aiplatform_v1beta1_SearchNearestEntitiesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesResponse> __Marshaller_google_cloud_aiplatform_v1beta1_SearchNearestEntitiesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteRequest> __Marshaller_google_cloud_aiplatform_v1beta1_FeatureViewDirectWriteRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteResponse> __Marshaller_google_cloud_aiplatform_v1beta1_FeatureViewDirectWriteResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesResponse> __Method_FetchFeatureValues = new grpc::Method<global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FetchFeatureValues",
        __Marshaller_google_cloud_aiplatform_v1beta1_FetchFeatureValuesRequest,
        __Marshaller_google_cloud_aiplatform_v1beta1_FetchFeatureValuesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesResponse> __Method_StreamingFetchFeatureValues = new grpc::Method<global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamingFetchFeatureValues",
        __Marshaller_google_cloud_aiplatform_v1beta1_StreamingFetchFeatureValuesRequest,
        __Marshaller_google_cloud_aiplatform_v1beta1_StreamingFetchFeatureValuesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesRequest, global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesResponse> __Method_SearchNearestEntities = new grpc::Method<global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesRequest, global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchNearestEntities",
        __Marshaller_google_cloud_aiplatform_v1beta1_SearchNearestEntitiesRequest,
        __Marshaller_google_cloud_aiplatform_v1beta1_SearchNearestEntitiesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteRequest, global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteResponse> __Method_FeatureViewDirectWrite = new grpc::Method<global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteRequest, global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "FeatureViewDirectWrite",
        __Marshaller_google_cloud_aiplatform_v1beta1_FeatureViewDirectWriteRequest,
        __Marshaller_google_cloud_aiplatform_v1beta1_FeatureViewDirectWriteResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.AIPlatform.V1Beta1.FeatureOnlineStoreServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FeatureOnlineStoreService</summary>
    [grpc::BindServiceMethod(typeof(FeatureOnlineStoreService), "BindService")]
    public abstract partial class FeatureOnlineStoreServiceBase
    {
      /// <summary>
      /// Fetch feature values under a FeatureView.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesResponse> FetchFeatureValues(global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Bidirectional streaming RPC to fetch feature values under a FeatureView.
      /// Requests may not have a one-to-one mapping to responses and responses may
      /// be returned out-of-order to reduce latency.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task StreamingFetchFeatureValues(grpc::IAsyncStreamReader<global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesRequest> requestStream, grpc::IServerStreamWriter<global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Search the nearest entities under a FeatureView.
      /// Search only works for indexable feature view; if a feature view isn't
      /// indexable, returns Invalid argument response.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesResponse> SearchNearestEntities(global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Bidirectional streaming RPC to directly write to feature values in a
      /// feature view. Requests may not have a one-to-one mapping to responses and
      /// responses may be returned out-of-order to reduce latency.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task FeatureViewDirectWrite(grpc::IAsyncStreamReader<global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteRequest> requestStream, grpc::IServerStreamWriter<global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FeatureOnlineStoreService</summary>
    public partial class FeatureOnlineStoreServiceClient : grpc::ClientBase<FeatureOnlineStoreServiceClient>
    {
      /// <summary>Creates a new client for FeatureOnlineStoreService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FeatureOnlineStoreServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FeatureOnlineStoreService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FeatureOnlineStoreServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FeatureOnlineStoreServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FeatureOnlineStoreServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Fetch feature values under a FeatureView.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesResponse FetchFeatureValues(global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchFeatureValues(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Fetch feature values under a FeatureView.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesResponse FetchFeatureValues(global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FetchFeatureValues, null, options, request);
      }
      /// <summary>
      /// Fetch feature values under a FeatureView.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesResponse> FetchFeatureValuesAsync(global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchFeatureValuesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Fetch feature values under a FeatureView.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesResponse> FetchFeatureValuesAsync(global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FetchFeatureValues, null, options, request);
      }
      /// <summary>
      /// Bidirectional streaming RPC to fetch feature values under a FeatureView.
      /// Requests may not have a one-to-one mapping to responses and responses may
      /// be returned out-of-order to reduce latency.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesResponse> StreamingFetchFeatureValues(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamingFetchFeatureValues(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Bidirectional streaming RPC to fetch feature values under a FeatureView.
      /// Requests may not have a one-to-one mapping to responses and responses may
      /// be returned out-of-order to reduce latency.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesResponse> StreamingFetchFeatureValues(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamingFetchFeatureValues, null, options);
      }
      /// <summary>
      /// Search the nearest entities under a FeatureView.
      /// Search only works for indexable feature view; if a feature view isn't
      /// indexable, returns Invalid argument response.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesResponse SearchNearestEntities(global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchNearestEntities(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Search the nearest entities under a FeatureView.
      /// Search only works for indexable feature view; if a feature view isn't
      /// indexable, returns Invalid argument response.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesResponse SearchNearestEntities(global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchNearestEntities, null, options, request);
      }
      /// <summary>
      /// Search the nearest entities under a FeatureView.
      /// Search only works for indexable feature view; if a feature view isn't
      /// indexable, returns Invalid argument response.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesResponse> SearchNearestEntitiesAsync(global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchNearestEntitiesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Search the nearest entities under a FeatureView.
      /// Search only works for indexable feature view; if a feature view isn't
      /// indexable, returns Invalid argument response.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesResponse> SearchNearestEntitiesAsync(global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchNearestEntities, null, options, request);
      }
      /// <summary>
      /// Bidirectional streaming RPC to directly write to feature values in a
      /// feature view. Requests may not have a one-to-one mapping to responses and
      /// responses may be returned out-of-order to reduce latency.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteRequest, global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteResponse> FeatureViewDirectWrite(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FeatureViewDirectWrite(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Bidirectional streaming RPC to directly write to feature values in a
      /// feature view. Requests may not have a one-to-one mapping to responses and
      /// responses may be returned out-of-order to reduce latency.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteRequest, global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteResponse> FeatureViewDirectWrite(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_FeatureViewDirectWrite, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override FeatureOnlineStoreServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FeatureOnlineStoreServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(FeatureOnlineStoreServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_FetchFeatureValues, serviceImpl.FetchFeatureValues)
          .AddMethod(__Method_StreamingFetchFeatureValues, serviceImpl.StreamingFetchFeatureValues)
          .AddMethod(__Method_SearchNearestEntities, serviceImpl.SearchNearestEntities)
          .AddMethod(__Method_FeatureViewDirectWrite, serviceImpl.FeatureViewDirectWrite).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FeatureOnlineStoreServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_FetchFeatureValues, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1Beta1.FetchFeatureValuesResponse>(serviceImpl.FetchFeatureValues));
      serviceBinder.AddMethod(__Method_StreamingFetchFeatureValues, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesRequest, global::Google.Cloud.AIPlatform.V1Beta1.StreamingFetchFeatureValuesResponse>(serviceImpl.StreamingFetchFeatureValues));
      serviceBinder.AddMethod(__Method_SearchNearestEntities, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesRequest, global::Google.Cloud.AIPlatform.V1Beta1.SearchNearestEntitiesResponse>(serviceImpl.SearchNearestEntities));
      serviceBinder.AddMethod(__Method_FeatureViewDirectWrite, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteRequest, global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewDirectWriteResponse>(serviceImpl.FeatureViewDirectWrite));
    }

  }
}
#endregion
