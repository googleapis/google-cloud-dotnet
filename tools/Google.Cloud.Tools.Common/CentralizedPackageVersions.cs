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

using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Google.Cloud.Tools.Common;

/// <summary>
/// In-memory read-only representation of Directory.Packages.props.
/// Currently effectively just a dictionary of package to version, but may evolve more later.
/// </summary>
public sealed class CentralizedPackageVersions
{
    /// <summary>
    /// The name of the centralized package versions file relative to the repository root.
    /// </summary>
    public const string PathInRepository = "Directory.Packages.props";

    public ImmutableDictionary<string, StructuredVersion> PackageToVersionMap { get; }

    private CentralizedPackageVersions(IDictionary<string, StructuredVersion> packageToVersionMap)
    {
        PackageToVersionMap = packageToVersionMap.ToImmutableDictionary();
    }

    public static CentralizedPackageVersions FromXml(string xml) =>
        FromDoc(XDocument.Parse(xml));

    public static CentralizedPackageVersions Load(RootLayout rootLayout) =>
        FromDoc(XDocument.Load(Path.Combine(rootLayout.RepositoryRoot, PathInRepository)));

    private static CentralizedPackageVersions FromDoc(XDocument doc)
    {
        // If we don't have a Project element or an ItemGroup element, this will fail
        // with an NRE - that's fine.
        var dict = doc.Element("Project").Element("ItemGroup").Elements("PackageVersion")
            .ToDictionary(e => e.Attribute("Include").Value, e => ParseVersion(e.Attribute("Version").Value));
        return new CentralizedPackageVersions(dict);

        StructuredVersion ParseVersion(string versionOrRange)
        {
            string valueToParse = versionOrRange;
            if (versionOrRange.StartsWith('[') && versionOrRange.EndsWith(')') &&
                versionOrRange.Contains(','))
            {
                valueToParse = versionOrRange.Split(',')[0].TrimStart('[', ' ').TrimEnd();
            }
            return StructuredVersion.FromString(valueToParse);
        }
    }
}
