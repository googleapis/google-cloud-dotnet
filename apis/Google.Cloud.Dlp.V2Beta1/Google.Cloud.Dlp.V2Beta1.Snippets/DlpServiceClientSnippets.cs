// Copyright 2017, Google Inc. All rights reserved.
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
using Xunit;
using static Google.Cloud.Dlp.V2Beta1.RedactContentRequest.Types;

namespace Google.Cloud.Dlp.V2Beta1.Snippets
{
    public class DlpServiceClientSnippets
    {
        [Fact]
        public void Intro()
        {
            // Sample: Intro
            DlpServiceClient client = DlpServiceClient.Create();
            ContentItem content = new ContentItem
            {
                Type = "text/plain",
                Value = "Hi! My phone number is 555-1234-567. Please call me!"
            };
            ReplaceConfig replace = new ReplaceConfig { ReplaceWith = "(Redacted)" };
            var response = client.RedactContent(new InspectConfig(), new[] { content }, new[] { replace });
            var item = response.Items[0];
            Console.WriteLine(item.Value);
            // End sample
            Assert.Equal("Hi! My phone number is (Redacted). Please call me!", item.Value);
        }

        [Fact]
        public void ListRootCategories()
        {
            // Snippet: ListRootCategories(string, *)
            DlpServiceClient client = DlpServiceClient.Create();
            foreach (var category in client.ListRootCategories("en-US").Categories)
            {
                Console.WriteLine($"{category.Name}: {category.DisplayName}");
            }
            // End snippet
        }
    }
}
