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

using Google.Api.Gax;
using Google.Api.Gax.Testing;
using Google.Apis.Storage.v1.Data;
using Google.Cloud.ClientTesting;
using System;
using System.Linq;
using System.Net;
using Xunit;
using static System.Net.HttpStatusCode;

namespace Google.Cloud.Storage.V1.Tests;

/// <summary>
/// Retries custom RetryTimings and RetryPredicate variants complete flows.
/// </summary>
public class RetryTest
{
    private static readonly RetryTiming s_customRetryTiming = new(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(5), 2);
    private static readonly RetryPredicate s_customPredicate = RetryPredicate.FromErrorCodes(404, 400);
    private static readonly RetryOptions s_customRetryOptions = new(s_customRetryTiming, s_customPredicate);

    public static TheoryData<TestCase> TestCases { get; } = new TheoryData<TestCase>
    {
        new TestCase("SimpleSuccess_NoRetry", RetryOptions.IdempotentRetryOptions, new[] { OK }, new[] { 0 }, true),
        new TestCase("SuccessAfterMaxRetry", RetryOptions.IdempotentRetryOptions, new[] { BadGateway, BadGateway, OK }, new[] { 0, 1, 3 }, true),
        new TestCase("FailureAfterMaxRetry", RetryOptions.IdempotentRetryOptions, new[] { BadGateway, BadGateway, BadGateway }, new[] { 0, 1, 3 }, false),

        new TestCase("CustomTiming_SuccessAfterRetry",  s_customRetryOptions, new[] { NotFound, BadRequest, OK }, new[] { 0, 1, 3 }, true),
        new TestCase("CustomTiming_FailureAfterRetry",  s_customRetryOptions, new[] { NotFound, BadRequest, BadRequest }, new[] { 0, 1, 3}, false),

        new TestCase("CustomPredicate_Success", s_customRetryOptions, new[] { OK }, new[] { 0 }, true),
        new TestCase("CustomPredicate_ImmediateFailure", s_customRetryOptions, new[] { InternalServerError }, new[] { 0 }, false),
        new TestCase("CustomPredicate_SingleRetry", s_customRetryOptions, new[] { NotFound, OK }, new[] { 0, 1 }, true),
        new TestCase("CustomPredicate_DoubleRetry",  s_customRetryOptions, new[] { NotFound, BadRequest, OK }, new[] { 0, 1, 3 }, true),
        new TestCase("CustomPredicate_FailureAfterRetry",  s_customRetryOptions, new[] { NotFound, BadRequest, BadRequest }, new[] { 0, 1, 3 }, false),
        new TestCase("CustomPredicate_SuccessAfterRetry",  s_customRetryOptions, new[] { NotFound, OK }, new[] { 0, 1 }, true),
        new TestCase("CustomPredicate_Never", RetryOptions.Never, new[] { BadGateway }, new[] { 0 }, false),

        new TestCase("RetryUntilMaxRequests", RetryOptions.IdempotentRetryOptions, new[] { BadGateway, BadGateway, BadGateway }, new[] { 0, 1, 3 }, false),
        new TestCase("RetryableErrors", s_customRetryOptions, new[] { BadRequest, BadRequest, OK }, new[] { 0, 1, 3 }, true),
        new TestCase("NonRetryableErrors", s_customRetryOptions , new[] { PreconditionFailed }, new[] { 0 }, false)
    };

    [Theory, MemberData(nameof(TestCases))]
    public void RunTest(TestCase testCase)
    {
        var scheduler = new FakeScheduler();
        var clock = scheduler.Clock;
        var messageHandler = new ReplayingMessageHandler(header: null, clock);
        var service = new FakeStorageService(messageHandler);

        var client = new StorageClientImpl(service, encryptionKey: null, scheduler);
        service.ExpectRequests(service.Buckets.Get("bucket"), new Bucket(), testCase.ReturnedStatusCodes);

        scheduler.Run(() =>
        {
            if (testCase.EventualSuccess)
            {
                MakeClientCall();
            }
            else
            {
                Assert.Throws<GoogleApiException>(MakeClientCall);
            }
        });

        Assert.Equal(testCase.ExpectedRequestTimes.Select(time => TimeSpan.FromSeconds(time)), messageHandler.RequestTimes);
        service.Verify();

        void MakeClientCall() => client.GetBucket("bucket", new GetBucketOptions { RetryOptions = testCase.RetryOptions });
    }

    /// <summary>
    /// A single test case to execute.
    /// </summary>
    public class TestCase
    {
        /// <summary>
        /// The ID of the test case, which should be reasonably descriptive.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// The retry options to test.
        /// </summary>
        public RetryOptions RetryOptions { get; }

        /// <summary>
        /// The status codes that the fake service should return.
        /// </summary>
        public HttpStatusCode[] ReturnedStatusCodes { get; }

        /// <summary>
        /// The expected time (in seconds since the start of the test, for simplicity)
        /// for each request. This must be the same length as <see cref="ReturnedStatusCodes"/>.
        /// </summary>
        public int[] ExpectedRequestTimes { get; }

        /// <summary>
        /// Whether we expect the overall client operation to succeed or not.
        /// </summary>
        public bool EventualSuccess { get; }

        public TestCase(string id, RetryOptions retryOptions, HttpStatusCode[] returnedStatusCodes, int[] expectedRequestTimes, bool eventualSuccess)
        {
            GaxPreconditions.CheckArgument(
                returnedStatusCodes.Length == expectedRequestTimes.Length,
                nameof(expectedRequestTimes),
                $"Expected {nameof(returnedStatusCodes)} and {nameof(expectedRequestTimes)} to have the same number of elements");
            Id = id;
            RetryOptions = retryOptions;
            ReturnedStatusCodes = returnedStatusCodes;
            ExpectedRequestTimes = expectedRequestTimes;
            EventualSuccess = eventualSuccess;
        }

        public override string ToString() => Id;
    }
}
