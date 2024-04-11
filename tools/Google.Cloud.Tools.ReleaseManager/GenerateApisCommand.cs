// Copyright 2024 Google LLC
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
using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

internal class GenerateApisCommand : ICommand
{
    private static readonly string[] BashLocations =
    {
        @"C:\Program Files\Git\usr\bin\bash.exe",
        "/usr/bin/bash"
    };
    private const string ProtocEnvironmentVariable = "PROTOC";
    private const string ProtobufToolsRootEnvironmentVariable = "PROTOBUF_TOOLS_ROOT";
    private const string GapicGeneratorEnvironmentVariable = "GAPIC_PLUGIN";
    private const string GrpcGeneratorEnvironmentVariable = "GRPC_PLUGIN";
    private const string GoogleApisDirectoryEnvironmentVariable = "GOOGLEAPIS";
    private const string TempDir = "tmp";

    private readonly string protocBinary;
    private readonly string gapicGeneratorBinary;
    private readonly string grpcGeneratorBinary;
    private readonly string googleApisDirectory;
    private readonly string protobufToolsRootDirectory;

    public string Description => "Generates APIs (used by generateapis.sh)";

    public string Command => "generate-apis";

    public string ExpectedArguments => $"[id...] (defaults to all APIs)";

    public GenerateApisCommand()
    {
        // These are only *validated* in Execute.
        protocBinary = Environment.GetEnvironmentVariable(ProtocEnvironmentVariable);
        gapicGeneratorBinary = Environment.GetEnvironmentVariable(GapicGeneratorEnvironmentVariable);
        grpcGeneratorBinary = Environment.GetEnvironmentVariable(GrpcGeneratorEnvironmentVariable);
        googleApisDirectory = Environment.GetEnvironmentVariable(GoogleApisDirectoryEnvironmentVariable);
        protobufToolsRootDirectory = Environment.GetEnvironmentVariable(ProtobufToolsRootEnvironmentVariable);
    }

    public int Execute(string[] args)
    {
        ValidateEnvironment();
        var catalog = ApiCatalog.Load();
        var apis = new List<ApiMetadata>();

        // If APIs have been specified, check they all exist before we start.
        if (args.Length == 0)
        {
            apis = catalog.Apis.Where(api => api.Generator != GeneratorType.None).ToList();
        }
        else
        {
            foreach (var id in args)
            {
                if (!catalog.TryGetApi(id, out var api))
                {
                    throw new UserErrorException($"API '{id}' is not in the API catalog.");
                }
                apis.Add(api);
            }
        }

        Directory.Delete(TempDir, true);
        Directory.CreateDirectory(TempDir);

        foreach (var api in apis)
        {
            Generate(api);
        }

        Console.WriteLine($"Regenerating projects");
        new GenerateProjectsCommand().Execute(new string[0]);

        return 0;
    }

    private void Generate(ApiMetadata api)
    {
        var layout = DirectoryLayout.ForApi(api.Id);
        Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff}Z Generating {api.Id}");
        MaybeRunScript("pregeneration.sh");
        switch (api.Generator)
        {
            case GeneratorType.Micro:
                GenerateGapicApi(api);
                break;
            case GeneratorType.Proto:
                GenerateProtoApi(api);
                break;
            default:
                throw new UserErrorException($"Unsupported generator type '{api.Generator}'");
        }
        MaybeRunScript("postgeneration.sh");
        ValidateNamespaces();

        void MaybeRunScript(string script)
        {
            var fullScript = Path.Combine(layout.SourceDirectory, script);
            if (!File.Exists(fullScript))
            {
                return;
            }
            Console.WriteLine($"Running {script}");
            var psi = new ProcessStartInfo
            {
                FileName = GetBashExecutable(),
                WorkingDirectory = layout.SourceDirectory,
                ArgumentList = { script }
            };
            Processes.RunAndPropagateOutput(psi, script);
        }

