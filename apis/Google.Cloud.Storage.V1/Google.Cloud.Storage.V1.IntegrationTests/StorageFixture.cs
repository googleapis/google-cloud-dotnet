// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Storage.v1.Data;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// This creates new buckets with test data, and deletes them at the end of the test.
    /// The Google Cloud Project name is fetched from the TEST_PROJECT environment variable.
    /// </summary>
    [CollectionDefinition(nameof(StorageFixture))]
    [FileLoggerBeforeAfterTest]
    public sealed class StorageFixture : CloudProjectFixtureBase, ICollectionFixture<StorageFixture>
    {
        internal const string CrossLanguageTestBucket = "storage-library-test-bucket";

        private const string RequesterPaysProjectEnvironmentVariable = "REQUESTER_PAYS_TEST_PROJECT";
        private const string RequesterPaysCredentialsEnvironmentVariable = "REQUESTER_PAYS_CREDENTIALS";
        public const string DelayTestSuffix = "_InitDelayTest";

        private static TypeInfo _delayTestsTypeBeingRegistered;

        /// <summary>
        /// Name of a bucket which already exists, but has no canned data. Mostly used
        /// for creating objects.
        /// </summary>
        public string InitiallyEmptyBucket => BucketPrefix + "-empty";

        /// <summary>
        /// Name of a bucket which already exists, has no canned data, but has soft delete protection
        /// for 24 hours.
        /// </summary>
        public string SoftDeleteBucket => BucketPrefix + "-soft-delete";

        /// <summary>
        /// Name of a bucket with hierarchical namespace enabled
        /// </summary>
        public string HnsBucket => BucketPrefix + "-hns";

        /// <summary>
        /// A small amount of content. Do not mutate the array.
        /// </summary>
        public byte[] SmallContent { get; } = Encoding.UTF8.GetBytes("hello, world");

        /// <summary>
        /// A large amount of content (more than 10K). Do not mutate the array.
        /// </summary>
        public byte[] LargeContent { get; }

        /// <summary>
        /// Bucket without versioning enabled, which tests can write to.
        /// </summary>
        public string SingleVersionBucket => BucketPrefix + "single";
        /// <summary>
        /// Bucket with versioning enabled, which tests can write to.
        /// </summary>
        public string MultiVersionBucket => BucketPrefix + "multi";

        /// <summary>
        /// Bucket to be used for requester-pays testing, or null if requester-pays is not configured.
        /// </summary>
        public string RequesterPaysBucket { get; }
        /// <summary>
        /// Project ID of the requester-pays bucket, or null if requester-pays is not configured.
        /// (This may be removable later, when we don't need to specify it in options.)
        /// </summary>
        private string RequesterPaysProjectId { get; }
        /// <summary>
        /// Storage client set up with requester-pays credentials, or null if requester-pays is not configured.
        /// </summary>
        private StorageClient RequesterPaysClient { get; }

        /// <summary>
        /// Bucket which tests should *not* write to, so that tests can
        /// rely on the precise contents. This bucket supports multiple versions.
        /// </summary>
        public string ReadBucket => BucketPrefix + "testsonlyread";

        public string BucketPrefix { get; }

        public StorageClient Client { get; }

        /// <summary>
        /// Name of an object populated in <see cref="ReadBucket"/> with <see cref="SmallContent"/>.
        /// </summary>
        public string SmallObject { get; } = "small.txt";

        /// <summary>
        /// Name of an object populated in <see cref="ReadBucket"/> with <see cref="LargeContent"/>.
        /// </summary>
        public string LargeObject { get; } = "large.txt";

        /// <summary>
        /// Name of an object in <see cref="ReadBucket"/> with a first version containing
        /// <see cref="SmallContent"/> and a second version containing <see cref="LargeContent"/>.
        /// </summary>
        public string SmallThenLargeObject { get; } = "small_then_large.txt";

        /// <summary>
        /// Gets an HTTP client that can be used to make requests during a test.
        /// </summary>
        public HttpClient HttpClient { get; } = new HttpClient();

        /// <summary>
        /// Gets a <see cref="UrlSigner"/> instance which can be used for testing.
        /// </summary>
        public UrlSigner UrlSigner { get; } =
            UrlSigner.FromCredential(GoogleCredential.GetApplicationDefault());

        public IEnumerable<string> ReadBucketObjects => new[] { SmallObject, LargeObject, SmallThenLargeObject }.Concat(s_objectsInFolders);

        /// <summary>
        /// Name of the only test-related bucket beginning with z. (For easy listing tests.)
        /// </summary>
        public string BucketBeginningWithZ => BucketPrefix + "zbucketname";

        public string LabelsTestBucket => BucketPrefix + "labels";

        /// <summary>
        /// Returns all the known buckets that have been created for this test run.
        /// (This includes any buckets created by <see cref="CreateBucket"/> or registered
        /// with <see cref="RegisterBucketToDelete(string)"/>).
        /// </summary>
        public IEnumerable<string> AllBuckets => _bucketsToDelete;

        private static readonly string[] s_objectsInFolders = { "a/o1.txt", "a/o2.txt", "a/x/o3.txt", "a/x/o4.txt", "b/o5.txt" };

        private readonly List<string> _bucketsToDelete = new List<string>();

        private readonly HashSet<string> _classesWithDelayTests = new HashSet<string>();
        private readonly Dictionary<string, DelayTestInfo> _delayTests = new Dictionary<string, DelayTestInfo>();
        private bool _delayTestsNeedToStart;

        public StorageFixture()
        {
            Client = StorageClient.Create();
            BucketPrefix = IdGenerator.FromDateTime(prefix: "tests-", suffix: "-");
            LargeContent = Encoding.UTF8.GetBytes(string.Join("\n", Enumerable.Repeat("All work and no play makes Jack a dull boy.", 500)));
            CreateBucket(SingleVersionBucket, multiVersion: false);
            CreateBucket(MultiVersionBucket, multiVersion: true);
            CreateAndPopulateReadBucket();
            CreateBucket(BucketBeginningWithZ, multiVersion: false);
            CreateBucket(LabelsTestBucket, multiVersion: false);
            CreateBucket(InitiallyEmptyBucket, multiVersion: false);
            CreateBucket(SoftDeleteBucket, multiVersion: false, softDelete: true);
            CreateBucket(HnsBucket, multiVersion: false, hnsEnabled: true);

            RequesterPaysClient = CreateRequesterPaysClient();
            if (RequesterPaysClient != null)
            {
                RequesterPaysProjectId = Environment.GetEnvironmentVariable(RequesterPaysProjectEnvironmentVariable);
                if (string.IsNullOrEmpty(RequesterPaysProjectId))
                {
                    throw new Exception($"{RequesterPaysCredentialsEnvironmentVariable} set, but not {RequesterPaysProjectEnvironmentVariable}");
                }

                RequesterPaysBucket = CreateRequesterPaysBucket();
            }

            // Clean up any HMAC keys left over previous runs.
            PurgeHmacKeys();
        }

        private static StorageClient CreateRequesterPaysClient()
        {
            string file = Environment.GetEnvironmentVariable(RequesterPaysCredentialsEnvironmentVariable);
            if (string.IsNullOrEmpty(file))
            {
                return null;
            }
            var credential = GoogleCredential.FromFile(file);
            return StorageClient.Create(credential);
        }

        private string CreateRequesterPaysBucket()
        {
            string name = IdGenerator.FromDateTime(prefix: "dotnet-requesterpays-");
            CreateBucket();
            AddServiceAccountBinding();
            CreateObject();
            return name;

            // Adds the service account associated with the application default credentials as a writer for the bucket.
            // Note: this assumes the default credentials *are* a service account. If we've got a compute credential,
            // this will cause a problem - but in reality, our tests always run with a service account.
            void AddServiceAccountBinding()
            {
                var credential = (ServiceAccountCredential) GoogleCredential.GetApplicationDefault().UnderlyingCredential;
                string serviceAccountEmail = credential.Id;

                var policy = RequesterPaysClient.GetBucketIamPolicy(name,
                    new GetBucketIamPolicyOptions { UserProject = RequesterPaysProjectId });
                // Note: we assume there are no conditions in the policy, as we've only just created the bucket.
                var writerRole = "roles/storage.objectAdmin";
                Policy.BindingsData writerBinding = null;
                foreach (var binding in policy.Bindings)
                {
                    if (binding.Role == writerRole)
                    {
                        writerBinding = binding;
                        break;
                    }
                }
                if (writerBinding == null)
                {
                    writerBinding = new Policy.BindingsData { Role = writerRole, Members = new List<string>() };
                    policy.Bindings.Add(writerBinding);
                }
                writerBinding.Members.Add($"serviceAccount:{serviceAccountEmail}");
                RequesterPaysClient.SetBucketIamPolicy(name, policy,
                    new SetBucketIamPolicyOptions { UserProject = RequesterPaysProjectId });
            }

            void CreateBucket()
            {
                RequesterPaysClient.CreateBucket(RequesterPaysProjectId,
                    new Bucket { Name = name, Billing = new Bucket.BillingData { RequesterPays = true } });
                SleepAfterBucketCreateDelete();
            }

            void CreateObject()
            {
                RequesterPaysClient.UploadObject(name, SmallObject, "text/plain", new MemoryStream(SmallContent),
                    new UploadObjectOptions { UserProject = RequesterPaysProjectId });
            }

        }

        internal Bucket CreateBucket(string name, bool multiVersion, bool softDelete = false, bool registerForDeletion = true, bool hnsEnabled = false)
        {
            var bucket = Client.CreateBucket(ProjectId,
                new Bucket
                {
                    Name = name,
                    Versioning = new Bucket.VersioningData { Enabled = multiVersion },
                    // The minimum allowed for soft delete is 7 days.
                    SoftDeletePolicy = softDelete ? new Bucket.SoftDeletePolicyData { RetentionDurationSeconds = (int) TimeSpan.FromDays(7).TotalSeconds } : null,
                    IamConfiguration = hnsEnabled ? new Bucket.IamConfigurationData
                    {
                        UniformBucketLevelAccess = new Bucket.IamConfigurationData.UniformBucketLevelAccessData { Enabled = true }
                    } : null,
                    HierarchicalNamespace = hnsEnabled ? new Bucket.HierarchicalNamespaceData { Enabled = true } : null,
                });
            SleepAfterBucketCreateDelete();
            if (registerForDeletion)
            {
                RegisterBucketToDelete(name);
            }
            return bucket;
        }

        internal string GenerateBucketName() => IdGenerator.FromGuid(prefix: BucketPrefix, separator: "", maxLength: 63);

        private void CreateAndPopulateReadBucket()
        {
            CreateBucket(ReadBucket, true);
            Client.UploadObject(ReadBucket, SmallObject, "text/plain", new MemoryStream(SmallContent));
            Client.UploadObject(ReadBucket, LargeObject, "text/plain", new MemoryStream(LargeContent));
            Client.UploadObject(ReadBucket, SmallThenLargeObject, "text/plain", new MemoryStream(SmallContent));
            Client.UploadObject(ReadBucket, SmallThenLargeObject, "text/plain", new MemoryStream(LargeContent));
            foreach (var name in s_objectsInFolders)
            {
                Client.UploadObject(ReadBucket, name, "text/plain", new MemoryStream(SmallContent));
            }
        }

        /// <summary>
        /// Bucket creation/deletion is rate-limited. To avoid making the tests flaky, we sleep after each operation.
        /// </summary>
        internal static void SleepAfterBucketCreateDelete() => Thread.Sleep(2000);

        internal void RegisterBucketToDelete(string bucket) => _bucketsToDelete.Add(bucket);

        internal void UnregisterBucket(string bucket) => _bucketsToDelete.Remove(bucket);

        internal Task EventuallyAsync(TimeSpan delayUntilGuaranteedConsistency, Action action) =>
            EventuallyAsync(delayUntilGuaranteedConsistency, () =>
            {
                action();
                return Task.CompletedTask;
            });

        internal async Task EventuallyAsync(TimeSpan delayUntilGuaranteedConsistency, Func<Task> action)
        {
            // We don't want to continue retrying past this point in time
            // as that's meant to be the time for the change to be eventually consistent.
            DateTimeOffset shouldSucceedAfter = DateTimeOffset.UtcNow + delayUntilGuaranteedConsistency;

            // Initial backoff is 10% of the guaranteed success delay.
            // Max backoff is 60% of the guaranteed success delay.
            int backoffMs = (int) delayUntilGuaranteedConsistency.TotalMilliseconds / 10;
            int maxBackoffMs = 6 * backoffMs;

            bool retry;
            do
            {
                // We continue to retry until we are certain we have retried at least once past the
                // guaranteed success delay.
                retry = DateTimeOffset.UtcNow <= shouldSucceedAfter;
                try
                {
                    await action();
                    // The operation was successful we don't need to retry further.
                    retry = false;
                }
                catch (Exception) when (retry)
                {
                    await Task.Delay(backoffMs);
                    backoffMs = Math.Max(2 * backoffMs, maxBackoffMs);
                }

            } while (retry);
        }

        internal async Task FinishDelayTest(string testName)
        {
            DelayTestInfo currentTestInfo;
            GaxPreconditions.CheckState(_delayTests.TryGetValue(testName, out currentTestInfo), $"{testName} was not registered or was finalized twice.");

            if (_delayTestsNeedToStart)
            {
                _delayTestsNeedToStart = false;
                foreach (var testInfo in _delayTests.Values)
                {
                    await testInfo.StartTest();
                }
            }

            currentTestInfo.OnTestFinalizing();
            // Add some additional delay just in case there is a minor difference in times between
            // this machine and the server.
            var resolvedExpiration = currentTestInfo.DelayExpiration.Value + TimeSpan.FromSeconds(3);
            var now = DateTimeOffset.UtcNow;
            if (now < resolvedExpiration)
            {
                await Task.Delay(resolvedExpiration - now);
            }

            await currentTestInfo.AfterDelayAction();
            _delayTests.Remove(testName);
        }

        internal void RegisterDelayTests(object testClass)
        {
            try
            {
                GaxPreconditions.CheckState(_delayTestsTypeBeingRegistered == null, "We should not be recursively registering delay tests.");
                _delayTestsTypeBeingRegistered = testClass.GetType().GetTypeInfo();
                if (_classesWithDelayTests.Add(_delayTestsTypeBeingRegistered.FullName))
                {
                    var testMethodInits = from method in _delayTestsTypeBeingRegistered.DeclaredMethods
                                          where method.IsPrivate && method.Name.EndsWith(DelayTestSuffix)
                                          select method;
                    foreach (var testMethodInit in testMethodInits)
                    {
                        testMethodInit.Invoke(testClass, null);
                    }
                }
            }
            finally
            {
                _delayTestsTypeBeingRegistered = null;
            }
        }

        internal void RegisterDelayTest(TimeSpan duration, Func<TimeSpan, Task> beforeDelay, Func<Task> afterDelay, [CallerMemberName] string initMethodName = null)
        {
            GaxPreconditions.CheckArgument(
                initMethodName.EndsWith(StorageFixture.DelayTestSuffix),
                initMethodName,
                $"The delay test initialization method name must end with {StorageFixture.DelayTestSuffix}");

            var methodName = initMethodName.Substring(0, initMethodName.Length - StorageFixture.DelayTestSuffix.Length);
            var testName = $"{_delayTestsTypeBeingRegistered.Name}.{methodName}";
            GaxPreconditions.CheckState(!_delayTests.ContainsKey(testName), $"{testName} was registered twice");
            GaxPreconditions.CheckState(
                _delayTestsTypeBeingRegistered.GetDeclaredMethod(methodName) != null,
                $"There is no test named {testName} representing the delay test.");
            GaxPreconditions.CheckState(
                _delayTestsTypeBeingRegistered.GetDeclaredMethod(methodName).GetCustomAttribute(typeof(FactAttribute)) != null,
                $"{testName} must have the {nameof(FactAttribute)} attribute.");

            _delayTests.Add(testName, new DelayTestInfo(duration, beforeDelay, afterDelay));
            _delayTestsNeedToStart = true;
        }

        public override void Dispose()
        {
            var client = StorageClient.Create();
            foreach (var bucket in _bucketsToDelete)
            {
                DeleteBucket(client, bucket, null);
            }
            if (RequesterPaysBucket != null)
            {
                DeleteBucket(RequesterPaysClient, RequesterPaysBucket, RequesterPaysProjectId);
            }
            PurgeHmacKeys();
        }

        private void DeleteBucket(StorageClient client, string bucket, string userProject)
        {
            try
            {
                client.DeleteBucket(bucket, new DeleteBucketOptions { UserProject = userProject, DeleteObjects = true });
            }
            catch (GoogleApiException)
            {
                // Some tests fail to delete buckets due to object retention locks etc.
                // They can be cleaned up later.
            }
            SleepAfterBucketCreateDelete();
        }

        /// <summary>
        /// Sets the labels on <see cref="LabelsTestBucket"/> without using any of the client *Labels methods.
        /// Any old labels are wiped.
        /// </summary>
        public void SetUpLabels(Dictionary<string, string> labels, [CallerMemberName] string callerName = null)
        {
            // Just avoid mutating the parameter...
            labels = new Dictionary<string, string>(labels);
            var oldLabels = Client.GetBucket(LabelsTestBucket).Labels ?? new Dictionary<string, string>();
            foreach (var key in oldLabels.Keys.Except(labels.Keys))
            {
                labels[key] = null;
            }

            FileLogger.Log($"Starting patching {LabelsTestBucket} by {callerName}.");
            Client.PatchBucket(new Bucket { Name = LabelsTestBucket, Labels = labels });
            FileLogger.Log($"Finished patching {LabelsTestBucket} by {callerName}.");

            SleepAfterBucketCreateDelete();
        }

        /// <summary>
        /// Clears the labels on <see cref="LabelsTestBucket"/> without using any of the client *Labels methods.
        /// </summary>
        public void ClearLabels([CallerMemberName] string callerName = null)
        {
            var oldLabels = Client.GetBucket(LabelsTestBucket).Labels ?? new Dictionary<string, string>();
            var cleanLabels = new Dictionary<string, string>();
            foreach (var key in oldLabels.Keys)
            {
                cleanLabels.Add(key, null);
            }

            FileLogger.Log($"Starting clearing labels for {LabelsTestBucket} by {callerName}.");
            Client.PatchBucket(new Bucket { Name = LabelsTestBucket, Labels = cleanLabels });
            FileLogger.Log($"Finished clearing labels for {LabelsTestBucket} by {callerName}.");

            SleepAfterBucketCreateDelete();
        }

        private void PurgeHmacKeys()
        {
            var keys = Client.ListHmacKeys(ProjectId).ToList();
            foreach (var key in keys)
            {
                if (key.State != HmacKeyStates.Inactive)
                {
                    key.State = HmacKeyStates.Inactive;
                    Client.UpdateHmacKey(key);
                }
                Client.DeleteHmacKey(ProjectId, key.AccessId);
            }
        }

        private class DelayTestInfo
        {
            private ExceptionDispatchInfo _exceptionDispatchInfo;

            public DateTimeOffset? DelayExpiration { get; private set; }
            public Func<Task> AfterDelayAction { get; }
            public Func<TimeSpan, Task> BeforeDelayTask { get; }
            public TimeSpan Duration { get; }

            public DelayTestInfo(TimeSpan duration, Func<TimeSpan, Task> beforeDelayTask, Func<Task> afterDelayAction)
            {
                AfterDelayAction = afterDelayAction;
                BeforeDelayTask = beforeDelayTask;
                Duration = duration;
            }

            public async Task StartTest()
            {
                if (DelayExpiration == null)
                {
                    try
                    {
                        await BeforeDelayTask(Duration);
                    }
                    catch (Exception ex)
                    {
                        _exceptionDispatchInfo = ExceptionDispatchInfo.Capture(ex);
                    }
                    DelayExpiration = DateTimeOffset.UtcNow + Duration;
                }
            }

            public void OnTestFinalizing()
            {
                Debug.Assert(DelayExpiration != null, "A delay test is finalizing before being started.");
                if (_exceptionDispatchInfo != null)
                {
                    _exceptionDispatchInfo.Throw();
                }
            }
        }
    }
}
