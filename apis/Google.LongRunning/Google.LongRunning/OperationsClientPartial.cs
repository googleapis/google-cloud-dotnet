// Copyright 2016 Google Inc. All Rights Reserved.
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

using gaxgrpc = Google.Api.Gax.Grpc;
using mel = Microsoft.Extensions.Logging;
using wkt = Google.Protobuf.WellKnownTypes;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using System;
using System.Collections.Generic;
using Google.Protobuf;

namespace Google.LongRunning
{
    public partial class OperationsSettings
    {
        /// <summary>
        /// The poll settings used by default for repeated polling operations.
        /// </summary>
        public PollSettings DefaultPollSettings { get; set; }

        partial void OnCopy(OperationsSettings existing)
        {
            DefaultPollSettings = existing.DefaultPollSettings;
        }
    }

    public partial class OperationsClient
    {
        /// <summary>
        /// The clock used for timeouts, retries and polling.
        /// </summary>
        public virtual IClock Clock
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// The scheduler used for timeouts, retries and polling.
        /// </summary>
        public virtual IScheduler Scheduler
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// The poll settings used by default for repeated polling operations.
        /// May be null if no defaults have been set.
        /// </summary>
        public virtual PollSettings DefaultPollSettings
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Return the <see cref="CallSettings"/> that would be used by a call to
        /// <see cref="GetOperation(GetOperationRequest, CallSettings)"/>, using the base
        /// settings of this client and the specified per-call overrides.
        /// </summary>
        /// <remarks>
        /// This method is used when polling, to determine the appropriate timeout and cancellation
        /// token to use for each call.
        /// </remarks>
        /// <param name="callSettings">The per-call override, if any.</param>
        /// <returns>The effective call settings for a GetOperation RPC.</returns>
        protected internal virtual CallSettings GetEffectiveCallSettingsForGetOperation(CallSettings callSettings)
        {
            throw new NotImplementedException();
        }
    }

    public partial class OperationsClientImpl
    {
        private IClock _clock;
        private IScheduler _scheduler;
        private PollSettings _defaultPollSettings;

        /// <inheritdoc />
        public override IClock Clock => _clock;

        /// <inheritdoc />
        public override IScheduler Scheduler => _scheduler;

        /// <inheritdoc />
        public override PollSettings DefaultPollSettings => _defaultPollSettings;

        // Note: if we ever have a partial Modify_GetOperationRequest call body,
        // we'd want to call it here, but cope with not providing a request.

        /// <inheritdoc />
        protected internal override CallSettings GetEffectiveCallSettingsForGetOperation(CallSettings callSettings) =>
            _callGetOperation.BaseCallSettings.MergedWith(callSettings);

        partial void OnConstruction(Operations.OperationsClient grpcClient, OperationsSettings effectiveSettings, ClientHelper clientHelper)
        {
            _clock = clientHelper.Clock;
            _scheduler = clientHelper.Scheduler;
            _defaultPollSettings = effectiveSettings?.DefaultPollSettings;
        }

