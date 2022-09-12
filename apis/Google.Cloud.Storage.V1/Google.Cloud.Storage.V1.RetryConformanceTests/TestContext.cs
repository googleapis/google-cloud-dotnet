// Copyright 2022 Google LLC
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

namespace Google.Cloud.Storage.V1.RetryConformanceTests;

/// <summary>
/// Contextual information for a test: buckets, project ID etc.
/// </summary>
internal class TestContext
{
    internal string ProjectId { get; }
    internal string ServiceAccountEmail { get; }

    internal string BucketName { get; set; }
    internal string ObjectName { get; set; }
    internal long ObjectGeneration { get; set; }
    internal string HmacSecret { get; set; }
    internal string HmacAccessId { get; set; }
    internal string NotificationId { get; set; }

    // Just for object rewrite (copy) tests
    internal string DestinationBucketName { get; set; }
    internal string DestinationObjectName { get; set; }

    internal TestContext(string projectId, string serviceAccountEmail)
    {
        ProjectId = projectId;
        ServiceAccountEmail = serviceAccountEmail;
    }
}
