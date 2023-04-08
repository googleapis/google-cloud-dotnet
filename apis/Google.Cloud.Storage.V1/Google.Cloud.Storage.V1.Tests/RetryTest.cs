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

using Google.Apis.Requests;
using Google.Apis.Storage.v1.Data;
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
    [InlineData(502, true, 502, 504)]
    [InlineData(504, true, 502, 504)]
    [InlineData(429, false, 502, 504)]
    [InlineData(502, false)]
    public void CustomRetryPredicateTest(int statusCode, bool success, params int[] errorCodes)
    {
        RetryOptions retryOptions = new RetryOptions(
            retryTiming: new RetryTiming(initialBackoff: TimeSpan.FromSeconds(1),
            maxBackoff: TimeSpan.FromSeconds(6), backoffMultiplier: 2),
            retryPredicate: RetryPredicate.FromErrorCodes(errorCodes));

        AssertAttempts(
            retryOptions: retryOptions,
            statusCode: statusCode,
            numOfFailures: 2,
            maximumRetries: 3,
            success: success,
            expectedBackOffs: new int[] { 0, 1, 3 });
    }

    [Theory]
    [InlineData(0, 1, 2, 0, 0)]
    [InlineData(1, 2, 2, 2, 0, 1, 3)]
    [InlineData(1, 4, 1, 3, 0, 1, 2, 3)]
    public void CustomRetryTimingTest(int initialBackoff, int maxBackoff, double backoffMultiplier, int numOfFailures, params int[] expectedBackOffs)
    {
        RetryOptions retryOptions = new RetryOptions(
            retryTiming: new RetryTiming(initialBackoff: TimeSpan.FromSeconds(initialBackoff),
            maxBackoff: TimeSpan.FromSeconds(maxBackoff), backoffMultiplier: backoffMultiplier),
            retryPredicate: RetryPredicate.FromErrorCodes(502, 504));

        AssertAttempts(
            retryOptions: retryOptions,
            statusCode: 502,
            numOfFailures: numOfFailures,
            maximumRetries: numOfFailures + 1,
            success: true,
            expectedBackOffs: expectedBackOffs);
    }

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
           statusCode: 502,
           numOfFailures: 4,
           maximumRetries: 3,
           success: false,
           expectedBackOffs: expectedBackOffs);
    }

    private static void AssertAttempts(RetryOptions retryOptions, int statusCode, int numOfFailures, int maximumRetries, bool success, params int[] expectedBackOffs)
    {
        var messageHandler = new ReplayingMessageHandler(VersionHeaderBuilder.HeaderName);
        var service = new FakeStorageService(messageHandler);
        service.HttpClient.MessageHandler.GoogleApiClientHeader = "test/fake";
        service.HttpClient.MessageHandler.NumTries = maximumRetries;

        var request = service.Buckets.Get("bucket");
        var client = new StorageClientImpl(service);

        // Retries for the the failures. Assumed that error code 504 is always included in the predicate for these tests.
        service.ExpectRequests(request, (HttpStatusCode) 504, numOfFailures - 1);
        if (numOfFailures > 0)
        {
            service.ExpectRequest(request, (HttpStatusCode) statusCode);
        }

        DateTime startTime = DateTime.UtcNow;
        if (success)
        {
            // Last call is a success.
            service.ExpectRequest(request, new Bucket());

            client.GetBucket("bucket", new GetBucketOptions { RetryOptions = retryOptions });

            Assert.Equal(expectedBackOffs.Count(), messageHandler.AttemptTimestamps.Count());
            service.Verify();
        }
        else
        {
            // The call throws an exception
            Assert.Throws<GoogleApiException>(() => client.GetBucket("bucket", new GetBucketOptions { RetryOptions = retryOptions }));
        }

        for (int i = 0; i < messageHandler.AttemptTimestamps.Count; i++)
        {
            Assert.Equal(expectedBackOffs[i], (messageHandler.AttemptTimestamps[i] - startTime).TotalSeconds, 0.25);
        }
    }
}
