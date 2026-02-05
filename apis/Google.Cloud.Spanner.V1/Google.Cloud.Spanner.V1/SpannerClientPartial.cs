// Copyright 2020 Google LLC
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

using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.Common.V1;
using System.Threading;

namespace Google.Cloud.Spanner.V1
{
    public partial class SpannerClient
    {
        private const string LeaderRoutingHeader = "x-goog-spanner-route-to-leader";

        /// <summary>
        /// Returns the effective <see cref="SpannerSettings"/> used for each API call.
        /// This can be used to create a modified instance of <see cref="SpannerSettings"/> to pass
        /// for a single API request.
        /// </summary>
        public virtual SpannerSettings Settings { get; protected set; }

        internal void MaybeApplyRouteToLeaderHeader(ref CallSettings settings, TransactionOptions.ModeOneofCase transactionMode)
        {
            if (transactionMode == TransactionOptions.ModeOneofCase.ReadWrite ||
                transactionMode == TransactionOptions.ModeOneofCase.PartitionedDml)
            {
                MaybeApplyRouteToLeaderHeader(ref settings);
            }
        }

        internal void MaybeApplyRouteToLeaderHeader(ref CallSettings settings)
        {
            if (Settings.LeaderRoutingEnabled)
            {
                settings = settings.WithHeader(LeaderRoutingHeader, bool.TrueString);
            }
        }
    }

    public partial class SpannerClientImpl
    {
        /// <summary>
        /// Creates the request ID associated with each RPC.
        /// </summary>
        private RequestIdSource _requestIdSource;

        /// <summary>
        /// The name of the header used for efficiently routing requests.
        /// </summary>
        /// <remarks>
        /// This should be set to the database resource name ("projects/{projectId}/instances/{instanceId}/databases/{databaseId}") for any RPC.
        /// For non-streaming calls, <see cref="SpannerClientImpl"/> performs this automatically. This cannot be performed
        /// automatically for streaming calls due to the separation between initializing the stream and sending requests, so
        /// client code should set the value in a <see cref="CallSettings"/>. Typically this is performed with either the
        /// <see cref="CallSettings.FromHeader(string, string)"/> factory method or the
        /// <see cref="CallSettingsExtensions.WithHeader(CallSettings, string, string)"/> extension method.
        /// </remarks>
        public const string ResourcePrefixHeader = "google-cloud-resource-prefix";

        partial void OnConstruction(Spanner.SpannerClient grpcClient, SpannerSettings effectiveSettings, ClientHelper clientHelper)
        {
            Settings = effectiveSettings;
            _requestIdSource = new RequestIdSource();
        }

        partial void Modify_CreateSessionRequest(ref CreateSessionRequest request, ref CallSettings settings)
        {
            ApplyResourcePrefixHeaderFromDatabase(ref settings, request.Database);
            MaybeApplyRouteToLeaderHeader(ref settings);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_BatchCreateSessionsRequest(ref BatchCreateSessionsRequest request, ref CallSettings settings)
        {
            ApplyResourcePrefixHeaderFromDatabase(ref settings, request.Database);
            MaybeApplyRouteToLeaderHeader(ref settings);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_GetSessionRequest(ref GetSessionRequest request, ref CallSettings settings)
        {
            ApplyResourcePrefixHeaderFromSession(ref settings, request.Name);
            MaybeApplyRouteToLeaderHeader(ref settings);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_ListSessionsRequest(ref ListSessionsRequest request, ref CallSettings settings)
        {
            // This operation is never routed to leader so we don't call MaybeApplyRouteToLeaderHeader.
            ApplyResourcePrefixHeaderFromDatabase(ref settings, request.Database);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_DeleteSessionRequest(ref DeleteSessionRequest request, ref CallSettings settings)
        {
            // This operation is never routed to leader so we don't call MaybeApplyRouteToLeaderHeader.
            ApplyResourcePrefixHeaderFromSession(ref settings, request.Name);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_ExecuteSqlRequest(ref ExecuteSqlRequest request, ref CallSettings settings)
        {
            // This operations is routed to leader only if the transaction it uses is of a certain type.
            // We don't have that information here so the leader routing header needs to be applied elsewhere.
            ApplyResourcePrefixHeaderFromSession(ref settings, request.Session);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_ExecuteBatchDmlRequest(ref ExecuteBatchDmlRequest request, ref CallSettings settings)
        {
            ApplyResourcePrefixHeaderFromSession(ref settings, request.Session);
            MaybeApplyRouteToLeaderHeader(ref settings);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_ReadRequest(ref ReadRequest request, ref CallSettings settings)
        {
            // This operations is routed to leader only if the transaction it uses is of a certain type.
            // We don't have that information here so the leader routing header needs to be applied elsewhere.
            ApplyResourcePrefixHeaderFromSession(ref settings, request.Session);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_BeginTransactionRequest(ref BeginTransactionRequest request, ref CallSettings settings)
        {
            ApplyResourcePrefixHeaderFromSession(ref settings, request.Session);
            MaybeApplyRouteToLeaderHeader(ref settings, request.Options?.ModeCase ?? TransactionOptions.ModeOneofCase.None);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_CommitRequest(ref CommitRequest request, ref CallSettings settings)
        {
            ApplyResourcePrefixHeaderFromSession(ref settings, request.Session);
            MaybeApplyRouteToLeaderHeader(ref settings);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_RollbackRequest(ref RollbackRequest request, ref CallSettings settings)
        {
            ApplyResourcePrefixHeaderFromSession(ref settings, request.Session);
            MaybeApplyRouteToLeaderHeader(ref settings);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_PartitionQueryRequest(ref PartitionQueryRequest request, ref CallSettings settings)
        {
            ApplyResourcePrefixHeaderFromSession(ref settings, request.Session);
            MaybeApplyRouteToLeaderHeader(ref settings);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_PartitionReadRequest(ref PartitionReadRequest request, ref CallSettings settings)
        {
            ApplyResourcePrefixHeaderFromSession(ref settings, request.Session);
            MaybeApplyRouteToLeaderHeader(ref settings);
            ApplyRequestIdHeader(ref settings);
        }

        partial void Modify_BatchWriteRequest(ref BatchWriteRequest request, ref CallSettings settings)
        {
            ApplyResourcePrefixHeaderFromSession(ref settings, request.Session);
            MaybeApplyRouteToLeaderHeader(ref settings);
            ApplyRequestIdHeader(ref settings);
        }

        internal static void ApplyResourcePrefixHeaderFromDatabase(ref CallSettings settings, string resource)
        {
            // If we haven't been given a resource name, just leave the request as it is.
            if (string.IsNullOrEmpty(resource))
            {
                return;
            }

            if (DatabaseName.TryParse(resource, out DatabaseName database))
            {
                settings = settings.WithHeader(ResourcePrefixHeader, database.ToString());
            }
        }

        internal static void ApplyResourcePrefixHeaderFromSession(ref CallSettings settings, string resource)
        {
            // If we haven't been given a resource name, just leave the request as it is.
            if (string.IsNullOrEmpty(resource))
            {
                return;
            }

            if (SessionName.TryParse(resource, out SessionName session))
            {
                var database = DatabaseName.FromProjectInstanceDatabase(
                    session.ProjectId, session.InstanceId, session.DatabaseId);
                settings = settings.WithHeader(ResourcePrefixHeader, database.ToString());
            }
        }

        internal void ApplyRequestIdHeader(ref CallSettings settings)
        {
            var requestId = _requestIdSource.NewRequestId();
            var newSettings = CallSettings.FromHeaderMutation(requestId.AddHeader);
            settings = settings.MergedWith(newSettings);
        }
    }
}
