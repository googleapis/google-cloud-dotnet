// Copyright 2025 Google LLC
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

using Google.Cloud.Tools.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

internal class IntegrationTestLibraryCommand : IContainerCommand
{
    private const string ServiceAccountJsonEnvironmentVariable = "INTEGRATION_TEST_SERVICE_ACCOUNT_JSON";
    private const string ServiceAccountFileEnvironmentVariable = "GOOGLE_APPLICATION_CREDENTIALS";
    private const string TestProjectEnvironmentVariable = "TEST_PROJECT";
    private const string DefaultQuotaProjectEnvironmentVariable = "GOOGLE_CLOUD_QUOTA_PROJECT";

    private const int MaxAttempts = 3;

    public int Execute(ContainerOptions options)
    {
        MaybeSaveServiceAccount();
        MaybeSetQuotaProject();
        var repoRoot = options.RequireOption(options.RepoRoot);
        using var _ = SourceLinkFixer.Create(repoRoot);

        var rootLayout = RootLayout.ForRepositoryRoot(repoRoot);
        var catalog = ApiCatalog.Load(rootLayout);
        var apis = options.GetApisFromLibraryId(catalog);
        for (int attempt = 1; true; attempt++)
        {
            var args = attempt == 1 ? apis.Select(api => api.Id) : new List<string> { "--retry" };
            try
            {
                Processes.RunBashScript(repoRoot, "runintegrationtests.sh", args);
                break;
            }
            catch (Exception) when (attempt < MaxAttempts)
            {
                Console.WriteLine($"Failure running integration tests on attempt {attempt}. (Max attempts = {MaxAttempts})");
            }
        }
        return 0;
    }

    private void MaybeSaveServiceAccount()
    {
        var json = Environment.GetEnvironmentVariable(ServiceAccountJsonEnvironmentVariable);
        if (string.IsNullOrEmpty(json))
        {
            return;
        }
        // Don't do anything if we're not running in Docker. The presence of an "/app/ReleaseManager" directory
        // is a reasonable heuristic for this...
        if (!Directory.Exists("/app/ReleaseManager"))
        {
            Console.WriteLine("Not saving service account JSON: not running in Docker");
            return;
        }
        // Don't do anything if we've already set GOOGLE_APPLICATION_CREDENTIALS for some reason.
        if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable(ServiceAccountFileEnvironmentVariable)))
        {
            Console.WriteLine($"Not saving service account JSON: {ServiceAccountFileEnvironmentVariable} is already set");
            return;
        }
        if (!string.IsNullOrEmpty(json))
        {
            var serviceAccountFile = "/app/service-account.json";
            File.WriteAllText(serviceAccountFile, json);
            Environment.SetEnvironmentVariable(ServiceAccountFileEnvironmentVariable, serviceAccountFile);
            Console.WriteLine("Saved service account details for testing");
        }
    }

    /// <summary>
    /// If we have TEST_PROJECT set, but not GOOGLE_APPLICATION_CREDENTIALS,
    /// then set the default project to the TEST_PROJECT.
    /// </summary>
    private void MaybeSetQuotaProject()
    {
        var testProject = Environment.GetEnvironmentVariable(TestProjectEnvironmentVariable);
        if (!string.IsNullOrEmpty(testProject) &&
            string.IsNullOrEmpty(Environment.GetEnvironmentVariable(ServiceAccountFileEnvironmentVariable)))
        {
            Environment.SetEnvironmentVariable(DefaultQuotaProjectEnvironmentVariable, testProject);
            Console.WriteLine("Set default quota project");
        }
    }
}
