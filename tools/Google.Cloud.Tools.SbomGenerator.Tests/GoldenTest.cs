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

using System.Text.RegularExpressions;
using Xunit;

namespace Google.Cloud.Tools.SbomGenerator.Tests;

public class GoldenTest
{
    private const string GoldenTestDataPath = "GoldenTestData";

    [Fact]
    public void OsLogin() => ExecuteTest("Google.Cloud.OsLogin.V1Beta.3.0.0-beta05");

    [Fact]
    public void FunctionsFrameworkTemplates() => ExecuteTest("Google.Cloud.Functions.Templates.2.2.0");

    private static void ExecuteTest(string package)
    {
        string packageFilePath = Path.Combine(GoldenTestDataPath, $"{package}.nupkg");
        string expectedSbomFilePath = Path.Combine(GoldenTestDataPath, $"Expected-{package}.nupkg-sbom.spdx.json");
        string actualSbomFilePath = Path.Combine(GoldenTestDataPath, $"{package}.nupkg-sbom.spdx.json");
        try
        {
            Program.Main(new[] { packageFilePath });
            Assert.True(File.Exists(actualSbomFilePath));

            string expected = Normalize(File.ReadAllText(expectedSbomFilePath));
            string actual = Normalize(File.ReadAllText(actualSbomFilePath));

            Assert.Equal(expected, actual);
        }
        finally
        {
            if (File.Exists(actualSbomFilePath))
            {
                File.Delete(actualSbomFilePath);
            }
        }

        // Massage the data in three ways:
        // - Normalize line endings
        // - Remove the content of the "created" JSON property as it depends on the system time.
        // - Trim the end, so that trailing whitespace is irrelevant
        string Normalize(string text) =>
            new Regex("\"created\": \"[^\"]*\"").Replace(text, "\"created\": \"REDACTED\"")
                .ReplaceLineEndings()
                .Trim();
    }
}
