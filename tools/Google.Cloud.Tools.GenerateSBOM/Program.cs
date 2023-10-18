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
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text.Json;
using System.Xml;

namespace GenerateSBOM;

// The classes below are not general purpose Spdx classes.  Their single
// purpose is to generate json SBOMs for nupkgs generated from this repository,
// so they have default values convenient for that purpose.
// Reusing these classes for any other purpose would require a refactor.

/// <summary>
/// SPDX format.
/// See https://github.com/spdx/spdx-spec/blob/development/v2.3.1/schemas/spdx-schema.json
/// </summary>
internal class Spdx
{
    public string spdxVersion { get; } = "SPDX-2.3";
    public string dataLicense { get; } = "CC0-1.0";
    public string SPDXID { get; } = "SPDXRef-Document";
    public string name { get; set; } = "";

    public string documentNamespace { get; set; } = "";
    public List<string> creators { get; set; } = new List<string>();
    public string created { get; set; } = "";

    public List<SpdxPackage> packages { get; set; } = new List<SpdxPackage>();

    public List<SpdxRelationship> relationships { get; set; }
        = new List<SpdxRelationship> { new() };
}

internal class SpdxPackage
{
    public string name { get; set; } = "";
    public string SPDXID { get; set; } = "";
    public string versionInfo { get; set; } = "";
    public string description { get; set; } = "";
    public string supplier { get; set; } = "Person: Google LLC";
    public string originator { get; set; } = "Person: Google LLC";
    public string downloadLocation { get; set; }
        = "https://github.com/googleapis/google-cloud-dotnet.git";
    public string licenseConcluded { get; set; } = "Apache-2.0";
    public string licenseDeclared { get; set; } = "Apache-2.0";
    public string copyrightText { get; set; } = "NOASSERTION";
    public List<SpdxChecksum> checksums { get; set; }
        = new List<SpdxChecksum>();
    public List<SpdxPackageExternalRef> externalRefs { get; set; }
        = new List<SpdxPackageExternalRef>();
}

internal class SpdxPackageExternalRef
{
    public string referenceType { get; set; } = "purl";
    public string referenceCategory { get; set; } = "PACKAGE-MANAGER";
    public string referenceLocator { get; set; } = "";
}

internal class SpdxRelationship
{
    public string spdxElementId { get; set; } = "SPDXRef-DOCUMENT";
    public string relatedSpdxElement { get; set; } = "SPDXRef-DOCUMENT";
    public string relationshipType { get; set; } = "DESCRIBES";
}

internal class SpdxChecksum
{
    public string algorithm { get; set; } = "";
    public string checksumValue { get; set; } = "";
}

/// <summary>
/// Metadata collected from a nupkg's XML nuspec.
/// </summary>
internal class NuspecMetadata
{
    public string Id { get; set; } = "";
    public string Version { get; set; } = "";
    public string Description { get; set; } = "";
}

public class MissingNuspecError : Exception
{
    public MissingNuspecError(string filename)
        : base($"No .nuspec file found in ${filename}")
    {
    }
}

public class MultipleNuspecError : Exception
{
    public MultipleNuspecError(string filename)
        : base("Found multiple .nuspec files in " + filename
            + ".  I don't know which one to use.")
    {
    }
}


public class Program
{
    /// <summary>
    /// Write json with human-friendly indentation.
    /// </summary>
    private static readonly JsonSerializerOptions s_indented = new()
    {
        WriteIndented = true
    };

