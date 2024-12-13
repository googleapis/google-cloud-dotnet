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
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Command to modify BUILD.bazel files in-place, copying the transport value from
/// java_gapic_library to csharp_gapic_library, only if rest_numeric_enums is set to True.
/// This is expected to be run against a Google-internal source control location
/// (as the source of truth for the BUILD.bazel files) but is present in ReleaseManager
/// for ease of development and testing.
/// </summary>
public sealed class CopyTransportFromJavaCommand : CommandBase
{
    // Exclude directories containing libraries with hand-written surfaces,
    // or which are known to be unusual. We can come back to these.
    private static readonly HashSet<string> ExcludedDirectories = new()
    {
        "google/firestore/v1",
        "google/firestore/v1beta1",
        "grafeas/v1",
        "google/bigtable/v2",
        "google/pubsub/v1",
        "google/spanner/v1",
        // Known issue with auth
        "google/maps/addressvalidation/v1"
    };

    public CopyTransportFromJavaCommand()
        : base("copy-transport-from-java", "Copies transport values from BUILD.bazel java targets to corresponding csharp targets", "root", "max-modifications")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        string root = args[0];
        int maxModifications = int.Parse(args[1]);

        var bazelFiles = Directory.GetFiles(root, "BUILD.bazel", SearchOption.AllDirectories);

        int count = 0;
        foreach (var bazelFile in bazelFiles)
        {
            var relativePath = Path.GetRelativePath(root, bazelFile);
            string relativeDirectory = Path.GetDirectoryName(relativePath).Replace("\\", "/");
            if (ExcludedDirectories.Contains(relativeDirectory))
            {
                continue;
            }
            if (MaybeModify(bazelFile))
            {
                Console.WriteLine($"Modified {relativeDirectory}");
                count++;
                if (count == maxModifications)
                {
                    Console.WriteLine("Reached maximum number of modifications; stopping.");
                    break;
                }
            }
        }
        Console.WriteLine($"Modified files: {count}");
        return 0;
    }

    private static bool MaybeModify(string file)
    {
        var lines = File.ReadLines(file).ToList();
        int javaStart = lines.IndexOf("java_gapic_library(");
        int csharpStart = lines.IndexOf("csharp_gapic_library(");
        if (javaStart == -1 || csharpStart == -1)
        {
            return false;
        }

        int javaEnd = lines.IndexOf(")", javaStart);
        int csharpEnd = lines.IndexOf(")", csharpStart);

        if (!lines.Skip(csharpStart).Take(csharpEnd - csharpStart).Any(line => line.Contains("rest_numeric_enums = True")))
        {
            return false;
        }

        var javaTransportLine = lines.Skip(javaStart).Take(javaEnd - javaStart).FirstOrDefault(line => line.Contains("transport ="));
        var csharpTransportLine = lines.Skip(csharpStart).Take(csharpEnd - csharpStart).FirstOrDefault(line => line.Contains("transport ="));

        if (javaTransportLine is null || javaTransportLine == csharpTransportLine)
        {
            return false;
        }

        if (javaTransportLine.Contains("= \"grpc\"") && csharpTransportLine is not null)
        {
            Console.WriteLine($"Ignoring downgrade in {file} from {csharpTransportLine.Trim()} to just grpc");
            return false;
        }

        if (csharpTransportLine is null)
        {
            lines.Insert(csharpEnd, javaTransportLine);
        }
        else
        {
            int index = lines.IndexOf(csharpTransportLine, csharpStart);
            lines[index] = javaTransportLine;
        }
        File.WriteAllLines(file, lines);
        return true;
    }
}
