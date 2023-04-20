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

using Google.Api.Gax.Testing;
using Google.Apis.Requests;
using Google.Cloud.ClientTesting;
using System;
using System.Linq;
using System.Net;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests;

/// <summary>
/// Retries custom RetryTimings and RetryPredicate variants complete flows.
/// </summary>
public class RetryTest
{
    [Theory]
    [InlineData(new[] { 502, 200 }, true, 502, 504)] // It retries for 502 error code as it is present in retry predicate and then succeeds with 200 code.
    [InlineData(new[] { 502, 429 }, false, 502, 504)] // It fails because the second status code is not present in the retry predicate.
    [InlineData(new[] { 502 }, false)] // It fails because the retry predicate doesnt have any retriable error code.
    public void CustomRetryPredicateTest(int[] responseStatusCodes, bool success, params int[] errorCodes)
    {
        RetryOptions retryOptions = new RetryOptions(
            retryTiming: new RetryTiming(initialBackoff: TimeSpan.FromSeconds(1),
            maxBackoff: TimeSpan.FromSeconds(6), backoffMultiplier: 2),
            retryPredicate: RetryPredicate.FromErrorCodes(errorCodes));

        AssertAttempts(
            retryOptions: retryOptions,
            responseStatusCodes: responseStatusCodes,
            success: success,
            expectedBackOffs: new int[] { 0, 1 });
    }

    [Theory]
    [InlineData(0, 1, 2, new[] { 200 }, new[] { 0 })] // It succeeds in first attempt with 0 backoff.
    [InlineData(1, 2, 2, new[] { 502, 504, 200 }, new[] { 0, 1, 3 })] // It retries twice for 502, 504 error code and then succeeds with 200 code
    public void CustomRetryTimingTest(int initialBackoff, int maxBackoff, double backoffMultiplier, int[] responseStatusCodes, int[] expectedBackOffs)
    {
        RetryOptions retryOptions = new RetryOptions(
            retryTiming: new RetryTiming(initialBackoff: TimeSpan.FromSeconds(initialBackoff),
            maxBackoff: TimeSpan.FromSeconds(maxBackoff), backoffMultiplier: backoffMultiplier),
            retryPredicate: RetryPredicate.FromErrorCodes(502, 504));

        AssertAttempts(
            retryOptions: retryOptions,
            responseStatusCodes: responseStatusCodes,
            success: true,
            expectedBackOffs: expectedBackOffs);
    }

    /// <summary>
    /// Exception is thrown in this test case as the it exceeds number of retry attempts
    /// </summary>
    [Fact]
    public void ExceptionAfterRetryExhaustedTest()
    {
        RetryOptions retryOptions = new RetryOptions(
            retryTiming: new RetryTiming(initialBackoff: TimeSpan.FromSeconds(1),
            maxBackoff: TimeSpan.FromSeconds(3), backoffMultiplier: 2),
            retryPredicate: RetryPredicate.FromErrorCodes(502, 504));

        var expectedBackOffs = new[] { 0, 1, 3 };

        AssertAttempts(
           retryOptions: retryOptions,
           responseStatusCodes: new[] { 502, 502, 502 },
           success: false,
           expectedBackOffs: expectedBackOffs);
    }

    private static void AssertAttempts(RetryOptions retryOptions, int[] responseStatusCodes, bool success, params int[] expectedBackOffs)
    {
        var scheduler = new FakeScheduler();
        var clock = scheduler.Clock;
        var messageHandler = new ReplayingMessageHandler(VersionHeaderBuilder.HeaderName, clock);
        var service = new FakeStorageService(messageHandler);
        service.HttpClient.MessageHandler.NumTries = expectedBackOffs.Length;

        var request = service.Buckets.Get("bucket");
        var client = new StorageClientImpl(service, encryptionKey: null, scheduler);
        scheduler.Run(() =>
        {
            for (int i = 0; i < responseStatusCodes.Length; ++i)
            {
                service.ExpectRequest(request, (HttpStatusCode) responseStatusCodes[i]);
            }

            DateTime startTime = clock.GetCurrentDateTimeUtc();
            if (success)
            {
                client.GetBucket("bucket", new GetBucketOptions { RetryOptions = retryOptions });
                Assert.Equal(expectedBackOffs.Count(), messageHandler.AttemptTimestamps.Count());
            }
            else
            {
                Assert.Throws<GoogleApiException>(() => client.GetBucket("bucket", new GetBucketOptions { RetryOptions = retryOptions }));
            }

            service.Verify();

            for (int i = 0; i < messageHandler.AttemptTimestamps.Count; i++)
            {
                Assert.Equal(expectedBackOffs[i], (messageHandler.AttemptTimestamps[i] - startTime).TotalSeconds);
            }
        });
    }
}
