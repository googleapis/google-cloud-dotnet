﻿// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Apis.Storage.v1.Data;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public abstract partial class StorageClient
    {
        /// <summary>
        /// Updates the IAM policy information about a bucket synchronously.
        /// </summary>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="policy">The new IAM policy for the bucket. Must not be null.</param>
        /// <param name="options">Additional options for the operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The <see cref="Policy"/> representation of the resulting storage bucket IAM policy.</returns>
        public virtual Policy SetBucketIamPolicy(string bucket, Policy policy, SetBucketIamPolicyOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the IAM policy information about a bucket asynchronously.
        /// </summary>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="policy">The new IAM policy for the bucket. Must not be null.</param>
        /// <param name="options">Additional options for the fetch operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Policy"/> representation of the resulting storage bucket IAM policy.</returns>
        public virtual Task<Policy> SetBucketIamPolicyAsync(string bucket, Policy policy, SetBucketIamPolicyOptions options = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
