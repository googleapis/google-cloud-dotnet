// Copyright 2026 Google LLC
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

using CommandLine;
using Google.Cloud.SecretManager.V1;

namespace Google.Cloud.Tools.SecretManagerHelper;

public class Program
{
    /// <summary>
    /// Retrieves the latest version of a secret from Secret Manager
    /// and writes it to standard output.
    /// </summary>
    /// <param name="args">Project Name and Secret Id. These are passed in using standard grammar
    /// like dotnet run --project <project-name> --secret <secret-id>
    /// </param>
    /// <returns>0 if the secret was successfully fetched and output; 1 otherwise.</returns>
    public static async Task<int> Main(string[] args)
    {
        var secretOptions = Parser.Default.ParseArguments<SecretPathOptions>(args);
        if (secretOptions.Errors.Any())
        {
            // CommandLine will provide a detailed error message so we only need to exit with the error code
            return 1;
        }

        string projectName = secretOptions.Value.ProjectName;
        string secretId = secretOptions.Value.SecretId;

        try
        {
            string secretPayload = await GetSecretPayloadAsync(projectName, secretId);

            // The scripts using this will redirect the output to file, so we reserve the standard output for outputting the secret
            Console.Write(secretPayload);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error geting secret payload for project: {projectName}, secret: {secretId}: {ex}");
            return 1;
        }

        return 0;
    }

    private static async Task<string> GetSecretPayloadAsync(string projectName, string secretId)
    {
        var client = await SecretManagerServiceClient.CreateAsync();
        var secretName = SecretVersionName.FromProjectSecretSecretVersion(projectName, secretId, "latest");
        var response = await client.AccessSecretVersionAsync(secretName);
        return response.Payload.Data.ToStringUtf8();
    }
}
