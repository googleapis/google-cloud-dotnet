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
using System.Text;
using System.Xml.Linq;
using Secret = Google.Cloud.SecretManager.V1.Secret;

namespace Google.Cloud.AspNetCore.DataProtection.SecretManager;

/// <summary>
/// Implementation of <see cref="IXmlRepository"/> that stores the protected elements in Google Cloud Secret Manager.
/// This class is configured by <see cref="GoogleCloudDataProtectionBuilderExtensions.PersistKeysToGoogleCloudSecretManager(Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder, string, string)"/>
/// (and other overloads).
/// </summary>
internal class CloudSecretManagerXmlRepository : IXmlRepository
{
    private readonly SecretManagerServiceClient _secretManagerServiceClient;
    private readonly SecretName _secretName;
    private readonly ProjectName _projectName;

    internal CloudSecretManagerXmlRepository(SecretManagerServiceClient client, string secretName, string projectId)
    {
        _secretManagerServiceClient = GaxPreconditions.CheckNotNull(client, nameof(client));
        GaxPreconditions.CheckNotNull(secretName, nameof(secretName));
        GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        _projectName = new ProjectName(projectId);
        _secretName = new SecretName(projectId, secretName);
    }

    /// <inheritdoc />
    public IReadOnlyCollection<XElement> GetAllElements()
    {
        try
        {
            var elements = new List<XElement>();
            foreach (SecretVersion secretVersion in _secretManagerServiceClient.ListSecretVersions(_secretName))
            {
                var accessSecretVersionResponse = _secretManagerServiceClient.AccessSecretVersion(secretVersion.SecretVersionName);
                var secretPayload = accessSecretVersionResponse.Payload.Data.ToStringUtf8();
                elements.Add(XElement.Parse(secretPayload));
            }
            return elements.AsReadOnly();
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.NotFound)
        {
            return Array.Empty<XElement>();
        }
    }

    /// <inheritdoc />
    public void StoreElement(XElement element, string friendlyName)
    {
        try
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
        catch (RpcException ex) when (ex.StatusCode == StatusCode.AlreadyExists)
        {
            // Ignore; When the secret is already exists.
        }

        SecretPayload payload = new SecretPayload
        {
            Data = ByteString.CopyFrom(element.ToString(), Encoding.UTF8)
        };
        _secretManagerServiceClient.AddSecretVersion(_secretName, payload);
    }
}
