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

using Google.Cloud.AspNetCore.DataProtection.SecretManager;
using Google.Cloud.SecretManager.V1;
using System.Xml.Linq;
using Xunit;

namespace IntegrationTests;

[Collection(nameof(SecretManagerFixture))]
public class CloudSecretManagerXmlRepositoryTest
{
    private readonly SecretManagerFixture _secretManagerFixture;

    public CloudSecretManagerXmlRepositoryTest(SecretManagerFixture secretManagerFixture) => _secretManagerFixture = secretManagerFixture;

    [Fact]
    private void StoreAndRead()
    {
        var data = new XElement("foo", new XAttribute("id", "id1"));
        var secretName = _secretManagerFixture.GenerateSecretName();
        var repo = CreateXmlRepository(secretName);
        repo.StoreElement(data, "ignore");
        var retrivedData = repo.GetAllElements();

        XElement element = Assert.Single(retrivedData);
        Assert.Equal("id1", element.Attribute("id")?.Value);
    }

    [Fact]
    private void StoreMultipleVersion_AndReadLatestVersion()
    {
        var data = new XElement("foo", new XAttribute("id", "id1"));
        var data2 = new XElement("foo", new XAttribute("id", "id2"));
        var secretName = _secretManagerFixture.GenerateSecretName();
        var repo = CreateXmlRepository(secretName);
        repo.StoreElement(data, "ignore");
        repo.StoreElement(data2, "ignore");
        var retrivedData = repo.GetAllElements();

        XElement element = Assert.Single(retrivedData);
        Assert.Equal("id2", element.Attribute("id")?.Value);
    }

    private CloudSecretManagerXmlRepository CreateXmlRepository(string secretName)
    {
        var client = SecretManagerServiceClient.Create();
        return new CloudSecretManagerXmlRepository(client, secretName, _secretManagerFixture.ProjectId);
    }
}
