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
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.RetryConformanceTests
{
    public class RetryConformanceTest
    {
        public static TheoryData<RetryTest> RetryTestData { get; } = StorageConformanceTestData.TestData.GetTheoryData(f => f.RetryTests);

        //TODO: Use a non CloudRun environment link as Cloud Run isn't recommended due to various issues.
        internal static string TestBenchUrl { get; } = GetEnvironmentVariableOrDefault("TEST_BENCH_URL", "https://storage-testbench-vkcain7hhq-el.a.run.app/");

        internal static string ProjectId { get; } = GetEnvironmentVariableOrDefault("PROJECT_ID", "test");

        internal string ServiceAccountEmail { get; } = GetEnvironmentVariableOrDefault("SERVICE_ACCOUNT_EMAIL", "test-service-account@test.iam.gserviceaccount.com");

        internal string Topic { get; } = GetEnvironmentVariableOrDefault("TOPIC", "test-topic");

        internal string AccessId { get; set; }

        internal string FilePath { get; } = Path.Combine(StorageConformanceTestData.TestData.DataPath, "test_service_account.not-a-test.json");

        private readonly StorageClient _storageClient;

        private readonly HttpClient _httpClient;

        private static readonly System.Type s_clientType = typeof(StorageClient);

        private readonly ConcurrentDictionary<string, MethodInvocation> _methodMappings;

        //internal string hmacKey;
        internal string hmacSecret;
        internal string notificationId;

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
            // Create a dictionary which maps method names with the Storage client delegate to be called.
            // May need to adjust based on wider set of methods.
            CreateMethodMapping(test);
            bool expectSuccess = test.ExpectSuccess;
            foreach (InstructionList testCase in test.Cases)
            {
                foreach (string instruction in testCase.Instructions)
                {
                    foreach (Method method in test.Methods)
                    {
                        // TODO: Remove this if condition, when the mapping dictionary is completely and correctly populated.

                        //if (method.Name.Contains("storage.buckets.testIamPermissions") || method.Name.Contains("storage.buckets.lockRetentionPolicy"))
                        //if (method.Name.Contains("storage.objects.get") || method.Name.Contains("storage.objects.list"))
                       // if (method.Name.Contains("storage.hmacKey.get"))

                         if (method.Name.Contains("storage.notifications.list"))
                        {
                            await RunTestCase(instruction, method, expectSuccess);
                        }
                    }
                }
            }
        }

        private async Task RunTestCase(string instruction, Method method, bool expectSuccess)
        {
            // method.resources specifies the resources needed by the test. Create the resource for each scenario.
            var resources = await CreateStorageResources(method);

            // Create retry test resource and read Id from response headers.
            var response = await CreateRetryTestResource(method, instruction);

            bool success = true;
            try
            {
                RunRetryTest(response, resources);
                // TODO:  to check and change the code if  we need another request. I think retry happens automatically.
                // Probably add some delay for retry tests to make sure the testbench has time to process the request.
                var updatedResponse = await GetRetryTest(response.Id);
                success = updatedResponse.Completed;
            }
            catch (System.Exception)
            {
                // Log exception to check the status of each test?
                success = false;
            }

            Assert.Equal(expectSuccess, success);

            // Delete the retry test and delete Storage Resource as well.
            await DeleteRetryTest(response.Id);
        }

        private async Task<TestResponse> CreateRetryTestResource(Method method, string instruction)
        {
            var stringContent = GetBodyContent(method.Name, instruction);
            HttpResponseMessage response = await _httpClient.PostAsync("retry_test", stringContent);
            response.EnsureSuccessStatusCode();
            var responseMessage = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TestResponse>(responseMessage);
        }

        private void RunRetryTest(TestResponse response, StorageResources resources)
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

                if (invocation.ServiceAccountEmailRequired)
                {
                    invocation.ServiceAccountEmail = ServiceAccountEmail;
                }

                if (invocation.NotificationRequired)
                {
                    invocation.Notification = resources.Notification;
                }

                invocation.Invoke(_storageClient);
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
            // TODO: Add all mappings from the json file and throw exception in the default case.
            "storage.buckets.delete" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.DeleteBucket), new System.Type[] { typeof(string), typeof(DeleteBucketOptions) }), false, true, false, false, false, false, false,false),
            "storage.buckets.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetBucket)), false, true, false, false, false, false, false,false),
            "storage.buckets.getiampolicy" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetBucketIamPolicy)), false, true, false, false, false, false, false, false),
            "storage.buckets.insert" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.CreateBucket), new System.Type[] { typeof(string), typeof(string), typeof(CreateBucketOptions) }), true, true, false, false, false, false, false, false),
            "storage.buckets.list" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.ListBuckets)), true, false, false, false, false, false, false, false),
            "storage.buckets.testIamPermissions" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.TestBucketIamPermissions), new System.Type[] { typeof(string), typeof(string), typeof(TestBucketIamPermissionsOptions) }), true, true, false, false, false, false, false, false),
            "storage.buckets.lockRetentionPolicy" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.LockBucketRetentionPolicy), new System.Type[] { typeof(string), typeof(string), typeof(LockBucketRetentionPolicyOptions) }), true, true, false, false, false, false, false, true),

            "storage.objects.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetObject), new System.Type[] { typeof(string), typeof(string), typeof(GetObjectOptions) }), false, true, true, false, false, false, false, false),
            "storage.objects.list" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.ListObjects), new System.Type[] { typeof(string), typeof(string), typeof(ListObjectsOptions) }), false, true, false, false, false, false, false, false),

            "storage.hmackey.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetHmacKey), new System.Type[] { typeof(string), typeof(string), typeof(GetHmacKeyOptions) }), true, false, false, false, false, false, true, false),
            "storage.hmackey.delete" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.DeleteHmacKey), new System.Type[] { typeof(string), typeof(string), typeof(DeleteHmacKeyOptions) }), true, false, false, false, false, false, true, false),
            "storage.hmackey.list" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.ListHmacKeys), new System.Type[] { typeof(string), typeof(string), typeof(ListHmacKeysOptions) }), true, false, false, false, false, false, false, false),

            "storage.notifications.list" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.ListNotifications), new System.Type[] { typeof(string), typeof(string), typeof(ListNotificationsOptions) }), true, false, false,true, false, false, false, false),
            "storage.notifications.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetNotification), new System.Type[] { typeof(string), typeof(string), typeof(GetNotificationOptions) }), false, true, false, true, false, false, false, false),
            "storage.notifications.delete" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.DeleteNotification), new System.Type[] { typeof(string), typeof(string), typeof(DeleteNotificationOptions) }), false, true, false, true, false, false, false, false),

            "storage.serviceaccount.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetStorageServiceAccountEmail), new System.Type[] { typeof(string), typeof(string), typeof(GetStorageServiceAccountEmailOptions) }), true, false, false, false, false, false, false, false),

            // Just to proceed with testing for now.
            _ => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetBucket)), false, true, false, false, false, false, false, false),
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
            string objectName = "TestFile.json"; // Could be any other file name as well.
            // This will ensure that for the given test, object/notification are linked to correct bucket.
            foreach (var item in method.Resources)
            {
                if (item.ToString().Equals("BUCKET", StringComparison.OrdinalIgnoreCase))
                {
                    // Storage Client CreateBucket API CreateBucket(ProjectId, bucket) is failing with test bench.
                    // This is a quick hack to create a bucket in test bench.
                    var created = await CreateBucket(ProjectId, bucket);
                    if (created)
                    {
                        result.Add(new StorageResource(Resource.Bucket, bucket));
                    }
                }

                if (item.ToString().Equals("HMACKEY", StringComparison.OrdinalIgnoreCase))
                {
                    var createdHmac = await CreateHmacKey(ProjectId, ServiceAccountEmail);
                    if (createdHmac)
                    {
                        result.Add(new StorageResource(Resource.HmacKey, hmacSecret));
                    }

                    /*
                    var hmacKey = _storageClient.CreateHmacKey(ProjectId, ServiceAccountEmail);
                    AccessId = hmacKey.Metadata.AccessId;
                    result.Add(new StorageResource(Resource.HmacKey, hmacKey.Secret));
                    */
                }

                if (item.ToString().Equals("NOTIFICATION", StringComparison.OrdinalIgnoreCase))
                {

                    var created = await CreateNotification(ProjectId,bucket);
                    if(created)
                    result.Add(new StorageResource(Resource.Notification, notificationId));


                    /*
                    var config = new Notification { Topic = $"//pubsub.googleapis.com/{Topic}", PayloadFormat = "JSON_API_V1" };
                    var notification = _storageClient.CreateNotification(bucket, config);
                    result.Add(new StorageResource(Resource.Notification, notification.Id));
                    */
                }

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

        private async Task<bool> CreateHmacKey(string projectId, string serviceAccountEmail)
        {
            var content = new StringContent("");
            var response = await _httpClient.PostAsync($"storage/v1/projects/proj/hmacKeys?project={projectId}&serviceAccountEmail={serviceAccountEmail}", content);
            var payload = response.Content.ReadAsStringAsync().Result;
            var metadata = JObject.Parse(payload)["metadata"];
            AccessId = metadata["accessId"].ToString();

            hmacSecret = JObject.Parse(payload)["secret"].ToString();
            return response.IsSuccessStatusCode;
        }

        private async Task<bool> CreateNotification(string projectId, string bucket)
        {
            var content = new StringContent("{\"payload_format\":\"NONE\",\"topic\":\"projects/"+projectId+"/topics/{"+ Topic + "}\"}");
            var response = await _httpClient.PostAsync($"storage/v1/b/{bucket}/notificationConfigs?project={projectId}", content);

            var payload = response.Content.ReadAsStringAsync().Result;
            notificationId = JObject.Parse(payload)["id"].ToString();
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

        private static StringContent GetBodyContent(string methodName, string instruction)
        {
            if (string.IsNullOrWhiteSpace(methodName) || string.IsNullOrWhiteSpace(instruction))
            {
                return null;
            }

            StringBuilder builder = new StringBuilder();

            builder.AppendLine(" { ");
            builder.Append("\"instructions\":");
            builder.Append($" {{\"{methodName}\":");
            builder.Append($" [\"{instruction}\"]}}");
            builder.Append(" } ");

            return new StringContent(builder.ToString(), Encoding.UTF8, "application/json");
        }

        private static string GetEnvironmentVariableOrDefault(string name, string defaultValue)
        {
            string value = Environment.GetEnvironmentVariable(name);
            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }
    }
}
