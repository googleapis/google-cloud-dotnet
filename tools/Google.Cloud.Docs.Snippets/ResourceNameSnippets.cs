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
using Google.Pubsub.V1;
using System;
using Xunit;

namespace Google.Cloud.Tools.Snippets
{
    public class ResourceNameSnippets
    {
        // Not a test - the hard-coded project doesn't actually exist.
        public void ListTopics()
        {
            // Sample: ListTopics
            var client = PublisherClient.Create();
            var projectName = new ProjectName("petstore");
            var topics = client.ListTopics(projectName);
            foreach (Topic topic in topics)
            {
                // Output would include projects/petstore/topics/offers
                Console.WriteLine(topic.Name);
            }
            // End sample
        }

        [Fact]
        public void FormatResourceName()
        {
            // Sample: FormatResourceName
            string projectId = "petstore";
            string topicId = "offers";
            TopicName topicName = new TopicName(projectId, topicId);
            // The value of topicName is now "projects/petstore/topics/offers"
            // End sample

            Assert.Equal(topicName.ToString(), "projects/petstore/topics/offers");
        }

        [Fact]
        public void ParseResourceName()
        {
            // Sample: ParseResourceName_Index
            string rawTopicName = "projects/petstore/topics/offers";
            TopicName parsedName = TopicName.Parse(rawTopicName);
            string projectId = parsedName.ProjectId;
            string topicId = parsedName.TopicId;

            // The value of projectId is now "petstore"
            // The value of topicId is now "offers"
            // End sample

            Assert.Equal("petstore", projectId);
            Assert.Equal("offers", topicId);
        }        
    }
}
