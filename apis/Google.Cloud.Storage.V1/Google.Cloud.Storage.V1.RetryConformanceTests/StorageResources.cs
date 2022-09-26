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

using Google.Cloud.Storage.V1.Tests.Conformance;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Storage.V1.RetryConformanceTests;

/// <summary>
/// Created to allow multiple resources to be created and sent together for single test cases as well
/// </summary>
internal class StorageResources : List<StorageResource>
{
    internal string BucketName => this.FirstOrDefault(j => j.Resource == Resource.Bucket).Value;

    internal string ObjectName => this.FirstOrDefault(j => j.Resource == Resource.Object).Value;

    internal string HmacKey => this.FirstOrDefault(j => j.Resource == Resource.HmacKey).Value;

    internal string Notification => this.FirstOrDefault(j => j.Resource == Resource.Notification).Value;
}
