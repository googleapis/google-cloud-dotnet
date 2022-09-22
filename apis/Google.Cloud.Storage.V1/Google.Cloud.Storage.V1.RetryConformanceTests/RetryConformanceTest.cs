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

using Google.Apis.Storage.v1.Data;
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

namespace Google.Cloud.Storage.V1.RetryConformanceTests;

public class RetryConformanceTest
{
    public static TheoryData<RetryTest> RetryTestData { get; } = StorageConformanceTestData.TestData.GetTheoryData(f => f.RetryTests);

    internal static string TestBenchUrl { get; } = GetEnvironmentVariableOrDefault("TEST_BENCH_URL", "https://storage-testbench-vkcain7hhq-el.a.run.app/");

    internal static string ProjectId { get; } = GetEnvironmentVariableOrDefault("PROJECT_ID", "test");

    internal string TestTopic { get; } = GetEnvironmentVariableOrDefault("TOPIC", "test-topic");

    internal string AccessId { get; set; }

    internal string FilePath { get; } = Path.Combine(StorageConformanceTestData.TestData.DataPath, "test_service_account.not-a-test.json");

    private readonly StorageClient _storageClient;

    private readonly HttpClient _httpClient;

    private readonly ConcurrentDictionary<string, MethodInvocation> _methodMappings;

    private readonly string _retryIdHeader = "x-retry-test-id";

    private static readonly System.Type s_clientType = typeof(StorageClient);

    public RetryConformanceTest()
    {
        _storageClient = InitializeClient();
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(TestBenchUrl)
        };

