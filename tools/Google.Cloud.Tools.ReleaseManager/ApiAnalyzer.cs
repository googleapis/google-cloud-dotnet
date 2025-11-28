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

using Google.Api;
using Google.Cloud.Tools.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using YamlDotNet.Serialization;
using IOPath = System.IO.Path; // For disambiguation with the Path property

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Effectively replaces the API index by performing the same job, only for the information we actually need
/// to configure a library.
/// </summary>
internal sealed class ApiAnalyzer
{
    private readonly ProtobufCompiler _protoc;
    private readonly string _googleapis;

    internal ApiAnalyzer(ProtobufCompiler protoc, string googleapis)
    {
        _protoc = protoc;
        _googleapis = googleapis;
    }

    /// <summary>
    /// Returns an <see cref="ApiMetadata"/> representation of an API path, by loading the protos,
    /// service config etc. The returns metadata is not added to <paramref name="catalog"/>.
    /// </summary>
    internal ApiMetadata ConfigureApi(string apiPath, ApiCatalog catalog)
    {
        var indexEntry = MiniIndexEntry.Load(_protoc, _googleapis, apiPath);
        var serviceConfig = ParseServiceConfigYaml(Path.Combine(_googleapis, indexEntry.Path, indexEntry.ServiceConfigFile));

        var api = new ApiMetadata
        {
            Id = indexEntry.CSharpNamespace,
            ProtoPath = indexEntry.Path,
            ProductName = indexEntry.Title.EndsWith(" API") ? indexEntry.Title[..^4] : indexEntry.Title,
            ProductUrl = serviceConfig.Publishing?.DocumentationUri,
            Description = indexEntry.Description,
            Version = "1.0.0-beta00",
            Type = ApiType.Grpc,
            Generator = GeneratorType.Micro,
            // Let's not include test dependencies, which are rarely useful.
            TestDependencies = null,
            // Translate the host name into the "short name", e.g. bigquery.googleapis.com => bigquery
            ShortName = indexEntry.ServiceName.Split('.').First(),
            // The service config file is always populated in the index, so we don't need to translate empty to null here.
            ServiceConfigFile = indexEntry.ServiceConfigFile
        };

        // Add dependencies discovered via the proto imports.
        // This doesn't fail on any dependencies that aren't found - we could tighten this up later
        // by knowing about common protos, for example.
        var apisByProtoPath = catalog.Apis.Where(api => api.ProtoPath is object).ToDictionary(api => api.ProtoPath);
        foreach (var import in indexEntry.ImportDirectories)
        {
            if (apisByProtoPath.TryGetValue(import, out var dependency))
            {
                api.Dependencies.Add(dependency.Id, dependency.Version);
            }
        }

        // Add mixin dependencies discovered via APIs listed in the service config file.
        // This *does* fail if we can't find the API, as that would indicate a general issue.
        foreach (var mixin in indexEntry.MixinPackages)
        {
            api.Dependencies[mixin] = catalog[mixin].Version;
        }

        // Add any other information from BUILD.bazel
        UpdateFromBazel(api, _googleapis);
        return api;
    }

