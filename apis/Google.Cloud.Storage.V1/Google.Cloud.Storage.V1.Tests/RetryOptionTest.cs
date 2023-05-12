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
public class RetryOptionTest
{
    [Fact]
    public void Idempotent_Options()
    {
        RetryOptions retryOptions = RetryOptions.IdempotentRetryOptions;

        Assert.Equal(TimeSpan.FromSeconds(1), retryOptions.Timing.InitialBackoff);
        Assert.Equal(TimeSpan.FromSeconds(32), retryOptions.Timing.MaxBackoff);
        Assert.Equal(2, retryOptions.Timing.BackoffMultiplier);

        Assert.Equal(RetryPredicate.RetriableIdempotentErrors, retryOptions.Predicate);
    }

    [Fact]
    public void Never_Options()
    {
        RetryOptions retryOptions = RetryOptions.Never;

        Assert.Equal(TimeSpan.FromSeconds(1), retryOptions.Timing.InitialBackoff);
        Assert.Equal(TimeSpan.FromSeconds(32), retryOptions.Timing.MaxBackoff);
        Assert.Equal(2, retryOptions.Timing.BackoffMultiplier);

        Assert.Equal(RetryPredicate.Never, retryOptions.Predicate);
    }

    [Fact]
    public void MaybeIdempotent_Options()
    {
        RetryOptions retryOptions_Idempotent = RetryOptions.MaybeIdempotent(true);
        RetryOptions retryOptions_nonIdempotent = RetryOptions.MaybeIdempotent(null);

        Assert.Equal(RetryOptions.Never, retryOptions_nonIdempotent);
        Assert.Equal(RetryOptions.IdempotentRetryOptions, retryOptions_Idempotent);
    }

    [Fact]
    public void ConstructorTest()
    {
        RetryOptions retryOptions = new RetryOptions(null, null);

        Assert.Equal(RetryTiming.Default, retryOptions.Timing);
        Assert.Equal(RetryPredicate.Never, retryOptions.Predicate);
    }

    [Fact]
    public void CustomRetryOptionTest()
    {
        var retryOptions = new RetryOptions(new RetryTiming(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(4), 2), RetryPredicate.FromErrorCodes(500));

        Assert.Equal(TimeSpan.FromSeconds(1), retryOptions.Timing.GetDelay(1));
        Assert.Equal(TimeSpan.FromSeconds(2), retryOptions.Timing.GetDelay(2));
        Assert.Equal(TimeSpan.FromSeconds(4), retryOptions.Timing.GetDelay(3));

        Assert.True(retryOptions.Predicate.ShouldRetry(500));
        Assert.False(retryOptions.Predicate.ShouldRetry(504));
    }
}
