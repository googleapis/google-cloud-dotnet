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

using System.IO.Compression;
using System.Net;
using System.Security.Cryptography;
using System.Text.Json;
using System.Xml.Serialization;

namespace Google.Cloud.Tools.SbomGenerator;

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
        if (args.Length != 1)
        {
            Console.WriteLine(@"generate-sbom tool examines a .nupkg file and writes an SPDX SBOM JSON file next to it.");
            Console.WriteLine("Usage:");
            Console.WriteLine("dotnet generate-sbom <path-to-.nupkg>");
            return;
        }
        string nupkgPath = args[0];
        WriteSpdx(nupkgPath);
    }

    /// <summary>
    /// Examines a .nupkg file and writes an SPDX SBOM json file next to it.
    /// </summary>
    /// <param name="nupkgPath">Path to .nupkg file.</param>
    private static void WriteSpdx(string nupkgPath)
    {
        Console.WriteLine($"Generating SBOM for {nupkgPath}.");

        var spdx = GenerateSpdx(nupkgPath);
        var sbomPath = $"{nupkgPath}-sbom.spdx.json";

        File.WriteAllText(sbomPath, JsonSerializer.Serialize(spdx, s_indented));
        
        Console.WriteLine($"SBOM written to {sbomPath}.");
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
    private static Spdx GenerateSpdx(string nupkgPath)
    {
        // Get a hash and a uuid for the Nuget package.
        var (hash, uuid) = GetSha256AndGuid(nupkgPath);

        // Get information from the .nuspec file.
        var nuspecPackage = GetNuspecMetadata(nupkgPath);

        var nupkgFileName = Path.GetFileName(nupkgPath);

        // Assemble a SPDX SBOM.
        var spdx = new Spdx
        {
            Name = nuspecPackage.Metadata.NameWithVersion,
            DocumentNamespace = $"https://spdx.google/{uuid}",
            Packages = new List<Spdx.SpdxPackage>
            {
                new Spdx.SpdxPackage
                {
                    Name = nuspecPackage.Metadata.Id,
                    FileName = nupkgFileName,
                    SpdxId = $"SPDXRef-Package-{nupkgFileName}-{uuid}",
                    Version = nuspecPackage.Metadata.Version,
                    Description = nuspecPackage.Metadata.Description,
                    Checksums = new List<Spdx.SpdxPackage.SpdxChecksum>
                    {
                        new Spdx.SpdxPackage.SpdxChecksum
                        {
                            Algorithm = "SHA256",
                            Value = hash
                        }
                    },
                    ExternalReferences = new List<Spdx.SpdxPackage.SpdxPackageExternalReference>
                    {
                        new Spdx.SpdxPackage.SpdxPackageExternalReference
                        {
                            Locator = $"pkg:nuget/{nuspecPackage.Metadata.NameWithVersion}"
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
    private static NuspecPackage GetNuspecMetadata(string nupkgPath)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(NuspecPackage));
        using var zipFile = ZipFile.OpenRead(nupkgPath);
        using var nuspecStream = zipFile.Entries.Single(entry => Path.GetExtension(entry.Name).ToLower() == ".nuspec").Open();
        return xmlSerializer.Deserialize(nuspecStream) as NuspecPackage;
    }

    private static (string hash, string uuid) GetSha256AndGuid(string nupkgPath)
    {
        // Compute the SHA-256 hash of the .nupkg file.
        using var sha256 = SHA256.Create();
        using var file = File.OpenRead(nupkgPath);

        var hashBytes = sha256.ComputeHash(file);

        // Use the SHA-256 hash to create a deterministic uuid.
        var uuid = Uuid5FromHash(hashBytes);

        return (BitConverter.ToString(hashBytes).Replace("-", ""), uuid.ToString());
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
