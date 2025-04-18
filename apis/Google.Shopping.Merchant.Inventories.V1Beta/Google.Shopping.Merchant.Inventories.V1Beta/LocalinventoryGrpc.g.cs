// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/shopping/merchant/inventories/v1beta/localinventory.proto
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

namespace Google.Shopping.Merchant.Inventories.V1Beta {
  /// <summary>
  /// Service to manage local inventory for products
  /// </summary>
  public static partial class LocalInventoryService
  {
    static readonly string __ServiceName = "google.shopping.merchant.inventories.v1beta.LocalInventoryService";

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
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesRequest> __Marshaller_google_shopping_merchant_inventories_v1beta_ListLocalInventoriesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesResponse> __Marshaller_google_shopping_merchant_inventories_v1beta_ListLocalInventoriesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Inventories.V1Beta.InsertLocalInventoryRequest> __Marshaller_google_shopping_merchant_inventories_v1beta_InsertLocalInventoryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Inventories.V1Beta.InsertLocalInventoryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Inventories.V1Beta.LocalInventory> __Marshaller_google_shopping_merchant_inventories_v1beta_LocalInventory = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Inventories.V1Beta.LocalInventory.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Inventories.V1Beta.DeleteLocalInventoryRequest> __Marshaller_google_shopping_merchant_inventories_v1beta_DeleteLocalInventoryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Inventories.V1Beta.DeleteLocalInventoryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesRequest, global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesResponse> __Method_ListLocalInventories = new grpc::Method<global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesRequest, global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListLocalInventories",
        __Marshaller_google_shopping_merchant_inventories_v1beta_ListLocalInventoriesRequest,
        __Marshaller_google_shopping_merchant_inventories_v1beta_ListLocalInventoriesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Inventories.V1Beta.InsertLocalInventoryRequest, global::Google.Shopping.Merchant.Inventories.V1Beta.LocalInventory> __Method_InsertLocalInventory = new grpc::Method<global::Google.Shopping.Merchant.Inventories.V1Beta.InsertLocalInventoryRequest, global::Google.Shopping.Merchant.Inventories.V1Beta.LocalInventory>(
        grpc::MethodType.Unary,
        __ServiceName,
        "InsertLocalInventory",
        __Marshaller_google_shopping_merchant_inventories_v1beta_InsertLocalInventoryRequest,
        __Marshaller_google_shopping_merchant_inventories_v1beta_LocalInventory);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Inventories.V1Beta.DeleteLocalInventoryRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteLocalInventory = new grpc::Method<global::Google.Shopping.Merchant.Inventories.V1Beta.DeleteLocalInventoryRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteLocalInventory",
        __Marshaller_google_shopping_merchant_inventories_v1beta_DeleteLocalInventoryRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Shopping.Merchant.Inventories.V1Beta.LocalinventoryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LocalInventoryService</summary>
    [grpc::BindServiceMethod(typeof(LocalInventoryService), "BindService")]
    public abstract partial class LocalInventoryServiceBase
    {
      /// <summary>
      /// Lists the `LocalInventory` resources for the given product in your merchant
      /// account. The response might contain fewer items than specified by
      /// `pageSize`. If `pageToken` was returned in previous request, it can be used
      /// to obtain additional results.
      ///
      /// `LocalInventory` resources are listed per product for a given account.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesResponse> ListLocalInventories(global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Inserts a `LocalInventory` resource to a product in your merchant
      /// account.
      ///
      /// Replaces the full `LocalInventory` resource if an entry with the same
      /// [`storeCode`][google.shopping.merchant.inventories.v1beta.LocalInventory.store_code]
      /// already exists for the product.
      ///
      /// It might take up to 30 minutes for the new or updated `LocalInventory`
      /// resource to appear in products.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Inventories.V1Beta.LocalInventory> InsertLocalInventory(global::Google.Shopping.Merchant.Inventories.V1Beta.InsertLocalInventoryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the specified `LocalInventory` from the given product in your
      /// merchant account. It might take a up to an hour for the
      /// `LocalInventory` to be deleted from the specific product.
      /// Once you have received a successful delete response, wait for that
      /// period before attempting a delete again.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteLocalInventory(global::Google.Shopping.Merchant.Inventories.V1Beta.DeleteLocalInventoryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for LocalInventoryService</summary>
    public partial class LocalInventoryServiceClient : grpc::ClientBase<LocalInventoryServiceClient>
    {
      /// <summary>Creates a new client for LocalInventoryService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public LocalInventoryServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LocalInventoryService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public LocalInventoryServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected LocalInventoryServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected LocalInventoryServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists the `LocalInventory` resources for the given product in your merchant
      /// account. The response might contain fewer items than specified by
      /// `pageSize`. If `pageToken` was returned in previous request, it can be used
      /// to obtain additional results.
      ///
      /// `LocalInventory` resources are listed per product for a given account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesResponse ListLocalInventories(global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListLocalInventories(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the `LocalInventory` resources for the given product in your merchant
      /// account. The response might contain fewer items than specified by
      /// `pageSize`. If `pageToken` was returned in previous request, it can be used
      /// to obtain additional results.
      ///
      /// `LocalInventory` resources are listed per product for a given account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesResponse ListLocalInventories(global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListLocalInventories, null, options, request);
      }
      /// <summary>
      /// Lists the `LocalInventory` resources for the given product in your merchant
      /// account. The response might contain fewer items than specified by
      /// `pageSize`. If `pageToken` was returned in previous request, it can be used
      /// to obtain additional results.
      ///
      /// `LocalInventory` resources are listed per product for a given account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesResponse> ListLocalInventoriesAsync(global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListLocalInventoriesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the `LocalInventory` resources for the given product in your merchant
      /// account. The response might contain fewer items than specified by
      /// `pageSize`. If `pageToken` was returned in previous request, it can be used
      /// to obtain additional results.
      ///
      /// `LocalInventory` resources are listed per product for a given account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesResponse> ListLocalInventoriesAsync(global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListLocalInventories, null, options, request);
      }
      /// <summary>
      /// Inserts a `LocalInventory` resource to a product in your merchant
      /// account.
      ///
      /// Replaces the full `LocalInventory` resource if an entry with the same
      /// [`storeCode`][google.shopping.merchant.inventories.v1beta.LocalInventory.store_code]
      /// already exists for the product.
      ///
      /// It might take up to 30 minutes for the new or updated `LocalInventory`
      /// resource to appear in products.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Inventories.V1Beta.LocalInventory InsertLocalInventory(global::Google.Shopping.Merchant.Inventories.V1Beta.InsertLocalInventoryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertLocalInventory(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Inserts a `LocalInventory` resource to a product in your merchant
      /// account.
      ///
      /// Replaces the full `LocalInventory` resource if an entry with the same
      /// [`storeCode`][google.shopping.merchant.inventories.v1beta.LocalInventory.store_code]
      /// already exists for the product.
      ///
      /// It might take up to 30 minutes for the new or updated `LocalInventory`
      /// resource to appear in products.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Inventories.V1Beta.LocalInventory InsertLocalInventory(global::Google.Shopping.Merchant.Inventories.V1Beta.InsertLocalInventoryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_InsertLocalInventory, null, options, request);
      }
      /// <summary>
      /// Inserts a `LocalInventory` resource to a product in your merchant
      /// account.
      ///
      /// Replaces the full `LocalInventory` resource if an entry with the same
      /// [`storeCode`][google.shopping.merchant.inventories.v1beta.LocalInventory.store_code]
      /// already exists for the product.
      ///
      /// It might take up to 30 minutes for the new or updated `LocalInventory`
      /// resource to appear in products.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Inventories.V1Beta.LocalInventory> InsertLocalInventoryAsync(global::Google.Shopping.Merchant.Inventories.V1Beta.InsertLocalInventoryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertLocalInventoryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Inserts a `LocalInventory` resource to a product in your merchant
      /// account.
      ///
      /// Replaces the full `LocalInventory` resource if an entry with the same
      /// [`storeCode`][google.shopping.merchant.inventories.v1beta.LocalInventory.store_code]
      /// already exists for the product.
      ///
      /// It might take up to 30 minutes for the new or updated `LocalInventory`
      /// resource to appear in products.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Inventories.V1Beta.LocalInventory> InsertLocalInventoryAsync(global::Google.Shopping.Merchant.Inventories.V1Beta.InsertLocalInventoryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_InsertLocalInventory, null, options, request);
      }
      /// <summary>
      /// Deletes the specified `LocalInventory` from the given product in your
      /// merchant account. It might take a up to an hour for the
      /// `LocalInventory` to be deleted from the specific product.
      /// Once you have received a successful delete response, wait for that
      /// period before attempting a delete again.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteLocalInventory(global::Google.Shopping.Merchant.Inventories.V1Beta.DeleteLocalInventoryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteLocalInventory(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified `LocalInventory` from the given product in your
      /// merchant account. It might take a up to an hour for the
      /// `LocalInventory` to be deleted from the specific product.
      /// Once you have received a successful delete response, wait for that
      /// period before attempting a delete again.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteLocalInventory(global::Google.Shopping.Merchant.Inventories.V1Beta.DeleteLocalInventoryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteLocalInventory, null, options, request);
      }
      /// <summary>
      /// Deletes the specified `LocalInventory` from the given product in your
      /// merchant account. It might take a up to an hour for the
      /// `LocalInventory` to be deleted from the specific product.
      /// Once you have received a successful delete response, wait for that
      /// period before attempting a delete again.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteLocalInventoryAsync(global::Google.Shopping.Merchant.Inventories.V1Beta.DeleteLocalInventoryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteLocalInventoryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified `LocalInventory` from the given product in your
      /// merchant account. It might take a up to an hour for the
      /// `LocalInventory` to be deleted from the specific product.
      /// Once you have received a successful delete response, wait for that
      /// period before attempting a delete again.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteLocalInventoryAsync(global::Google.Shopping.Merchant.Inventories.V1Beta.DeleteLocalInventoryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteLocalInventory, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override LocalInventoryServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LocalInventoryServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(LocalInventoryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListLocalInventories, serviceImpl.ListLocalInventories)
          .AddMethod(__Method_InsertLocalInventory, serviceImpl.InsertLocalInventory)
          .AddMethod(__Method_DeleteLocalInventory, serviceImpl.DeleteLocalInventory).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, LocalInventoryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListLocalInventories, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesRequest, global::Google.Shopping.Merchant.Inventories.V1Beta.ListLocalInventoriesResponse>(serviceImpl.ListLocalInventories));
      serviceBinder.AddMethod(__Method_InsertLocalInventory, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Inventories.V1Beta.InsertLocalInventoryRequest, global::Google.Shopping.Merchant.Inventories.V1Beta.LocalInventory>(serviceImpl.InsertLocalInventory));
      serviceBinder.AddMethod(__Method_DeleteLocalInventory, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Inventories.V1Beta.DeleteLocalInventoryRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteLocalInventory));
    }

  }
}
#endregion
