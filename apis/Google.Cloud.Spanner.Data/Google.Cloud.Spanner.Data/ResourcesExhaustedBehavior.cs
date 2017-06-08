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

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Specifies the behavior when <see cref="SpannerOptions.MaximumActiveSessions"/>
    /// is reached.
    /// </summary>
    public enum ResourcesExhaustedBehavior
    {
        /// <summary>
        /// The operation is blocked until a currently running operation
        /// completes and releases its Spanner session.  If the operation is
        /// synchronous, the thread will be blocked until it can complete.
        /// If the operation is asynchronous, it will be completed on the
        /// threadpool when resources become available.
        /// </summary>
        Block = 0,

        /// <summary>
        /// The operation will fail with a <see cref="SpannerException"/>
        /// with <see cref="SpannerException.ErrorCode"/> equal to
        /// <see cref="ErrorCode.ResourceExhausted"/>.
        /// </summary>
        Fail = 1
    }
}
