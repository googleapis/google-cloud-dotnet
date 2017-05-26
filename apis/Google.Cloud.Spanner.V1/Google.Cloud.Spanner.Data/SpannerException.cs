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

using System;
using System.Collections.Generic;
using System.Linq;
using Google.Cloud.Spanner.V1.Logging;
using Grpc.Core;
using Google.Cloud.Spanner.V1;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents an error communicating with the Spanner database.
    /// </summary>
    public sealed class SpannerException : Exception {

        private static readonly Dictionary<ErrorCode, string> s_errorMessageTable =
            new Dictionary<ErrorCode, string>() {
                {ErrorCode.Cancelled, "The operation was canceled."},
                {ErrorCode.InvalidArgument, "An invalid argument was sent to Spanner."},
                {ErrorCode.DeadlineExceeded, "The operation deadline was exceeded."},
                {ErrorCode.NotFound, "Object not found."},
                {ErrorCode.AlreadyExists, "Object already exists."}, {
                    ErrorCode.PermissionDenied,
                    "Insufficient permission to execute the specified operation."
                },
                {ErrorCode.Unauthenticated, "Invalid authentication credentials for the operation."},
                {ErrorCode.ResourceExhausted, "Resources have been exhausted."}, {
                    ErrorCode.FailedPrecondition,
                    "Operation was rejected because the system is not in a state required for the operation's execution."
                },
                {ErrorCode.Aborted, "The operation was aborted."},
                {ErrorCode.OutOfRange, "Operation was attempted past the valid range."}, {
                    ErrorCode.Unimplemented,
                    "Operation is not implemented or not supported/enabled in this service."
                },
                {ErrorCode.Internal, "Internal error."}, {
                    ErrorCode.Unavailable,
                    "The service is currently unavailable.  This is a most likely a transient condition."
                },
                {ErrorCode.DataLoss, "Unrecoverable data loss or corruption."},
                {ErrorCode.Unknown, "An unknown error occurred."}
            };

        /// <summary>
        /// This class is a thin conversion around a grpc exception, with the additional
        /// information of whether the operation is retryable based on the resulting error.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="innerException"></param>
        internal SpannerException(ErrorCode code, RpcException innerException)
            : base(GetMessageFromErrorCode(code), innerException) {
            Logger.LogPerformanceCounterFn("SpannerException.Count", x => x + 1);
            ErrorCode = innerException.IsSessionExpiredError() ? ErrorCode.Aborted : code;
        }

        internal SpannerException(ErrorCode code, string message) : base(message) {
            Logger.LogPerformanceCounterFn("SpannerException.Count", x => x + 1);
            ErrorCode = code;
        }

        internal SpannerException(RpcException innerException)
            : this(ConvertFromStatusCode(innerException.Status.StatusCode), innerException) {
        }

        /// <summary>
        /// </summary>
        public ErrorCode ErrorCode { get; }

        /// <summary>
        /// </summary>
        public bool IsRetryable {
            get {
                switch (ErrorCode) {
                    case ErrorCode.DeadlineExceeded:
                    case ErrorCode.Aborted:
                    case ErrorCode.Unavailable:
                        return true;
                    default:
                        return false;
                }
            }
        }

        internal static SpannerException TryTranslateRpcException(Exception possibleRpcException) {
            SpannerException spannerException = null;
            var aggregateException = possibleRpcException as AggregateException;
            var rpcException = possibleRpcException as RpcException;

            if (aggregateException?.InnerExceptions != null)
            { 
                spannerException = (SpannerException) aggregateException.InnerExceptions
                    .FirstOrDefault(x => x is SpannerException);
                rpcException = (RpcException) aggregateException.InnerExceptions
                    .FirstOrDefault(x => x is RpcException);
            }


            if (rpcException != null)
            {
                spannerException = new SpannerException(rpcException);
            }
            return spannerException;
        }

        private static ErrorCode ConvertFromStatusCode(StatusCode statusCode) {
            switch (statusCode) {
                case StatusCode.OK:
                    return ErrorCode.Unknown;
                default:
                    return (ErrorCode) (int) statusCode;
            }
        }

        private static string GetMessageFromErrorCode(ErrorCode errorCode) {
            string message;
            if (!s_errorMessageTable.TryGetValue(errorCode, out message)) {
                throw new ArgumentOutOfRangeException(nameof(errorCode), errorCode, null);
            }
            return message;
        }
    }
}