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
using Microsoft.Extensions.DependencyInjection;

namespace Google.Cloud.AspNetCore.DataProtection.SecretManager.Snippets;

public class DataProtectionExtensionMethodsSnippets
{
    public void RegisterSecretManagerClient()
    {
        IServiceCollection services = new ServiceCollection();

        // Sample: RegisterSecretManagerClient

        // Configures the data protection API to use the given secret manager client for making grpc calls.
        var secretManagerClient = SecretManagerServiceClient.Create();
        services.AddSingleton<SecretManagerServiceClient>(secretManagerClient); 
        services.AddDataProtection().PersistKeysToGoogleCloudSecretManager("projectId", "SecretName");
        // End sample
    }

    public void RegisterGoogleCredentials()
    {
        IServiceCollection services = new ServiceCollection();

        // Sample: RegisterGoogleCredentials

        // Configures the data protection API to use the given Google credentials to establish connection.
        var credentials = GoogleCredential.FromJson("service-credentials-json-file-path");
        services.AddSingleton<GoogleCredential>(credentials);
        services.AddDataProtection().PersistKeysToGoogleCloudSecretManager("projectId", "SecretName");
        // End sample
    }

    public void UseDefaultSecretManagerClientWithADC()
    {
        IServiceCollection services = new ServiceCollection();

        // Sample: UseDefaultSecretManagerClientWithADC

        // Configures the data protection API to use the default secret manager client that uses ADC to establish connection.
        services.AddDataProtection().PersistKeysToGoogleCloudSecretManager("projectId", "SecretName");
        // End sample
    }


}
