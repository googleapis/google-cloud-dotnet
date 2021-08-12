// Copyright 2021 Google LLC
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

using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.Compute.V1.ModifyGeneratedClients
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Required single argument: path to directory containing generated clients");
                return 1;
            }
            foreach (var file in Directory.GetFiles(args[0], "*Client.g.cs"))
            {
                ModifyClient(file);
            }
            return 0;
        }

        static void ModifyClient(string file)
        {
            var lines = File.ReadAllLines(file);

            var lroMethods = new List<LroMethod>();

            var clientMethodDeclarationPattern = new Regex(@"public virtual lro::Operation<Operation, Operation> (?<name>[^(]*)\((?<request>\S*Request) ");
            foreach (var line in lines)
            {
                var match = clientMethodDeclarationPattern.Match(line);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string requestType = match.Groups["request"].Value;
                    lroMethods.Add(new LroMethod(name, requestType));
                }
            }
            var operationTypes = lroMethods.Select(m => m.OperationType).Distinct().ToList();
            if (operationTypes.Count == 0)
            {
                return;
            }
            if (operationTypes.Count > 1)
            {
                throw new InvalidOperationException($"Client {file} contains multiple operation types: {string.Join(", ", operationTypes)}");
            }

            // Okay, we know that all the LROs in the client use this single kind of operation.
            // This is needed for the fix-ups...
            var operationType = operationTypes[0];

            // We need to fix up the following lines:
            // Change every ApiCall lro::Operation field back to use Operation
            // Change every ApiCall lro::Operation construction to use Operation
            // Change every partial modify call (e.g. Modify_DeleteApiCall) to use Operation
            // Per-LRO-method, change the implementation to call the original and wrap it
            // Per-client, modify the CreateOperationsClient implementation.

            var replacements = lroMethods.Select(method => method.GetLineReplacements()).ToList();
            // ApiCall field declaration
            replacements.Add(line => line.Replace(", lro::Operation> _call", ", Operation> _call"));
            // Modify method declaration
            replacements.Add(line => line.Replace(", lro::Operation> call);", ", Operation> call);"));
            // ApiCall field initialization
            replacements.Add(line => line.Replace("lro::Operation>(grpcClient.", "Operation>(grpcClient."));

            // Per-client 
            string adapterLine = $"new lro::Operations.OperationsClient(OperationAdapter.Create{operationType}CallInvoker(CallInvoker));";
            replacements.Add(line => line.Replace("new lro::Operations.OperationsClient(CallInvoker);", adapterLine));

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                foreach (var replacement in replacements)
                {
                    line = replacement(line);
                }
                lines[i] = line;
            }
            Console.WriteLine($"Modified {file}");
            File.WriteAllLines(file, lines);
        }

        class LroMethod
        {
            public string Name { get; }
            public string RequestType { get; }
            public OperationType OperationType { get; }
            
            private string OperationConverter { get; }

            public LroMethod(string name, string requestType)
            {
                Name = name;
                RequestType = requestType;
                OperationType = InferOperationType(requestType);
                OperationConverter = OperationType switch
                {
                    OperationType.Regional => "ToRegionalOperation(request.Project, request.Region)",
                    OperationType.Zonal => "ToZonalOperation(request.Project, request.Zone)",
                    OperationType.Global => "ToGlobalOperation(request.Project)",
                    OperationType.GlobalOrganization => "ToGlobalOrganizationOperation()",
                    _ => throw new InvalidOperationException()
                };
            }

            internal Func<string, string> GetLineReplacements()
            {
                var existingSync = $"return new lro::Operation<Operation, Operation>(_call{Name}.Sync(request, callSettings), {Name}OperationsClient);";
                var existingAsync = $"return new lro::Operation<Operation, Operation>(await _call{Name}.Async(request, callSettings).ConfigureAwait(false), {Name}OperationsClient);";
                var newSync = $"return new lro::Operation<Operation, Operation>(_call{Name}.Sync(request, callSettings).{OperationConverter}, {Name}OperationsClient);";
                var newAsync = $"return new lro::Operation<Operation, Operation>((await _call{Name}.Async(request, callSettings).ConfigureAwait(false)).{OperationConverter}, {Name}OperationsClient);";
                return line => line.Replace(existingSync, newSync).Replace(existingAsync, newAsync);
            }

            private static OperationType InferOperationType(string requestType)
            {
                string fullName = "google.cloud.compute.v1." + requestType;
                var descriptor = ComputeReflection.Descriptor.MessageTypes.SingleOrDefault(mt => mt.FullName == fullName);
                if (descriptor == null)
                {
                    throw new ArgumentException($"Can't find {fullName}");
                }

                var fieldNames = descriptor.Fields.InDeclarationOrder().Select(f => f.Name).ToList();
                // FIXME: Check parent field for global organization
                var hasProject = fieldNames.Contains("project");
                var hasRegion = fieldNames.Contains("region");
                var hasZone = fieldNames.Contains("zone");
                return (hasProject, hasRegion, hasZone) switch
                {
                    (true, true, false) => OperationType.Regional,
                    (true, false, true) => OperationType.Zonal,
                    (true, false, false) => OperationType.Global,
                    (false, false, false) => OperationType.GlobalOrganization,
                    _ => throw new ArgumentException($"Can't infer the operation type of {requestType}")
                };
            }

        }

        enum OperationType
        {
            Zonal, Regional, Global, GlobalOrganization
        }
    }
}
