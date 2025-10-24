// Copyright 2021 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Grpc.Core;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Interface for common properties of <see cref="ReadRequest"/> and <see cref="ExecuteSqlRequest"/>.
    /// </summary>
    internal interface IReadOrQueryRequest
    {
        /// <summary>
        /// Returns a ByteString representation of this request.
        /// </summary>
        ByteString ToByteString();

        /// <summary>
        /// See <see cref="ReadRequest.Clone"/> and <see cref="ExecuteSqlRequest.Clone"/>
        /// </summary>
        IReadOrQueryRequest CloneRequest();

        /// <summary>
        /// See <see cref="ReadRequest.Session"/> and <see cref="ExecuteSqlRequest.Session"/>
        /// </summary>
        string Session { get; }

        /// <summary>
        /// See <see cref="ReadRequest.Session"/> and <see cref="ExecuteSqlRequest.Session"/>
        /// </summary>
        SessionName SessionAsSessionName { set; }

        /// <summary>
        /// See <see cref="ReadRequest.Transaction"/> and <see cref="ExecuteSqlRequest.Transaction"/>
        /// </summary>
        TransactionSelector Transaction { get; set; }

        /// <summary>
        /// See <see cref="ReadRequest.DirectedReadOptions"/> and <see cref="ExecuteSqlRequest.DirectedReadOptions"/>
        /// </summary>
        DirectedReadOptions DirectedReadOptions { get; set; }

        /// <summary>
        /// See <see cref="ReadRequest.ResumeToken"/> and <see cref="ExecuteSqlRequest.ResumeToken"/>
        /// </summary>
        ByteString ResumeToken { set; }

        /// <summary>
        /// See <see cref="ReadRequest.DataBoostEnabled"/> and <see cref="ExecuteSqlRequest.DataBoostEnabled"/>
        /// </summary>
        bool DataBoostEnabled { get; set; }

        /// <summary>
        /// See <see cref="ReadRequest.PartitionToken"/> and <see cref="ExecuteSqlRequest.PartitionToken"/>
        /// </summary>
        ByteString PartitionToken { get; set; }

        /// <summary>
        /// Executes the streaming query/read RPC.
        /// </summary>
        /// <param name="client">The client to use for the execution</param>
        /// <param name="callSettings">The call settings to use for the invocation</param>
        /// <returns>The result stream for the query/read</returns>
        AsyncServerStreamingCall<PartialResultSet> ExecuteStreaming(SpannerClient client, CallSettings callSettings);
    }

    /// <summary>
    /// Interface for common properties of <see cref="PartitionReadRequest"/> and <see cref="PartitionQueryRequest"/>.
    /// </summary>
    internal interface IPartitionReadOrQueryRequest
    {
        /// <summary>
        /// See <see cref="PartitionReadRequest.Session"/> and <see cref="PartitionQueryRequest.Session"/>
        /// </summary>
        SessionName SessionAsSessionName { set; }

        /// <summary>
        /// See <see cref="PartitionReadRequest.Transaction"/> and <see cref="PartitionQueryRequest.Transaction"/>
        /// </summary>
        TransactionSelector Transaction { get;  set; }

        /// <summary>
        /// See <see cref="PartitionReadRequest.PartitionOptions"/> and <see cref="PartitionQueryRequest.PartitionOptions"/>
        /// </summary>
        PartitionOptions PartitionOptions { get; set; }

        /// <summary>
        /// Executes the partition request using the given client and call settings.
        /// </summary>
        /// <param name="client">The client to use to execute the request</param>
        /// <param name="callSettings">The call settings to use for the invocation</param>
        /// <returns>The partition response</returns>
        Task<PartitionResponse> PartitionAsync(SpannerClient client, CallSettings callSettings);
    }

    /// <summary>
    /// Class for common properties of <see cref="ReadRequest"/> and <see cref="ExecuteSqlRequest"/>.
    /// </summary>
    public sealed class ReadOrQueryRequest
    {
        internal IReadOrQueryRequest UnderlyingRequest { get; }

        /// <summary>
        /// Creates a new ReadOrQueryRequest from an ExecuteSqlRequest.
        /// </summary>
        /// <param name="request">The request to wrap in a generic ReadOrQueryRequest</param>
        /// <returns>A new ReadOrQueryRequest that wraps the given request</returns>
        public static ReadOrQueryRequest FromQueryRequest(ExecuteSqlRequest request) =>
            FromRequest(request);

        /// <summary>
        /// Creates a new ReadOrQueryRequest from an ReadRequest.
        /// </summary>
        /// <param name="request">The request to wrap in a generic ReadOrQueryRequest</param>
        /// <returns>A new ReadOrQueryRequest that wraps the given request</returns>
        public static ReadOrQueryRequest FromReadRequest(ReadRequest request) =>
            FromRequest(request);

        internal static ReadOrQueryRequest FromRequest(IReadOrQueryRequest request) =>
            new ReadOrQueryRequest(request);

        private ReadOrQueryRequest(IReadOrQueryRequest request) => UnderlyingRequest = GaxPreconditions.CheckNotNull(request, nameof(request));

        /// <summary>
        /// True if this is query, and false otherwise.
        /// </summary>
        public bool IsQuery => UnderlyingRequest is ExecuteSqlRequest;

        /// <summary>
        /// True if this is a read, and false otherwise.
        /// </summary>
        public bool IsRead => UnderlyingRequest is ReadRequest;

        /// <summary>
        /// The underlying ExecuteSqlRequest if this is a query, and null otherwise.
        /// </summary>
        public ExecuteSqlRequest ExecuteSqlRequest => UnderlyingRequest as ExecuteSqlRequest;

        /// <summary>
        /// The underlying ReadRequest if this is a read, and null otherwise.
        /// </summary>
        public ReadRequest ReadRequest => UnderlyingRequest as ReadRequest;

        /// <summary>
        /// Creates a PartitionReadOrQueryRequest from a ReadOrQueryRequest.
        /// </summary>
        /// <returns>A new PartitionReadOrQueryRequest with the properties of the given request</returns>
        public PartitionReadOrQueryRequest ToPartitionReadOrQueryRequest(long? partitionSizeBytes, long? maxPartitions)
        {
            var request = IsQuery
                ? PartitionReadOrQueryRequest.FromRequest(ToPartitionQueryRequest())
                : PartitionReadOrQueryRequest.FromRequest(ToPartitionReadRequest());
            request.PartitionOptions =
                partitionSizeBytes.HasValue || maxPartitions.HasValue ? new PartitionOptions() : null;
            if (partitionSizeBytes.HasValue)
            {
                request.PartitionOptions.PartitionSizeBytes = partitionSizeBytes.Value;
            }
            if (maxPartitions.HasValue)
            {
                request.PartitionOptions.MaxPartitions = maxPartitions.Value;
            }
            return request;
        }

        private PartitionQueryRequest ToPartitionQueryRequest()
        {
            var request = UnderlyingRequest as ExecuteSqlRequest;
            return new PartitionQueryRequest
            {
                Sql = request.Sql,
                Params = request.Params,
                ParamTypes = { request.ParamTypes }
            };
        }

        private PartitionReadRequest ToPartitionReadRequest()
        {
            var request = UnderlyingRequest as ReadRequest;
            return new PartitionReadRequest
            {
                Table = request.Table,
                Columns = { request.Columns },
                Index = request.Index,
                KeySet = request.KeySet
            };
        }

        /// <summary>
        /// Extracts the corresponding CallSettings for the read or query request from the SpannerSettings.
        /// </summary>
        /// <param name="spannerSettings">The SpannerSettings to extract the CallSettings from</param>
        /// <returns>The CallSettings to use for the request</returns>
        public CallSettings GetCallSettings(SpannerSettings spannerSettings) =>
            IsQuery
                ? spannerSettings.ExecuteStreamingSqlSettings
                : spannerSettings.StreamingReadSettings;

        /// <summary>
        /// Returns a ByteString representation of this request.
        /// </summary>
        public ByteString ToByteString() => UnderlyingRequest.ToByteString();

        /// <summary>
        /// See <see cref="ReadRequest.Clone"/> and <see cref="ExecuteSqlRequest.Clone"/>
        /// </summary>
        public ReadOrQueryRequest CloneRequest() => new ReadOrQueryRequest(UnderlyingRequest.CloneRequest());

        /// <summary>
        /// See <see cref="V1.Session"/> and <see cref="V1.Session"/>
        /// </summary>
        public string Session => UnderlyingRequest.Session;

        /// <summary>
        /// See <see cref="V1.Session"/> and <see cref="V1.Session"/>
        /// </summary>
        public SessionName SessionAsSessionName
        {
            set => UnderlyingRequest.SessionAsSessionName = value;
        }

        /// <summary>
        /// See <see cref="ReadRequest.Transaction"/> and <see cref="ExecuteSqlRequest.Transaction"/>
        /// </summary>
        public TransactionSelector Transaction
        {
            get => UnderlyingRequest.Transaction;
            set => UnderlyingRequest.Transaction = value;
        }

        /// <summary>
        /// See <see cref="ReadRequest.DirectedReadOptions"/> and <see cref="ExecuteSqlRequest.DirectedReadOptions"/>
        /// </summary>
        public DirectedReadOptions DirectedReadOptions
        {
            get => UnderlyingRequest.DirectedReadOptions;
            set => UnderlyingRequest.DirectedReadOptions = value;
        }

        /// <summary>
        /// See <see cref="ReadRequest.ResumeToken"/> and <see cref="ExecuteSqlRequest.ResumeToken"/>
        /// </summary>
        public ByteString ResumeToken
        {
            set => UnderlyingRequest.ResumeToken = value;
        }

        /// <summary>
        /// See <see cref="ReadRequest.DataBoostEnabled"/> and <see cref="ExecuteSqlRequest.DataBoostEnabled"/>
        /// </summary>
        public bool DataBoostEnabled
        {
            get => UnderlyingRequest.DataBoostEnabled;
            set => UnderlyingRequest.DataBoostEnabled = value;
        }

        /// <summary>
        /// See <see cref="ReadRequest.PartitionToken"/> and <see cref="ExecuteSqlRequest.PartitionToken"/>
        /// </summary>
        public ByteString PartitionToken
        {
            get => UnderlyingRequest.PartitionToken;
            set => UnderlyingRequest.PartitionToken = value;
        }

        /// <summary>
        /// Executes the streaming query/read RPC.
        /// </summary>
        /// <param name="client">The client to use for the execution</param>
        /// <param name="callSettings">The call settings to use for the invocation</param>
        /// <returns>The result stream for the query/read</returns>
        internal AsyncServerStreamingCall<PartialResultSet> ExecuteStreaming(SpannerClient client, CallSettings callSettings) =>
            UnderlyingRequest.ExecuteStreaming(client, callSettings);

        /// <summary>
        /// Creates a <see cref="ReliableStreamReader"/> for this request
        /// </summary>
        /// <param name="transaction">The managed transaction to use for the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A <see cref="ReliableStreamReader"/> for this request.</returns>
        public ReliableStreamReader ExecuteReadOrQueryStreamReader(ManagedTransaction transaction, CallSettings callSettings) =>
            transaction.ExecuteReadOrQueryStreamReader(this, callSettings);

        /// <summary>
        /// Creates a <see cref="ReliableStreamReader"/> for this request
        /// </summary>
        /// <param name="session">The session to use for the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A <see cref="ReliableStreamReader"/> for this request.</returns>
        public ReliableStreamReader ExecuteReadOrQueryStreamReader(PooledSession session, CallSettings callSettings) =>
            session.ExecuteReadOrQueryStreamReader(this, callSettings);

        /// <inheritdoc/>
        public override bool Equals(object o) =>
            o is ReadOrQueryRequest request && request.UnderlyingRequest.Equals(UnderlyingRequest);

        /// <inheritdoc/>
        public override int GetHashCode() => UnderlyingRequest.GetHashCode();
    }

    /// <summary>
    /// Class for common properties of <see cref="PartitionReadRequest"/> and <see cref="PartitionQueryRequest"/>.
    /// </summary>
    public sealed class PartitionReadOrQueryRequest
    {
        private IPartitionReadOrQueryRequest Request { get; }

        internal static PartitionReadOrQueryRequest FromRequest(IPartitionReadOrQueryRequest request) =>
            new PartitionReadOrQueryRequest(request);

        private PartitionReadOrQueryRequest(IPartitionReadOrQueryRequest request) => Request = GaxPreconditions.CheckNotNull(request, nameof(request));

        /// <summary>
        /// Extracts the corresponding CallSettings for the partition read or query request from the SpannerSettings.
        /// </summary>
        /// <param name="spannerSettings">The SpannerSettings to extract the CallSettings from</param>
        /// <returns>The CallSettings to use for the request</returns>
        public CallSettings GetCallSettings(SpannerSettings spannerSettings) =>
            Request is PartitionQueryRequest
                ? spannerSettings.PartitionQuerySettings
                : spannerSettings.PartitionReadSettings;

        /// <summary>
        /// See <see cref="PartitionReadRequest.Session"/> and <see cref="PartitionQueryRequest.Session"/>
        /// </summary>
        public SessionName SessionAsSessionName
        {
            set => Request.SessionAsSessionName = value;
        }

        /// <summary>
        /// See <see cref="PartitionReadRequest.Transaction"/> and <see cref="PartitionQueryRequest.Transaction"/>
        /// </summary>
        public TransactionSelector Transaction
        {
            get => Request.Transaction;
            set => Request.Transaction = value;
        }

        /// <summary>
        /// See <see cref="PartitionReadRequest.PartitionOptions"/> and <see cref="PartitionQueryRequest.PartitionOptions"/>
        /// </summary>
        public PartitionOptions PartitionOptions
        {
            get => Request.PartitionOptions;
            set => Request.PartitionOptions = value;
        }

        /// <summary>
        /// Executes the partition request using the given client and call settings.
        /// </summary>
        /// <param name="client">The client to use to execute the request</param>
        /// <param name="callSettings">The call settings to use for the invocation</param>
        /// <returns>The partition response</returns>
        internal Task<PartitionResponse> PartitionAsync(SpannerClient client, CallSettings callSettings) => Request.PartitionAsync(client, callSettings);

        /// <summary>
        /// Executes a PartitionRead or PartitionQuery RPC asynchronously.
        /// </summary>
        /// <param name="session">The session to use for the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<PartitionResponse> PartitionReadOrQueryAsync(PooledSession session, CallSettings callSettings) =>
            session.PartitionReadOrQueryAsync(this, callSettings);

        /// <summary>
        /// Executes a PartitionRead or PartitionQuery RPC asynchronously.
        /// </summary>
        /// <param name="transaction">The managed transaction to use for the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<PartitionResponse> PartitionReadOrQueryAsync(ManagedTransaction transaction, CallSettings callSettings) =>
            transaction.PartitionReadOrQueryAsync(this, callSettings);

        /// <inheritdoc/>
        public override bool Equals(object o) =>
            o is PartitionReadOrQueryRequest request && request.Request.Equals(Request);

        /// <inheritdoc/>
        public override int GetHashCode() => Request.GetHashCode();
    }

    public sealed partial class ReadRequest : IReadOrQueryRequest
    {
        ByteString IReadOrQueryRequest.ToByteString() => this.ToByteString();

        IReadOrQueryRequest IReadOrQueryRequest.CloneRequest() => Clone();

        AsyncServerStreamingCall<PartialResultSet> IReadOrQueryRequest.ExecuteStreaming(
            SpannerClient client,
            CallSettings callSettings) => client.StreamingRead(this, callSettings).GrpcCall;
    }

    public sealed partial class ExecuteSqlRequest : IReadOrQueryRequest
    {
        ByteString IReadOrQueryRequest.ToByteString() => this.ToByteString();

        IReadOrQueryRequest IReadOrQueryRequest.CloneRequest() => Clone();

        AsyncServerStreamingCall<PartialResultSet> IReadOrQueryRequest.ExecuteStreaming(
            SpannerClient client,
            CallSettings callSettings) => client.ExecuteStreamingSql(this, callSettings).GrpcCall;
    }

    public sealed partial class PartitionReadRequest : IPartitionReadOrQueryRequest
    {
        Task<PartitionResponse> IPartitionReadOrQueryRequest.PartitionAsync(SpannerClient client, CallSettings callSettings) =>
            client.PartitionReadAsync(this, callSettings);
    }

    public sealed partial class PartitionQueryRequest : IPartitionReadOrQueryRequest
    {
        Task<PartitionResponse> IPartitionReadOrQueryRequest.PartitionAsync(SpannerClient client, CallSettings callSettings) =>
            client.PartitionQueryAsync(this, callSettings);
    }
}
