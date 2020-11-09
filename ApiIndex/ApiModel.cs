// Copyright 2020, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
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

using Google.Cloud.Tools.ApiIndex.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using static Google.Cloud.Tools.ApiIndex.V1.Api.Types;
using FileOptions = Google.Protobuf.Reflection.FileOptions;

namespace Google.Cloud.Tools.ApiIndex
{
    /// <summary>
    /// Internal representation of an API, without reference to any specific schema version.
    /// </summary>
    public class ApiModel
    {
        private static readonly Regex ApiMajorVersionPattern = new Regex("^v[0-9]+");

        /// <summary>
        /// The ID of the API, which is identical to the protobuf package.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Directory relative to googleapis.
        /// </summary>
        public string Directory { get; }

        /// <summary>
        /// Title from the service config file.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Description from the service config file.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Host name taken from the "name" property of the service config file.
        /// </summary>
        public string HostName { get; }

        /// <summary>
        /// Version, derived from the directory.
        /// </summary>
        public string Version { get; }

        public string MajorVersion { get; }

        /// <summary>
        /// Proto files which are part of this API.
        /// </summary>
        public IReadOnlyList<FileDescriptor> Files { get; }

        public IReadOnlyList<ServiceModel> Services { get; }

        private ApiModel(string directory, ServiceConfig serviceConfig, IReadOnlyList<FileDescriptor> descriptorSet)
        {
            Directory = directory;
            // We want all the protos in the given directory, so the name must start with that directory name *and have a slash*
            // to avoid (say) v1beta protos being included in v1.
            var namePrefix = directory + "/";
            Files = descriptorSet.Where(file => file.Name.StartsWith(namePrefix)).ToList().AsReadOnly();

            // TODO: Validate that the protobuf packages are (or start with) this.
            Id = directory.Replace('/', '.');

            Title = serviceConfig.Title;
            Description = serviceConfig.Documentation?.Summary?.Replace('\n', ' ') ?? "<UNKNOWN - NO SERVICE CONFIG DOCUMENTATION SUMMARY>";
            Version = directory.Split('/').Last();
            MajorVersion = ApiMajorVersionPattern.Match(Version).Value;
            HostName = serviceConfig.Name;

            Services = Files.SelectMany(file => file.Services)
                .OrderBy(service => service.FullName)
                .Select(service => new ServiceModel(service))
                .ToList()
                .AsReadOnly();
        }

        public static IReadOnlyList<ApiModel> Load(FileDescriptorSet descriptorSet, string googleApisRoot)
        {
            var descriptorByteStrings = descriptorSet.File.Select(proto => proto.ToByteString());
            var allDescriptors = FileDescriptor.BuildFromByteStrings(descriptorByteStrings).ToList().AsReadOnly();

            var models = new List<ApiModel>();
            AddServiceConfigsRecursively(googleApisRoot);

            return models.OrderBy(model => model.Id, StringComparer.Ordinal).ToList().AsReadOnly();

            void AddServiceConfigsRecursively(string directory)
            {
                // Only load service config files from versioned directories (e.g. "google/spanner/v1")
                if (ApiMajorVersionPattern.IsMatch(Path.GetFileName(directory)))
                {
                    string relativeDirectory = Path.GetRelativePath(googleApisRoot, directory).Replace('\\', '/');
                    var configsInDirectory = System.IO.Directory.GetFiles(directory, "*.yaml")
                        .Select(ServiceConfig.TryLoadFile)
                        .Where(config => config != null)
                        .ToList();
                    switch (configsInDirectory.Count)
                    {
                        case 0: break;
                        case 1:
                            models.Add(new ApiModel(relativeDirectory, configsInDirectory[0], allDescriptors));
                            break;
                        default:
                            models.Add(new ApiModel(relativeDirectory, configsInDirectory[0], allDescriptors));
                            Console.WriteLine($"Directory '{relativeDirectory}' contains {configsInDirectory.Count} service (API) config YAML files.");
                            break;
                    }
                }
                else
                {
                    // Note: we assume there are no "nested" APIs
                    foreach (var subdir in System.IO.Directory.GetDirectories(directory))
                    {
                        AddServiceConfigsRecursively(subdir);
                    }
                }
            }
        }

        public V1.Api ToV1Api() =>
            new V1.Api
            {
                Description = Description,
                Directory = Directory,
                Id = Directory.Replace('/', '.'),
                Title = Title,
                HostName = HostName,
                Version = Version,
                MajorVersion = MajorVersion,
                ImportDirectories =
                {
                    Files
                        .SelectMany(file => file.Dependencies)
                        .Select(import => Path.GetDirectoryName(import.Name).Replace('\\', '/'))
                        .Distinct()
                        .OrderBy(import => import, StringComparer.Ordinal)
                },
                Services = { Services.Select(svc => svc.ToV1Service()) },
                Options = { BuildOptionsMap() }
                // TODO: Options
            };

        private IDictionary<string, OptionValues> BuildOptionsMap()
        {
            // Just create a sequence of name/value pairs.
            var allOptions = Files.SelectMany(file => ListOptions(file.GetOptions()));

            // Then group by those names, creating an OptionValues for each option, and
            // then building a dictionary.
            return allOptions.GroupBy(pair => pair.Key, (key, pairs) => (key, optionValues: BuildOptionValues(pairs.Select(pair => pair.Value))))
                .ToDictionary(pair => pair.key, pair => pair.optionValues);

            OptionValues BuildOptionValues(IEnumerable<string> values)
            {
                var paddedValues = values.Concat(Enumerable.Repeat("", Files.Count - values.Count()));
                var dictionary = paddedValues.GroupBy(value => value, (value, values) => (key: value, count: values.Count()))
                    .ToDictionary(pair => pair.key, pair => pair.count);
                return new OptionValues
                {
                    ValueCounts = { dictionary }
                };
            }
        }

        private static readonly FieldDescriptor[] ExcludedOptionFields =
        {
            // Uninterpreted options aren't useful to us.
            FileOptions.Descriptor.Fields[FileOptions.UninterpretedOptionFieldNumber],
            // This is naturally a single value per file; it's entirely reasonable for it to vary.
            FileOptions.Descriptor.Fields[FileOptions.JavaOuterClassnameFieldNumber],
            // This doesn't affect anything important, so it's cleaner to exclude it.
            FileOptions.Descriptor.Fields[FileOptions.OptimizeForFieldNumber],
        };
        private IEnumerable<KeyValuePair<string, string>> ListOptions(FileOptions options)
        {
            var optionFields = FileOptions.Descriptor.Fields.InFieldNumberOrder().Except(ExcludedOptionFields);
            foreach (var field in optionFields)
            {
                if (field.Accessor.HasValue(options))
                {
                    var objValue = field.Accessor.GetValue(options);
                    string textValue = objValue switch
                    {
                        string text => text,
                        bool b => b ? "true" : "false",
                        null => throw new InvalidOperationException($"Null value for option {field.Name}"),
                        // Make sure we represent enum values using the original value from the .proto file, not the C#-friendly version.
                        Enum enumValue => enumValue.GetType().GetField(enumValue.ToString()).GetCustomAttributes<OriginalNameAttribute>().Single().Name,
                        _ => throw new InvalidOperationException($"Unhandled type for option {field.Name}: {objValue.GetType()}"),
                    };
                    yield return KeyValuePair.Create(field.Name, textValue);
                }
            }
        }        
    }
}
