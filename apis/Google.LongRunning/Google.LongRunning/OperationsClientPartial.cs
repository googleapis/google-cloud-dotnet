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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using System;

namespace Google.LongRunning
{
    public partial class OperationsSettings
    {
        /// <summary>
        /// The poll settings used by default for repeated polling operations.
        /// </summary>
        public PollSettings DefaultPollSettings { get; private set; }

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
    }
}
