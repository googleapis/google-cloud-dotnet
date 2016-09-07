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
            string projectName = PublisherClient.FormatProjectName(projectId);
            IPagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageSize: 3);
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
            string projectName = PublisherClient.FormatProjectName(projectId);
            IPagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageSize: 3);
            IResponseEnumerable<ListTopicsResponse, Topic> topicPages = topics.AsPages();
            foreach (ListTopicsResponse page in topicPages)
            {
                Console.WriteLine("Topics in response:");
                foreach (Topic topic in page.Topics)
                {
                    Console.WriteLine($"  {topic.Name}");
                }
                // If you were processing items in batches, you might wish to store this
                // in order to recover from failures. The page token can be passed into the ListTopics method.
                Console.WriteLine($"Next page token: {page.NextPageToken}");
            }
            // End sample
        }

        [Fact]
        public void SingleResponse()
        {
            string projectId = _fixture.ProjectId;
            // Sample: SingleResponse
            PublisherClient client = PublisherClient.Create();
            string projectName = PublisherClient.FormatProjectName(projectId);
            IPagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageSize: 3);
            IResponseEnumerable<ListTopicsResponse, Topic> topicPages = topics.AsPages();
            // This is just the regular LINQ First() method. The sequence of pages will never be empty,
            // but the page may have no resources.
            ListTopicsResponse firstPage = topicPages.First();
            Console.WriteLine("Topics in response:");
            foreach (Topic topic in firstPage.Topics)
            {
                Console.WriteLine($"  {topic.Name}");
            }
            // If you were processing items in batches, you might wish to store this
            // in order to recover from failures. The page token can be passed into the ListTopics method.
            Console.WriteLine($"Next page token: {firstPage.NextPageToken}");
            // End sample
        }

        [Fact]
        public void WithFixedSize()
        {
            string projectId = _fixture.ProjectId;
            string pageTokenFromRequest = "";

            // Sample: WithFixedSize
            PublisherClient client = PublisherClient.Create();
            string projectName = PublisherClient.FormatProjectName(projectId);
            IPagedEnumerable<ListTopicsResponse, Topic> topics = client.ListTopics(projectName, pageTokenFromRequest);

            IEnumerable<FixedSizePage<Topic>> fixedSizePages = topics.AsPages().WithFixedSize(3);
            // With fixed size pages, if there are no more resources, there are no more pages.
            FixedSizePage<Topic> nextPage = fixedSizePages.FirstOrDefault();
            if (nextPage != null)
            {
                // In a web application, this would be a matter of including the topics in the web page.
                foreach (Topic topic in nextPage)
                {
                    Console.WriteLine(topic.Name);
                }
                // ... and embedding the next page token into a "next page" link.
                Console.WriteLine($"Next page token: {nextPage.NextPageToken}");
            }
            // End sample
        }

    }
}
