// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.ClientTesting;
using System.IO;
using System.Net;
using System.Text;
using Xunit;

namespace Google.Cloud.Storage.V1.Snippets;

[SnippetOutputCollector]
[Collection(nameof(StorageSnippetFixture))]
public class UploadObjectOptionsSnippets
{
    private readonly StorageSnippetFixture _fixture;

    public UploadObjectOptionsSnippets(StorageSnippetFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void IfGenerationMatch_NonExistence()
    {
        string bucketName = _fixture.BucketName;

        // Snippet: IfGenerationMatch
        var client = StorageClient.Create();

        using var sourceStream = new MemoryStream(Encoding.UTF8.GetBytes("Sample data"));
        var destination = "greetings/hello.txt";
        var contentType = "text/plain";

        // An IfGenerationMatch of 0 means "only if the object doesn't already exist".
        var options = new UploadObjectOptions { IfGenerationMatch = 0 };

        bool existed = false;
        try
        {
            client.UploadObject(bucketName, destination, contentType, sourceStream, options);
        }
        catch (GoogleApiException e) when (e.HttpStatusCode == HttpStatusCode.PreconditionFailed)
        {
            // The object already existed.
            existed = true;
        }

        // Log or otherwise use the information about whether the object already existed.
        // End snippet

        Assert.True(existed);
    }
}

