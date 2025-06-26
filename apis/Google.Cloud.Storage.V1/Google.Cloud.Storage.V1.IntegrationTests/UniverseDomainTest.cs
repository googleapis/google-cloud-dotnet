// Copyright 2024 Google LLC
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

using Google.Apis.Storage.v1.Data;
using System;
using System.IO;
using System.Text;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests;

public class UniverseDomainTest : IDisposable
{
    private StorageClient _storage;
    private readonly string _universeDomain;
    private readonly string _location;
    private readonly string _projectId;
    private readonly string _credsPath;
    private readonly string _bucketName;
    private readonly string _objectName;

    public UniverseDomainTest()
    {
        _universeDomain = GetEnvironmentVariable("TEST_UNIVERSE_DOMAIN",
            "This is the universe domain, for instance, googleapis.com");
        _projectId = GetEnvironmentVariable("TEST_UNIVERSE_PROJECT_ID",
            "This is the project ID of a GCP project in the universe.");
        _location = GetEnvironmentVariable("TEST_UNIVERSE_LOCATION",
            "The location to create the bucket in, which must be a location of the universe.");
        _credsPath = GetEnvironmentVariable("TEST_UNIVERSE_DOMAIN_CREDENTIAL",
            "The path to the credentials file. Credentials must be from the universe.");

        _bucketName = "ud-test-bucket" + Guid.NewGuid();
        _objectName = "ud-test-object";
    }

    [Fact]
    public void UniverseDomain()
    {
        _storage = new StorageClientBuilder { CredentialsPath = _credsPath, UniverseDomain = _universeDomain }.Build();

        _storage.CreateBucket(_projectId, new Bucket { Location = _location, Name = _bucketName });

        byte[] byteArray = Encoding.UTF8.GetBytes("hello");
        MemoryStream stream = new MemoryStream(byteArray);
        _storage.UploadObject(_bucketName, _objectName, "application/octet-stream", stream);

        MemoryStream download = new MemoryStream();
        _storage.DownloadObject(_bucketName, _objectName, download);

        Assert.Equal(byteArray, download.ToArray());
    }

    public void Dispose()
    {
        if (_storage != null)
        {
            try
            {
                _storage.DeleteObject(_bucketName, _objectName);
                _storage.DeleteBucket(_bucketName);
            }
            catch (Exception)
            {
                // Do nothing, we delete on a best effort basis.
            }
        }
    }

    private static string GetEnvironmentVariable(string envVarName, string message = "")
    {
        string varValue = Environment.GetEnvironmentVariable(envVarName);
        if (string.IsNullOrEmpty(varValue))
        {
            throw new InvalidOperationException(
                $"Please set the {envVarName} environment variable. {message}");
        }
        return varValue;
    }
}
