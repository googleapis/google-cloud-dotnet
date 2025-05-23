// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/v2beta1/session.proto
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

namespace Google.Cloud.Dialogflow.V2Beta1 {
  /// <summary>
  /// A service used for session interactions.
  ///
  /// For more information, see the [API interactions
  /// guide](https://cloud.google.com/dialogflow/docs/api-overview).
  /// </summary>
  public static partial class Sessions
  {
    static readonly string __ServiceName = "google.cloud.dialogflow.v2beta1.Sessions";

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
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentRequest> __Marshaller_google_cloud_dialogflow_v2beta1_DetectIntentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentResponse> __Marshaller_google_cloud_dialogflow_v2beta1_DetectIntentResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentRequest> __Marshaller_google_cloud_dialogflow_v2beta1_StreamingDetectIntentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentResponse> __Marshaller_google_cloud_dialogflow_v2beta1_StreamingDetectIntentResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentRequest, global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentResponse> __Method_DetectIntent = new grpc::Method<global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentRequest, global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DetectIntent",
        __Marshaller_google_cloud_dialogflow_v2beta1_DetectIntentRequest,
        __Marshaller_google_cloud_dialogflow_v2beta1_DetectIntentResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentRequest, global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentResponse> __Method_StreamingDetectIntent = new grpc::Method<global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentRequest, global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamingDetectIntent",
        __Marshaller_google_cloud_dialogflow_v2beta1_StreamingDetectIntentRequest,
        __Marshaller_google_cloud_dialogflow_v2beta1_StreamingDetectIntentResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dialogflow.V2Beta1.SessionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Sessions</summary>
    [grpc::BindServiceMethod(typeof(Sessions), "BindService")]
    public abstract partial class SessionsBase
    {
      /// <summary>
      /// Processes a natural language query and returns structured, actionable data
      /// as a result. This method is not idempotent, because it may cause contexts
      /// and session entity types to be updated, which in turn might affect
      /// results of future queries.
      ///
      /// If you might use
      /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
      /// or other CCAI products now or in the future, consider using
      /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
      /// instead of `DetectIntent`. `AnalyzeContent` has additional
      /// functionality for Agent Assist and other CCAI products.
      ///
      /// Note: Always use agent versions for production traffic.
      /// See [Versions and
      /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentResponse> DetectIntent(global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Processes a natural language query in audio format in a streaming fashion
      /// and returns structured, actionable data as a result. This method is only
      /// available via the gRPC API (not REST).
      ///
      /// If you might use
      /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
      /// or other CCAI products now or in the future, consider using
      /// [StreamingAnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.StreamingAnalyzeContent]
      /// instead of `StreamingDetectIntent`. `StreamingAnalyzeContent` has
      /// additional functionality for Agent Assist and other CCAI products.
      ///
      /// Note: Always use agent versions for production traffic.
      /// See [Versions and
      /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task StreamingDetectIntent(grpc::IAsyncStreamReader<global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentRequest> requestStream, grpc::IServerStreamWriter<global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Sessions</summary>
    public partial class SessionsClient : grpc::ClientBase<SessionsClient>
    {
      /// <summary>Creates a new client for Sessions</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SessionsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Sessions that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SessionsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SessionsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SessionsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Processes a natural language query and returns structured, actionable data
      /// as a result. This method is not idempotent, because it may cause contexts
      /// and session entity types to be updated, which in turn might affect
      /// results of future queries.
      ///
      /// If you might use
      /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
      /// or other CCAI products now or in the future, consider using
      /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
      /// instead of `DetectIntent`. `AnalyzeContent` has additional
      /// functionality for Agent Assist and other CCAI products.
      ///
      /// Note: Always use agent versions for production traffic.
      /// See [Versions and
      /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentResponse DetectIntent(global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DetectIntent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Processes a natural language query and returns structured, actionable data
      /// as a result. This method is not idempotent, because it may cause contexts
      /// and session entity types to be updated, which in turn might affect
      /// results of future queries.
      ///
      /// If you might use
      /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
      /// or other CCAI products now or in the future, consider using
      /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
      /// instead of `DetectIntent`. `AnalyzeContent` has additional
      /// functionality for Agent Assist and other CCAI products.
      ///
      /// Note: Always use agent versions for production traffic.
      /// See [Versions and
      /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentResponse DetectIntent(global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DetectIntent, null, options, request);
      }
      /// <summary>
      /// Processes a natural language query and returns structured, actionable data
      /// as a result. This method is not idempotent, because it may cause contexts
      /// and session entity types to be updated, which in turn might affect
      /// results of future queries.
      ///
      /// If you might use
      /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
      /// or other CCAI products now or in the future, consider using
      /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
      /// instead of `DetectIntent`. `AnalyzeContent` has additional
      /// functionality for Agent Assist and other CCAI products.
      ///
      /// Note: Always use agent versions for production traffic.
      /// See [Versions and
      /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentResponse> DetectIntentAsync(global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DetectIntentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Processes a natural language query and returns structured, actionable data
      /// as a result. This method is not idempotent, because it may cause contexts
      /// and session entity types to be updated, which in turn might affect
      /// results of future queries.
      ///
      /// If you might use
      /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
      /// or other CCAI products now or in the future, consider using
      /// [AnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.AnalyzeContent]
      /// instead of `DetectIntent`. `AnalyzeContent` has additional
      /// functionality for Agent Assist and other CCAI products.
      ///
      /// Note: Always use agent versions for production traffic.
      /// See [Versions and
      /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentResponse> DetectIntentAsync(global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DetectIntent, null, options, request);
      }
      /// <summary>
      /// Processes a natural language query in audio format in a streaming fashion
      /// and returns structured, actionable data as a result. This method is only
      /// available via the gRPC API (not REST).
      ///
      /// If you might use
      /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
      /// or other CCAI products now or in the future, consider using
      /// [StreamingAnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.StreamingAnalyzeContent]
      /// instead of `StreamingDetectIntent`. `StreamingAnalyzeContent` has
      /// additional functionality for Agent Assist and other CCAI products.
      ///
      /// Note: Always use agent versions for production traffic.
      /// See [Versions and
      /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentRequest, global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentResponse> StreamingDetectIntent(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamingDetectIntent(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Processes a natural language query in audio format in a streaming fashion
      /// and returns structured, actionable data as a result. This method is only
      /// available via the gRPC API (not REST).
      ///
      /// If you might use
      /// [Agent Assist](https://cloud.google.com/dialogflow/docs/#aa)
      /// or other CCAI products now or in the future, consider using
      /// [StreamingAnalyzeContent][google.cloud.dialogflow.v2beta1.Participants.StreamingAnalyzeContent]
      /// instead of `StreamingDetectIntent`. `StreamingAnalyzeContent` has
      /// additional functionality for Agent Assist and other CCAI products.
      ///
      /// Note: Always use agent versions for production traffic.
      /// See [Versions and
      /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentRequest, global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentResponse> StreamingDetectIntent(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamingDetectIntent, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override SessionsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SessionsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SessionsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DetectIntent, serviceImpl.DetectIntent)
          .AddMethod(__Method_StreamingDetectIntent, serviceImpl.StreamingDetectIntent).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SessionsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DetectIntent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentRequest, global::Google.Cloud.Dialogflow.V2Beta1.DetectIntentResponse>(serviceImpl.DetectIntent));
      serviceBinder.AddMethod(__Method_StreamingDetectIntent, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentRequest, global::Google.Cloud.Dialogflow.V2Beta1.StreamingDetectIntentResponse>(serviceImpl.StreamingDetectIntent));
    }

  }
}
#endregion
