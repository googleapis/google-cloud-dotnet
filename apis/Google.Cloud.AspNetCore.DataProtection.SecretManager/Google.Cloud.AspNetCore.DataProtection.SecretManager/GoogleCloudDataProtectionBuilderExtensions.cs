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

using Google.Apis.Auth.OAuth2;
using Google.Cloud.SecretManager.V1;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Google.Cloud.AspNetCore.DataProtection.SecretManager;

/// <summary>
/// Contains extension methods for modifying a <see cref="IDataProtectionBuilder"/> to work with Google Cloud Secret Manager.
/// </summary>
public static class GoogleCloudDataProtectionBuilderExtensions
{
    /// <summary>
    /// Configures data protection system to persist keys in Google Cloud Secret Manager.
    /// </summary>
    /// <param name="builder">The data protection builder to configure. Must not be null.</param>
    /// <param name="projectName">The project id in which the keys are stored. Must not be null</param>
    /// <param name="secretName">The name of the secret in which to store the keys. Must not be null.</param>
    public static IDataProtectionBuilder PersistKeysToGoogleCloudSecretManager(
            this IDataProtectionBuilder builder, string projectName, string secretName) =>
            PersistKeysToGoogleCloudSecretManager(builder, projectName, secretName, null);

    /// <summary>
    /// Configures data protection system to persist keys in Google Cloud Secret Manager.
    /// </summary>
    /// <remarks>
    /// <para>
    /// If <paramref name="client"/> is null, the client is constructed as follows:
    /// <list type="bullet">
    ///   <item><description>If a <c>SecretManagerServiceClient</c> is configured via dependency injection, that is used.</description></item>
    ///   <item><description>If a <c>GoogleCredential</c> is configured via dependency injection, that is used to construct a <c>SecretManagerServiceClient</c>.</description></item>
    ///   <item><description>Otherwise, the default credentials are used to construct a <c>SecretManagerServiceClient</c>.</description></item>
    /// </list>
    /// </para>
    /// </remarks>
    /// <param name="builder">The data protection builder to configure. Must not be null.</param>
    /// <param name="projectName">The project id in which the keys are stored. Must not be null</param>
    /// <param name="secretName">The name of the secret in which to store the keys. Must not be null.</param>
    /// <param name="client">The Google Cloud Secret Manager client to use for requests. May be null in which case the client will
    /// be fetched from dependency injection or created with the default credentials.</param>
    /// <returns>The same builder, for chaining purposes</returns>
    public static IDataProtectionBuilder PersistKeysToGoogleCloudSecretManager(
            this IDataProtectionBuilder builder, string projectName, string secretName, SecretManagerServiceClient client)
    {
        builder.Services.AddSingleton<IConfigureOptions<KeyManagementOptions>>(services =>
        {
            if (client == null)
            {
                client = services.GetService<SecretManagerServiceClient>();
                if (client == null)
                {
                    var credential = services.GetService<GoogleCredential>();
                    // If credential is null, this will use the default credentials automatically.
                    client = SecretManagerServiceClient.Create();
                }
            }
            return new ConfigureOptions<KeyManagementOptions>(options =>
                options.XmlRepository = new CloudSecretManagerXmlRepository(client, secretName, projectName));
        });
        return builder;
    }
}
