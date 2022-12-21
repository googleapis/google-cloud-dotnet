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
using Xunit;

namespace Google.Cloud.Storage.V1.Tests;

/// <summary>
/// Test the various custom timing variants and delays.
/// </summary>
public class RetryTimingTest
{
    [Fact]
    public void InvalidInitialBackOff() => Assert.Throws<ArgumentOutOfRangeException>(() =>
        RetryTiming.Default.WithInitialBackoff(initialBackoff: TimeSpan.FromSeconds(-1)));

    [Fact]
    public void InvalidBackOffMultiplier() => Assert.Throws<ArgumentOutOfRangeException>(() =>
        RetryTiming.Default.WithBackoffMultiplier(backoffMultiplier: 0));

    [Fact]
    public void InvalidMaxBackOff() => Assert.Throws<ArgumentOutOfRangeException>(() =>
        RetryTiming.Default.WithMaxBackoff(maxBackoff: TimeSpan.FromSeconds(0)));

    [Fact]
    public void MaxBackOff_LessThanInitialBackoff() => Assert.Throws<ArgumentOutOfRangeException>(() =>
        RetryTiming.Default.WithInitialBackoff(initialBackoff: TimeSpan.FromSeconds(4)).WithMaxBackoff(maxBackoff: TimeSpan.FromSeconds(2)));

    [Theory]
    [InlineData(1, 5, 2, 1, 2, 4, 5)]
    [InlineData(2, 20, 3, 2, 6, 18, 20)]
    [InlineData(0, 1, 2, 0)]
    [InlineData(1, 2, 2, 1, 2)]
    [InlineData(1, 4, 1, 1, 1, 1)]
    [InlineData(8, 40, 1.5, 8, 12, 18, 27, 40, 40)]
    public void GetDelayVariation(int initialBackoff, int maxBackoff, double backoffMultiplier, params int[] backOffs)
    {
        RetryTiming retryTiming = new RetryTiming(initialBackoff: TimeSpan.FromSeconds(initialBackoff), maxBackoff: TimeSpan.FromSeconds(maxBackoff), backoffMultiplier: backoffMultiplier);

        for (int i = 0; i < backOffs.Length; i++)
        {
            Assert.Equal(TimeSpan.FromSeconds(backOffs[i]), retryTiming.GetDelay(failureCount: i + 1));
        }
    }

    [Fact]
    public void NullTiming_EquivalentToDefault()
    {
        RetryTiming retryTiming = null;
        RetryPredicate retryPredicate = RetryPredicate.RetriableIdempotentErrors;
        RetryOptions retryOptions = new RetryOptions(retryTiming, retryPredicate);

        Assert.Equal(RetryTiming.Default, retryOptions.Timing);
    }
}
