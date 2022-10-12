// Copyright 2022 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Download;
using Google.Apis.Storage.v1.Data;
using Google.Apis.Upload;
using Google.Cloud.ClientTesting;
using Google.Cloud.Storage.V1.Tests.Conformance;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.RetryConformanceTests;

[Collection(nameof(RetryConformanceTestFixture))]
public class RetryConformanceTest
{
    private const string RetryIdHeader = "x-retry-test-id";
    private static readonly Dictionary<string, MethodInvocation> s_methodMappings = CreateMethodMappings();
    public static TheoryData<RetryTest> RetryTestData { get; } = StorageConformanceTestData.TestData.GetTheoryData(f => f.RetryTests);
    private StorageClient Client => _fixture.Client;

    private readonly RetryConformanceTestFixture _fixture;

    public RetryConformanceTest(RetryConformanceTestFixture fixture) =>
        _fixture = fixture;

    /// <summary>
    /// Iterate throught the json file and run the test cases 
    /// </summary>
    /// <param name="test"> An intstance of <see cref="Tests.Conformance.RetryTest"/>.</param>
    /// <returns></returns>
    [SkippableTheory]
    [MemberData(nameof(RetryTestData))]
    public async Task RetryTest(RetryTest test)
    {
        Skip.IfNot(ShouldRunTest(test));

        // TODO: Work out what to do about groups. The old CreateMethodMapping 
        //CreateMethodMapping(test);

        foreach (InstructionList instructionList in test.Cases)
        {
            foreach (Method method in test.Methods)
            {
                if (!ShouldRunMethod(method.Name))
                {
                    continue;
                }

                await RunTestCase(instructionList, method, test.ExpectSuccess, test.PreconditionProvided);
            }
        }

        // bucket_acl, default_object_acl, object_acl functions do not exist in our handwritten library.
        // object.compose does not exist in our handwritten library and hence does not have retry implemented
        // object.insert is covered under resumable upload
        // objects.copy is not used directly but only as objects.rewrite which is a seperate test case
        bool ShouldRunMethod(string methodName) =>
            !methodName.Contains("_acl") && methodName != "objects.compose" && methodName != "objects.insert" && methodName != "objects.copy";

        // Ids with description "handle_complex_retries" are to test resumable uploads and downloads which will be implemented in the next phase
        bool ShouldRunTest(RetryTest test) => !test.Description.Contains("handle_complex_retries");
    }

