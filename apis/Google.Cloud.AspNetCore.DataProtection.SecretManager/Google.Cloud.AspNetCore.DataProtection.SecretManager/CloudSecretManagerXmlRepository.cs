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
using Google.Api.Gax.Grpc;
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
    private readonly CallSettings _callSettings = CallSettingsExtensions.WithRetry(CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromMilliseconds(10000))), RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: TimeSpan.FromMilliseconds(0.2), maxBackoff: TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.5, retryFilter: RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable)));

    internal CloudSecretManagerXmlRepository(SecretManagerServiceClient client, string secretName, string projectName)
    {
        _secretManagerServiceClient = GaxPreconditions.CheckNotNull(client, nameof(client));
        GaxPreconditions.CheckNotNull(secretName, nameof(secretName));
        GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
        _projectName = new ProjectName(projectName);
        _secretName = new SecretName(projectName, secretName);

        // Version is populated in such a way that it always refers to the most latest version.
        // For more information on version naming refer to
        // https://cloud.google.com/dotnet/docs/reference/Google.Cloud.SecretManager.V1/latest/Google.Cloud.SecretManager.V1.AccessSecretVersionRequest#Google_Cloud_SecretManager_V1_AccessSecretVersionRequest_Name
        _version = SecretVersionName.FromProjectSecretSecretVersion(projectName, secretName, "latest");
    }

    /// <inheritdoc />
    public IReadOnlyCollection<XElement> GetAllElements()
    {
        if (!IsSecretExists())
        {
            return Array.Empty<XElement>();
        }
        var accessSecretVersionResponse = GetSecretVersionResponse();

        if (accessSecretVersionResponse != null)
        {
            var secretPayload = accessSecretVersionResponse.Payload.Data.ToStringUtf8();
            XDocument document = XDocument.Parse(secretPayload);
            var res = document?.Root?.Elements().ToList();
            return res ?? (IReadOnlyCollection<XElement>) Array.Empty<XElement>();
        }
        return Array.Empty<XElement>();

        AccessSecretVersionResponse GetSecretVersionResponse()
        {
            var response = _secretManagerServiceClient.AccessSecretVersion(_version, _callSettings);
            return response;
        }
    }

    /// <inheritdoc />
    public void StoreElement(XElement element, string friendlyName)
    {
        if (!IsSecretExists())
        {
            CreateSecret();
        }
        XDocument document = new XDocument(new XElement("root"));
        document.Root.Add(element);
        SecretPayload payload = new SecretPayload
        {
            Data = ByteString.CopyFrom(document.ToString(), Encoding.UTF8)
        };
        _secretManagerServiceClient.AddSecretVersion(_secretName, payload, _callSettings);
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
        _secretManagerServiceClient.CreateSecret(createSecretRequest, _callSettings);
    }

    private bool IsSecretExists()
    {
        try
        {
            var res = _secretManagerServiceClient.GetSecret(_secretName);
            return true;
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.NotFound)
        {
            return false;
        }
    }
}
