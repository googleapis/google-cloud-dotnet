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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.LongRunning;
using System.Threading.Tasks;
using lro = Google.LongRunning;

namespace Google.Cloud.Compute.V1
{
    // We'd want one of these for regional and global as well. We may well be able to use a base class to get rid of some duplication.
    // An alternative would be to write a lower-level adapter to create the gRPC Operations.OperationsClient, basically using
    // marshallers to adapt the calls.

    internal class RegionalLroClient : lro::OperationsClient
    {
        internal static PathTemplate NameTemplate { get; } = new PathTemplate("projects/{project}/regions/{region}/operations/{operation}");
        private readonly RegionOperationsClient _client;
        private readonly CallSettings _getSettings;

        public override PollSettings DefaultPollSettings { get; }
        public override IClock Clock { get; }
        public override IScheduler Scheduler { get; }

        internal RegionalLroClient(RegionOperations.RegionOperationsClient grpcClient, OperationsSettings settings)
        {
            settings = settings ?? OperationsSettings.GetDefault();
            _getSettings = settings.GetOperationSettings;
            _client = new RegionOperationsClientImpl(grpcClient, new RegionOperationsSettings
            {
                // General settings
                Clock = settings.Clock,
                Scheduler = settings.Scheduler,
                Interceptor = settings.Interceptor,
                CallSettings = settings.CallSettings,
                // Method-specific settings
                GetSettings = settings.GetOperationSettings,
                ListSettings = settings.ListOperationsSettings,
                DeleteSettings = settings.DeleteOperationSettings,
                WaitSettings = settings.WaitOperationSettings
            });
            DefaultPollSettings = settings.DefaultPollSettings;
            Clock = settings.Clock ?? SystemClock.Instance;
            Scheduler = settings.Scheduler ?? SystemScheduler.Instance;
        }

        public override lro.Operation GetOperation(GetOperationRequest request, CallSettings callSettings = null)
        {
            // TODO: Better error handling
            var parsedName = NameTemplate.ParseName(request.Name);
            var computeRequest = new GetRegionOperationRequest
            {
                Project = parsedName[0],
                Region = parsedName[1],
                Operation = parsedName[2]
            };
            var computeOperation = _client.Get(computeRequest, callSettings);
            return OperationAdapter.CreateRawOperation(computeOperation, request.Name);
        }

        public override async Task<lro.Operation> GetOperationAsync(GetOperationRequest request, CallSettings callSettings = null)
        {
            // TODO: Better error handling
            var parsedName = NameTemplate.ParseName(request.Name);
            var computeRequest = new GetRegionOperationRequest
            {
                Project = parsedName[0],
                Region = parsedName[1],
                Operation = parsedName[2]
            };
            var computeOperation = await _client.GetAsync(computeRequest, callSettings).ConfigureAwait(false);
            return OperationAdapter.CreateRawOperation(computeOperation, request.Name);
        }

        protected override CallSettings GetEffectiveCallSettingsForGetOperation(CallSettings callSettings) =>
            _getSettings.MergedWith(callSettings);

        // TODO: Cancel, delete, list, wait
    }
}
