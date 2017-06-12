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
    /// A detailed code supplied via <see cref="SpannerException.ErrorCode"/> when an error
    /// occurs.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// The operation was cancelled.
        /// </summary>
        Cancelled = StatusCode.Cancelled,

        /// <summary>
        /// Unknown error. This may happen if an internal error occured or
        /// not enough information was obtained to produce a useful message.
        /// </summary>
        Unknown = StatusCode.Unknown,

        /// <summary>
        /// A bad SQL statement or other invalid input was sent to Spanner.
        /// </summary>
        InvalidArgument = StatusCode.InvalidArgument,

        /// <summary>
        /// A timeout has occurred. A <see cref="SpannerTransaction"/> should be
        /// retried if this error is encountered.
        /// </summary>
        DeadlineExceeded = StatusCode.DeadlineExceeded,

        /// <summary>
        /// The given resource (Spanner Instance, Database, Table) was not
        /// found.
        /// </summary>
        NotFound = StatusCode.NotFound,

        /// <summary>
        /// The given resource could be not created because it already exists.
        /// </summary>
        AlreadyExists = StatusCode.AlreadyExists,

        /// <summary>
        /// The supplied credential from <see cref="SpannerConnectionStringBuilder.Credential"/>
        /// or from default application credentials does not have sufficient permission for the request.
        /// </summary>
        PermissionDenied = StatusCode.PermissionDenied,

        /// <summary>
        /// There is no supplied credential either through default application credentials or
        /// directly through <see cref="SpannerConnectionStringBuilder.Credential"/>
        /// </summary>
        Unauthenticated = StatusCode.Unauthenticated,

        /// <summary>
        /// <see cref="SpannerOptions.MaximumActiveSessions"/> has been reached.
        /// Therefore a new session with Spanner could not be created.
        /// </summary>
        ResourceExhausted = StatusCode.ResourceExhausted,

        /// <summary>
        /// Operation was rejected because the system is not in a state required for the
        /// operation's execution.
        /// </summary>
        FailedPrecondition = StatusCode.FailedPrecondition,

        /// <summary>
        /// The operation was aborted due to transient issue such as competing transaction
        /// resources. A <see cref="SpannerTransaction"/> should be retried if this error
        /// is encountered.
        /// </summary>
        Aborted = StatusCode.Aborted,

        /// <summary>
        /// The operation attempted to read past the valid range.
        /// </summary>
        OutOfRange = StatusCode.OutOfRange,

        /// <summary>
        /// Operation is not implemented or not supported/enabled in this service.
        /// </summary>
        Unimplemented = StatusCode.Unimplemented,

        /// <summary>
        /// Internal error.
        /// </summary>
        Internal = StatusCode.Internal,

        /// <summary>
        /// The service is currently unavailable. This is a most likely a transient condition
        /// and may be corrected by retrying. A <see cref="SpannerTransaction"/> should be
        /// retried if this error is encountered.
        /// </summary>
        Unavailable = StatusCode.Unavailable,

        /// <summary>
        /// Unrecoverable data loss or corruption.
        /// </summary>
        DataLoss = StatusCode.DataLoss
    }
}
