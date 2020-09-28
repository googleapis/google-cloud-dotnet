// Copyright 2020 Google LLC
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

using Google.Cloud.Tools.Common;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace Google.Cloud.Tools.ConstructorGenerator
{
    /// <summary>
    /// One-off tool to generate constructors in partial classes for gRPC compatibility.
    /// </summary>
    class Program
    {
        private const string TestTargetFramework = "netcoreapp2.1";

        static void Main(string[] args)
        {
            var catalog = ApiCatalog.Load();

            var generateAwkward = args.Length == 1 && args[0] == "--awkward";

            var apis = catalog.Apis
                // Only use gRPC APIs
                .Where(api => api.Type == ApiType.Grpc)
                // If the minor version is greater than 0, there must be a GA release.
                .Where(api => api.StructuredVersion.Minor > 0 || api.IsReleaseVersion)
                // Generate LongRunning and IAM in a separate run, as they're dependencies of other APIs, which causes assembly loading issues.
                // Basically run the generator once without the --awkward flag, then once with.
                .Where(api => generateAwkward == (api.Id == "Google.LongRunning" || api.Id == "Google.Cloud.Iam.V1"));
            foreach (var api in apis)
            {
                GenerateConstructors(api);
            }
        }

        static void GenerateConstructors(ApiMetadata api)
        {
            Console.WriteLine($"Processing {api.Id}");
            var asm = PublishUnitTestsAndLoadAssembly(api);
            var clientTypes = asm.GetTypes().Where(t => t.IsClass && t.BaseType.IsConstructedGenericType && t.BaseType.GetGenericTypeDefinition() == typeof(ClientBase<>)).ToList();

            if (clientTypes.Count > 0)
            {
                var lines = new List<string>
                {
                    "// Copyright 2020 Google LLC",
                    "//",
                    "// Licensed under the Apache License, Version 2.0 (the \"License\");",
                    "// you may not use this file except in compliance with the License.",
                    "// You may obtain a copy of the License at",
                    "//",
                    "//     https://www.apache.org/licenses/LICENSE-2.0",
                    "//",
                    "// Unless required by applicable law or agreed to in writing, software",
                    "// distributed under the License is distributed on an \"AS IS\" BASIS,",
                    "// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.",
                    "// See the License for the specific language governing permissions and",
                    "// limitations under the License.",
                    "",
                    "// Partial class constructors to preserve compatibility when migrating",
                    "// from gRPC 1.x to 2.x tooling.",
                    "",
                    "using Grpc.Core;",
                    "using System;",
                    "",
                    $"namespace {api.Id}",
                    "{"
                };

                foreach (var type in clientTypes)
                {
                    var name = type.Name[0..^6]; // Strip off client
                    lines.AddRange(new[]
                    {
                        // All interpolated to make indentation easier to verify
                        $"    public partial class {name}",
                        $"    {{",
                        $"        public partial class {name}Client",
                        $"        {{",
                        $"            /// <summary>Creates a new client using a channel.</summary>",
                        $"            /// <param name=\"channel\">The channel to use to make remote calls.</param>",
                        $"            [Obsolete(\"This constructor overload is present for compatibility only, and will be removed in the next major version\")]",
                        $"            public {name}Client(Channel channel) : base(channel)",
                        $"            {{",
                        $"            }}",
                        $"        }}",
                        $"    }}",
                        $""
                    });
                }
                // Replace trailing empty line with the closing brace
                lines[lines.Count - 1] = "}";
                var sourceRoot = DirectoryLayout.ForApi(api.Id).SourceDirectory;
                File.WriteAllLines(Path.Combine(sourceRoot, api.Id, "GrpcCtorCompatibility.g.cs"), lines);
            }
        }

        private static Assembly PublishUnitTestsAndLoadAssembly(ApiMetadata api)
        {
            // We publish the *test* project, as that's executable - so the appropriate gRPC native
            // libraries are published as well. (They're not published within the library project.)
            var sourceRoot = DirectoryLayout.ForApi(api.Id).SourceDirectory;
            var testProject = $"{api.Id}.Tests";
            var testFramework = api.TestTargetFrameworks?.Split(';').FirstOrDefault(tfm => tfm.Contains("netcoreapp")) ?? TestTargetFramework;
            Processes.RunDotnet(sourceRoot, "publish", "-nologo", "-clp:NoSummary", "-v", "quiet", "-c", "Release", testProject, "-f", testFramework);

            var assemblyFile = Path.Combine(sourceRoot, testProject, "bin", "Release", testFramework, "publish", $"{api.Id}.dll");
            return Assembly.LoadFrom(assemblyFile);
        }
    }
}
