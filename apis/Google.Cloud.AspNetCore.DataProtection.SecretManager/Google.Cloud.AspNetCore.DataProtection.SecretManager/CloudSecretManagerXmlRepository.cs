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

using Google.Api.Gax;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.SecretManager.V1;
using Google.Protobuf;
using Grpc.Core;
using Microsoft.AspNetCore.DataProtection.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Secret = Google.Cloud.SecretManager.V1.Secret;

namespace Google.Cloud.AspNetCore.DataProtection.SecretManager;

/// <summary>
/// Implementation of <see cref="IXmlRepository"/> that stores the protected elements in a Google Cloud Secret Manager.
/// This class is configured by <see cref="GoogleCloudDataProtectionBuilderExtensions.PersistKeysToGoogleCloudSecretManager(Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder, string, string)"/>
/// (and other overloads).
/// </summary>
internal class CloudSecretManagerXmlRepository : IXmlRepository
{
    private readonly SecretManagerServiceClient _secretManagerServiceClient;
    private readonly SecretName _secretName;
    private readonly ProjectName _projectName;
    private readonly SecretVersionName _version;

    internal CloudSecretManagerXmlRepository(SecretManagerServiceClient client, string secretName, string projectId)
    {
        _secretManagerServiceClient = GaxPreconditions.CheckNotNull(client, nameof(client));
        GaxPreconditions.CheckNotNull(secretName, nameof(secretName));
        GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        _projectName = new ProjectName(projectId);
        _secretName = new SecretName(projectId, secretName);

        // Version is populated in such a way that it always refers to the most latest version.
        // For more information on version naming refer to
        // https://cloud.google.com/dotnet/docs/reference/Google.Cloud.SecretManager.V1/latest/Google.Cloud.SecretManager.V1.AccessSecretVersionRequest#Google_Cloud_SecretManager_V1_AccessSecretVersionRequest_Name
        _version = SecretVersionName.FromProjectSecretSecretVersion(projectId, secretName, "latest");
    }

    /// <inheritdoc />
    public IReadOnlyCollection<XElement> GetAllElements()
    {
        if (!SecretExists())
        {
            return Array.Empty<XElement>();
        }
        var accessSecretVersionResponse = _secretManagerServiceClient.AccessSecretVersion(_version);

        if (accessSecretVersionResponse != null)
        {
            var secretPayload = accessSecretVersionResponse.Payload.Data.ToStringUtf8();
            XDocument document = XDocument.Parse(secretPayload);
            var xElements = document.Root.Elements().ToList();
            return xElements;
        }
        return Array.Empty<XElement>();
    }

    /// <inheritdoc />
    public void StoreElement(XElement element, string friendlyName)
    {
        if (!SecretExists())
        {
            CreateSecret();
        }
        XDocument document = new XDocument(new XElement("root"));
        document.Root.Add(element);
        SecretPayload payload = new SecretPayload
        {
            Data = ByteString.CopyFrom(document.ToString(), Encoding.UTF8)
        };
        _secretManagerServiceClient.AddSecretVersion(_secretName, payload);
    }

    private void CreateSecret()
    {
        var createSecretRequest = new CreateSecretRequest
        {
            Secret = new Secret
            {
                Replication = new Replication
                {
                    Automatic = new Replication.Types.Automatic(),
                },
            },
            ParentAsProjectName = _projectName,
            SecretId = _secretName.SecretId
        };
        _secretManagerServiceClient.CreateSecret(createSecretRequest);
    }

    private bool SecretExists()
    {
        try
        {
            _secretManagerServiceClient.GetSecret(_secretName);
            return true;
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.NotFound)
        {
            return false;
        }
    }
}
