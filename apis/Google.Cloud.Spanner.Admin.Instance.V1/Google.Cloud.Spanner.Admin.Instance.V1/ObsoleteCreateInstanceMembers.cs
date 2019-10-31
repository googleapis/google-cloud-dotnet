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

using System;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxres = Google.Api.Gax.ResourceNames;
using gcscv = Google.Cloud.Spanner.Common.V1;
using lro = Google.LongRunning;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    // CreateInstanceRequest was misconfigured for instance_id to be an InstanceName instead of just a string.

    partial class CreateInstanceRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="InstanceId"/> resource name property.
        /// </summary>
        [Obsolete("This property should not exist; InstanceId is just a string, not a full resource name")]
        public gcscv::InstanceName InstanceIdAsInstanceName
        {
            get { return string.IsNullOrEmpty(InstanceId) ? null : gcscv::InstanceName.Parse(InstanceId); }
            set { InstanceId = value != null ? value.ToString() : ""; }
        }
    }

    partial class InstanceAdminClient
    {
        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * The instance is readable via the API, with all requested attributes
        ///     but no allocated resources. Its state is `CREATING`.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation renders the instance immediately unreadable
        ///     via the API.
        ///   * The instance can be deleted.
        ///   * All other attempts to modify the instance are rejected.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing for all successfully-allocated resources begins (some types
        ///     may have lower than the requested levels).
        ///   * Databases can be created in the instance.
        ///   * The instance's allocated resource levels are readable via the API.
        ///   * The instance's state becomes `READY`.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 6 and 30 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        [Obsolete("The instance ID parameter should be a single ID, not a full resource name. Please use the overload accepting a string.")]
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(
            gaxres::ProjectName parent,
            gcscv::InstanceName instanceId,
            Instance instance,
            gaxgrpc::CallSettings callSettings = null) => CreateInstance(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceIdAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId)),
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                },
                callSettings);

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * The instance is readable via the API, with all requested attributes
        ///     but no allocated resources. Its state is `CREATING`.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation renders the instance immediately unreadable
        ///     via the API.
        ///   * The instance can be deleted.
        ///   * All other attempts to modify the instance are rejected.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing for all successfully-allocated resources begins (some types
        ///     may have lower than the requested levels).
        ///   * Databases can be created in the instance.
        ///   * The instance's allocated resource levels are readable via the API.
        ///   * The instance's state becomes `READY`.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 6 and 30 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        [Obsolete("The instance ID parameter should be a single ID, not a full resource name. Please use the overload accepting a string.")]
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            gaxres::ProjectName parent,
            gcscv::InstanceName instanceId,
            Instance instance,
            gaxgrpc::CallSettings callSettings = null) => CreateInstanceAsync(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceIdAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId)),
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                },
                callSettings);

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * The instance is readable via the API, with all requested attributes
        ///     but no allocated resources. Its state is `CREATING`.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation renders the instance immediately unreadable
        ///     via the API.
        ///   * The instance can be deleted.
        ///   * All other attempts to modify the instance are rejected.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing for all successfully-allocated resources begins (some types
        ///     may have lower than the requested levels).
        ///   * Databases can be created in the instance.
        ///   * The instance's allocated resource levels are readable via the API.
        ///   * The instance's state becomes `READY`.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 6 and 30 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        [Obsolete("The instance ID parameter should be a single ID, not a full resource name. Please use the overload accepting a string.")]
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            gaxres::ProjectName parent,
            gcscv::InstanceName instanceId,
            Instance instance,
            st::CancellationToken cancellationToken) => CreateInstanceAsync(
                parent,
                instanceId,
                instance,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }
}
