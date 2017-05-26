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

using Grpc.Core;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// </summary>
        Cancelled = StatusCode.Cancelled,

        /// <summary>
        /// </summary>
        Unknown = StatusCode.Unknown,

        /// <summary>
        /// </summary>
        InvalidArgument = StatusCode.InvalidArgument,

        /// <summary>
        /// </summary>
        DeadlineExceeded = StatusCode.DeadlineExceeded,

        /// <summary>
        /// </summary>
        NotFound = StatusCode.NotFound,

        /// <summary>
        /// </summary>
        AlreadyExists = StatusCode.AlreadyExists,

        /// <summary>
        /// </summary>
        PermissionDenied = StatusCode.PermissionDenied,

        /// <summary>
        /// </summary>
        Unauthenticated = StatusCode.Unauthenticated,

        /// <summary>
        /// </summary>
        ResourceExhausted = StatusCode.ResourceExhausted,

        /// <summary>
        /// </summary>
        FailedPrecondition = StatusCode.FailedPrecondition,

        /// <summary>
        /// </summary>
        Aborted = StatusCode.Aborted,

        /// <summary>
        /// </summary>
        OutOfRange = StatusCode.OutOfRange,

        /// <summary>
        /// </summary>
        Unimplemented = StatusCode.Unimplemented,

        /// <summary>
        /// </summary>
        Internal = StatusCode.Internal,

        /// <summary>
        /// </summary>
        Unavailable = StatusCode.Unavailable,

        /// <summary>
        /// </summary>
        DataLoss = StatusCode.DataLoss
    }
}