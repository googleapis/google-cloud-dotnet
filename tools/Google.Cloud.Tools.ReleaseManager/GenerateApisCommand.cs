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
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Google.Cloud.Tools.ReleaseManager;

internal class GenerateApisCommand : ICommand
{
    private static readonly string[] BashLocations =
    {
        @"C:\Program Files\Git\usr\bin\bash.exe",
        "/usr/bin/bash"
    };
    internal const string ProtocEnvironmentVariable = "PROTOC";
    internal const string ProtobufToolsRootEnvironmentVariable = "PROTOBUF_TOOLS_ROOT";
    internal const string GapicGeneratorEnvironmentVariable = "GAPIC_PLUGIN";
    internal const string GrpcGeneratorEnvironmentVariable = "GRPC_PLUGIN";
    internal const string GoogleApisDirectoryEnvironmentVariable = "GOOGLEAPIS";
    internal const string GeneratorOutputDirectoryEnvironmentVariable = "GENERATOR_OUTPUT_DIR";
    internal const string GeneratorInputDirectoryEnvironmentVariable = "GENERATOR_INPUT_DIR";

    private readonly RootLayout _rootLayout;
    private readonly string _protocBinary;
    private readonly string _gapicGeneratorBinary;
    private readonly string _grpcGeneratorBinary;
    private readonly string _protobufToolsRootDirectory;
    private readonly string _tempOutputDirectory;

    public string Description => "Generates APIs (used by generateapis.sh)";

    public string Command => "generate-apis";

    public string ExpectedArguments => $"[--unconfigured] [id...] (defaults to all APIs)";

    public GenerateApisCommand(RootLayout rootLayout)
    {
        // These are only *validated* in Execute.
        _rootLayout = rootLayout;
        _protocBinary = Environment.GetEnvironmentVariable(ProtocEnvironmentVariable);
        _gapicGeneratorBinary = Environment.GetEnvironmentVariable(GapicGeneratorEnvironmentVariable);
        _grpcGeneratorBinary = Environment.GetEnvironmentVariable(GrpcGeneratorEnvironmentVariable);
        _protobufToolsRootDirectory = Environment.GetEnvironmentVariable(ProtobufToolsRootEnvironmentVariable);
        _tempOutputDirectory = Path.Combine(Path.GetTempPath(), "generator-output");
    }

    public GenerateApisCommand() : this(
        RootLayout.ForGeneration(
            Environment.GetEnvironmentVariable(GeneratorInputDirectoryEnvironmentVariable),
            Environment.GetEnvironmentVariable(GeneratorOutputDirectoryEnvironmentVariable),
            Environment.GetEnvironmentVariable(GoogleApisDirectoryEnvironmentVariable)))
    {
    }

    public int Execute(string[] args)
    {
        ValidateEnvironment();
        if (Directory.Exists(_tempOutputDirectory))
        {
            Directory.Delete(_tempOutputDirectory, true);
        }
        Directory.CreateDirectory(_tempOutputDirectory);

        if (args.FirstOrDefault() == "--unconfigured")
        {
            return ExecuteForUnconfigured(args.Skip(1).ToArray());
        }

        var apis = new List<ApiMetadata>();
        var nonSourceGenerator = new NonSourceGenerator(_rootLayout);
        var catalog = nonSourceGenerator.ApiCatalog;

        // If APIs have been specified, check they all exist before we start.
        if (args.Length == 0)
        {
            apis = catalog.Apis.ToList();
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

        foreach (var api in apis)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff}Z Generating {api.Id}");
            if (api.Generator != GeneratorType.None)
            {
                Generate(api);
            }
            nonSourceGenerator.GenerateApiFiles(api);
        }
        nonSourceGenerator.GenerateNonApiFiles();

