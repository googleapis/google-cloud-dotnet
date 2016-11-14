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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Json;
using Google.Apis.Storage.v1.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Storage.V1.IntegrationTests
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// This creates new buckets with test data, and deletes them at the end of the test.
    /// The Google Cloud Project name is fetched from the TEST_PROJECT environment variable.
    /// </summary>
    [CollectionDefinition(nameof(StorageFixture))]
    public sealed class StorageFixture : IDisposable, ICollectionFixture<StorageFixture>
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";

        /// <summary>
        /// Name of a bucket which already exists, but has no canned data. Mostly used
        /// for creating objects.
        /// </summary>
        public string InitiallyEmptyBucket => BucketPrefix + "-empty";

        /// <summary>
        /// A small amount of content. Do not mutate the array.
        /// </summary>
        public byte[] SmallContent { get; } = Encoding.UTF8.GetBytes("hello, world");

        /// <summary>
        /// A large amount of content (more than 10K). Do not mutate the array.
        /// </summary>
        public byte[] LargeContent { get; }

        public string ProjectId { get; }

        /// <summary>
        /// Bucket without versioning enabled, which tests can write to.
        /// </summary>
        public string SingleVersionBucket => BucketPrefix + "single";
        /// <summary>
        /// Bucket with versioning enabled, which tests can write to.
        /// </summary>
        public string MultiVersionBucket => BucketPrefix + "multi";

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
        /// Gets the path to a service account credentials JSON file.
        /// </summary>
        public string CredentialsFilePath { get; } = GetCredentialsFilePath();

        public IEnumerable<string> ReadBucketObjects => new[] { SmallObject, LargeObject, SmallThenLargeObject }.Concat(s_objectsInFolders);

        /// <summary>
        /// Name of the only test-related bucket beginning with z. (For easy listing tests.)
        /// </summary>
        public string BucketBeginningWithZ => BucketPrefix + "zbucketname";

        /// <summary>
        /// Returns all the known buckets that have been created for this test run.
        /// (This includes any buckets created by <see cref="CreateBucket"/> or registered
        /// with <see cref="RegisterBucketToDelete(string)"/>).
        /// </summary>
        public IEnumerable<string> AllBuckets => _bucketsToDelete;

        private static readonly string[] s_objectsInFolders = { "a/o1.txt", "a/o2.txt", "a/x/o3.txt", "a/x/o4.txt", "b/o5.txt" };

        private readonly List<string> _bucketsToDelete = new List<string>();
        private readonly List<string> _localFilesToDelete = new List<string>();

        private readonly HashSet<string> _classesWithDelayTests = new HashSet<string>();
        private readonly Dictionary<string, DelayTestInfo> _delayTests = new Dictionary<string, DelayTestInfo>();
        private bool _delayTestsNeedToStart;

        public StorageFixture()
        {
            ProjectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            Client = StorageClient.Create();
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }
            BucketPrefix = "tests-" + Guid.NewGuid().ToString().ToLowerInvariant() + "-";
            LargeContent = Encoding.UTF8.GetBytes(string.Join("\n", Enumerable.Repeat("All work and no play makes Jack a dull boy.", 500)));
            CreateBucket(SingleVersionBucket, false);
            CreateBucket(MultiVersionBucket, true);
            CreateAndPopulateReadBucket();
            CreateBucket(BucketBeginningWithZ, false);
        }

        internal void CreateBucket(string name, bool multiVersion)
        {
            Client.CreateBucket(ProjectId, new Bucket { Name = name, Versioning = new Bucket.VersioningData { Enabled = multiVersion } });
            RegisterBucketToDelete(name);
        }

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

        internal void RegisterBucketToDelete(string bucket)
        {
            _bucketsToDelete.Add(bucket);
        }
        
        internal async Task FinishDelayTest(string testName)
        {
            if (_delayTestsNeedToStart)
            {
                _delayTestsNeedToStart = false;
                foreach (var testInfo in _delayTests.Values)
                {
                    await testInfo.StartTest();
                }
            }

            DelayTestInfo currentTestInfo;
            Assert.True(_delayTests.TryGetValue(testName, out currentTestInfo), $"{testName} was not registered or was finalized twice.");

            currentTestInfo.OnTestFinalizing();
            var now = DateTimeOffset.UtcNow;
            if (now < currentTestInfo.DelayExpiration.Value)
            {
                await Task.Delay(currentTestInfo.DelayExpiration.Value - now);
            }

            await currentTestInfo.AfterDelayAction();
            _delayTests.Remove(testName);
        }

        internal void RegisterDelayTests(object testClass)
        {
            var type = testClass.GetType();
            if (_classesWithDelayTests.Add(type.FullName))
            {
                var testMethodInits = from method in type.GetTypeInfo().DeclaredMethods
                                      where method.IsPrivate && method.Name.EndsWith("_InitDelayTest")
                                      select method;
                foreach (var testMethodInit in testMethodInits)
                {
                    testMethodInit.Invoke(testClass, null);
                }
            }
        }
        
        internal void RegisterDelayTest(string testName, TimeSpan duration, Func<TimeSpan, Task> beforeDelay, Func<Task> afterDelay)
        {
            Assert.False(_delayTests.ContainsKey(testName), $"{testName} was registered twice");
            _delayTests.Add(testName, new DelayTestInfo(duration, beforeDelay, afterDelay));
            _delayTestsNeedToStart = true;
        }

        private static string GetCredentialsFilePath()
        {
            // TODO: This is taken and changed slightly from DefaultCredentialProvider. Expose the pieces necessary so we don't need to duplicate logic.
            var credentialFilePath = Environment.GetEnvironmentVariable(CredentialEnvironmentVariable) ?? GetWellKnownCredentialFilePath();
            if (!string.IsNullOrEmpty(credentialFilePath) && File.Exists(credentialFilePath))
            {
                try
                {
                    using (var credentialStream = File.OpenRead(credentialFilePath))
                    {
                        var credentialParameters = NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(credentialStream);
                        if (credentialParameters.Type == JsonCredentialParameters.ServiceAccountCredentialType)
                        {
                            return credentialFilePath;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new InvalidOperationException("Error deserializing JSON credential data.", e);
                }
            }

            throw new InvalidOperationException($"Set the {CredentialEnvironmentVariable} environment variable to a service account credentials JSON file");
        }

        // TODO: Everything below is taking from DefaultCredentialProvider. Try to expose it somehow to we don't need to duplicate logic.

        /// <summary>
        /// Environment variable override which stores the default application credentials file path.
        /// </summary>
        private const string CredentialEnvironmentVariable = "GOOGLE_APPLICATION_CREDENTIALS";

        /// <summary>Well known file which stores the default application credentials.</summary>
        private const string WellKnownCredentialsFile = "application_default_credentials.json";

        /// <summary>Environment variable which contains the Application Data settings.</summary>
        private const string AppdataEnvironmentVariable = "APPDATA";

        /// <summary>Environment variable which contains the location of home directory on UNIX systems.</summary>
        private const string HomeEnvironmentVariable = "HOME";

        /// <summary>GCloud configuration directory in Windows, relative to %APPDATA%.</summary>
        private const string CloudSDKConfigDirectoryWindows = "gcloud";

        /// <summary>GCloud configuration directory on Linux/Mac, relative to $HOME.</summary>
        private static readonly string CloudSDKConfigDirectoryUnix = Path.Combine(".config", "gcloud");

        private static string GetWellKnownCredentialFilePath()
        {
            var appData = Environment.GetEnvironmentVariable(AppdataEnvironmentVariable);
            if (appData != null)
            {
                return Path.Combine(appData, CloudSDKConfigDirectoryWindows, WellKnownCredentialsFile);
            }
            var unixHome = Environment.GetEnvironmentVariable(HomeEnvironmentVariable);
            if (unixHome != null)
            {
                return Path.Combine(unixHome, CloudSDKConfigDirectoryUnix, WellKnownCredentialsFile);
            }
            return Path.Combine(CloudSDKConfigDirectoryWindows, WellKnownCredentialsFile);
        }

        public void Dispose()
        {
            var client = StorageClient.Create();
            foreach (var bucket in _bucketsToDelete)
            {
                var objects = client.ListObjects(bucket, null, new ListObjectsOptions { Versions = true }).ToList();
                foreach (var obj in objects)
                {
                    client.DeleteObject(obj, new DeleteObjectOptions { Generation = obj.Generation });
                }
                client.DeleteBucket(bucket);
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
