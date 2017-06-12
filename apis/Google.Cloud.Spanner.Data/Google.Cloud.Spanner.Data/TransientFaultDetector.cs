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

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Transactions can be retried using the Transient Fault Handling Application Block.
    /// This extension helps you create a strategy that will detect transient faults when performing
    /// transactions with Spanner.
    /// To create an execution strategy, create a class
    /// <code>
    /// class SpannerTransientErrorDetectionStrategy : ITransientErrorDetectionStrategy
    /// {
    ///   public bool IsTransient(Exception ex) => ex.IsTransientSpannerFault();
    /// }
    /// </code>
    /// </summary>
    public static class TransientFaultDetector
    {
        /// <summary>
        /// Returns true if the exception represents a transient error in Spanner.
        /// This indicates that the operation may succeed if it is attempted again.
        /// Common errors that can cause this include temporary network interruption
        /// or the service being temporarily unavailable.
        /// </summary>
        /// <returns></returns>
        public static bool IsTransientSpannerFault(this Exception exception)
        {
            var spannerException = exception as SpannerException
                ?? SpannerException.TryTranslateRpcException(exception);

            return spannerException != null && spannerException.IsRetryable;
        }
    }
}
