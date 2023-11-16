// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Cloud.ClientTesting;
using Google.Cloud.SecretManager.V1;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Google.Cloud.AspNetCore.DataProtection.SecretManager.IntegrationTests;

[CollectionDefinition(nameof(SecretManagerFixture))]
public class SecretManagerFixture : CloudProjectFixtureBase, ICollectionFixture<SecretManagerFixture>
{
    private readonly IList<string> _generatedSecrets = new List<string>();
    public readonly DirectoryInfo  DirectoryInfo = new DirectoryInfo(Path.GetFullPath(@".\temp"));

    private SecretManagerServiceClient _client { get; }

    public string GenerateSecretName()
    {
        var secretName = IdGenerator.FromGuid(prefix: "tests-", suffix: "-data-protection", separator: "-");
        _generatedSecrets.Add(secretName);
        return secretName;
    }

    public SecretManagerFixture() =>
        _client = SecretManagerServiceClient.Create();

    public override void Dispose()
    {
        foreach (var secret in _generatedSecrets)
        {
            try
            {
                SecretName secretName = new SecretName(ProjectId, secret);
                _client.DeleteSecret(secretName);
            }
            catch
            {
                // We're swallowing the exception.
            }
        }
        // Deleting the files and folder created and used by FileXmlRespository.
        FileInfo[] files = DirectoryInfo.GetFiles();
        foreach (FileInfo file in files)
        {
            file.Delete();
        }
        DirectoryInfo.Delete();
    }
}
