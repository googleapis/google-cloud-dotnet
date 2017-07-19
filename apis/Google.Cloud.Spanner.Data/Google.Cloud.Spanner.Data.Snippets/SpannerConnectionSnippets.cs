// Copyright 2017 Google Inc. All Rights Reserved.
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

namespace Google.Cloud.Spanner.Data.Snippets
{
    public class SpannerConnectionSnippets
    {
        [Fact]
        public void CreateConnection()
        {
            // Snippet: #ctor(string, ITokenAccess)
            string connectionString = "Data Source=projects/my-project/instances/my-instance/databases/my-db";
            SpannerConnection connection = new SpannerConnection(connectionString);
            Console.WriteLine(connection.Project);
            Console.WriteLine(connection.SpannerInstance);
            Console.WriteLine(connection.Database);
            // End snippet

            Assert.Equal("my-project", connection.Project);
            Assert.Equal("my-instance", connection.SpannerInstance);
            Assert.Equal("my-db", connection.Database);
        }
    }
}
