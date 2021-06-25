// Copyright 2021 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.AIPlatform.V1.Schema.TrainingJob.Definition;
using Google.Cloud.ClientTesting;
using System;
using Xunit;

namespace Google.Cloud.AIPlatform.V1.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(AIPlatformFixture))]
    public class ReadmeSnippets
    {
        private readonly AIPlatformFixture _fixture;

        public ReadmeSnippets(AIPlatformFixture fixture) =>
            _fixture = fixture;

            [Fact]
        public void Endpoint()
        {
            string projectId = _fixture.ProjectId;
            // Sample: Endpoint
            string region = "us-central1";
            DatasetServiceClient client = new DatasetServiceClientBuilder
            {
                Endpoint = $"{region}-aiplatform.googleapis.com"
            }.Build();

            LocationName location = new LocationName(projectId, region);
            PagedEnumerable<ListDatasetsResponse, Dataset> datasets = client.ListDatasets(location);
            foreach (Dataset dataset in datasets)
            {
                Console.WriteLine(dataset.Name);
            }
            // End sample
        }

        [Fact]
        public void MessageToValue()
        {
            // Sample: MessageToValue
            AutoMlImageClassificationInputs inputs = new AutoMlImageClassificationInputs
            {
                ModelType = AutoMlImageClassificationInputs.Types.ModelType.Cloud,
                BaseModelId = "model-id",
                // Other properties
            };
            TrainingPipeline pipeline = new TrainingPipeline
            {
                TrainingTaskInputs = ValueConverter.ToValue(inputs)
            };
            // Use pipeline in API calls such as PipelineServiceClient.CreateTrainingPipeline.
            // End sample
        }
    }
}
