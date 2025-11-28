// Copyright 2019 Google LLC
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

using Google.Apis.Auth.OAuth2;
using Google.Cloud.ClientTesting;
using System.IO;

namespace Google.Cloud.Storage.V1.Tests.Conformance
{
    /// <summary>
    /// Simple centralized access to the conformance test data.
    /// </summary>
    public static class StorageConformanceTestData
    {
        /// <summary>
        /// The service account credential used in conformance tests.
        /// </summary>
        public static ServiceAccountCredential TestCredential { get; }

        /// <summary>
        /// All conformance tests.
        /// </summary>
        public static ConformanceTestData<TestFile> TestData { get; }

        static StorageConformanceTestData()
        {
            TestData = ConformanceTestData.Load<TestFile>("storage", "v1");
            var serviceAccountFile = Path.Combine(TestData.DataPath, "test_service_account.not-a-test.json");
            TestCredential = CredentialFactory.FromFile<ServiceAccountCredential>(serviceAccountFile);
        }
    }
}
