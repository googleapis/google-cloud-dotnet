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


using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using System;
using Xunit;
using static Google.Cloud.Dlp.V2.InfoTypeTransformations.Types;

namespace Google.Cloud.Dlp.V2.Snippets
{
    [SnippetOutputCollector]
    public class DlpServiceClientSnippets
    {
        [Fact]
        public void Intro()
        {
            string projectId = TestEnvironment.GetTestProjectId();
            // Sample: Intro
            DlpServiceClient client = DlpServiceClient.Create();
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                ParentAsProjectName = new ProjectName(projectId),
                Item = new ContentItem
                {
                    Value = "Hi! My phone number is 555-1234-567. Please call me!"
                },
                DeidentifyConfig = new DeidentifyConfig
                {
                    InfoTypeTransformations = new InfoTypeTransformations
                    {
                        Transformations =
                        {
                            new InfoTypeTransformation
                            {
                                PrimitiveTransformation = new PrimitiveTransformation
                                {
                                    ReplaceConfig = new ReplaceValueConfig
                                    {
                                        NewValue = new Value { StringValue = "(Redacted)" }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            DeidentifyContentResponse response = client.DeidentifyContent(request);
            Console.WriteLine(response.Item.Value);
            // End sample
            Assert.Equal("Hi! My phone number is (Redacted). Please call me!", response.Item.Value);
        }
    }
}
