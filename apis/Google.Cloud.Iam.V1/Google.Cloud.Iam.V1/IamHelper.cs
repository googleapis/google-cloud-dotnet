// Copyright 2017 Google Inc. All Rights Reserved.
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
using Google.Api.Gax.Grpc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Iam.V1
{
    /// <summary>
    /// Provides higher-level IAM manipulation operations than the raw gRPC clients.
    /// This class is abstract for testability; it is expected that most users will retrieve
    /// an instance of this class via client libraries that implement IAM within a larger API.
    /// </summary>
    public abstract class IamHelper
    {
        // TODO: Overloads accepting IResourceName?

        /// <summary>
        /// Modifies the policy associated with a resource.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method performs a read/modify/write operation, retrying if the modification conflicts with
        /// concurrent changes. The IAM policy associated with the resource is fetched, and <paramref name="modification"/> delegate
        /// called on it. If the result is a change in policy, the policy is set in a separate RPC. If that set fails due
        /// to a conflict, the whole process is retried, based on <paramref name="retrySettings"/> or defaults if no
        /// retry settings are provided. These retry settings only govern how the overall operation is retried; each RPC
        /// is retried (or not) based on <paramref name="callSettings"/> and the default call settings for the RPCs in question.
        /// </para>
        /// </remarks>
        /// <param name="resource">The name of the resource to modify. Must not be null or empty.</param>
        /// <param name="modification">The modification to perform. Must not be null; the input will never be null.</param>
        /// <param name="callSettings">If not null, applies overrides to all RPC calls.</param>
        /// <param name="retrySettings">If not null, determines the retry policy when a conflict is detected.</param>
        /// <returns><c>true</c> if the policy was successfully modified; <c>false</c> if no modification was required.</returns>
        public virtual bool ModifyPolicy(string resource, Action<Policy> modification,
            CallSettings callSettings = null, RetrySettings retrySettings = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// TODO
        /// </summary>
        public virtual Task<bool> ModifyPolicyAsync(string resource, Action<Policy> modification,
            CallSettings callSettings = null, RetrySettings retrySettings = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// TODO
        /// </summary>
        public virtual Task<bool> ModifyPolicyAsync(string resource, Action<Policy> modification,
            CancellationToken cancellationToken, RetrySettings retrySettings = null) =>
            ModifyPolicyAsync(resource, modification, CallSettings.FromCancellationToken(cancellationToken), retrySettings);
    }
}
