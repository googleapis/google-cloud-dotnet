// Copyright 2022 Google LLC
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

using Google.Cloud.Tools.Common;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.ReleaseManager;

public class CreateClientsCommand : CommandBase
{
    public CreateClientsCommand()
        : base("create-clients", "Checks that we can create clients for a pure-GAPIC package", "id")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        string id = args[0];
        var catalog = ApiCatalog.Load(RootLayout);
        if (!catalog.TryGetApi(id, out var api))
        {
            throw new UserErrorException($"No such API: {id}");
        }
        if (api.Generator != GeneratorType.Micro)
        {
            Console.WriteLine($"{id} is not a GAPIC-generated API; skipping client creation test.");
            return 0;
        }

        var assembly = PublishAndLoadAssembly(id);
        CreateClients(assembly, id);
        return 0;
    }

    /// <summary>
    /// Returns the tfm (e.g. netstandard2.0 or netstandard2.1) to build/load for tools
    /// that need to load the library with reflection, e.g. for smoke tests.
    /// </summary>
    internal static string GetTargetForReflectionLoad(RootLayout rootLayout, string id)
    {
        // Work out the TFM to publish, based on specified target frameworks.
        var api = ApiCatalog.Load(rootLayout)[id];
        return api.TargetFrameworks?
            .Split(';')
            .FirstOrDefault(candidate => candidate.StartsWith("netstandard"))
            ?? NonSourceGenerator.DefaultNetstandardTarget;
    }

    // Note: a lot of code from here on is copied/modified from SmokeTest and SuggestSmokeTestsCommand.
    // We could consider refactoring later, if we find this is a problem.
    private Assembly PublishAndLoadAssembly(string id)
    {
        var sourceRoot = RootLayout.CreateApiLayout(id).SourceDirectory;

        // Work out the TFM to publish, based on specified target frameworks.
        string tfm = GetTargetForReflectionLoad(RootLayout, id);

        // Note: we explicitly don't build here, as this code is normally run from a build script which has
        // has already built. Avoiding the rebuild saves a lot of time.
        Processes.RunDotnet(sourceRoot, "publish", "-nologo", "-clp:NoSummary", "-v", "quiet", "-c", "Release", "--no-build", id, "-f", tfm);

        var assemblyFile = Path.Combine(sourceRoot, id, "bin", "Release", tfm, "publish", $"{id}.dll");
        return Assembly.LoadFrom(assemblyFile);
    }

    private void CreateClients(Assembly assembly, string id)
    {
        var clientTypes = assembly.GetTypes()
            .Where(t => t.IsClass)
            .Where(t => t.Name.EndsWith("Client"))
            // Skip clients such as BigtableClient which don't have their own service metadata.
            .Where(t => t.GetProperty("ServiceMetadata", BindingFlags.Public | BindingFlags.Static) is not null)
            .Where(t => assembly.GetType(t.FullName + "Builder") is System.Type builderType
                        && builderType.BaseType.Name == "ClientBuilderBase`1")
            .ToList();

        foreach (var clientType in clientTypes)
        {
            dynamic metadata = clientType.GetProperty("ServiceMetadata", BindingFlags.Public | BindingFlags.Static).GetValue(null);
            string transportsText = metadata.Transports.ToString();
            var transports = transportsText.Split(',').Select(t => t.Trim());
            foreach (var transport in transports)
            {
                try
                {
                    CreateClient(clientType, transport);
                }
                catch (Exception ex)
                {
                    // Unwrap exceptions thrown via reflection.
                    if (ex is TargetInvocationException && ex.InnerException is Exception inner)
                    {
                        ex = inner;
                    }
                    throw new UserErrorException($"Package '{id}' is broken: creation of client '{clientType.Name}' with transport '{transport}' failed: {ex.GetType().FullName}: {ex.Message}");
                }
            }
        }
        Console.WriteLine($"Successfully created clients ({clientTypes.Count}) for {id}");
    }

    private object CreateClient(System.Type clientType, string transport)
    {
        var builderType = clientType.Assembly.GetType(clientType.FullName + "Builder");
        dynamic builder = Activator.CreateInstance(builderType);

        // Set a credential which will never be used. (If we remove TokenAccessMethod in the next GAX
        // release, we'll need to do something else. This is the simplest option for now though.)
        Func<string, CancellationToken, Task<string>> tokenAccessMethod = (url, token) => null;
        builder.TokenAccessMethod = tokenAccessMethod;

        // Grafeas.V1 (and potentially other APIs in the future) have no default endpoint.
        builder.Endpoint = "nowhere.googleapis.com";

        // We only actually need to set the gRPC adapter explicitly if there's more than one transport,
        // and if we're trying to use REST. It's simplest to always do it for REST though.
        // We fetch everything via reflection to avoid a direct dependency on GAX which could interfere with the
        // client's dependency.
        if (transport == "Rest")
        {
            dynamic restTransport = builderType.BaseType.Assembly.GetType("Google.Api.Gax.Grpc.Rest.RestGrpcAdapter")
                .GetProperty("Default", BindingFlags.Public | BindingFlags.Static)
                .GetValue(null);
            builder.GrpcAdapter = restTransport;
        }
        return builder.Build();
    }
}