        /// <summary>
        /// Constructs a client wrapper for the Operations service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OperationsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        /// <param name="modifiers"></param>
        public OperationsClientImpl(OperationsClientCallModifierCollection modifiers, Operations.OperationsClient grpcClient, OperationsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OperationsSettings effectiveSettings = settings ?? OperationsSettings.GetDefault();
            GaxPreconditions.CheckNotNull(modifiers, nameof(modifiers));
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callListOperations = modifiers.ListOperationsModifier(clientHelper.BuildApiCall<ListOperationsRequest, ListOperationsResponse>("ListOperations", grpcClient.ListOperationsAsync, grpcClient.ListOperations, effectiveSettings.ListOperationsSettings));
            Modify_ApiCall(ref _callListOperations);
            Modify_ListOperationsApiCall(ref _callListOperations);
            _callGetOperation = modifiers.GetOperationModifier(clientHelper.BuildApiCall<GetOperationRequest, Operation>("GetOperation", grpcClient.GetOperationAsync, grpcClient.GetOperation, effectiveSettings.GetOperationSettings));
            Modify_ApiCall(ref _callGetOperation);
            Modify_GetOperationApiCall(ref _callGetOperation);
            _callDeleteOperation = modifiers.DeleteOperationModifier(clientHelper.BuildApiCall<DeleteOperationRequest, wkt::Empty>("DeleteOperation", grpcClient.DeleteOperationAsync, grpcClient.DeleteOperation, effectiveSettings.DeleteOperationSettings));
            Modify_ApiCall(ref _callDeleteOperation);
            Modify_DeleteOperationApiCall(ref _callDeleteOperation);
            _callCancelOperation = modifiers.CancelOperationModifier(clientHelper.BuildApiCall<CancelOperationRequest, wkt::Empty>("CancelOperation", grpcClient.CancelOperationAsync, grpcClient.CancelOperation, effectiveSettings.CancelOperationSettings));
            Modify_ApiCall(ref _callCancelOperation);
            Modify_CancelOperationApiCall(ref _callCancelOperation);
            _callWaitOperation = modifiers.WaitOperationModifier(clientHelper.BuildApiCall<WaitOperationRequest, Operation>("WaitOperation", grpcClient.WaitOperationAsync, grpcClient.WaitOperation, effectiveSettings.WaitOperationSettings));
            Modify_ApiCall(ref _callWaitOperation);
            Modify_WaitOperationApiCall(ref _callWaitOperation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        /// <summary>
        /// 
        /// </summary>
        public class OperationsClientCallModifierCollection
        {
            // Note: the delegate declared below could be put into GAX.

            /// <summary>
            /// 
            /// </summary>
            /// <typeparam name="TRequest"></typeparam>
            /// <typeparam name="TResponse"></typeparam>
            /// <param name="call"></param>
            /// <returns></returns>
            public delegate ApiCall<TRequest, TResponse> Modifier<TRequest, TResponse>(ApiCall<TRequest, TResponse> call)
                where TRequest : class, IMessage<TRequest>
                where TResponse : class, IMessage<TResponse>;

            /// <summary>
            /// 
            /// </summary>
            public static OperationsClientCallModifierCollection Default { get; } = new OperationsClientCallModifierCollection(
                call => call.WithGoogleRequestParam("name", request => request.Name),
                call => call.WithGoogleRequestParam("name", request => request.Name),
                call => call.WithGoogleRequestParam("name", request => request.Name),
                call => call.WithGoogleRequestParam("name", request => request.Name),
                call => call);

            private OperationsClientCallModifierCollection(
                Modifier<ListOperationsRequest, ListOperationsResponse> listOperationsModifier,
                Modifier<GetOperationRequest, Operation> getOperationModifier,
                Modifier<DeleteOperationRequest, wkt::Empty> deleteOperationModifier,
                Modifier<CancelOperationRequest, wkt::Empty> cancelOperationModifier,
                Modifier<WaitOperationRequest, Operation> waitOperationModifier)
            {
                ListOperationsModifier = listOperationsModifier;
                GetOperationModifier = getOperationModifier;
                DeleteOperationModifier = deleteOperationModifier;
                CancelOperationModifier = cancelOperationModifier;
                WaitOperationModifier = waitOperationModifier;
            }

            internal Modifier<ListOperationsRequest, ListOperationsResponse> ListOperationsModifier { get; }
            internal Modifier<GetOperationRequest, Operation> GetOperationModifier { get; }
            internal Modifier<DeleteOperationRequest, wkt::Empty> DeleteOperationModifier { get; }
            internal Modifier<CancelOperationRequest, wkt::Empty> CancelOperationModifier { get; }
            internal Modifier<WaitOperationRequest, Operation> WaitOperationModifier { get; }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="modifier"></param>
            /// <returns></returns>
            public OperationsClientCallModifierCollection WithListOperationsModifier(
                Modifier<ListOperationsRequest, ListOperationsResponse> modifier) =>
                new OperationsClientCallModifierCollection(GaxPreconditions.CheckNotNull(modifier, nameof(modifier)),
                    GetOperationModifier, DeleteOperationModifier, CancelOperationModifier, WaitOperationModifier);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="modifier"></param>
            /// <returns></returns>
            public OperationsClientCallModifierCollection WithGetOperationModifier(
                Modifier<GetOperationRequest, Operation> modifier) =>
                new OperationsClientCallModifierCollection(
                    ListOperationsModifier,
                    GaxPreconditions.CheckNotNull(modifier, nameof(modifier)),
                    DeleteOperationModifier, CancelOperationModifier, WaitOperationModifier);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="modifier"></param>
            /// <returns></returns>
            public OperationsClientCallModifierCollection WithDeleteOperationModifier(
                Modifier<DeleteOperationRequest, wkt::Empty> modifier) =>
                new OperationsClientCallModifierCollection(
                    ListOperationsModifier, GetOperationModifier,
                    GaxPreconditions.CheckNotNull(modifier, nameof(modifier)),
                    CancelOperationModifier, WaitOperationModifier);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="modifier"></param>
            /// <returns></returns>
            public OperationsClientCallModifierCollection WithCancelOperationModifier(
                Modifier<CancelOperationRequest, wkt::Empty> modifier) =>
                new OperationsClientCallModifierCollection(
                    ListOperationsModifier, GetOperationModifier, DeleteOperationModifier,
                    GaxPreconditions.CheckNotNull(modifier, nameof(modifier)),
                    WaitOperationModifier);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="modifier"></param>
            /// <returns></returns>
            public OperationsClientCallModifierCollection WithCancelOperationModifier(
                Modifier<WaitOperationRequest, Operation> modifier) =>
                new OperationsClientCallModifierCollection(
                    ListOperationsModifier, GetOperationModifier, DeleteOperationModifier, CancelOperationModifier,
                    GaxPreconditions.CheckNotNull(modifier, nameof(modifier)));
        }
    }
}
