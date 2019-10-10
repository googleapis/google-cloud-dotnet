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
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Bigtable.Admin.V2
{
    // Partial class for BigtableInstanceAdminClient to add IAM v3-policy support
    public abstract partial class BigtableInstanceAdminClient
    {
        /// <summary>TODO - documentation.</summary>
        public virtual stt::Task<iam::Policy> GetIamPolicyV3Async(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Options = new iam.GetPolicyOptions { RequestedPolicyVersion = 3 }
                },
                callSettings);

        /// <summary>TODO - documentation.</summary>
        public virtual stt::Task<iam::Policy> GetIamPolicyV3Async(
            string resource,
            st::CancellationToken cancellationToken) => GetIamPolicyV3Async(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>TODO - documentation.</summary>
        public virtual iam::Policy GetIamPolicyV3(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Options = new iam.GetPolicyOptions { RequestedPolicyVersion = 3 }
                },
                callSettings);

        /// <summary>TODO - documentation.</summary>
        public virtual stt::Task<iam::Policy> GetIamPolicyV3Async(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(CloneRequestWithV3(request));

        /// <summary>TODO - documentation.</summary>
        public virtual stt::Task<iam::Policy> GetIamPolicyV3Async(
        iam::GetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => GetIamPolicyV3Async(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>TODO - documentation.</summary>
        public virtual iam::Policy GetIamPolicyV3(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(CloneRequestWithV3(request));

        private iam::GetIamPolicyRequest CloneRequestWithV3(iam::GetIamPolicyRequest request)
        {
            request = request.Clone();
            if (request.Options is null)
            {
                request.Options = new iam::GetPolicyOptions();
            }
            return request;
        }
    }
}