    public static void Main(string[] args)
    {
        if (0 == args.Length)
        {
            Console.WriteLine(@"GenerateSBOM

Examines .nupkg files and writes SPDX SBOM json files next to them.

Usage:
    dotnet run -- <path-to-.nupkg> <dir> ...");
            return;
        }
        foreach (var arg in args)
        {
            var attrs = File.GetAttributes(arg);
            if (attrs.HasFlag(FileAttributes.Directory))
            {
                Console.WriteLine("Looking for .nupkgs in " + arg);
                // Recurse into subdirectories looking for .nupkg files.
                var directories = new Queue<string>();
                string? dir = arg;
                while (dir != null)
                {
                    foreach (var filePath in Directory
                        .EnumerateFiles(dir, "*.nupkg"))
                    {
                        WriteSpdx(filePath);
                    }
                    foreach (var subDir in Directory.EnumerateDirectories(dir))
                    {
                        directories.Enqueue(subDir);
                    }
                    if (!directories.TryDequeue(out dir))
                    {
                        dir = null;
                    }
                }
            }
            else
            {
                WriteSpdx(arg);
            }
        }
    }

    /// <summary>
    /// Examines a .nupkg file and writes an SPDX SBOM json file next to it.
    /// </summary>
    /// <param name="nupkgPath">Path to .nupkg file.</param>
    /// <returns>Path to generated SPDX SBOM json file.</returns>
    private static void WriteSpdx(string nupkgPath)
    {
        Console.WriteLine("Examining " + nupkgPath);
        var spdx = SpdxFrom(nupkgPath);
        var sbomPath = nupkgPath + "-sbom.spdx.json";
        using (var file = File.Open(sbomPath, FileMode.OpenOrCreate,
            FileAccess.Write))
        {
            JsonSerializer.Serialize(file, spdx, s_indented);
        }
        Console.WriteLine("Wrote " + sbomPath);
    }

    /// <summary>
    /// Generates a SPDX SBOM from the given .nupkg file path.
    /// </summary>
    /// <param name="nupkgPath">Path to a .nupkg file.</param>
    /// <returns>Filled out SPDX SBOM.</returns>
    /// <exception cref="MultipleNuspecError">
    ///     When the .nupkg contains multiple .nuspec files.
    /// </exception>
    /// <exception cref="MissingNuspecError">
    ///     When the .nupkg contains no .nuspec files.
    /// </exception>
    private static Spdx SpdxFrom(string nupkgPath)
    {
        // Compute the SHA1 hash of the .nupkg file.
        var sha1 = SHA1.Create();
        byte[]? hash = null;
        using (var file = File.OpenRead(nupkgPath))
        {
            hash = sha1.ComputeHash(file);
        }

        // Use the SHA1 hash to create a deterministic uuid.
        var uuid = Uuid5FromHash(hash);

        // Find the .nuspec metadata in the .nupkg and collect the fields we
        // need.
        NuspecMetadata? nuspecMetadata = null;
        using (var zipFile = System.IO.Compression.ZipFile.OpenRead(nupkgPath))
        {
            foreach (var entry in zipFile.Entries)
            {
                if (Path.GetExtension(entry.Name).ToLower() == ".nuspec")
                {
                    if (nuspecMetadata == null)
                    {
                        nuspecMetadata = GetMetadata(entry.Open());
                    }
                    else
                    {
                        throw new MultipleNuspecError(nupkgPath);
                    }
                }
            }
        }
        if (nuspecMetadata == null)
        {
            throw new MissingNuspecError(nupkgPath);
        }

        // Assemble a SPDX SBOM.
        var fileName = Path.GetFileName(nupkgPath);
        var spdx = new Spdx
        {
            name = nuspecMetadata.Id + "@" + nuspecMetadata.Version,
            documentNamespace = "https://spdx.google/" + uuid,
            creators = new List<string> { "Organization: Google LLC" },
            created = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ",
                System.Globalization.CultureInfo.InvariantCulture),
            packages = new List<SpdxPackage> {
                new() {
                    name = fileName,
                    SPDXID = "SPDXRef-Package-" + fileName + "-" + uuid,
                    versionInfo = nuspecMetadata.Version,
                    description = nuspecMetadata.Description,
                    checksums = new List<SpdxChecksum> {
                        new() {
                            algorithm = "SHA1",
                            checksumValue = BitConverter.ToString(hash)
                                .Replace("-","")
                        }
                    },
                    externalRefs = new List<SpdxPackageExternalRef> {
                        new() {
                            referenceLocator = "pkg:nuget/"
                                + nuspecMetadata.Id + "@"
                                + nuspecMetadata.Version
                        }
                    }
                }
            }
        };
        return spdx;
    }

    /// <summary>
    /// Collects metadata from a nupkg's .nuspec xml file.
    /// </summary>
    /// <param name="nuspecXmlStream">xml content</param>
    /// <returns>metadata</returns>
    private static NuspecMetadata GetMetadata(Stream nuspecXmlStream)
    {
        var doc = new XmlDocument();
        var xmlReader = new XmlTextReader(nuspecXmlStream)
        {
            Namespaces = false
        };
        doc.Load(xmlReader);
        var metadata = doc.DocumentElement?
            .SelectSingleNode("/package/metadata");
        return new NuspecMetadata
        {
            Id = metadata?.SelectSingleNode("id")?.InnerText ?? "",
            Version = metadata?.SelectSingleNode("version")?.InnerText ?? "",
            Description = metadata?.SelectSingleNode("description")?.InnerText
                ?? "",
        };
    }

    /// <summary>
    /// Creates a UUID from a hash.
    /// 
    /// Ported from format_uuid_v3or5() in
    /// https://www.rfc-editor.org/rfc/rfc4122
    /// </summary>
    /// <param name="hash">A SHA1 hash or the like.
    ///   Must be 16 bytes or longer.</param>
    /// <returns>A UUID deterministically created from the hash.</returns>
    private static Guid Uuid5FromHash(byte[] hash)
    {
        /* convert UUID to local byte order */
        var time_low = IPAddress.NetworkToHostOrder(
            BitConverter.ToInt32(hash, 0));
        var time_mid = IPAddress.NetworkToHostOrder(
            BitConverter.ToInt16(hash, 4));
        var time_hi_and_version = IPAddress.NetworkToHostOrder(
            BitConverter.ToInt16(hash, 6));
        var clock_seq_hi_and_reserved = hash[8];

        /* put in the variant and version bits */
        const short version = 5;
        time_hi_and_version &= 0x0FFF;
        time_hi_and_version |= version << 12;
        clock_seq_hi_and_reserved &= 0x3F;
        clock_seq_hi_and_reserved |= 0x80;
        hash[8] = clock_seq_hi_and_reserved;

        return new Guid(time_low, time_mid,
            time_hi_and_version, hash[8..16]);
    }
}