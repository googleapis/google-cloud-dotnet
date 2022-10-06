// Copyright 2022 Google LLC
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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using linq = System.Linq;
using st = System.Threading;
using stt = System.Threading.Tasks;
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
        /// Required. The unique name of the table from which to sample row keys.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(string tableName, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to sample row keys.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(gcbcv::TableName tableName, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to sample row keys.
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
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to sample row keys.
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
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// Required. The unique name of the instance to check permissions for as well as
        /// respond. Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
    }
}