    internal static Service ParseServiceConfigYaml(string path)
    {
        if (path is null)
        {
            return null;
        }

        var deserializer = new Deserializer();
        using (var reader = File.OpenText(path))
        {
            var yamlObject = deserializer.Deserialize(reader);
            var serializer = new SerializerBuilder().JsonCompatible().Build();
            var writer = new StringWriter();
            serializer.Serialize(writer, yamlObject);
            string json = writer.ToString();
            // Hack to avoid proto parse failures with the serialized JSON: YamlDotNet serializes
            // values as strings (because it doesn't know that they're Boolean). Ideally, we should
            // deserialize straight from YAML to a Service...
            json = json.Replace("\"true\"", "true").Replace("\"false\"", "false");
            var parser = new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));
            return parser.Parse<Service>(json);
        }
    }

    internal static bool UpdateFromBazel(ApiMetadata api, string googleapis)
    {
        var bazelFile = Path.Combine(googleapis, api.ProtoPath, "BUILD.bazel");
        if (!File.Exists(bazelFile))
        {
            throw new UserErrorException($"Expected Bazel file does not exist: '{bazelFile}'");
        }

        var lines = File.ReadAllLines(bazelFile).ToList();
        var csharpGapicLibraryTargetLines = LoadTargetLines("csharp_gapic_library");
        if (csharpGapicLibraryTargetLines is null)
        {
            // This is effectively a warning. (AI Platform has it commented out, for example.)
            Console.WriteLine($"Warning: Bazel file for {api.Id} does not include csharp_gapic_library target.");
            return false;
        }
        var csharpGapicLibraryProperties = csharpGapicLibraryTargetLines
                .Select(line => line.TrimEnd(','))
                .Where(line => line.Contains('='))
                .Select(line => line.Split('=', 2))
                .ToDictionary(bits => bits[0].Trim(), bits => bits[1].Trim('"', ' '));

        var protoLibraryWithInfoLines = LoadTargetLines("proto_library_with_info");

        bool updated = false;

        MaybeUpdateRestNumericEnums();
        MaybeUpdateTransport();
        MaybeUpdateServiceConfigFile();
        MaybeUpdateIncludeCommonResourcesProto();

        return updated;

        void UpdateOrAddJson(string key, object value)
        {
            if (api.Json is not JObject obj)
            {
                return;
            }
            if (obj.ContainsKey(key))
            {
                obj[key] = JToken.FromObject(value);
            }
            else
            {
                obj.Last.AddAfterSelf(new JProperty(key, value));
            }
            updated = true;
        }

        List<string> LoadTargetLines(string target)
        {
            var start = lines.IndexOf($"{target}(");
            if (start == -1)
            {
                return null;
            }
            var end = lines.IndexOf(")", start);
            // Second check is just a safety-net, in case the end of the target is formatted badly and we've picked up a later one.
            if (end == -1 || end - start > 20)
            {
                throw new UserErrorException($"Cannot find end of ${target} target in Bazel file for {api.Id}.");
            }

            // We should only have one target of the given name, otherwise we don't know what to do.
            // There are a few exceptions to this, so we just log a warning and return the first target.
            var nextStart = lines.IndexOf($"{target}(", start + 1);
            if (nextStart != -1)
            {
                Console.WriteLine($"Warning: Multiple {target} targets in Bazel file for {api.Id}. Using the first target.");
            }

            // This is really pretty horrible, but it will do the job...
            return lines
                .Skip(start)
                .Take(end - start)
                .ToList();
        }

        void MaybeUpdateRestNumericEnums()
        {
            bool restNumericEnums = csharpGapicLibraryProperties.TryGetValue("rest_numeric_enums", out var restNumericEnumsValue) && restNumericEnumsValue == "True";
            if (api.RestNumericEnums != restNumericEnums)
            {
                api.RestNumericEnums = restNumericEnums;
                UpdateOrAddJson("restNumericEnums", restNumericEnums);
            }
        }

        void MaybeUpdateTransport()
        {
            string transport = csharpGapicLibraryProperties.GetValueOrDefault("transport", "grpc");
            if ((api.Transport ?? "grpc") != transport)
            {
                api.Transport = transport;
                UpdateOrAddJson("transport", transport);
            }
        }

        void MaybeUpdateServiceConfigFile()
        {
            string serviceConfig = csharpGapicLibraryProperties.GetValueOrDefault("service_yaml", "none");
            serviceConfig = serviceConfig.Split(':').Last();
            if (api.ServiceConfigFile != serviceConfig)
            {
                api.ServiceConfigFile = serviceConfig;
                UpdateOrAddJson("serviceConfigFile", serviceConfig);
            }
        }

        void MaybeUpdateIncludeCommonResourcesProto()
        {
            if (api.Generator != GeneratorType.Micro)
            {
                return;
            }
            bool includeCommonResourcesProto = protoLibraryWithInfoLines?.Any(line => line.Trim() == "\"//google/cloud:common_resources_proto\",") == true;
            if (includeCommonResourcesProto != api.IncludeCommonResourcesProto)
            {
                api.IncludeCommonResourcesProto = includeCommonResourcesProto;
                UpdateOrAddJson("includeCommonResourcesProto", includeCommonResourcesProto);
            }
        }
    }

    /// <summary>
    /// Just the bits of the old API Index which we need to configure an API.
    /// </summary>
    private sealed class MiniIndexEntry
    {
        private static readonly ImmutableDictionary<string, string> MixinDependencies = new Dictionary<string, string>()
        {
            { "google.cloud.location.Locations", "Google.Cloud.Location" },
            { "google.iam.v1.IAMPolicy","Google.Cloud.Iam.V1" },
            { "google.longrunning.Operations", "Google.LongRunning" }
        }.ToImmutableDictionary();

        private static readonly ExtensionRegistry s_registry = new ExtensionRegistry
        {
            ClientExtensions.DefaultHost,
            ClientExtensions.MethodSignature,
            ClientExtensions.OauthScopes,
            FieldBehaviorExtensions.FieldBehavior,
            AnnotationsExtensions.Http,
            ResourceExtensions.Resource,
            ResourceExtensions.ResourceDefinition,
            ResourceExtensions.ResourceReference
        };

        /// <summary>
        /// Directory within googleapis, e.g. google/cloud/functions/v2
        /// </summary>
        internal string Path { get; }
        internal string Title { get; }
        internal string CSharpNamespace { get; }
        internal string DocumentationUri { get; }
        internal string Description { get; }
        internal string ServiceName { get; }
        /// <summary>
        /// The name of the service config YAML file, relative to <see cref="Path"/>.
        /// </summary>
        internal string ServiceConfigFile { get; }
        internal ImmutableList<string> MixinPackages { get; }
        internal ImmutableList<string> ImportDirectories { get; }

        private MiniIndexEntry(string path, string serviceConfigFile, Service serviceConfig, ImmutableList<FileDescriptor> protoFiles)
        {
            Path = path;
            Title = serviceConfig.Title;
            CSharpNamespace = DeriveCSharpNamespace(protoFiles);
            DocumentationUri = serviceConfig.Publishing?.DocumentationUri;
            Description = serviceConfig.Documentation?.Summary?.Replace('\n', ' ') ?? "<UNKNOWN - NO SERVICE CONFIG DOCUMENTATION SUMMARY>";
            ServiceName = serviceConfig.Name;
            ServiceConfigFile = serviceConfigFile;

            MixinPackages = MixinDependencies
                .Join(serviceConfig.Apis, mixin => mixin.Key, api => api.Name, (mixin, api) => mixin.Value)
                .ToImmutableList();
            ImportDirectories = protoFiles
                .SelectMany(file => file.Dependencies)
                .Select(import => IOPath.GetDirectoryName(import.Name).Replace('\\', '/'))
                .Distinct()
                .OrderBy(import => import, StringComparer.Ordinal)
                .ToImmutableList();
        }

        private static string DeriveCSharpNamespace(ImmutableList<FileDescriptor> protoFiles)
        {
            // We want to enforce two rules:
            // - All namespaces have a common prefix (effectively representing the "root" package for the API).
            // - All files in the same protobuf package have the same namespace.
            // These are validated separately. The rules don't fully enforce "sensible" names, but they're
            // enough to catch simple errors.

            var allNamespaces = protoFiles.Select(GetCSharpNamespace).Distinct().OrderBy(ns => ns.Length).ToImmutableList();
            if (allNamespaces.Count == 0)
            {
                throw new UserErrorException("No namespaces available. Empty set of protos?");
            }
            var shortestNamespace = allNamespaces[0];
            // We expect all namespaces to have a common prefix - which should be the first entry in our list, as it's ordered
            // by length. For most APIs we'll only have a single entry anyway, but if there are APIs with subpackages of protos,
            // those should end up in their own namespace.
            foreach (var ns in allNamespaces)
            {
                if (!ns.StartsWith(shortestNamespace, StringComparison.Ordinal))
                {
                    throw new UserErrorException($"Inconsistent namespaces: {ns} is inconsistent with {shortestNamespace}");
                }
            }

            // Per-package checking
            var namespacesByProtoPackage = protoFiles.GroupBy(fd => fd.Package, GetCSharpNamespace);
            foreach (var group in namespacesByProtoPackage)
            {
                if (group.Distinct(StringComparer.Ordinal).Count() != 1)
                {
                    throw new UserErrorException($"Multiple namespaces for package '{group.Key}': {string.Join(", ", group)}");
                }
            }

            // Looks like it's probably reasonable.
            return shortestNamespace;

            static string GetCSharpNamespace(FileDescriptor desc)
            {
                // Order of looking for C# namespace: "csharp_namespace" option, proto package.
                // TODO: Also look for the "metadata" proto annotation: Metadata.PackageName
                string ns = desc?.GetOptions()?.CsharpNamespace;
                if (!string.IsNullOrEmpty(ns))
                {
                    return ns;
                }
                // As a fallback, capitalize the first character of each part of the proto package.
                return string.Join(".", desc.Package.Split('.').Select(x => ToUpperCamelCase(x)));
            }
        }

        internal static MiniIndexEntry Load(ProtobufCompiler protoc, string googleapis, string apiPath)
        {
            protoc.ValidateConfiguration();
            var descriptorFile = IOPath.GetTempFileName();
            protoc.Execute(googleapis, IOPath.Combine(googleapis, apiPath), $"--descriptor_set_out={descriptorFile}", "--include_imports");
            FileDescriptorSet descriptorSet = FileDescriptorSet.Parser.ParseFrom(File.ReadAllBytes(descriptorFile));
            var descriptorByteStrings = descriptorSet.File.Select(proto => proto.ToByteString());
            // We've included imports in order to get a complete file descriptor set, but we only want ones within our API
            // path. The FileDescriptor.Name property gives us the path to the proto; we need to add a "/" to our
            // apiPath to make sure we don't get descriptors from peer directories.
            // (For example, if we're looking for "a/b/v1" we don't want "a/b/v1beta/x.proto".)
            var prefix = apiPath + "/";
            var apiDescriptors = FileDescriptor.BuildFromByteStrings(descriptorByteStrings, s_registry)
                .Where(d => d.Name.StartsWith(prefix))
                .ToImmutableList();
            var (serviceConfig, serviceConfigFile) = LoadServiceConfig(googleapis, apiPath);
            return new(apiPath, serviceConfig, serviceConfigFile, apiDescriptors);
        }

        private static (string, Service) LoadServiceConfig(string googleapis, string apiPath)
        {
            var yamlPath = Directory.GetFiles(IOPath.Combine(googleapis, apiPath), "*.yaml")
                .Where(path => !IOPath.GetFileName(path).EndsWith("gapic.yaml"))
                .FirstOrDefault();
            if (yamlPath is null)
            {
                throw new UserErrorException($"No service config file found for API path '{apiPath}'");
            }
            return (IOPath.GetFileName(yamlPath), ParseServiceConfigYaml(yamlPath));
        }

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
}
