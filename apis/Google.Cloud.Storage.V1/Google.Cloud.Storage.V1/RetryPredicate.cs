// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using System;
using System.Linq;

namespace Google.Cloud.Storage.V1;

/// <summary>
/// Specifies the conditions under which a failed operation is retried. This class is immutable.
/// </summary>
public sealed class RetryPredicate
{
    private readonly Func<int, bool> _predicate;

    /// <summary>
    /// Default retriable error codes for which the operation would retry unless otherwise specified by the user. 
    /// </summary>
    public static RetryPredicate RetriableIdempotentErrors { get; } = RetryPredicate.FromErrorCodes(
        408, // Request timeout
        429, // Too many requests
        500, // Internal server error
        502, // Bad gateway
        503, // Service unavailable
        504 // Gateway timeout
    );

    /// <summary>
    /// Returns a Retry Predicate which will ensure that the operation will never retry in case of failure.
    /// </summary>
    public static RetryPredicate Never { get; } = RetryPredicate.FromErrorCodes();

    /// <summary>
    /// Returns a predicate which will retry on the specified HTTP error codes.
    /// Note that only these error codes will be retried; the default error codes are not used by the returned predicate.
    /// </summary>
    /// <param name="errorCodes">Error codes on which to retry.</param>
    /// <returns>Returns a predicate which retries on the specified error codes.</returns>
    public static RetryPredicate FromErrorCodes(params int[] errorCodes) => errorCodes is null ? RetryPredicate.Never : new(x => errorCodes.Contains(x));

    /// <summary>
    /// Returns a predicate which will retry based on the result of the specified delegate, which is provided with
    /// the HTTP error code for the response.
    /// </summary>
    /// <param name="predicate">Predicate used to determine whether or not to retry. May be null, in which case <see cref="Never" /> will be returned.</param>
    /// <returns>Returns the retry predicate with the conditions specified for retrying.</returns>
    public static RetryPredicate FromErrorCodePredicate(Func<int, bool> predicate) => predicate is null ? RetryPredicate.Never : new(predicate);

    private RetryPredicate(Func<int, bool> predicate) => _predicate = predicate;

    internal bool ShouldRetry(int statusCode) => _predicate.Invoke(statusCode);
}
