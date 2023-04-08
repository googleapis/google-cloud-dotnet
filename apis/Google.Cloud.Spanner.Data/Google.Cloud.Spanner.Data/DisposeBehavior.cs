// Copyright 2018 Google Inc. All Rights Reserved.
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

using System.Threading;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Defines the behavior of <see cref="SpannerTransaction"/> when Dispose is called.
    /// </summary>
    public enum DisposeBehavior
    {
        /// <summary>
        /// Releases transactional resources back to the global pool when <see cref="SpannerTransaction.Dispose"/> is called.
        /// This option is not valid for shared transactions (see <see cref="SpannerCommand.GetReaderPartitionsAsync(PartitionOptions, CancellationToken)"/>).
        /// </summary>
        ReleaseToPool = 0,
        /// <summary>
        /// Automatically closes resources when <see cref="SpannerTransaction.Dispose"/> is called.
        /// </summary>
        CloseResources = 1,
        /// <summary>
        /// Detaches from the transaction and leaves resources still allocated.  You must set
        /// <see cref="SpannerTransaction.DisposeBehavior"/> to <see cref="CloseResources"/> on at least one
        /// instance to ensure there are no resource leaks when doing parallel reads.
        /// </summary>
        Detach = 2
    }
}