        _methodMappings = new ConcurrentDictionary<string, MethodInvocation>();
    }

    /// <summary>
    /// Iterate throught the json file and run the test cases 
    /// </summary>
    /// <param name="test"> An intstance of <see cref="Tests.Conformance.RetryTest"/>.</param>
    /// <returns></returns>
    [Theory]
    [MemberData(nameof(RetryTestData))]
    public async Task RetryTest(RetryTest test)
    {
        // TODO: Remove this if condition.
        // Right now retry tests with id 1( i.e. always_idempotent) is only working. There are total 9 types of retry tests. will be resolve incremently.
        if (test.Id == 1)
        {
            CreateMethodMapping(test);

            //UPDATE : Working for most test cases across except object related test cases and some exceptions to be fixed
            foreach (InstructionList instructionList in test.Cases)
            {
                if (instructionList.Instructions.Contains("return-reset-connection")) // TODO: This condition should be removed once "return-reset-connection" instruction works.
                {
                    continue;
                }

                foreach (Method method in test.Methods)
                {
                    // _acl function dont exist in our library
                    if (!method.Name.Contains("_acl"))
                    {
                        await RunTestCase(instructionList, method, test.ExpectSuccess, test.PreconditionProvided);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Handle full flow of each individual test case from resource creation to , running the testing, verify if it passed or failed and delete resource post usage.
    /// </summary>
    private async Task RunTestCase(InstructionList instructionList, Method method, bool expectSuccess, bool preConditionsPresent = false)
    {
        var resources = CreateStorageResources(method);
        var response = await CreateRetryTestResource(instructionList, method);
        try
        {
            if (expectSuccess)
            {
                RunRetryTest(response, resources, preConditionsPresent);
            }
            else
            {
                try
                {
                    RunRetryTest(response, resources, preConditionsPresent);
                    Assert.Fail("Expected failure but test was successful.");
                }
                catch // To catch expected exception when retry should not happen.
                {
                    //TODO: To check that it is an expected excpetion.
                }
            }

            var postTestResponse = await GetRetryTest(response.Id);

            Assert.True(postTestResponse.Completed, "Expected retry test completed to be true, but was false.");
        }
        finally
        {
            try
            {
                DeleteStorageResources(resources);
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
        HttpResponseMessage response = await _httpClient.PostAsync("retry_test", stringContent);
        response.EnsureSuccessStatusCode();
        var responseMessage = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<TestResponse>(responseMessage);
    }

    /// <summary>
    /// Add retry header for each request and make a call to retry and test each API.
    /// </summary>
    private void RunRetryTest(TestResponse response, StorageResources resources, bool preConditionsPresent)
    {
        AddRetryIdHeader(response.Id);

        // Use method mapping to call the StorageTestBench API.
        if (_methodMappings.TryGetValue(GetMethodName(response), out var invocation))
        {
            if (invocation.ProjectIdRequired)
            {
                invocation.ProjectId = ProjectId;
            }
            if (invocation.BucketNameRequired)
            {
                invocation.BucketName = resources.BucketName;
            }
            if (invocation.ObjectNameRequired)
            {
                invocation.ObjectName = resources.ObjectName;
            }
            if (invocation.HmacKeyRequired)
            {
                invocation.BucketName = resources.BucketName;
                invocation.HmacKey = resources.HmacKey;
            }
            if (invocation.AccessIdRequired)
            {
                invocation.AccessId = AccessId;
            }
            if (invocation.MetagenerationRequired)
            {
                invocation.Metageneration = 1;
            }
            if (invocation.ServiceAccountEmailRequired)
            {
                invocation.ServiceAccountEmail = _storageClient.GetStorageServiceAccountEmail(ProjectId);
            }
            if (invocation.NotificationRequired)
            {
                invocation.Notification = resources.Notification;
            }

            invocation.Invoke(_storageClient, preConditionsPresent);
        }
    }

    /// <summary>
    /// Create test bench URL for running test cases
    /// </summary>
    private StorageClient InitializeClient()
    {
        var clientBuilder = new StorageClientBuilder
        {
            BaseUri = TestBenchUrl + "storage/v1/",
            GZipEnabled = false
        };

        return clientBuilder.Build();
    }

    /// <summary>
    /// Created the map for each API to be tested with its corresponding method in .net library
    /// </summary>
    private void CreateMethodMapping(RetryTest test)
    {
        foreach (var method in test.Methods)
        {
            _methodMappings.TryAdd(method.Name, GetMappedFunction(method.Name));
        }
    }

    /// <summary>
    /// Returns the mapping of the given API to its correspondng .net library method
    /// </summary>
    private MethodInvocation GetMappedFunction(string name) => name.ToLowerInvariant() switch
    {
        // TODO: Add all mappings from the json file and throw exception in the default case. To be optimised

        "storage.buckets.delete" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.DeleteBucket), new System.Type[] { typeof(string), typeof(DeleteBucketOptions) })) { BucketNameRequired = true },
        "storage.buckets.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetBucket))) { BucketNameRequired = true },
        "storage.buckets.getiampolicy" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetBucketIamPolicy))) { BucketNameRequired = true },
        "storage.buckets.insert" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.CreateBucket), new System.Type[] { typeof(string), typeof(string), typeof(CreateBucketOptions) })) { ProjectIdRequired = true, BucketNameRequired = true },
        "storage.buckets.update" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.UpdateBucket), new System.Type[] { typeof(Bucket), typeof(UpdateBucketOptions) })) { ProjectIdRequired = true, BucketNameRequired = true },
        "storage.buckets.list" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.ListBuckets))) { ProjectIdRequired = true },
        "storage.buckets.testiampermissions" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.TestBucketIamPermissions), new System.Type[] { typeof(string), typeof(IEnumerable<string>), typeof(TestBucketIamPermissionsOptions) })) { ProjectIdRequired = true, BucketNameRequired = true },
        "storage.buckets.lockretentionpolicy" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.LockBucketRetentionPolicy), new System.Type[] { typeof(string), typeof(long), typeof(LockBucketRetentionPolicyOptions) })) { ProjectIdRequired = true, BucketNameRequired = true, MetagenerationRequired = true },
        "storage.buckets.patch" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.PatchBucket), new System.Type[] { typeof(Bucket), typeof(PatchBucketOptions) })) { ProjectIdRequired = true, BucketNameRequired = true },
        "storage.buckets.setiampolicy" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.SetBucketIamPolicy), new System.Type[] { typeof(string), typeof(Policy), typeof(SetBucketIamPolicyOptions) })) { ProjectIdRequired = true, BucketNameRequired = true },

        "storage.objects.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetObject), new System.Type[] { typeof(string), typeof(string), typeof(GetObjectOptions) })) { BucketNameRequired = true, ObjectNameRequired = true },
        "storage.objects.list" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.ListObjects), new System.Type[] { typeof(string), typeof(string), typeof(ListObjectsOptions) })) { BucketNameRequired = true },

        "storage.hmackey.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetHmacKey), new System.Type[] { typeof(string), typeof(string), typeof(GetHmacKeyOptions) })) { ProjectIdRequired = true, AccessIdRequired = true },
        "storage.hmackey.delete" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.DeleteHmacKey), new System.Type[] { typeof(string), typeof(string), typeof(DeleteHmacKeyOptions) })) { ProjectIdRequired = true, AccessIdRequired = true },
        "storage.hmackey.list" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.ListHmacKeys), new System.Type[] { typeof(string), typeof(string), typeof(ListHmacKeysOptions) })) { ProjectIdRequired = true },
        "storage.hmackey.update" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.UpdateHmacKey), new System.Type[] { typeof(HmacKeyMetadata), typeof(UpdateHmacKeyOptions) })) { ProjectIdRequired = true, AccessIdRequired = true },

        "storage.notifications.list" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.ListNotifications), new System.Type[] { typeof(string), typeof(ListNotificationsOptions) })) { ProjectIdRequired = true, BucketNameRequired = true, NotificationRequired = true },
        "storage.notifications.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetNotification), new System.Type[] { typeof(string), typeof(string), typeof(GetNotificationOptions) })) { BucketNameRequired = true, NotificationRequired = true },
        "storage.notifications.delete" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.DeleteNotification), new System.Type[] { typeof(string), typeof(string), typeof(DeleteNotificationOptions) })) { BucketNameRequired = true, NotificationRequired = true },

        "storage.serviceaccount.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetStorageServiceAccountEmail), new System.Type[] { typeof(string), typeof(GetStorageServiceAccountEmailOptions) })) { ProjectIdRequired = true },

        // Just to proceed with testing for now.
        _ => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetBucket))) { BucketNameRequired = true }

    };

    /// <summary>
    /// Checks if the retry resource has been created successfully.
    /// </summary>
    private async Task<TestResponse> GetRetryTest(string id)
    {
        HttpResponseMessage response = await _httpClient.GetAsync($"retry_test/{id}");
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
            HttpResponseMessage response = await _httpClient.DeleteAsync($"retry_test/{id}");
            response.EnsureSuccessStatusCode();
        }
    }

    /// <summary>
    /// Create the basic storage resources on storage test bench to enable running of the test cases
    /// </summary>
    private StorageResources CreateStorageResources(Method method)
    {
        var result = new StorageResources();

        string bucketName = IdGenerator.FromDateTime(prefix: "retry-test-");
        string objectName = "TestFile.json";
        foreach (var resource in method.Resources)
        {
            if (resource == Resource.Bucket)
            {
                CreateAndAddBucket(result, bucketName);
            }
            else if (resource == Resource.HmacKey)
            {
                CreateAndAddHmacKey(result, method.Name);
            }
            else if (resource == Resource.Notification)
            {
                CreateAndAddNotification(result, bucketName);
            }
            else if (resource == Resource.Object)
            {
                CreateAndAndObject(result, bucketName, objectName);
            }
        }

        // Need to do speacial handling for 'storage.buckets.insert' becasue library's CreateBucket requires
        // bucket's name as mandatory parameter, but retry_tests.json doesn't specify it as required resource. 
        if (method.Name.Equals("storage.buckets.insert", StringComparison.OrdinalIgnoreCase))
        {
            result.Add(new StorageResource(Resource.Bucket, bucketName));
        }

        return result;
    }

    /// <summary>
    /// Creates a new bucket and adds it to the provided storage resources collection.
    /// </summary>
    private void CreateAndAddBucket(StorageResources result, string bucketName)
    {
        var bucket = _storageClient.CreateBucket(ProjectId, new Bucket { Name = bucketName });
        SleepAfterBucketCreateDelete();
        result.Add(new StorageResource(Resource.Bucket, bucketName));
    }

    /// <summary>
    /// Creates a new HmacKey and adds it to the provided storage resources collection.
    /// </summary>
    private void CreateAndAddHmacKey(StorageResources result, string methodName)
    {
        var serviceAccountEmail = _storageClient.GetStorageServiceAccountEmail(ProjectId);
        var hmacKey = _storageClient.CreateHmacKey(ProjectId, serviceAccountEmail);
        AccessId = hmacKey.Metadata.AccessId;
        var hmacSecret = hmacKey.Secret;

        // If we are testing hmacKey.delete functionality then we have to
        // also deactivate the hmacKey for deletion to be successful.
        if (methodName.Equals("storage.hmacKey.delete"))
        {
            hmacKey.Metadata.State = HmacKeyStates.Inactive;
            _storageClient.UpdateHmacKey(hmacKey.Metadata);
        }

        result.Add(new StorageResource(Resource.HmacKey, hmacSecret));
    }

    /// <summary>
    /// Creates a new notification and adds it to the provided storage resources collection.
    /// </summary>
    /// <param name="result"></param>
    /// <param name="bucketName"></param>
    private void CreateAndAddNotification(StorageResources result, string bucketName)
    {
        var notificationConfig = new Notification { Topic = TestTopic, PayloadFormat = "NONE" };
        var notification = _storageClient.CreateNotification(bucketName, notificationConfig);
        var notificationId = notification.Id;
        result.Add(new StorageResource(Resource.Notification, notificationId));
    }

    /// <summary>
    /// Uploads a new object in to provided bucket and adds it to the storage resources collection.
    /// </summary
    private void CreateAndAndObject(StorageResources result, string bucketName, string objectName)
    {
        using var stream = File.OpenRead(FilePath);
        var objectCreated = _storageClient.UploadObject(bucketName, objectName, "application/json", stream);
        result.Add(new StorageResource(Resource.Object, objectCreated.Name));
    }

    /// <summary>
    /// To clear the storage resources created for the retry test.
    /// </summary>
    private void DeleteStorageResources(StorageResources resources)
    {
        if (resources != null)
        {
            if (resources.Notification != null)
            {
                _storageClient.DeleteNotification(resources.BucketName, resources.Notification);
            }
            if (resources.HmacKey != null)
            {
                var hmacKeyMetadata = _storageClient.GetHmacKey(ProjectId, AccessId);
                hmacKeyMetadata.State = HmacKeyStates.Inactive;
                _storageClient.UpdateHmacKey(hmacKeyMetadata);
                _storageClient.DeleteHmacKey(ProjectId, AccessId);
            }
            if (!string.IsNullOrWhiteSpace(resources.BucketName))
            {
                try
                {
                    _storageClient.DeleteBucket(resources.BucketName, new DeleteBucketOptions { UserProject = null, DeleteObjects = true });
                }
                catch (GoogleApiException)
                {
                    // Some tests fail to delete buckets due to object retention locks etc.They can be cleaned up later.
                }
                SleepAfterBucketCreateDelete();
            }
        }
    }

    /// <summary>
    /// Create header specific to this request. Remove all previous headers
    /// </summary>
    private void AddHeader(string header, string value)
    {
        bool contains = _storageClient.Service.HttpClient.DefaultRequestHeaders.Contains(header);
        if (contains)
        {
            // Remove.
            _storageClient.Service.HttpClient.DefaultRequestHeaders.Remove(header);
        }

        _storageClient.Service.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation(header, value);
    }

    /// <summary>
    /// Gets the resource method name
    /// </summary>
    private string GetMethodName(TestResponse response)
    {
        if (response.Instructions.Any())
        {
            var token = response.Instructions.First().Value;
            if (token?.First is JProperty first)
            {
                return first.Name;
            }
        }

        return default;
    }

    /// <summary>
    /// Create the payload header to be sent for running test cases
    /// </summary>
    private void AddRetryIdHeader(string id)
    {
        AddHeader(_retryIdHeader, id);
    }

    /// <summary>
    /// Removes the existing payload header. Should be called once retry test with added header is completed.
    /// </summary>
    private void RemoveRetryIdHeader()
    {
        if (_storageClient.Service.HttpClient.DefaultRequestHeaders.Contains(_retryIdHeader))
        {
            _storageClient.Service.HttpClient.DefaultRequestHeaders.Remove(_retryIdHeader);
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
    /// Function created to be used for getting envionmental variables
    /// </summary>
    private static string GetEnvironmentVariableOrDefault(string name, string defaultValue)
    {
        string value = Environment.GetEnvironmentVariable(name);
        return string.IsNullOrEmpty(value) ? defaultValue : value;
    }

    private static void SleepAfterBucketCreateDelete() => Thread.Sleep(2000);
}
