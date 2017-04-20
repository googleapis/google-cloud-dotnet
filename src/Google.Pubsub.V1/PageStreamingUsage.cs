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

using System;
using System.Linq;

namespace Google.Pubsub.V1
{
    public class PageStreamingUsage
    {
        // We could have a different method for this if we wanted, but it does work out nicely...
        static void GetOnePage()
        {
            var client = PublisherClient.Create();
            // This will never throw - there's always one page, even if it's empty.
            ListTopicsResponse response = client.ListTopicsStreamed("project", "page_token").First();
            foreach (var topic in response)
            {
                Console.WriteLine($"My topic is {topic.Name}");
            }
        }

        static void JustProcessEverything()
        {
            var client = PublisherClient.Create();
            foreach (var topic in client.ListTopicsStreamed("project").Flatten())
            {
                Console.WriteLine($"My topic is {topic.Name}");
            }
        }
        // How do we capture the query parameters?
        static void UseTheSimplePages()
        {
            var client = PublisherClient.Create();
            foreach (var page in client.ListTopicsStreamed("project"))
            {
                Console.WriteLine($"Currently looking at page with next token {page.NextPageToken}");
                // Note: can look at other properties of the page here.
                foreach (var topic in page)
                {
                    Console.WriteLine($"My topic is {topic.Name}");
                }
            }
        }

        static void FixedSizePages()
        {
            var client = PublisherClient.Create();
            foreach (var page in client.ListTopicsStreamed("project").WithFixedSize(10))
            {
                Console.WriteLine($"Currently looking at page with next token {page.NextPageToken}");
                // We don't have a "natural" page here, so we can't look at extra properties.
                // However, we can check for a genuine NextPageToken (which can be used with any later call)
                // and we know we will never have a short page until the last one.
                foreach (var topic in page)
                {
                    Console.WriteLine($"My topic is {topic.Name}");
                }
            }
        }
    }
}
