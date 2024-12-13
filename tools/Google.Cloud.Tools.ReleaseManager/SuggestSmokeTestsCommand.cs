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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Command that looks at all the RPCs in a client library and considers which ones might be suitable for smoke tests.
    /// (This is currently very simplistic, but can become more sophisticated over time.)
    /// The smoke tests are written to disk automatically (if the file doesn't already exist) but they should definitely be checked by hand.
    /// For example, the Vision API's ProductSearchClient has a PurgeProducts parameterless method - we can't easily tell that that's
    /// dangerous whereas other parameterless RPCs are safe. (A really sophisticated version of this tool might examine
    /// the HTTP bindings for the RPC and only allow GET requests...)
    /// </summary>
    public class SuggestSmokeTestsCommand : CommandBase
    {
        public SuggestSmokeTestsCommand()
            : base("suggest-smoke-tests", "Analyzes a client library for possible simple smoke tests", "id")
        {
        }

        protected override int ExecuteImpl(string[] args)
        {
            string id = args[0];
            var assembly = PublishAndLoadAssembly(id);
            var clients = FindClients(assembly);
            if (clients.Count == 0)
            {
                throw new UserErrorException($"{id} appears to have no client types. Are you sure this is an API client library?");
            }
            Console.WriteLine($"Detect client types: {string.Join(", ", clients.Select(t => t.Name))}");
            var tests = clients.SelectMany(c => SuggestSmokeTests(c)).ToList();
            Console.WriteLine($"Number of smoke tests suggested: {tests.Count}");
            if (tests.Any())
            {
                var serializerSettings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = { new StringEnumConverter(new CamelCaseNamingStrategy()) },
                    ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() }
                };
                string testJson = JsonConvert.SerializeObject(tests, Formatting.Indented, serializerSettings);
                Console.WriteLine(testJson);
                Console.WriteLine();
                var smokeTestsFile = Path.Combine(RootLayout.CreateApiLayout(id).SourceDirectory, "smoketests.json");
                if (File.Exists(smokeTestsFile))
                {
                    Console.WriteLine("smoketests.json already exists, so it has been left alone.");
                }
                else
                {
                    File.WriteAllText(smokeTestsFile, testJson);
                    Console.WriteLine("Written suggested smoke tests to smoketests.json. Please review the tests carefully before committing.");
                }
            }
            return 0;
        }

        private Assembly PublishAndLoadAssembly(string id)
        {
            Console.WriteLine($"Publishing release version of library");
            var sourceRoot = RootLayout.CreateApiLayout(id).SourceDirectory;
            string tfm = CreateClientsCommand.GetTargetForReflectionLoad(RootLayout, id);
            Processes.RunDotnet(sourceRoot, "publish", "-nologo", "-clp:NoSummary", "-v", "quiet", "-c", "Release", id, "-f", tfm);

            var assemblyFile = Path.Combine(sourceRoot, id, "bin", "Release", tfm, "publish", $"{id}.dll");
            return Assembly.LoadFrom(assemblyFile);
        }

        private List<System.Type> FindClients(Assembly assembly) => assembly.GetTypes()
            .Where(t => t.Name.EndsWith("Client"))
            // Check that FooClient has FooSettings
            .Where(t => assembly.GetType(t.FullName[..^6] + "Settings") is object)
            .ToList();

        private IEnumerable<SmokeTest> SuggestSmokeTests(System.Type client) =>
            client.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                // All RPC methods have a final CallSettings parameter
                .Where(method => method.GetParameters().LastOrDefault()?.ParameterType.FullName == "Google.Api.Gax.Grpc.CallSettings")
                // Filter out async methods.
                .Where(method => !typeof(Task).IsAssignableFrom(method.ReturnType))
                .Where(method => !method.ReturnType.FullName.StartsWith("Google.Api.Gax.PagedAsyncEnumerable"))
                // Now collect into overloaded methods
                .GroupBy(method => method.Name)
                .Select(SyncRpc.FromMethods)
                // And convert to smoke tests, where possible
                .Select(rpc => rpc.ToSmokeTestOrNull())
                .Where(test => test is object);

        private class SyncRpc
        {
            public string Client { get; }
            public string Method { get; }
            public IReadOnlyList<Overload> Overloads { get; }

            private SyncRpc(string client, string method, IReadOnlyList<Overload> overloads) =>
                (Client, Method, Overloads) = (client, method, overloads);

            public static SyncRpc FromMethods(IEnumerable<MethodInfo> methods) =>
                new SyncRpc(methods.First().DeclaringType.Name, methods.First().Name, methods.Select(Overload.FromMethod).ToList());

            public SmokeTest ToSmokeTestOrNull()
            {
                // We just need to fill in the arguments...
                var candidate = new SmokeTest { Client = Client, Method = Method };

                // Parameterless RPCs are very rare, but are good candidates for smoke tests.
                // Admittedly this has some false positives, e.g. in Vision, ProductSearchClient.PurgeProducts.
                if (Overloads.Any(o => o.RequiredParameters.Count == 0))
                {
                    // No arguments required
                    return candidate;
                }
                // If there's a method that accepts just a ProjectName, find its equivalent accepting a string. (There should be exactly one.)
                if (Overloads.Any(o => o.HasSingleParameterOfType("Google.Api.Gax.ResourceNames.ProjectName")))
                {
                    var stringParameter = Overloads.Single(o => o.HasSingleParameterOfType(typeof(string))).RequiredParameters[0];
                    candidate.Arguments[stringParameter.Name] = "projects/${PROJECT_ID}";
                    return candidate;
                }

                // If there's a method that accepts just a LocationName, find its equivalent accepting a string. (There should be exactly one.)
                if (Overloads.Any(o => o.HasSingleParameterOfType("Google.Api.Gax.ResourceNames.LocationName")))
                {
                    var stringParameter = Overloads.Single(o => o.HasSingleParameterOfType(typeof(string))).RequiredParameters[0];
                    candidate.Arguments[stringParameter.Name] = "projects/${PROJECT_ID}/locations/us-east1";
                    return candidate;
                }
                return null;
            }
        }

        private class Overload
        {
            public IReadOnlyList<ParameterInfo> RequiredParameters { get; }

            private Overload(IReadOnlyList<ParameterInfo> requiredParamers) =>
                RequiredParameters = requiredParamers;

            public static Overload FromMethod(MethodInfo method) =>
                new Overload(method.GetParameters().Where(p => !p.IsOptional).ToList());

            public bool HasSingleParameterOfType(System.Type expectedType) =>
                HasSingleParameterOfType(expectedType.FullName);

            public bool HasSingleParameterOfType(string expectedTypeName) =>
                RequiredParameters.Count == 1 && RequiredParameters[0].ParameterType.FullName == expectedTypeName;

            public override string ToString() => $"({string.Join(", ", RequiredParameters.Select(p => $"{p.ParameterType.Name} {p.Name}"))})";
        }
    }
}
