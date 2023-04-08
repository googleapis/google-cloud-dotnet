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

namespace Google.Cloud.Storage.V1;

/// <summary>
/// Options used to indicate the retry configuration for an API request in case of failure. This class is immutable.
/// These determine whether and how the request should be retried.
/// </summary>
public sealed class RetryOptions
{
    /// <summary>
    /// Options used by default for idempotent operations upon failure.
    /// It has all retry timings reset to defaults and retry predicate based on default error codes.
    /// </summary>
    public static RetryOptions IdempotentRetryOptions { get; } = new RetryOptions(RetryTiming.Default, RetryPredicate.RetriableIdempotentErrors);

    /// <summary>
    /// This configuration ensures that the API request is never retried on failure.
    /// </summary>
    public static RetryOptions Never { get; } = new RetryOptions(RetryTiming.Default, RetryPredicate.Never);

    internal RetryPredicate Predicate { get; }
    internal RetryTiming Timing { get; }

    /// <summary>
    /// In case of partially idempotent operations, this method checks the conditions required to mark it as retriable.
    /// If the condition is available then the operation is retried.
    /// </summary>
    /// <param name="condition">
    /// An indicator of whether the operation should be retried or not.
    /// This method returns <see cref="IdempotentRetryOptions" /> if the value is not null, or
    /// <see cref="Never" /> if the value is null.
    /// </param>
    internal static RetryOptions MaybeIdempotent(object condition) =>
        condition is null ? Never : IdempotentRetryOptions;

    /// <summary>
    /// Creates an instance based on the given timing and predicate.
    /// </summary>
    /// <param name="retryTiming">Timing configuration to apply when retrying. May be null, in which case <see cref="RetryTiming.Default">the default timing</see> will be used.</param>
    /// <param name="retryPredicate">Predicate to apply to determine whether an error response can be retried. May be null, in which case <see cref="RetryPredicate.RetriableIdempotentErrors">default error codes</see> will be used.</param>
    public RetryOptions(RetryTiming retryTiming, RetryPredicate retryPredicate)
    {
        Timing = retryTiming ?? RetryTiming.Default;
        Predicate = retryPredicate ?? RetryPredicate.Never;
    }
}
