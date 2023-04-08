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

namespace Google.Cloud.Storage.V1;

/// <summary>
/// Options to control the delays between attempts when retrying failed API requests. This class is immutable.
/// </summary>
public sealed class RetryTiming
{
    /// <summary>
    /// The default initial backoff time between the first attempt and the first retry. The default is 1 second.
    /// </summary>
    public static TimeSpan DefaultInitialBackoff { get; } = TimeSpan.FromSeconds(1);

    /// <summary>
    /// The default maximum backoff time between retries. The default is 32 seconds.
    /// </summary>
    public static TimeSpan DefaultMaxBackoff { get; } = TimeSpan.FromSeconds(32);

    /// <summary>
    /// The default maximum backoff multiplier to be applied on each iteration. The default is 2.
    /// </summary>
    public static double DefaultBackoffMultiplier { get; } = 2;

    /// <summary>
    /// Returns the retry timing configurations all set to default.
    /// </summary>
    public static RetryTiming Default { get; } = new(RetryTiming.DefaultInitialBackoff, RetryTiming.DefaultMaxBackoff, RetryTiming.DefaultBackoffMultiplier);

    /// <summary>
    /// The backoff time between the first attempt and the first retry.
    /// </summary>
    public TimeSpan InitialBackoff { get; }

    /// <summary>
    /// Maximum backoff time between retries.
    /// </summary>
    public TimeSpan MaxBackoff { get; }

    /// <summary>
    /// The multiplier to apply to the previous backoff on each iteration, leading to exponential backoff.
    /// </summary>
    public double BackoffMultiplier { get; }

    /// <summary>
    /// Creates an instance with the specified values.
    /// </summary>
    /// <param name="initialBackoff">Initial backoff for retry. Must be non-negative.</param>
    /// <param name="maxBackoff">Maximum backoff for retry. Must be greater than or equal to <paramref name="initialBackoff" />.</param>
    /// <param name="backoffMultiplier">Backoff multiplier for retry. Must be greater than or equal to 1.0.</param>
    public RetryTiming(TimeSpan initialBackoff, TimeSpan maxBackoff, double backoffMultiplier)
    {
        InitialBackoff = initialBackoff >= TimeSpan.Zero ? initialBackoff : throw new ArgumentOutOfRangeException(nameof(initialBackoff), $"Parameter value '{InitialBackoff}' must at least be 1.");
        MaxBackoff = maxBackoff >= initialBackoff ? maxBackoff : throw new ArgumentOutOfRangeException(nameof(maxBackoff), $"Parameter value '{MaxBackoff}' must be at least as long as initialBackoff.");
        BackoffMultiplier = backoffMultiplier >= 1 ? backoffMultiplier : throw new ArgumentOutOfRangeException(nameof(backoffMultiplier), $"Parameter value '{BackoffMultiplier}' must at least be 1.");
    }

    /// <summary>
    /// Returns a new instance with the same values as the current instance, but with the specified initial backoff.
    /// </summary>
    /// <param name="initialBackoff">The new value for <see cref="InitialBackoff"/>.</param>
    /// <returns>A new instance based on the existing values, but with the specified initial backoff.</returns>
    public RetryTiming WithInitialBackoff(TimeSpan initialBackoff) =>
        new(initialBackoff: initialBackoff, maxBackoff: MaxBackoff, backoffMultiplier: BackoffMultiplier);

    /// <summary>
    /// Returns the existing retry timings configurations using the specified maximum backoff.
    /// </summary>
    /// <param name="maxBackoff">The new value for <see cref="MaxBackoff"/>.</param>
    /// <returns>A new instance based on the existing values, but with the specified max backoff.</returns>
    public RetryTiming WithMaxBackoff(TimeSpan maxBackoff) =>
         new(initialBackoff: InitialBackoff, maxBackoff: maxBackoff, backoffMultiplier: BackoffMultiplier);

    /// <summary>
    /// Returns the existing retry timings configurations using the specified backoff multiplier.
    /// </summary>
    /// <param name="backoffMultiplier">The new value for <see cref="BackoffMultiplier"/>.</param>
    /// <returns>A new instance based on the existing values, but with the specified backoff multiplier.</returns>
    public RetryTiming WithBackoffMultiplier(double backoffMultiplier) =>
        new(initialBackoff: InitialBackoff, maxBackoff: MaxBackoff, backoffMultiplier: backoffMultiplier);

    internal TimeSpan GetDelay(int failureCount)
    {
        if (failureCount < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(failureCount), "Value should be greater than 0.");
        }

        TimeSpan delay = TimeSpan.FromSeconds(InitialBackoff.TotalSeconds * Math.Pow(BackoffMultiplier, failureCount - 1));
        return delay > MaxBackoff ? MaxBackoff : delay;
    }
}
