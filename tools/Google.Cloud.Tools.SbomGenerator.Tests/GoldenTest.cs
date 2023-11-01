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

using Xunit;

namespace Google.Cloud.Tools.SbomGenerator.Tests;

public class GoldenTest
{
    private const string GoldenTestDataPath = "GoldenTestData";

    [Fact]
    public void OsLogin()
    {
        string packageFilePath = Path.Combine(GoldenTestDataPath, "Google.Cloud.OsLogin.V1Beta.3.0.0-beta05.nupkg");
        string expectedSbomFilePath = Path.Combine(GoldenTestDataPath, "Expected-Google.Cloud.OsLogin.V1Beta.3.0.0-beta05.nupkg-sbom.spdx.json");
        string actualSbomFilePath = Path.Combine(GoldenTestDataPath, "Google.Cloud.OsLogin.V1Beta.3.0.0-beta05.nupkg-sbom.spdx.json");
        try
        {
            Program.Main(new[] { packageFilePath });
            Assert.True(File.Exists(actualSbomFilePath));

            // Replace line endings in case we have run tests in environments different to those in which we generated
            // the golden test data.
            string expected = File.ReadAllText(expectedSbomFilePath).ReplaceLineEndings();
            string actual = File.ReadAllText(actualSbomFilePath).ReplaceLineEndings();

            // Ugly hack to skip the created date comparison.
            // This is a sanity check test on a tool so this is OK.
            Assert.Equal(expected[..303], actual[..303]);
            Assert.Equal(expected[323..], actual[323..]);
        }
        finally
        {
            if (File.Exists(actualSbomFilePath))
            {
                File.Delete(actualSbomFilePath);
            }
        }
    }
}