        return 0;
    }

    private void Generate(ApiMetadata api)
    {
        var apiLayout = _rootLayout.CreateGeneratorApiLayout(api);
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
            var fullScript = Path.Combine(apiLayout.TweaksDirectory, script);
            if (!File.Exists(fullScript))
            {
                return;
            }
            Console.WriteLine($"Running {script}");
            var psi = new ProcessStartInfo
            {
                FileName = GetBashExecutable(),
                WorkingDirectory = apiLayout.TweaksDirectory,
                ArgumentList = { script }
            };
            Processes.RunAndPropagateOutput(psi, script);
        }

        void ValidateNamespaces()
        {
            // We only validate the top-level directory - this mirrors the old bash script; the code to validate nested
            // directories would be more complex for very limited benefit.
            foreach (var file in Directory.GetFiles(apiLayout.ProductionDirectory, "*.g.cs"))
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
        var apiLayout = _rootLayout.CreateGeneratorApiLayout(api);
        string productionDirectory = apiLayout.ProductionDirectory;
        Directory.CreateDirectory(productionDirectory);
        DeleteGeneratedFiles(productionDirectory);
        DeleteGeneratedFiles(apiLayout.SnippetsDirectory);
        DeleteGeneratedFiles(apiLayout.GeneratedSnippetsDirectory);
        var protosDir = GetApiProtosDirectory(api.ProtoPath);

        // The project files will be generated by the GAPIC generator, but regenerated afterwards
        // using the API catalog, so we should end up with the right result. Importantly, this
        // means that any postgeneration scripts see just the GAPIC-generated project file, which
        // is helpful as it makes it easier to build in isolation.

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
            $"--plugin=protoc-gen-grpc={_grpcGeneratorBinary}");

        // GAPIC generation, which requires rather more configuration.
        var allGapicArguments = new List<string>
        {
            $"--gapic_out={apiLayout.SourceDirectory}",
            "--plugin",
            $"protoc-gen-gapic={_gapicGeneratorBinary}"
        };

        foreach (var (name, value) in GetGapicPluginOptions())
        {
            allGapicArguments.Add($"--gapic_opt={name}={value}");
        }

        // Include Cloud Common protos so that operation result/metadata types can use the messages in them.
        // Nothing will be generated for these protos though.
        foreach (var proto in Directory.GetFiles(GetApiProtosDirectory("google/cloud/common"), "*.proto"))
        {
            allGapicArguments.Add(proto);
        }
        // Conditionally include Cloud common resources.
        if (api.IncludeCommonResourcesProto == true)
        {
            allGapicArguments.Add($"{GetApiProtosDirectory("google/cloud")}/common_resources.proto");
        }

        RunProtoc(protosDir, allGapicArguments.ToArray());

        IEnumerable<(string name, string value)> GetGapicPluginOptions()
        {
            string apiSrcDir = GetApiProtosDirectory(api.ProtoPath);
            yield return ("log", Path.Combine(_tempOutputDirectory, $"generator-log-{api.Id}.txt"));
            yield return ("transport", api.Transport ?? "grpc");
            yield return ("rest-numeric-enums", api.RestNumericEnums.ToString());

            if (api.ServiceConfigFile != "none")
            {
                yield return ("service-config", $"{apiSrcDir}/{api.ServiceConfigFile}");
            }

            var serviceConfigFiles = Directory.GetFiles(apiSrcDir, "*_grpc_service_config.json");
            if (serviceConfigFiles.Length == 1)
            {
                yield return ("grpc-service-config", serviceConfigFiles[0]);
            }

            yield return ("common-resources-config", Path.Combine(_rootLayout.GeneratorInput, "CommonResourcesConfig.json"));
            if (api.CommonResourcesConfig is string config)
            {
                yield return ("common-resources-config", Path.Combine(_rootLayout.GeneratorInput, config));
            }
        }
    }

    private void GenerateProtoApi(ApiMetadata api)
    {
        var apiLayout = _rootLayout.CreateGeneratorApiLayout(api);
        string productionDirectory = Path.Combine(apiLayout.ProductionDirectory);
        Directory.CreateDirectory(productionDirectory);
        DeleteGeneratedFiles(productionDirectory);
        RunProtoc(GetApiProtosDirectory(api),
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
            FileName = _protocBinary,
            ArgumentList =
            {
                // Common arguments
                "-I", _rootLayout.Googleapis,
                "-I", Path.Combine(_protobufToolsRootDirectory, "tools")
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
        ValidateDirectory(_rootLayout.GeneratorInput, "generator output");
        ValidateDirectory(_rootLayout.GeneratorOutput, "generator input");
        ValidateDirectory(_rootLayout.Googleapis, "googleapis");
        ValidateFile(_protocBinary, "protoc");
        ValidateFile(_gapicGeneratorBinary, "GAPIC generator");
        ValidateFile(_grpcGeneratorBinary, "gRPC generator");
        ValidateDirectory(_protobufToolsRootDirectory, "protobuf tools root");
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

    // All code below here is for "unconfigured" generation. We may want to separate this from the code above
    // at some point, but this is a convenient location for prototyping.
    private int ExecuteForUnconfigured(string[] args)
    {
        if (args.Length == 0)
        {
            args = DetectApiDirectories();
        }

        if (Directory.Exists(_tempOutputDirectory))
        {
            Directory.Delete(_tempOutputDirectory, true);
        }
        Directory.CreateDirectory(_tempOutputDirectory);

        foreach (var arg in args)
        {
            GenerateUnconfigured(arg);
        }
        Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff}Z Generation complete.");
        return 0;
    }

    private void GenerateUnconfigured(string arg)
    {
        Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff}Z Generating {arg}");
        var apiDirectory = GetApiProtosDirectory(arg);
        var configFiles = GetServiceConfigFiles(apiDirectory);
        if (configFiles.Count != 1)
        {
            throw new UserErrorException($"{configFiles.Count} service config files detected in {arg}");
        }
        var serviceConfig = AddCommand.ParseServiceConfigYaml(configFiles[0]);

        // Copied from GenerateGapicApi and modified

        // First figure out the C# namespace, which we'd normally use as the ID.
        // We need to use a mixture of C# options and the protobuf package, just like the API Index does.
        // That means we first need to generate a descriptor file set.
        var descriptorFile = Path.Combine(_tempOutputDirectory, "descriptor.pb");
        try
        {
            RunProtoc(apiDirectory,
                $"--descriptor_set_out={descriptorFile}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff}Z API {arg} failed during initial FileDescriptorSet generation: {e.Message}");
            return;
        }

        FileDescriptorSet descriptorSet = FileDescriptorSet.Parser.ParseFrom(File.ReadAllBytes(descriptorFile));
        var expectedPackage = arg.Replace('/', '.');
        var namespaces = descriptorSet.File
            .Where(f => f.Package == expectedPackage) // Basically "only top-level protos"
            .Select(DeriveCSharpNamespace)
            .Distinct()
            .ToList();

        if (namespaces.Count != 1)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff}Z API {arg} failed: Inconsistent namespaces: {string.Join(", ", namespaces.Select(ns => $"'{ns}'"))}");
            return;
        }

        var id = namespaces[0];

        // Generate into a directory structure which matches the proto path name. (That makes it easy to find when building.)
        // This may seem redundant when only generating a single API, but it means users can generate multiple APIs to a single
        // output directory (even if that required multiple CLI invocations).
        var sourceDirectory = Path.Combine(_rootLayout.GeneratorOutput, arg);
        var productionDirectory = Path.Combine(sourceDirectory, id);
        Directory.CreateDirectory(productionDirectory);

        // Message and service generation. This doesn't need the common resources,
        // and we don't want to pass in the common resources proto because we don't
        // want to generate it.
        try
        {
            RunProtoc(apiDirectory,
                $"--csharp_out={productionDirectory}",
                $"--csharp_opt=base_namespace={id}",
                "--csharp_opt=file_extension=.g.cs",
                $"--grpc_out={productionDirectory}",
                $"--grpc_opt=base_namespace={id}",
                "--grpc_opt=file_suffix=Grpc.g.cs",
                $"--plugin=protoc-gen-grpc={_grpcGeneratorBinary}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff}Z API {arg} failed during message/service generation: {e.Message}");
            return;
        }

        // GAPIC generation, which requires rather more configuration.
        var allGapicArguments = new List<string>
        {
            $"--gapic_out={sourceDirectory}",
            "--plugin",
            $"protoc-gen-gapic={_gapicGeneratorBinary}"
        };

        foreach (var (name, value) in GetGapicPluginOptions())
        {
            allGapicArguments.Add($"--gapic_opt={name}={value}");
        }

        // Include Cloud Common protos so that operation result/metadata types can use the messages in them.
        // Nothing will be generated for these protos though.
        foreach (var proto in Directory.GetFiles(GetApiProtosDirectory("google/cloud/common"), "*.proto"))
        {
            allGapicArguments.Add(proto);
        }

        // TODO: use heuristics/block-lists to make more APIs generate cleanly.
        bool includeCommonResourcesProto = true;

        // Conditionally include Cloud common resources.
        if (includeCommonResourcesProto)
        {
            allGapicArguments.Add($"{_rootLayout.Googleapis}/google/cloud/common_resources.proto");
        }

        try
        {
            RunProtoc(apiDirectory, allGapicArguments.ToArray());
        }
        catch (Exception e)
        {
            Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff}Z API {arg} failed during GAPIC generation: {e.Message}");
            return;
        }

        var sln = Path.Combine(sourceDirectory, $"{id}.sln");
        var projects = new List<string>
        {
            id,
            $@"{id}.Snippets",
            $@"{id}.GeneratedSnippets",
        };
        NonSourceGenerator.GenerateSolutionFile(sln, projects);

        IEnumerable<(string name, string value)> GetGapicPluginOptions()
        {
            // Mostly hard-coded values, as we don't have the relevant configuration.
            yield return ("log", Path.Combine(sourceDirectory, "generator-log.txt"));
            yield return ("transport", "grpc");
            yield return ("rest-numeric-enums", "True");
            yield return ("service-config", configFiles[0]);
            yield return ("common-resources-config", Path.Combine(_rootLayout.GeneratorInput, "CommonResourcesConfig.json"));
        }
    }

    private string[] DetectApiDirectories()
    {
        Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff}Z Detecting API directories.");
        List<string> apiDirectories = new();
        var pending = new Queue<string>();
        Enqueue(Directory.GetDirectories(_rootLayout.Googleapis).Where(d => !d.EndsWith(".git")));
        while (pending.Count > 0)
        {
            var candidate = pending.Dequeue();
            var configFiles = GetServiceConfigFiles(candidate);
            switch (configFiles.Count)
            {
                // We've found an API: ignore child directories, but use this.
                case 1:
                    apiDirectories.Add(Path.GetRelativePath(_rootLayout.Googleapis, candidate).Replace('\\', '/'));
                    break;
                // Nothing: assume there may be child directories containing APIs.
                case 0:
                    Enqueue(Directory.GetDirectories(candidate));
                    break;
                // More than 1: warn, then ignore child directories.
                default:
                    Console.WriteLine($"WARNING: Directory '{candidate}' contains multiple service configs. Ignoring.");
                    break;
            }
        }
        Console.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff}Z Found {apiDirectories.Count} APIs.");
        return apiDirectories.OrderBy(x => x, StringComparer.Ordinal).ToArray();

        void Enqueue(IEnumerable<string> candidates)
        {
            foreach (var candidate in candidates)
            {
                pending.Enqueue(candidate);
            }
        }
    }

    private List<string> GetServiceConfigFiles(string directory)
    {
        return Directory.GetFiles(directory, "*.yaml")
            // Note: this assumes no leading or trailing whitespace. That's probably okay.
            .Where(f => File.ReadAllLines(f).Contains("type: google.api.Service"))
            .Where(HasApis)
            .ToList();

        // This is slow, but avoids directories with a service config but no APIs.
        bool HasApis(string file)
        {
            var config = AddCommand.ParseServiceConfigYaml(file);
            return config.Apis.Count > 0;
        }
    }

    private string GetApiProtosDirectory(ApiMetadata api) => GetApiProtosDirectory(api.ProtoPath);
    private string GetApiProtosDirectory(string relativePath) => Path.Combine(_rootLayout.Googleapis, relativePath);

    public string DeriveCSharpNamespace(FileDescriptorProto file) =>
        file.Options?.CsharpNamespace is string ns && ns != ""
            ? ns
            : string.Join('.', file.Package.Split('.').Select(bit => ToUpperCamelCase(bit)));

    // Copied from https://github.com/googleapis/gapic-generator-csharp/blob/main/Google.Api.Generator/Utils/SystemExtensions.cs.
    // We can move it somewhere more common if we need to...
    private static char MaybeForceCase(char c, bool? toUpper) =>
        toUpper is bool upper ? upper ? char.ToUpperInvariant(c) : char.ToLowerInvariant(c) : c;

    private static string Camelizer(string s, bool firstUpper, bool forceAllChars) =>
        s.Aggregate((upper: (bool?) firstUpper, prev: '\0', sb: new StringBuilder()), (acc, c) =>
            !char.IsLetterOrDigit(c) ?
                (acc.sb.Length > 0 ? true : firstUpper, c, acc.sb) :
                (char.IsDigit(c) ? true : forceAllChars ? (bool?) false : null, c,
                    acc.sb.Append(MaybeForceCase(c, char.IsLower(acc.prev) && char.IsUpper(c) ? true : acc.upper))),
            acc => acc.sb.ToString());

    private static string ToUpperCamelCase(string input, bool forceAllChars = false) => Camelizer(input, firstUpper: true, forceAllChars);
}
