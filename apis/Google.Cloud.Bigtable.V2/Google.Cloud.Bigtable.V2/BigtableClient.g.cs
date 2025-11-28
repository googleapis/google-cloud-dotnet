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

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcbcv = Google.Cloud.Bigtable.Common.V2;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using linq = System.Linq;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using Google.Api.Gax;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>BigtableServiceApi client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for reading from and writing to existing Bigtable tables.
    /// </remarks>
    public partial class BigtableClient
    {
        /// <summary>Streams back the contents of all requested rows in key order, optionally applying the same Reader filter to each.</summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="ReadRowsRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(ReadRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="SampleRowKeysRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(SampleRowKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to sample row keys.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(string tableName, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableName = tableName ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to sample row keys.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(gcbcv::TableName tableName, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableNameAsTableName = tableName,
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to sample row keys.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(string tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableName = tableName ?? "",
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to sample row keys.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(gcbcv::TableName tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableNameAsTableName = tableName,
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="MutateRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowResponse MutateRow(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="MutateRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="MutateRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(MutateRowRequest request, st::CancellationToken cancellationToken) =>
            MutateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="MutateRowsRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowsResponse MutateRows(MutateRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="MutateRowsRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual stt::Task<MutateRowsResponse> MutateRowsAsync(MutateRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="MutateRowsRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>The RPC response.</returns>
        public virtual stt::Task<MutateRowsResponse> MutateRowsAsync(MutateRowsRequest request, st::CancellationToken cancellationToken) => MutateRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="CheckAndMutateRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="CheckAndMutateRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="CheckAndMutateRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(CheckAndMutateRowRequest request, st::CancellationToken cancellationToken) =>
            CheckAndMutateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="PingAndWarmRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PingAndWarmResponse PingAndWarm(PingAndWarmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="PingAndWarmRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(PingAndWarmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="PingAndWarmRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(PingAndWarmRequest request, st::CancellationToken cancellationToken) =>
            PingAndWarmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PingAndWarmResponse PingAndWarm(string name, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarm(new PingAndWarmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarmAsync(new PingAndWarmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(string name, st::CancellationToken cancellationToken) =>
            PingAndWarmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PingAndWarmResponse PingAndWarm(gcbcv::InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarm(new PingAndWarmRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(gcbcv::InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarmAsync(new PingAndWarmRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(gcbcv::InstanceName name, st::CancellationToken cancellationToken) =>
            PingAndWarmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PingAndWarmResponse PingAndWarm(string name, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarm(new PingAndWarmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(string name, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarmAsync(new PingAndWarmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(string name, string appProfileId, st::CancellationToken cancellationToken) =>
            PingAndWarmAsync(name, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PingAndWarmResponse PingAndWarm(gcbcv::InstanceName name, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarm(new PingAndWarmRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(gcbcv::InstanceName name, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarmAsync(new PingAndWarmRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(gcbcv::InstanceName name, string appProfileId, st::CancellationToken cancellationToken) =>
            PingAndWarmAsync(name, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="ReadModifyWriteRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="ReadModifyWriteRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="ReadModifyWriteRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(ReadModifyWriteRowRequest request, st::CancellationToken cancellationToken) =>
            ReadModifyWriteRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the current list of partitions that make up the table's
        /// change stream. The union of partitions will cover the entire keyspace.
        /// Partitions can be read with `ReadChangeStream`.
        /// NOTE: This API is only intended to be used by Apache Beam BigtableIO.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="GenerateInitialChangeStreamPartitionsRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(GenerateInitialChangeStreamPartitionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the current list of partitions that make up the table's
        /// change stream. The union of partitions will cover the entire keyspace.
        /// Partitions can be read with `ReadChangeStream`.
        /// NOTE: This API is only intended to be used by Apache Beam BigtableIO.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to get change stream
        /// partitions. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(string tableName, gaxgrpc::CallSettings callSettings = null) =>
            GenerateInitialChangeStreamPartitions(new GenerateInitialChangeStreamPartitionsRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// Returns the current list of partitions that make up the table's
        /// change stream. The union of partitions will cover the entire keyspace.
        /// Partitions can be read with `ReadChangeStream`.
        /// NOTE: This API is only intended to be used by Apache Beam BigtableIO.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to get change stream
        /// partitions. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(gcbcv::TableName tableName, gaxgrpc::CallSettings callSettings = null) =>
            GenerateInitialChangeStreamPartitions(new GenerateInitialChangeStreamPartitionsRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// Returns the current list of partitions that make up the table's
        /// change stream. The union of partitions will cover the entire keyspace.
        /// Partitions can be read with `ReadChangeStream`.
        /// NOTE: This API is only intended to be used by Apache Beam BigtableIO.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to get change stream
        /// partitions. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// Single cluster routing must be configured on the profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(string tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            GenerateInitialChangeStreamPartitions(new GenerateInitialChangeStreamPartitionsRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Returns the current list of partitions that make up the table's
        /// change stream. The union of partitions will cover the entire keyspace.
        /// Partitions can be read with `ReadChangeStream`.
        /// NOTE: This API is only intended to be used by Apache Beam BigtableIO.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to get change stream
        /// partitions. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// Single cluster routing must be configured on the profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(gcbcv::TableName tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            GenerateInitialChangeStreamPartitions(new GenerateInitialChangeStreamPartitionsRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Reads changes from a table's change stream. Changes will
        /// reflect both user-initiated mutations and mutations that are caused by
        /// garbage collection.
        /// NOTE: This API is only intended to be used by Apache Beam BigtableIO.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="ReadChangeStreamRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.ReadChangeStreamStream ReadChangeStream(ReadChangeStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads changes from a table's change stream. Changes will
        /// reflect both user-initiated mutations and mutations that are caused by
        /// garbage collection.
        /// NOTE: This API is only intended to be used by Apache Beam BigtableIO.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read a change stream.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.ReadChangeStreamStream ReadChangeStream(string tableName, gaxgrpc::CallSettings callSettings = null) =>
            ReadChangeStream(new ReadChangeStreamRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// Reads changes from a table's change stream. Changes will
        /// reflect both user-initiated mutations and mutations that are caused by
        /// garbage collection.
        /// NOTE: This API is only intended to be used by Apache Beam BigtableIO.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read a change stream.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.ReadChangeStreamStream ReadChangeStream(gcbcv::TableName tableName, gaxgrpc::CallSettings callSettings = null) =>
            ReadChangeStream(new ReadChangeStreamRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// Reads changes from a table's change stream. Changes will
        /// reflect both user-initiated mutations and mutations that are caused by
        /// garbage collection.
        /// NOTE: This API is only intended to be used by Apache Beam BigtableIO.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read a change stream.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// Single cluster routing must be configured on the profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.ReadChangeStreamStream ReadChangeStream(string tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadChangeStream(new ReadChangeStreamRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Reads changes from a table's change stream. Changes will
        /// reflect both user-initiated mutations and mutations that are caused by
        /// garbage collection.
        /// NOTE: This API is only intended to be used by Apache Beam BigtableIO.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read a change stream.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// Single cluster routing must be configured on the profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.ReadChangeStreamStream ReadChangeStream(gcbcv::TableName tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadChangeStream(new ReadChangeStreamRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="PrepareQueryRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrepareQueryResponse PrepareQuery(PrepareQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="PrepareQueryRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(PrepareQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="PrepareQueryRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(PrepareQueryRequest request, st::CancellationToken cancellationToken) =>
            PrepareQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrepareQueryResponse PrepareQuery(string instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQuery(new PrepareQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(string instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQueryAsync(new PrepareQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(string instanceName, string query, st::CancellationToken cancellationToken) =>
            PrepareQueryAsync(instanceName, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrepareQueryResponse PrepareQuery(gcbcv::InstanceName instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQuery(new PrepareQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(gcbcv::InstanceName instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQueryAsync(new PrepareQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(gcbcv::InstanceName instanceName, string query, st::CancellationToken cancellationToken) =>
            PrepareQueryAsync(instanceName, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrepareQueryResponse PrepareQuery(string instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQuery(new PrepareQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(string instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQueryAsync(new PrepareQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(string instanceName, string query, string appProfileId, st::CancellationToken cancellationToken) =>
            PrepareQueryAsync(instanceName, query, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrepareQueryResponse PrepareQuery(gcbcv::InstanceName instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQuery(new PrepareQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(gcbcv::InstanceName instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQueryAsync(new PrepareQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(gcbcv::InstanceName instanceName, string query, string appProfileId, st::CancellationToken cancellationToken) =>
            PrepareQueryAsync(instanceName, query, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes a SQL query against a particular Bigtable instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call. If the <see cref="ExecuteQueryRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.ExecuteQueryStream ExecuteQuery(ExecuteQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a SQL query against a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// 
        /// Exactly one of `query` and `prepared_query` is required. Setting both
        /// or neither is an `INVALID_ARGUMENT`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        [sys::ObsoleteAttribute]
        public virtual BigtableServiceApiClient.ExecuteQueryStream ExecuteQuery(string instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteQuery(new ExecuteQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Executes a SQL query against a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// 
        /// Exactly one of `query` and `prepared_query` is required. Setting both
        /// or neither is an `INVALID_ARGUMENT`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        [sys::ObsoleteAttribute]
        public virtual BigtableServiceApiClient.ExecuteQueryStream ExecuteQuery(gcbcv::InstanceName instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteQuery(new ExecuteQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Executes a SQL query against a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// 
        /// Exactly one of `query` and `prepared_query` is required. Setting both
        /// or neither is an `INVALID_ARGUMENT`.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for replication. If not specified,
        /// the `default` application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        [sys::ObsoleteAttribute]
        public virtual BigtableServiceApiClient.ExecuteQueryStream ExecuteQuery(string instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteQuery(new ExecuteQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Executes a SQL query against a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// 
        /// Exactly one of `query` and `prepared_query` is required. Setting both
        /// or neither is an `INVALID_ARGUMENT`.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for replication. If not specified,
        /// the `default` application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        [sys::ObsoleteAttribute]
        public virtual BigtableServiceApiClient.ExecuteQueryStream ExecuteQuery(gcbcv::InstanceName instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteQuery(new ExecuteQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);
    }

    /// <summary>BigtableServiceApi client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for reading from and writing to existing Bigtable tables.
    /// </remarks>
    public sealed partial class BigtableClientImpl : BigtableClient
    {
        /// <inheritdoc/>
        public override ReadRowsStream ReadRows(ReadRowsRequest request, gaxgrpc::CallSettings callSettings = null) => ReadRowsImpl(request, callSettings);

        /// <inheritdoc/>
        public override BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(SampleRowKeysRequest request, gaxgrpc::CallSettings callSettings = null) => _client.SampleRowKeys(request, callSettings);

        /// <inheritdoc/>
        public override MutateRowResponse MutateRow(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null) => _client.MutateRow(request, callSettings);

        /// <inheritdoc/>
        public override stt::Task<MutateRowResponse> MutateRowAsync(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null) => _client.MutateRowAsync(request, callSettings);

        /// <inheritdoc/>
        public override MutateRowsResponse MutateRows(MutateRowsRequest request, gaxgrpc::CallSettings callSettings = null) => stt::Task.Run(() => MutateRowsAsync(request, callSettings)).ResultWithUnwrappedExceptions();

        /// <inheritdoc/>
        public override stt::Task<MutateRowsResponse> MutateRowsAsync(MutateRowsRequest request, gaxgrpc::CallSettings callSettings = null) => MutateRowsImpl(request, callSettings);

        /// <inheritdoc/>
        public override CheckAndMutateRowResponse CheckAndMutateRow(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null) => _client.CheckAndMutateRow(request, callSettings);

        /// <inheritdoc/>
        public override stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null) => _client.CheckAndMutateRowAsync(request, callSettings);

        /// <inheritdoc/>
        public override PingAndWarmResponse PingAndWarm(PingAndWarmRequest request, gaxgrpc::CallSettings callSettings = null) => _client.PingAndWarm(request, callSettings);

        /// <inheritdoc/>
        public override stt::Task<PingAndWarmResponse> PingAndWarmAsync(PingAndWarmRequest request, gaxgrpc::CallSettings callSettings = null) => _client.PingAndWarmAsync(request, callSettings);

        /// <inheritdoc/>
        public override ReadModifyWriteRowResponse ReadModifyWriteRow(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null) => _client.ReadModifyWriteRow(request, callSettings);

        /// <inheritdoc/>
        public override stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null) => _client.ReadModifyWriteRowAsync(request, callSettings);

        /// <inheritdoc/>
        public override BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(GenerateInitialChangeStreamPartitionsRequest request, gaxgrpc::CallSettings callSettings = null) => _client.GenerateInitialChangeStreamPartitions(request, callSettings);

        /// <inheritdoc/>
        public override BigtableServiceApiClient.ReadChangeStreamStream ReadChangeStream(ReadChangeStreamRequest request, gaxgrpc::CallSettings callSettings = null) => _client.ReadChangeStream(request, callSettings);

        /// <inheritdoc/>
        public override PrepareQueryResponse PrepareQuery(PrepareQueryRequest request, gaxgrpc::CallSettings callSettings = null) => _client.PrepareQuery(request, callSettings);

        /// <inheritdoc/>
        public override stt::Task<PrepareQueryResponse> PrepareQueryAsync(PrepareQueryRequest request, gaxgrpc::CallSettings callSettings = null) => _client.PrepareQueryAsync(request, callSettings);

        /// <inheritdoc/>
        public override BigtableServiceApiClient.ExecuteQueryStream ExecuteQuery(ExecuteQueryRequest request, gaxgrpc::CallSettings callSettings = null) => _client.ExecuteQuery(request, callSettings);
    }
}