    /// <summary>
    /// Handle full flow of each individual test case from resource creation to , running the testing, verify if it passed or failed and delete resource post usage.
    /// </summary>
    private async Task RunTestCase(InstructionList instructionList, Method method, bool expectSuccess, bool preConditionsPresent = false)
    {
        var context = CreateTestContext(method);
        var response = await CreateRetryTestResource(instructionList, method);
        try
        {
            if (expectSuccess)
            {
                RunRetryTest(response, context, preConditionsPresent);
                var postTestResponse = await GetRetryTest(response.Id);
                Assert.True(postTestResponse.Completed, "Expected retry test completed to be true, but was false.");
            }
            else
            {
                try
                {
                    RunRetryTest(response, context, preConditionsPresent);
                    Assert.Fail("Expected failure but test was successful.");
                }
                catch (Exception ex) // To catch expected exception when retry should not happen.
                {
                    if (ex.InnerException != null && ex.InnerException is GoogleApiException)
                    {
                        var statusCode = ((GoogleApiException) ex.InnerException).HttpStatusCode;

                        if ((instructionList.Instructions.Contains("return-503") && statusCode == System.Net.HttpStatusCode.ServiceUnavailable)
                            || (instructionList.Instructions.Contains("return-400") && statusCode == System.Net.HttpStatusCode.BadRequest)
                            || (instructionList.Instructions.Contains("return-401") && statusCode == System.Net.HttpStatusCode.Unauthorized))
                        {
                            Assert.False(expectSuccess);
                        }
                        else
                        {
                            throw;
                        }
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
        finally
        {
            try
            {
                DeleteStorageResources(context);
                RemoveRetryIdHeader();
                await DeleteRetryTest(response.Id);
            }
            catch// To catch and ignore exceptions occured, if any, while doing clean up of test.
            {
            }
        }
    }

    /// <summary>
    /// Create individual test resource on the storage test bench for each of API to be tested.
    /// </summary>
    private async Task<TestResponse> CreateRetryTestResource(InstructionList instructionList, Method method)
    {
        var stringContent = GetBodyContent(method.Name, instructionList);
        HttpResponseMessage response = await _fixture.HttpClient.PostAsync("retry_test", stringContent);
        response.EnsureSuccessStatusCode();
        var responseMessage = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<TestResponse>(responseMessage);
    }

    /// <summary>
    /// Add retry header for each request and make a call to retry and test each API.
    /// </summary>
    private void RunRetryTest(TestResponse response, TestContext context, bool preConditionsPresent)
    {
        AddRetryIdHeader(response.Id);

        Skip.IfNot(s_methodMappings.TryGetValue(response.GetMethodName(), out var invocation));
        invocation.Invoke(Client, context, preConditionsPresent);
    }

    private static Dictionary<string, MethodInvocation> CreateMethodMappings()
    {
        // Method group conversion for instance methods really needs an instance.
        // TODO(jonskeet): I'd expect method group conversions to work using an extra parameter. Look into this further.
        // TODO(jonskeet): Could we just use null? Unclear.
        var client = StorageClient.Create();

        return new Dictionary<string, MethodInvocation>
        {
            // TODO: Potentially just provide the method name and find the best overload, preferring strings over resources.
            { "storage.buckets.delete", CreateInvocation<string, DeleteBucketOptions>(client.DeleteBucket) },
            { "storage.buckets.get", CreateInvocation<string, GetBucketOptions>(client.GetBucket) },
            { "storage.buckets.getIamPolicy", CreateInvocation<string, GetBucketIamPolicyOptions>(client.GetBucketIamPolicy) },
            { "storage.buckets.insert", CreateInvocation<string, string, CreateBucketOptions>(client.CreateBucket) },
            { "storage.buckets.update", CreateInvocation<Bucket, UpdateBucketOptions>(client.UpdateBucket) },
            { "storage.buckets.list", CreateInvocation<string, ListBucketsOptions>(client.ListBuckets) },
            { "storage.buckets.testIamPermissions", CreateInvocation<string, IEnumerable<string>, TestBucketIamPermissionsOptions>(client.TestBucketIamPermissions) },
            { "storage.buckets.lockRetentionPolicy", CreateInvocation<string, long, LockBucketRetentionPolicyOptions>(client.LockBucketRetentionPolicy) },
            { "storage.buckets.patch", CreateInvocation<Bucket, PatchBucketOptions>(client.PatchBucket) },
            { "storage.buckets.setIamPolicy", CreateInvocation<string, Policy, SetBucketIamPolicyOptions>(client.SetBucketIamPolicy) },
            { "storage.objects.get", CreateInvocation<string, string, GetObjectOptions>(client.GetObject) },
            { "storage.objects.list", CreateInvocation<string, string, ListObjectsOptions>(client.ListObjects) },
            { "storage.objects.delete", CreateInvocation<string, string, DeleteObjectOptions>(client.DeleteObject) },
            { "storage.objects.patch", CreateInvocation<Object, PatchObjectOptions>(client.PatchObject) },
            { "storage.objects.rewrite", CreateInvocation<string, string, string, string, CopyObjectOptions>(client.CopyObject) },
            { "storage.objects.update", CreateInvocation<Object, UpdateObjectOptions>(client.UpdateObject) },
            { "storage.hmackey.get", CreateInvocation<string, string, GetHmacKeyOptions>(client.GetHmacKey) },
            { "storage.hmackey.delete", CreateInvocation<string, string, DeleteHmacKeyOptions>(client.DeleteHmacKey) },
            { "storage.hmackey.list", CreateInvocation<string, string, ListHmacKeysOptions>(client.ListHmacKeys) },
            { "storage.hmackey.update", CreateInvocation<HmacKeyMetadata, UpdateHmacKeyOptions>(client.UpdateHmacKey) },
            { "storage.hmackey.create", CreateInvocation<string, string, CreateHmacKeyOptions>(client.CreateHmacKey) },

            { "storage.notifications.list", CreateInvocation<string, ListNotificationsOptions>(client.ListNotifications) },
            { "storage.notifications.get", CreateInvocation<string, string, GetNotificationOptions>(client.GetNotification) },
            { "storage.notifications.delete", CreateInvocation<string, string, DeleteNotificationOptions>(client.DeleteNotification) },
            { "storage.notifications.insert", CreateInvocation<string, Notification, CreateNotificationOptions>(client.CreateNotification) },

            { "storage.serviceAccount.get", CreateInvocation<string, GetStorageServiceAccountEmailOptions>(client.GetStorageServiceAccountEmail) },

            { "storage.resumable.upload", CreateInvocation<string, string, string, Stream, UploadObjectOptions, IProgress<IUploadProgress>>(client.UploadObject) },
            { "storage.objects.download", CreateInvocation<Object, Stream, DownloadObjectOptions, IProgress<IDownloadProgress>>(client.DownloadObject) }
        };
    }

    // Note: these can't be local methods as they're overloaded
    private static MethodInvocation CreateInvocation<T1, T2>(Func<T1, T2, object> method) => new MethodInvocation(method);
    private static MethodInvocation CreateInvocation<T1, T2, T3>(Func<T1, T2, T3, object> method) => new MethodInvocation(method);
    private static MethodInvocation CreateInvocation<T1, T2, T3, T4>(Func<T1, T2, T3, T4, object> method) => new MethodInvocation(method);
    private static MethodInvocation CreateInvocation<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, object> method) => new MethodInvocation(method);
    private static MethodInvocation CreateInvocation<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, object> method) => new MethodInvocation(method);
    private static MethodInvocation CreateInvocation<T1, T2>(Action<T1, T2> method) => new MethodInvocation(method);
    private static MethodInvocation CreateInvocation<T1, T2, T3>(Action<T1, T2, T3> method) => new MethodInvocation(method);

    /// <summary>
    /// Checks if the retry resource has been created successfully.
    /// </summary>
    private async Task<TestResponse> GetRetryTest(string id)
    {
        HttpResponseMessage response = await _fixture.HttpClient.GetAsync($"retry_test/{id}");
        response.EnsureSuccessStatusCode();
        var responseMessage = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<TestResponse>(responseMessage);
    }

    /// <summary>
    /// Clears test resource once the test case is complete
    /// </summary>
    private async Task DeleteRetryTest(string id)
    {
        if (!string.IsNullOrWhiteSpace(id))
        {
            HttpResponseMessage response = await _fixture.HttpClient.DeleteAsync($"retry_test/{id}");
            response.EnsureSuccessStatusCode();
        }
    }

    /// <summary>
    /// Create the basic storage resources on storage test bench to enable running of the test cases
    /// </summary>
    private TestContext CreateTestContext(Method method)
    {
        var context = new TestContext(_fixture.ProjectId, _fixture.ServiceAccountEmail);
        string bucketName = IdGenerator.FromDateTime(prefix: "retry-test-");
        string objectName = "TestFile.json";
        foreach (var resource in method.Resources)
        {
            switch (resource)
            {
                case Resource.Bucket:
                    context.BucketName = CreateBucket(bucketName);
                    break;
                case Resource.Object:
                    (context.ObjectName, context.ObjectGeneration) = CreateObject(bucketName, objectName);
                    break;
                case Resource.HmacKey:
                    (context.HmacSecret, context.HmacAccessId) = CreateHmacKey(deactivate: method.Name == "storage.hmacKey.delete");
                    break;
                case Resource.Notification:
                    context.NotificationId = CreateNotification(bucketName);
                    break;
            }
        }
        // Handling for 'storage.buckets.insert' because library's CreateBucket requires
        // bucket's name as mandatory parameter, but retry_tests.json doesn't specify it as required resource. 
        if (method.Name == "storage.buckets.insert")
        {
            context.BucketName = CreateBucket(bucketName);
        }

        // For copying objects, need to create destination bucket and object as well
        if (method.Name == "storage.objects.rewrite")
        {
            string destBucketName = IdGenerator.FromDateTime(prefix: "retry-test-dest-bucket-");
            context.DestinationBucketName = CreateBucket(destBucketName);
            (context.DestinationObjectName, _) = CreateObject(destBucketName, "DestinationTestFile.json");
        }
        return context;

        // Local methods used to perform the actual resource creation.
        // TODO: Perhaps move these into the fixture?
        string CreateBucket(string bucketName)
        {
            Client.CreateBucket(_fixture.ProjectId, new Bucket { Name = bucketName });
            SleepAfterBucketCreateDelete();
            return bucketName;
        }

        (string secret, string accessId) CreateHmacKey(bool deactivate)
        {
            var serviceAccountEmail = Client.GetStorageServiceAccountEmail(_fixture.ProjectId);
            var hmacKey = Client.CreateHmacKey(_fixture.ProjectId, serviceAccountEmail);

            // If we are testing hmacKey.delete functionality then we have to
            // also deactivate the hmacKey for deletion to be successful.
            if (deactivate)
            {
                hmacKey.Metadata.State = HmacKeyStates.Inactive;
                Client.UpdateHmacKey(hmacKey.Metadata);
            }
            return (hmacKey.Secret, hmacKey.Metadata.AccessId);
        }

        string CreateNotification(string bucketName)
        {
            var notificationConfig = new Notification { Topic = _fixture.TestTopic, PayloadFormat = "NONE" };
            var notification = Client.CreateNotification(bucketName, notificationConfig);
            return notification.Id;
        }

        (string name, long generation) CreateObject(string bucketName, string objectName)
        {
            using var stream = File.OpenRead(_fixture.SampleObjectContentPath);
            var objectCreated = Client.UploadObject(bucketName, objectName, "application/json", stream);
            return (objectCreated.Name, objectCreated.Generation.Value);
        }
    }

    /// <summary>
    /// Cleans up any storage resources created for the retry test.
    /// </summary>
    private void DeleteStorageResources(TestContext context)
    {
        if (context.NotificationId is string notificationId)
        {
            Client.DeleteNotification(context.BucketName, notificationId);
        }
        if (context.HmacSecret is string)
        {
            var hmacKeyMetadata = Client.GetHmacKey(context.ProjectId, context.HmacAccessId);
            hmacKeyMetadata.State = HmacKeyStates.Inactive;
            Client.UpdateHmacKey(hmacKeyMetadata);
            Client.DeleteHmacKey(context.ProjectId, context.HmacAccessId);
        }
        MaybeDeleteBucket(context.BucketName);
        MaybeDeleteBucket(context.DestinationBucketName);

        void MaybeDeleteBucket(string bucketName)
        {
            if (bucketName is null)
            {
                return;
            }
            try
            {
                Client.DeleteBucket(bucketName, new DeleteBucketOptions { UserProject = null, DeleteObjects = true });
            }
            catch (GoogleApiException)
            {
                // Some tests fail to delete buckets due to object retention locks etc. They can be cleaned up later.
            }
            SleepAfterBucketCreateDelete();
        }
    }

    /// <summary>
    /// Create header specific to this request. Remove all previous headers
    /// </summary>
    private void AddHeader(string header, string value)
    {
        bool contains = Client.Service.HttpClient.DefaultRequestHeaders.Contains(header);
        if (contains)
        {
            // Remove.
            Client.Service.HttpClient.DefaultRequestHeaders.Remove(header);
        }

        Client.Service.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation(header, value);
    }

    /// <summary>
    /// Create the payload header to be sent for running test cases
    /// </summary>
    private void AddRetryIdHeader(string id) => AddHeader(RetryIdHeader, id);

    /// <summary>
    /// Removes the existing payload header. Should be called once retry test with added header is completed.
    /// </summary>
    private void RemoveRetryIdHeader()
    {
        if (Client.Service.HttpClient.DefaultRequestHeaders.Contains(RetryIdHeader))
        {
            Client.Service.HttpClient.DefaultRequestHeaders.Remove(RetryIdHeader);
        }
    }

    /// <summary>
    /// Create the payload body to be sent for running test cases
    /// </summary>
    private static StringContent GetBodyContent(string methodName, InstructionList instructionList)
    {
        if (string.IsNullOrWhiteSpace(methodName) || instructionList == null)
        {
            return null;
        }

        JObject payload = new JObject();
        JArray instructions = new JArray();
        foreach (string instruct in instructionList.Instructions)
        {
            instructions.Add(instruct);
        }

        payload.Add(methodName, instructions);
        JObject body = new JObject();
        body.Add("instructions", payload);

        return new StringContent(body.ToString(), Encoding.UTF8, "application/json");
    }

    /// <summary>
    /// Function created to be used for getting environmental variables
    /// </summary>
    private static string GetEnvironmentVariableOrDefault(string name, string defaultValue)
    {
        string value = Environment.GetEnvironmentVariable(name);
        return string.IsNullOrEmpty(value) ? defaultValue : value;
    }

    private static void SleepAfterBucketCreateDelete() => Thread.Sleep(2000);
}
