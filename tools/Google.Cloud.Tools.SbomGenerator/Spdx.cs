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

using System.Globalization;
using System.Text.Json.Serialization;

namespace Google.Cloud.Tools.SbomGenerator;

/// <summary>
/// SPDX format.
/// See https://github.com/spdx/spdx-spec/blob/development/v2.3.1/schemas/spdx-schema.json
/// </summary>
internal class Spdx
{
    [JsonPropertyName("spdxVersion")]
    public string SpdxVersion => "SPDX-2.3";

    [JsonPropertyName("dataLicense")]
    public string DataLicense => "CC0-1.0";

    [JsonPropertyName("SPDXID")]
    public string SpdxId => "SPDXRef-Document";

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("documentNamespace")]
    public string DocumentNamespace { get; set; }

    [JsonPropertyName("creators")]
    public List<string> Creators { get; } = new List<string> { "Organization: Google LLC" };

    [JsonPropertyName("created")]
    public string Created { get; } = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);

    [JsonPropertyName("packages")]
    public List<SpdxPackage> Packages { get; set; }

    [JsonPropertyName("relationships")]
    public List<SpdxRelationship> Relationships { get; } = new List<SpdxRelationship> { new SpdxRelationship() };

    internal class SpdxPackage
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("packageFileName")]
        public string FileName { get; set; }

        [JsonPropertyName("SPDXID")]
        public string SpdxId { get; set; }

        [JsonPropertyName("versionInfo")]
        public string Version { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("supplier")]
        public string Supplier => "Organization: Google LLC";

        [JsonPropertyName("originator")]
        public string Originator => "Organization: Google LLC";

        [JsonPropertyName("downloadLocation")]
        public string DownloadLocation { get; set; }

        [JsonPropertyName("licenseConcluded")]
        public string LicenseConcluded { get; set; }

        [JsonPropertyName("licenseDeclared")]
        public string LicenseDeclared { get; set; }

        [JsonPropertyName("copyrightText")]
        public string CopyrightText => "NOASSERTION";

        [JsonPropertyName("checksums")]
        public List<SpdxChecksum> Checksums { get; set; }

        [JsonPropertyName("externalRefs")]
        public List<SpdxPackageExternalReference> ExternalReferences { get; set; }

        internal class SpdxChecksum
        {
            [JsonPropertyName("algorithm")]
            public string Algorithm { get; set; }

            [JsonPropertyName("checksumValue")]
            public string Value { get; set; }
        }

        internal class SpdxPackageExternalReference
        {
            [JsonPropertyName("referenceType")]
            public string Type => "purl";

            [JsonPropertyName("referenceCategory")]
            public string Category => "PACKAGE-MANAGER";

            [JsonPropertyName("referenceLocator")]
            public string Locator { get; set; }
        }
    }

    internal class SpdxRelationship
    {
        [JsonPropertyName("spdxElementId")]
        public string SpdxElementId => "SPDXRef-DOCUMENT";

        [JsonPropertyName("relatedSpdxElement")]
        public string RelatedSpdxElement => "SPDXRef-DOCUMENT";

        [JsonPropertyName("relationshipType")]
        public string RelationshipType => "DESCRIBES";
    }
}
