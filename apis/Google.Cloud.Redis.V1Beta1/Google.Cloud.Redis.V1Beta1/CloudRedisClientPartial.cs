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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pbwkt = Google.Protobuf.WellKnownTypes;
using lro = Google.LongRunning;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Redis.V1Beta1
{
    public partial class CloudRedisClient
    {
        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        ///     `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, pbwkt::Any>> FailoverInstanceAsync(
            string name,
            FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode,
            gaxgrpc::CallSettings callSettings = null) => FailoverInstanceAsync(
                new FailoverInstanceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    DataProtectionMode = dataProtectionMode,
                },
                callSettings);

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        ///     `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, pbwkt::Any>> FailoverInstanceAsync(
            string name,
            FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode,
            st::CancellationToken cancellationToken) => FailoverInstanceAsync(
                name,
                dataProtectionMode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        ///     `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Instance, pbwkt::Any> FailoverInstance(
            string name,
            FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode,
            gaxgrpc::CallSettings callSettings = null) => FailoverInstance(
                new FailoverInstanceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    DataProtectionMode = dataProtectionMode,
                },
                callSettings);
    }
}
