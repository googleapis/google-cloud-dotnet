// Copyright 2018 Google LLC
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

using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using Google.Protobuf.WellKnownTypes;
using System;
using Xunit;

namespace Google.Cloud.Asset.V1Beta1.Snippets
{
    [Collection(nameof(AssetFixture))]
    [SnippetOutputCollector]
    public class AssetServiceClientSnippets
    {
        private readonly AssetFixture _fixture;

        public AssetServiceClientSnippets(AssetFixture fixture) =>
            _fixture = fixture;

        [Fact(Skip = "Can't enable the project yet")]
        public void BatchGetAssetsHistory_NoOp()
        {
            // Deliberately not a real snippet at the moment; we'd ideally like something that retrieves
            // an actual asset history...
            AssetServiceClient client = AssetServiceClient.Create();
            var project = new ProjectName(_fixture.ProjectId);
            var request = new BatchGetAssetsHistoryRequest
            {
                ParentAsProjectName = project,
                ContentType = ContentType.Resource,
                ReadTimeWindow = new TimeWindow { StartTime = DateTime.UtcNow.AddDays(-30).ToTimestamp() }
            };
            BatchGetAssetsHistoryResponse response = client.BatchGetAssetsHistory(request);
            Assert.Equal(0, response.Assets.Count);
        }
    }
}
