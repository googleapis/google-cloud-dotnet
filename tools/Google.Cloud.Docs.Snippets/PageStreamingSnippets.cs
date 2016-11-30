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
using Google.Cloud.PubSub.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.Tools.Snippets
{
    [Collection(nameof(SnippetFixture))]
    public class PageStreamingSnippets
    {
        private readonly SnippetFixture _fixture;

        public PageStreamingSnippets(SnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void AllResources()
        {
            string projectId = _fixture.ProjectId;
            // Sample: AllResources
            PublisherClient client = PublisherClient.Create();
            ProjectName projectName = new ProjectName(projectId);
            PagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageSize: 3);
            foreach (Topic topic in topics)
            {
                Console.WriteLine(topic.Name);
            }
            // End sample
        }

        [Fact]
        public void Responses()
        {
            string projectId = _fixture.ProjectId;
            // Sample: Responses
            PublisherClient client = PublisherClient.Create();
            ProjectName projectName = new ProjectName(projectId);
            PagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageSize: 3);
            IEnumerable<ListTopicsResponse> topicResponses = topics.AsRawResponses();
            foreach (ListTopicsResponse response in topicResponses)
            {
                Console.WriteLine("Topics in response:");
                foreach (Topic topic in response.Topics)
                {
                    Console.WriteLine($"  {topic.Name}");
                }
                // If you were processing items in batches, you might wish to store this
                // in order to recover from failures. The page token can be passed into the ListTopics method.
                Console.WriteLine($"Next page token: {response.NextPageToken}");
            }
            // End sample
        }

        [Fact]
        public void SingleResponse()
        {
            string projectId = _fixture.ProjectId;
            // Sample: SingleResponse
            PublisherClient client = PublisherClient.Create();
            ProjectName projectName = new ProjectName(projectId);
            PagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageSize: 3);
            IEnumerable<ListTopicsResponse> topicResponses = topics.AsRawResponses();
            // This is just the regular LINQ First() method. The sequence of pages will never be empty,
            // but the page may have no resources.
            ListTopicsResponse firstResponse = topicResponses.First();
            Console.WriteLine("Topics in response:");
            foreach (Topic topic in firstResponse.Topics)
            {
                Console.WriteLine($"  {topic.Name}");
            }
            // If you were processing items in batches, you might wish to store this
            // in order to recover from failures. The page token can be passed into the ListTopics method.
            Console.WriteLine($"Next page token: {firstResponse.NextPageToken}");
            // End sample
        }

        [Fact]
        public void ReadPage()
        {
            string projectId = _fixture.ProjectId;
            string pageTokenFromRequest = "";

            // Sample: ReadPage
            PublisherClient client = PublisherClient.Create();
            ProjectName projectName = new ProjectName(projectId);
            PagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageTokenFromRequest);

            Page<Topic> page = topics.ReadPage(3);
            // In a web application, this would be a matter of including the topics in the web page.
            foreach (Topic topic in page)
            {
                Console.WriteLine(topic.Name);
            }
            // ... and embedding the next page token into a "next page" link.
            Console.WriteLine($"Next page token: {page.NextPageToken}");
            // End sample
        }

    }
}
