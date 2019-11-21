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
using iam = Google.Cloud.Iam.V1;
using scg = System.Collections.Generic;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Tasks.V2
{
    // We used to generate Get/Set/Test calls specific to QueueName rather than "any IResourceName".
    // We no longer do, so these methods are now manually-written.
    // They're not marked as obsolete, as when they're removed after the major version bump, callers
    // will just end up using the more general overload.
    public partial class CloudTasksClient
    {
        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        ///
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        ///
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            QueueName resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                },
                callSettings);


        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        ///
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        ///
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            QueueName resource,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));


        /// <summary>
        /// Gets the access control policy for a [Queue][google.cloud.tasks.v2.Queue].
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        ///
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        ///
        /// * `cloudtasks.queues.getIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy GetIamPolicy(
            QueueName resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Returns permissions that a caller has on a [Queue][google.cloud.tasks.v2.Queue].
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        ///
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            QueueName resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissionsAsync(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that a caller has on a [Queue][google.cloud.tasks.v2.Queue].
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        ///
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            QueueName resource,
            scg::IEnumerable<string> permissions,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on a [Queue][google.cloud.tasks.v2.Queue].
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a [NOT_FOUND][google.rpc.Code.NOT_FOUND] error.
        ///
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            QueueName resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissions(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue]. Replaces any existing
        /// policy.
        ///
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        ///
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        ///
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            QueueName resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicyAsync(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue]. Replaces any existing
        /// policy.
        ///
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        ///
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        ///
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            QueueName resource,
            iam::Policy policy,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy for a [Queue][google.cloud.tasks.v2.Queue]. Replaces any existing
        /// policy.
        ///
        /// Note: The Cloud Console does not check queue-level IAM permissions yet.
        /// Project-level permissions are required to use the Cloud Console.
        ///
        /// Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission on the specified
        /// resource parent:
        ///
        /// * `cloudtasks.queues.setIamPolicy`
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy SetIamPolicy(
            QueueName resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicy(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);
    }
}