        void ValidateNamespaces()
        {
            // We only validate the top-level directory - this mirrors the old bash script; the code to validate nested
            // directories would be more complex for very limited benefit.
            foreach (var file in Directory.GetFiles(Path.Combine(layout.SourceDirectory, api.Id), "*.g.cs"))
            {
                var nsLine = File.ReadLines(file).FirstOrDefault(line => line.StartsWith("namespace", StringComparison.Ordinal));
                if (nsLine is null)
                {
                    throw new UserErrorException($"File '{file}' does not include a namespace declaration");
                }
                // Handle either kind of namespace declaration.
                var ns = nsLine.Split(' ')[1].TrimEnd(';');
                if (ns != api.Id && ns != "Microsoft.Extensions.DependencyInjection")
                {
                    if (api.Id == "Google.LongRunning")
                    {
                        // We know that Google.LongRunning contains Google.Cloud
                        Console.WriteLine($"Ignoring namespace '{ns}' in {api.Id} file {Path.GetFileName(file)}");
                    }
                    else
                    {
                        throw new UserErrorException($"Incorrect namespace '{ns}' in {api.Id} file {Path.GetFileName(file)}");
                    }
                }
            }
        }
    }

    private void GenerateGapicApi(ApiMetadata api)
    {
        var layout = DirectoryLayout.ForApi(api.Id);
        string productionDirectory = Path.Combine(layout.SourceDirectory, api.Id);
        DeleteGeneratedFiles(productionDirectory);
        DeleteGeneratedFiles(Path.Combine(layout.SourceDirectory, $"{api.Id}.Snippets"));
        DeleteGeneratedFiles(Path.Combine(layout.SourceDirectory, $"{api.Id}.GeneratedSnippets"));
        var protosDir = Path.Combine(googleApisDirectory, api.ProtoPath);

        // We remember any existing project files, so we can reset them afterwards -
        // we don't want anything generated by the GAPIC generator. We don't
        // specifically restrict this to project files we expect to be generated - there's
        // no harm in reading/writing unnecessarily, and it avoids additional knowledge of the generator.
        var projectFileCache = Directory.GetFiles(layout.SourceDirectory, "*.csproj", SearchOption.AllDirectories)
            .ToDictionary(path => path, path => File.ReadAllBytes(path));

        // Message and service generation. This doesn't need the common resources,
        // and we don't want to pass in the common resources proto because we don't
        // want to generate it.
        RunProtoc(protosDir,
            $"--csharp_out={productionDirectory}",
            $"--csharp_opt=base_namespace={api.Id}",
            "--csharp_opt=file_extension=.g.cs",
            $"--grpc_out={productionDirectory}",
            $"--grpc_opt=base_namespace={api.Id}",
            "--grpc_opt=file_suffix=Grpc.g.cs",
            $"--plugin=protoc-gen-grpc={grpcGeneratorBinary}");

        // GAPIC generation, which requires rather more configuration.
        var allGapicArguments = new List<string>
        {
            $"--gapic_out={layout.SourceDirectory}",
            "--plugin",
            $"protoc-gen-gapic={gapicGeneratorBinary}"
        };

        foreach (var (name, value) in GetGapicPluginOptions())
        {
            allGapicArguments.Add($"--gapic_opt={name}={value}");
        }

        // Include Cloud Common protos so that operation result/metadata types can use the messages in them.
        // Nothing will be generated for these protos though.
        foreach (var proto in Directory.GetFiles(Path.Combine(googleApisDirectory, "google", "cloud", "common"), "*.proto"))
        {
            allGapicArguments.Add(proto);
        }
        // Conditionally include Cloud common resources.
        if (api.IncludeCommonResourcesProto == true)
        {
            allGapicArguments.Add($"{googleApisDirectory}/google/cloud/common_resources.proto");
        }

        RunProtoc(protosDir, allGapicArguments.ToArray());

        // Restore project files
        foreach (var entry in projectFileCache)
        {
            File.WriteAllBytes(entry.Key, entry.Value);
        }

        IEnumerable<(string name, string value)> GetGapicPluginOptions()
        {
            string apiSrcDir = Path.Combine(googleApisDirectory, api.ProtoPath);
            yield return ("log", $"tmp/generator-log-{api.Id}.txt");
            yield return ("transport", api.Transport ?? "grpc");
            yield return ("rest-numeric-enums", api.RestNumericEnums.ToString());

            if (api.ServiceConfigFile != "none")
            {
                yield return("service-config", $"{apiSrcDir}/{api.ServiceConfigFile}");
            }

            var serviceConfigFiles = Directory.GetFiles(apiSrcDir, "*_grpc_service_config.json");
            if (serviceConfigFiles.Length == 1)
            {
                yield return ("grpc-service-config", serviceConfigFiles[0]);
            }

            yield return ("common-resources-config", "CommonResourcesConfig.json");
            if (api.CommonResourcesConfig is string config)
            {
                yield return ("common-resources-config", config);
            }
        }
    }

    private void GenerateProtoApi(ApiMetadata api)
    {
        var layout = DirectoryLayout.ForApi(api.Id);
        string productionDirectory = Path.Combine(layout.SourceDirectory, api.Id);
        DeleteGeneratedFiles(productionDirectory);
        var protosDir = Path.Combine(googleApisDirectory, api.ProtoPath);
        RunProtoc(protosDir,
            $"--csharp_out={productionDirectory}",
            $"--csharp_opt=base_namespace={api.Id}",
            "--csharp_opt=file_extension=.g.cs");
    }

    /// <summary>
    /// Runs protoc with the specified custom arguments, assuming common include paths (-I arguments),
    /// and fetching all protos (recursively) from the given proto directory.
    /// </summary>
    private void RunProtoc(string protoDirectory, params string[] customArgs)
    {
        var protos = Directory.GetFiles(protoDirectory, "*.proto", SearchOption.AllDirectories);
        var psi = new ProcessStartInfo
        {
            FileName = protocBinary,
            ArgumentList =
            {
                // Common arguments
                "-I", googleApisDirectory,
                "-I", Path.Combine(protobufToolsRootDirectory, "tools")
            }
        };
        // Then the custom arguments passed in, then the protos.
        foreach (var arg in customArgs.Concat(protos))
        {
            psi.ArgumentList.Add(arg);
        }
        Processes.RunAndPropagateOutput(psi, "protoc", line => !line.Contains(" is unused."));
    }

    private void DeleteGeneratedFiles(string directory)
    {
        if (!Directory.Exists(directory))
        {
            return;
        }
        var files = Directory.EnumerateFiles(directory, "*.g.cs", new EnumerationOptions { RecurseSubdirectories = true });
        foreach (var file in files)
        {
            File.Delete(file);
        }
    }

    private void ValidateEnvironment()
    {
        ValidateFile(protocBinary, "protoc");
        ValidateFile(gapicGeneratorBinary, "GAPIC generator");
        ValidateFile(grpcGeneratorBinary, "gRPC generator");
        ValidateDirectory(googleApisDirectory, "googleapis");
        ValidateDirectory(protobufToolsRootDirectory, "protobuf tools root");
        // This will throw if we can't detect bash.
        GetBashExecutable();

        void ValidateFile(string file, string description)
        {
            ValidateSpecified(file, description);
            if (!File.Exists(file))
            {
                throw new UserErrorException($"File for {description} doesn't exist: '{file}'");
            }
        }

        void ValidateDirectory(string directory, string description)
        {
            ValidateSpecified(directory, description);
            if (!Directory.Exists(directory))
            {
                throw new UserErrorException($"Directory for {description} doesn't exist: '{directory}'");
            }
        }

        void ValidateSpecified(string value, string description)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new UserErrorException($"No value specified for {description}");
            }
        }
    }

    private static string GetBashExecutable() =>
        BashLocations.FirstOrDefault(File.Exists) ??
        throw new UserErrorException("Bash does not exist in any default location");

    /// <summary>
    /// Equivalent to File.Delete, but with no expectation that a file exists or even that the directory
    /// containing it exists.
    /// </summary>
    private static void MaybeDelete(string file)
    {
        if (File.Exists(file))
        {
            File.Delete(file);
        }
    }
}
