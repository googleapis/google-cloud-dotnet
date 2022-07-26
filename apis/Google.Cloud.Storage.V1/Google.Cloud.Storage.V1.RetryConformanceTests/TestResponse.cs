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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Google.Cloud.Storage.V1.RetryConformanceTests
{
    internal class TestResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        // TODO: Make this property clean and better. This is a quick hack to get the Instructions.

        [JsonExtensionData]
        public IDictionary<string, JToken> Instructions { get; set; } = new Dictionary<string, JToken>();

        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }
}
