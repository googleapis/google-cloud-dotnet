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
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.RetryConformanceTests;

public class RetryConformanceTest
{
    public static TheoryData<RetryTest> RetryTestData { get; } = StorageConformanceTestData.TestData.GetTheoryData(f => f.RetryTests);

    internal static string TestBenchUrl { get; } = GetEnvironmentVariableOrDefault("TEST_BENCH_URL", "https://storage-testbench-vkcain7hhq-el.a.run.app/");

    internal static string ProjectId { get; } = GetEnvironmentVariableOrDefault("PROJECT_ID", "test");

    internal string Topic { get; } = GetEnvironmentVariableOrDefault("TOPIC", "test-topic");

    internal string AccessId { get; set; }

    internal string FilePath { get; } = Path.Combine(StorageConformanceTestData.TestData.DataPath, "test_service_account.not-a-test.json");

    private readonly StorageClient _storageClient;

    private readonly HttpClient _httpClient;

    private static readonly System.Type s_clientType = typeof(StorageClient);

    private readonly ConcurrentDictionary<string, MethodInvocation> _methodMappings;

    internal string _hmacSecret;

    internal string _notificationId;

    public RetryConformanceTest()
    {
        _storageClient = InitializeClient();
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(TestBenchUrl)
        };

        _methodMappings = new ConcurrentDictionary<string, MethodInvocation>();
    }

    [Theory]
    [MemberData(nameof(RetryTestData))]
    public async Task RetryTest(RetryTest test)
    {
        CreateMethodMapping(test);
        bool expectSuccess = test.ExpectSuccess;

        //Iterate throught the json file and run test cases
        //UPDATE : Working for most test cases across except object related test cases and some exceptions to be fixed
        foreach (InstructionList testCase in test.Cases)
        {
            JArray instruct = new JArray();
            foreach (string instructions in testCase.Instructions)
            {
                instruct.Add(instructions);
            }
            foreach (Method method in test.Methods)
            {
                // _acl function dont exist in our library
                if (!method.Name.Contains("_acl")) 
                {
                    await RunTestCase(instruct, method, expectSuccess, test.Description.Contains("when_precondition_is_present"));
                }
            }
        }
    }

    private async Task RunTestCase(JArray instruction, Method method, bool expectSuccess, bool preConditionsPresent = false)
    {
        var resources = await CreateStorageResources(method);
        var response = await CreateRetryTestResource(method, instruction);

        bool success = true;
        try
        {
            RunRetryTest(response, resources, preConditionsPresent);
            var updatedResponse = await GetRetryTest(response.Id);
            success = updatedResponse.Completed;
        }
        catch (System.Exception)
        {
            success = false;
        }

        Assert.Equal(expectSuccess, success);

        // Delete the retry test and delete Storage Resource as well.
        await DeleteRetryTest(response.Id);
    }

    private async Task<TestResponse> CreateRetryTestResource(Method method, JArray instruction)
    {
        var stringContent = GetBodyContent(method.Name, instruction);
        HttpResponseMessage response = await _httpClient.PostAsync("retry_test", stringContent);
        response.EnsureSuccessStatusCode();
        var responseMessage = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<TestResponse>(responseMessage);
    }

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

    private StorageClient InitializeClient()
    {
        var clientBuilder = new StorageClientBuilder
        {
            BaseUri = TestBenchUrl + "storage/v1/"
        };

        return clientBuilder.Build();
    }

    private void CreateMethodMapping(RetryTest test)
    {
        foreach (var method in test.Methods)
        {
            _methodMappings.TryAdd(method.Name, GetMappedFunction(method.Name));
        }
    }

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

    private async Task<TestResponse> GetRetryTest(string id)
    {
        HttpResponseMessage response = await _httpClient.GetAsync($"retry_test/{id}");
        response.EnsureSuccessStatusCode();
        var responseMessage = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<TestResponse>(responseMessage);
    }

    private async Task DeleteRetryTest(string id)
    {
        HttpResponseMessage response = await _httpClient.DeleteAsync($"retry_test/{id}");
        response.EnsureSuccessStatusCode();
    }

    private async Task<StorageResources> CreateStorageResources(Method method)
    {
        var result = new StorageResources();

        string bucket = IdGenerator.FromGuid();
        string objectName = "TestFile.json";
        foreach (var item in method.Resources)
        {
            if (item.ToString().Equals("BUCKET", StringComparison.OrdinalIgnoreCase))
            {
                var created = await CreateBucket(ProjectId, bucket);
                if (created)
                {
                    result.Add(new StorageResource(Resource.Bucket, bucket));
                }
            }

            if (item.ToString().Equals("HMACKEY", StringComparison.OrdinalIgnoreCase))
            {
                var createdHmac = await CreateHmacKey(ProjectId);
                if (createdHmac)
                {
                    result.Add(new StorageResource(Resource.HmacKey, _hmacSecret));
                }
            }

            if (item.ToString().Equals("NOTIFICATION", StringComparison.OrdinalIgnoreCase))
            {
                var created = await CreateNotification(ProjectId, bucket);
                if (created)
                {
                    result.Add(new StorageResource(Resource.Notification, _notificationId));
                }
            }

            //TODO: Get the creation of object working
            if (item.ToString().Equals("OBJECT", StringComparison.OrdinalIgnoreCase))
            {
                using var stream = File.OpenRead(FilePath);
                var objectCreated = _storageClient.UploadObject(bucket, objectName, "application/json", stream);
                result.Add(new StorageResource(Resource.Object, objectCreated.Name));
            }
        }
        return result;
    }

    private async Task<bool> CreateBucket(string projectId, string bucket)
    {
        var content = new StringContent($"{{\"name\":\"{bucket}\"}}");
        var response = await _httpClient.PostAsync($"storage/v1/b?project={projectId}", content);
        return response.IsSuccessStatusCode;
    }

    private async Task<bool> CreateHmacKey(string projectId)
    {
        var _serviceAccountEmail = _storageClient.GetStorageServiceAccountEmail(projectId);
        var content = new StringContent("");
        var response = await _httpClient.PostAsync($"storage/v1/projects/proj/hmacKeys?project={projectId}&serviceAccountEmail={_serviceAccountEmail}", content);
        var payload = response.Content.ReadAsStringAsync();
        var metadata = JObject.Parse(payload.Result)["metadata"];
        AccessId = metadata["accessId"].ToString();

        _hmacSecret = JObject.Parse(payload.Result)["secret"].ToString();
        return response.IsSuccessStatusCode;
    }

    private async Task<bool> CreateNotification(string projectId, string bucket)
    {
        var content = new StringContent("{\"payload_format\":\"NONE\",\"topic\":\"projects/" + projectId + "/topics/{" + Topic + "}\"}");
        var response = await _httpClient.PostAsync($"storage/v1/b/{bucket}/notificationConfigs?project={projectId}", content);

        var payload = response.Content.ReadAsStringAsync();
        _notificationId = JObject.Parse(payload.Result)["id"].ToString();
        return response.IsSuccessStatusCode;
    }

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

    private void AddRetryIdHeader(string id)
    {
        AddHeader("x-retry-test-id", id);
    }

    private static StringContent GetBodyContent(string methodName, JArray instruction)
    {
        if (string.IsNullOrWhiteSpace(methodName) || instruction == null)
        {
            return null;
        }
        JObject payload = new JObject();
        payload.Add(methodName, instruction);
        JObject body = new JObject();
        body.Add("instructions", payload);

        return new StringContent(body.ToString(), Encoding.UTF8, "application/json");
    }

    private static string GetEnvironmentVariableOrDefault(string name, string defaultValue)
    {
        string value = Environment.GetEnvironmentVariable(name);
        return string.IsNullOrEmpty(value) ? defaultValue : value;
    }
}
