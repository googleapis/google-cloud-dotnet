// Copyright 2019 Google LLC
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
using Grafeas.V1;
using System;

namespace Google.Cloud.DevTools.ContainerAnalysis.V1
{
    // Partial classes to provide easy access to the Grafeas API.

    public partial class ContainerAnalysisSettings
    {
        /// <summary>
        /// Settings for the Grafeas client returned by <see cref="ContainerAnalysisClient.GrafeasClient"/>.
        /// </summary>
        public GrafeasSettings GrafeasSettings { get; set; } = new GrafeasSettings();

        partial void OnCopy(ContainerAnalysisSettings existing)
        {
            GrafeasSettings = existing.GrafeasSettings?.Clone();
        }
    }

    public partial class ContainerAnalysisClient
    {
        /// <summary>
        /// Returns a <see cref="GrafeasClient"/> using the same endpoint and credentials
        /// as this client.
        /// </summary>
        public virtual GrafeasClient GrafeasClient => throw new NotImplementedException();
    }

    public partial class ContainerAnalysisClientImpl
    {
        private GrafeasClient _grafeasClient;
        
        /// <inheritdoc />
        public override GrafeasClient GrafeasClient => _grafeasClient;

        partial void OnConstruction(ContainerAnalysis.ContainerAnalysisClient grpcClient, ContainerAnalysisSettings effectiveSettings, ClientHelper clientHelper) =>
            _grafeasClient = new GrafeasClientImpl(grpcClient.CreateGrafeasClient(), effectiveSettings.GrafeasSettings, clientHelper.Logger);
    }

    public static partial class ContainerAnalysis
    {
        public partial class ContainerAnalysisClient
        {
            internal global::Grafeas.V1.Grafeas.GrafeasClient CreateGrafeasClient() => new global::Grafeas.V1.Grafeas.GrafeasClient(CallInvoker);
        }
    }
}
