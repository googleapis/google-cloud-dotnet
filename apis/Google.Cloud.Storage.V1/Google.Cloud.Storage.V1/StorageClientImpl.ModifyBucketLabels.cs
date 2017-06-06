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

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class StorageClientImpl
    {
        /// <inheritdoc />
        public override IDictionary<string, string> ModifyBucketLabels(string bucket, IDictionary<string, string> labels, ModifyBucketLabelsOptions options = null)
        {
            // TODO: Implement:
            // - Fetch bucket with GetBucket
            // - Modify the in-memory dictionary (and remember old values)
            // - Call PatchBucket pass in the metageneration
            // - Repeat from scratch up to 3 times if we get conflicts.

            // In theory, many label modifications could be performed with just a single call rather than
            // read-modify-write, but:
            // - Always doing a read-modify-write simplifies the code
            // - This way we get to return the previous values as well
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override IDictionary<string, string> ClearBucketLabels(string bucket, ModifyBucketLabelsOptions options = null)
        {
            // TODO: Implement
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override Task<IDictionary<string, string>> ModifyBucketLabelsAsync(string bucket, IDictionary<string, string> labels, ModifyBucketLabelsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // TODO: Implement
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override IDictionary<string, string> ClearBucketLabelsAsync(string bucket, ModifyBucketLabelsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            // TODO: Implement
            throw new NotImplementedException();
        }
    }
}
