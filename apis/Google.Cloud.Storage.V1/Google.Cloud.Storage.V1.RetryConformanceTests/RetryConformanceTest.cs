// Copyright 2022 Google LLC9
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

using Google.Cloud.ClientTesting;
using Google.Cloud.Storage.V1.Tests.Conformance;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.RetryConformanceTests
{
    public class RetryConformanceTest
    {
        public static TheoryData<RetryTest> RetryTestData { get; } = StorageConformanceTestData.TestData.GetTheoryData(f => f.RetryTests);

        internal static string TestBenchUrl { get; } = GetEnvironmentVariableOrDefault("TEST_BENCH_URL", "https://storage-testbench-vkcain7hhq-el.a.run.app/");

        internal static string ProjectId { get; } = GetEnvironmentVariableOrDefault("PROJECT_ID", "test");

        internal string ServiceAccountEmail { get; } = GetEnvironmentVariableOrDefault("SERVICE_ACCOUNT_EMAIL", "test-service-account@test.iam.gserviceaccount.com");

        internal string Topic { get; } = GetEnvironmentVariableOrDefault("TOPIC", "test-topic"); // TODO: See if format is required.

        internal string FilePath { get; } = Path.Combine(StorageConformanceTestData.TestData.DataPath, "test_service_account.not-a-test.json");

        private readonly StorageClient _storageClient;

        private readonly HttpClient _httpClient;

        private static System.Type s_clientType = typeof(StorageClient);

        private readonly ConcurrentDictionary<string, MethodInvocation> _methodMappings;

        public RetryConformanceTest()
        {
            _storageClient = InitializeClient();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(TestBenchUrl)
            };

            _methodMappings = new ConcurrentDictionary<string, MethodInvocation>();
        }

        [Theory, MemberData(nameof(RetryTestData))]
        public void RetryTest(RetryTest test)
        {
            // Create a dictionary which maps method names with the Storage client delegate to be called.
            // May need to adjust based on wider set of methods.
            CreateMethodMapping(test);
            bool preconditionProvided = test.PreconditionProvided;
            bool expectSuccess = test.ExpectSuccess;

            foreach (InstructionList testCase in test.Cases)
            {
                foreach (string instruction in testCase.Instructions)
                {
                    foreach (Method method in test.Methods)
                    {
                        if (method.Name == "storage.hmacKey.get")
                        {                        
                            // TODO: Write your tests here.
                            var resource = CreateStorageResources(method);
                            var meth = GetMappedFunction(method.Name);
                            var funcname = meth.MethodInformation.Name;

                            callBench(funcname);
                        }
                    }
                }
            }
        }

        private async void callBench(string functionName)
        {
            if (functionName.Contains("HmacKey"))
            {
                // ------- QUESTION 1 : How to ensure these execute sequentially.??
                string res = await CreateResource();
                // System.Threading.Thread.Sleep(60000);
                string res2 = await ListRetryResources();

                if (res2.Contains(res))
                {
                    await GetUpdatedStatus(res);
                }
            }
        }

        private async Task GetUpdatedStatus(string resourceId)
        {
            // Use our retry method to be tested here
            _storageClient.Service.HttpClient.DefaultRequestHeaders.Clear();
            _storageClient.Service.HttpClient.DefaultRequestHeaders.Add("x-retry-test-id", resourceId);
            var response = await _storageClient.Service.HttpClient.GetAsync(TestBenchUrl + "storage/v1/b?project=test");
            var result = response.Content.ReadAsStringAsync().Result;
        }

        private async Task<string> ListRetryResources()
        {
            var response = await _storageClient.Service.HttpClient.GetAsync(TestBenchUrl + "retry_tests");
            var result = response.Content.ReadAsStringAsync().Result.ToString();
            return result;
        }

        private async Task<string> CreateResource()
        {
            var data = new StringContent("{\"instructions\":{\"storage.buckets.list\": [\"return-503\"]}}", Encoding.UTF8, "application/json");
            var response = await _storageClient.Service.HttpClient.PostAsync(TestBenchUrl + "retry_test", data);
            var resId = JObject.Parse(response.Content.ReadAsStringAsync().Result.Replace("\\", "")).GetValue("id").ToString();
            return resId;
        }

        private StorageResources CreateStorageResources(Method method)
        {
            var result = new StorageResources();
            foreach(Resource resource in method.Resources)
            {
              /*  if (resource.ToString().Equals("Bucket", StringComparison.OrdinalIgnoreCase))  ---- QUESTION 2: The bucket creation is throwing error
                {
                    var bucket = _storageClient.CreateBucket(ProjectId, Guid.NewGuid().ToString());
                    result.Add(new StorageResource(Resource.Bucket, bucket.Name));
                }
                else */ if(resource.ToString().Equals("HmacKey", StringComparison.OrdinalIgnoreCase))
                {
                    var hmac = _storageClient.CreateHmacKey(ProjectId, ServiceAccountEmail);
                   // _storageClient.CreateNotification();        -----QUESTION 3: Need to pass notification as a parameter .. how to do that?
                    result.Add(new StorageResource(Resource.HmacKey, hmac.ToString()));
                }
               
            }
            return result;
        }

    private StorageClient InitializeClient()
        {
            var clientBuilder = new StorageClientBuilder
            {
                // TODO: Check the url. This is just to demonstrate how to provide the url.
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

        private MethodInvocation GetMappedFunction(string name) => name switch
        {
            // TODO: Add all mappings from the json file.
            
            "storage.buckets.delete" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.DeleteBucket), new System.Type[] { typeof(string), typeof(DeleteBucketOptions) }), false, true, false, false, false),
            "storage.buckets.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetBucket)), false, true, false, false, false),
            "storage.buckets.getIamPolicy" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetBucketIamPolicy)), false, true, false, false, false),
            "storage.buckets.insert" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.CreateBucket), new System.Type[] { typeof(string), typeof(string), typeof(CreateBucketOptions) }), true, true, false, false, false),
           // "storage.buckets.update" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.UpdateBucket), new System.Type[] { typeof(string), typeof(string), typeof(UpdateBucketOptions) }), true, true, false, false, false),   ---- QUESTION 4: Update bucket needs bucket as a parameter.. how to pass that as typeOf() parameter??
            //"storage.buckets.patch" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.PatchBucket), new System.Type[] { typeof(string), typeof(string), typeof(PatchBucketOptions) }), true, true, false, false, false), 
            "storage.buckets.list" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.ListBuckets)), true, false, false, false, false),
            "storage.hmacKey.get" => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetHmacKey), new System.Type[] { typeof(string), typeof(string), typeof(GetHmacKeyOptions) }), false, false, false, false, true,true),
            // Just to proceed with testing for now.
            _ => new MethodInvocation(s_clientType.GetMethod(nameof(StorageClient.GetBucket)), false, true, false, false, false),
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

        private static string GetEnvironmentVariableOrDefault(string name, string defaultValue)
        {
            string value = Environment.GetEnvironmentVariable(name);
            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }
    }

    internal class MethodInvocation
    {
        internal string ProjectId { get; set; }

        internal string BucketName { get; set; }

        internal string ObjectName { get; set; }

        internal string Notification { get; set; }

        internal string HmacKey { get; set; }

        internal MethodInfo MethodInformation { get; set; }

        internal bool ProjectIdRequired { get; }

        internal bool BucketNameRequired { get; }

        internal bool ObjectNameRequired { get; }

        internal bool ServiceAccountEmailRequired { get; }

        internal string ServiceAccountEmail { get; }

        internal bool NotificationRequired { get; }

        internal bool HmacKeyRequired { get; }

        internal object Result { get; private set; }

        public MethodInvocation(MethodInfo methodInfo, bool projectIdRequired, bool bucketNameRequired, bool objectNameRequired, bool notificationRequired, bool hmacKeyRequired, bool serviceAccountEmailRequired=false)
        {
            MethodInformation = methodInfo;
            ProjectIdRequired = projectIdRequired;
            BucketNameRequired = bucketNameRequired;
            ObjectNameRequired = objectNameRequired;
            NotificationRequired = notificationRequired;
            HmacKeyRequired = hmacKeyRequired;
            ServiceAccountEmailRequired = serviceAccountEmailRequired;
        }

        public void Invoke(StorageClient storageClient)
        {
            List<object> arguments = new List<object>();

            var parameters = MethodInformation.GetParameters();
            foreach (var item in parameters)
            {
                if (item.ParameterType == typeof(string) && !item.IsOptional)
                {
                    if (item.Name is "bucket")
                    {
                        arguments.Add(BucketName);
                    }
                    else if (item.Name is "object")
                    {
                        arguments.Add(ObjectName);
                    }
                    else if (item.Name is "project")
                    {
                        arguments.Add(ProjectId);
                    }
                    else if (item.Name is "notification")
                    {
                        arguments.Add(Notification);
                    }
                    else if (item.Name is "hmacKey")
                    {
                        arguments.Add(HmacKey);
                    }
                    else if (item.Name is "serviceAccountEmail")
                    {
                        arguments.Add(ServiceAccountEmail);
                    }
                    else
                    {
                        arguments.Add(System.Type.Missing);
                    }
                }
                else
                {
                    arguments.Add(System.Type.Missing);
                }
            }

            if (MethodInformation.ReturnType != typeof(void))
            {
                Result = MethodInformation.Invoke(storageClient, arguments.ToArray());
            }
            else
            {
                MethodInformation.Invoke(storageClient, arguments.ToArray());
            }
        }
    }

    internal class TestResponse
    {
        public string Id { get; set; }

        public string Instructions { get; set; }

        public bool Completed { get; set; }
    }
}