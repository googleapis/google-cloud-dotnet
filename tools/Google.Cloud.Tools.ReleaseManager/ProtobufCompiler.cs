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
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Wrapper for protoc.
/// </summary>
internal sealed class ProtobufCompiler
{
    private const string ProtocEnvironmentVariable = "PROTOC";
    private const string ProtobufToolsRootEnvironmentVariable = "PROTOBUF_TOOLS_ROOT";

    private readonly string _protocBinary;
    private readonly string _protobufToolsRootDirectory;

    /// <summary>
    /// Determines the configuration based on environment variables but does not validate it.
    /// </summary>
    internal ProtobufCompiler()
    {
        _protocBinary = Environment.GetEnvironmentVariable(ProtocEnvironmentVariable);
        _protobufToolsRootDirectory = Environment.GetEnvironmentVariable(ProtobufToolsRootEnvironmentVariable);
    }

    /// <summary>
    /// Validates that protoc and the protobuf tools root directory are present.
    /// </summary>
    internal void ValidateConfiguration()
    {
        if (string.IsNullOrEmpty(_protocBinary))
        {
            throw new UserErrorException($"Environment variable '{ProtocEnvironmentVariable}' not set");
        }
        if (string.IsNullOrEmpty(_protobufToolsRootDirectory))
        {
            throw new UserErrorException($"Environment variable '{ProtobufToolsRootEnvironmentVariable}' not set");
        }
        if (!File.Exists(_protocBinary))
        {
            throw new UserErrorException($"Expected protoc file doesn't exist: '{_protocBinary}'");
        }
        if (!Directory.Exists(_protobufToolsRootDirectory))
        {
            throw new UserErrorException($"Expected protobuf tools root doesn't exist: '{_protobufToolsRootDirectory}'");
        }
    }

    /// <summary>
    /// Runs protoc with the specified custom arguments, assuming common include paths (-I arguments),
    /// and fetching all protos (recursively) from the given proto directory. Output from protoc is
    /// propagated to stdout, but filtering out lines containing " is unused" (which are common for unused imports).
    /// </summary>
    /// <param name="googleapis">The root directory of API definitions.</param>
    /// <param name="protoDirectory">The directory containing protos to be compiled (expected to be within <paramref name="googleapis"/>).</param>
    /// <param name="additionalArgs">Additional arguments to protoc, such as plugins and output directories.</param>
    internal void Execute(string googleapis, string protoDirectory, params string[] additionalArgs)
    {
        var protos = Directory.GetFiles(protoDirectory, "*.proto", SearchOption.AllDirectories);
        var psi = new ProcessStartInfo
        {
            FileName = _protocBinary,
            ArgumentList =
            {
                // Common arguments
                "-I", googleapis,
                "-I", Path.Combine(_protobufToolsRootDirectory, "tools")
            }
        };
        // Then the additional arguments passed in, then the protos.
        foreach (var arg in additionalArgs.Concat(protos))
        {
            psi.ArgumentList.Add(arg);
        }
        Processes.RunAndPropagateOutput(psi, "protoc", line => !line.Contains(" is unused."));
    }
}
