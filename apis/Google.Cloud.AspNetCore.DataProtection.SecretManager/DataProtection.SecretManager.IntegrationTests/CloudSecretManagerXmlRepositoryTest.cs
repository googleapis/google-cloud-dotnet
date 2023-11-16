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

using Google.Cloud.SecretManager.V1;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Xunit;

namespace Google.Cloud.AspNetCore.DataProtection.SecretManager.IntegrationTests;

[Collection(nameof(SecretManagerFixture))]
public class CloudSecretManagerXmlRepositoryTest
{
    private readonly SecretManagerFixture _secretManagerFixture;

    public CloudSecretManagerXmlRepositoryTest(SecretManagerFixture secretManagerFixture) => _secretManagerFixture = secretManagerFixture;

    [Fact]
    private void ReadDataFromSecretThatDoestExists()
    {
        var secretName = _secretManagerFixture.GenerateSecretName();
        var repo = CreateXmlRepository(secretName);
        var retrivedData = repo.GetAllElements();
        Assert.True(retrivedData.Count == 0);
    }

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
    private void CompareWithFileSystemXmlRepository()
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        var data = new XElement("foo", new XAttribute("id", "id1"));
        var data2 = new XElement("foo", new XAttribute("id", "id2"));
        var fs = new FileSystemXmlRepository(_secretManagerFixture.DirectoryInfo, loggerFactory);
        fs.StoreElement(data, "");
        fs.StoreElement(data2, "");
        var res1 = fs.GetAllElements();

        var secretName = _secretManagerFixture.GenerateSecretName();
        var repo = CreateXmlRepository(secretName);
        repo.StoreElement(data, "ignore");
        repo.StoreElement(data2, "ignore");
        var res2 = repo.GetAllElements();

        Assert.True(CompareCollection(res1, res2));
    }

    [Fact]
    private void StoreMultipleVersions()
    {
        var data = new XElement("foo", new XAttribute("id", "id1"));
        var data2 = new XElement("foo", new XAttribute("id", "id2"));
        var secretName = _secretManagerFixture.GenerateSecretName();
        var repo = CreateXmlRepository(secretName);
        repo.StoreElement(data, "ignore");
        repo.StoreElement(data2, "ignore");
        var retrievedData = repo.GetAllElements();

        Assert.True(retrievedData.Count == 2);
    }

    private CloudSecretManagerXmlRepository CreateXmlRepository(string secretName) =>
        new CloudSecretManagerXmlRepository(SecretManagerServiceClient.Create(), secretName, _secretManagerFixture.ProjectId);

    private bool CompareCollection(IEnumerable<XElement> list1, IEnumerable<XElement> list2)
    {
        var cnt = new Dictionary<XElement, int>(comparer: new XNodeEqualityComparer());
        foreach (var element in list1)
        {
            if (cnt.ContainsKey(element))
            {
                cnt[element]++;
            }
            else
            {
                cnt.Add(element, 1);
            }
        }
        foreach (var element in list2)
        {
            if (cnt.ContainsKey(element))
            {
                cnt[element]--;
            }
            else
            {
                return false;
            }
        }
        return cnt.Values.All(c => c == 0);
    }
}
