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
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Description of a smoke test for an API, along with some fairly grungy code to execute it.
    /// </summary>
    public class SmokeTest
    {
        internal const string GoogleApplicationCredentialsEnvironmentVariable = "GOOGLE_APPLICATION_CREDENTIALS";

        /// <summary>
        /// The method to test, e.g. AnalyzeSyntax. Only synchronous operations should be called,
        /// but long-running operations and list operations are handled automatically.
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// The name of the client class, assumed to be in the same namespace as the package ID,
        /// e.g. "PublisherClient".
        /// </summary>
        public string Client { get; set; }

        /// <summary>
        /// A map of named arguments to the method. Strings and numeric values can be represented
        /// directly as literals; object values are assumed to be protobuf messages, and are
        /// parsed as JSON. Note that every string value (even within an object) has the substring
        /// "${PROJECT_ID}" replaced by the project ID before invocation.
        /// </summary>
        public Dictionary<string, JToken> Arguments { get; set; } = new Dictionary<string, JToken>();

        /// <summary>
        /// If non-null, the test is skipped - and the value should be the reason why it's skipped.
        /// </summary>
        public string Skip { get; set; }

        /// <summary>
        /// If non-null, and running in a "restricted" environment (crudely detected by the absence of the
        /// GOOGLE_APPLICATION_CREDENTIALS environment variable), the test is skipped. As with <see cref="Skip"/>,
        /// the value should be the reason for skipping.
        /// </summary>
        public string RestrictedSkip { get; set; }

        /// <summary>
        /// The endpoint to set in the builder when creating a client. (May be null, in which case the default
        /// endpoint is used.)
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Used to navigate from the named client (in <see cref="Client"/>) to another client,
        /// e.g. for a mixin. <see cref="Method"/> is then expected to be within the referenced client.
        /// </summary>
        public string ClientNavigationProperty { get; set; }

        /// <summary>
        /// The transports to test. This should only be used for temporarily providing a smoke
        /// test for a subset of transports while problematic ones are being fixed.
        /// </summary>
        public string[] Transports { get; set; }

        /// <summary>
        /// When populated, the call is made with a FieldMask header in the CallSettings,
        /// as per https://googleapis.dev/dotnet/Google.Maps.Routing.V2/latest/.
        /// </summary>
        public string FieldMask { get; set; }

        /// <summary>
        /// Executes a smoke test. Returns whether it actually executed (true) or was skipped (false).
        /// </summary>
        /// <param name="assembly">The assembly of the client library being tests.</param>
        /// <param name="templateVariables">Variables to replace within the template.</param>
        public bool Execute(Assembly assembly, IReadOnlyDictionary<string, string> templateVariables)
        {
            var constructionClientType = FindClient(assembly);
            var transports = Transports ?? FindTransports(constructionClientType).Split(',').Select(t => t.Trim());

            // Work out which type we're actually going to test
            var navigationProperty = ClientNavigationProperty is null ? null : constructionClientType.GetProperty(ClientNavigationProperty);
            var effectiveClientType = navigationProperty is null ? constructionClientType : navigationProperty.PropertyType;

            var method = FindMethod(effectiveClientType);
            var arguments = ConvertArguments(method, templateVariables);

            if (RestrictedSkip is object && string.IsNullOrEmpty(Environment.GetEnvironmentVariable(GoogleApplicationCredentialsEnvironmentVariable)))
            {
                Console.WriteLine($"*** Skipping test for {constructionClientType.Name}.{Method} (running in restricted context): {RestrictedSkip} ***");
                return false;
            }
            if (Skip is object)
            {
                Console.WriteLine($"*** Skipping test for {constructionClientType.Name}.{Method}: {Skip} ***");
                return false;
            }
            foreach (var transport in transports)
            {
                Console.WriteLine($"Running test for {effectiveClientType.Name}.{Method} with transport {transport}");
                var clientInstance = CreateClient(constructionClientType, transport);
                if (navigationProperty is not null)
                {
                    clientInstance = navigationProperty.GetValue(clientInstance);
                }
                var result = method.Invoke(clientInstance, arguments);
                DisplayResult(result);
            }
            return true;
        }

        private System.Type FindClient(Assembly assembly)
        {
            if (Client is null)
            {
                throw new UserErrorException($"Smoke test configuration error: no client specified for method {Method}");
            }
            // Assume the namespace is the same as the assembly name.
            string ns = assembly.GetName().Name;
            var typeName = $"{ns}.{Client}";
            var type = assembly.GetType(typeName);
            return type ?? throw new UserErrorException($"No such client type {typeName} in assembly");
        }

        private string FindTransports(System.Type clientType)
        {
            dynamic metadata = clientType.GetProperty("ServiceMetadata", BindingFlags.Public | BindingFlags.Static).GetValue(null);
            return metadata.Transports.ToString();
        }

        private object CreateClient(System.Type clientType, string transport)
        {
            var builderType = clientType.Assembly.GetType(clientType.FullName + "Builder");
            var builder = Activator.CreateInstance(builderType);
            switch (transport)
            {
                case "Grpc": break;
                // We only actually need to set the gRPC adapter explicitly if there's more than one transport,
                // and if we're trying to use REST. It's simplest to always do it for REST though.
                // We fetch everything via reflection to avoid a direct dependency on GAX which could interfere with the
                // client's dependency.
                case "Rest":
                    if (transport == "Rest")
                    {
                        var restTransport = builderType.BaseType.Assembly.GetType("Google.Api.Gax.Grpc.Rest.RestGrpcAdapter")
                            .GetProperty("Default", BindingFlags.Public | BindingFlags.Static)
                            .GetValue(null);
                        builderType.GetProperty("GrpcAdapter").SetValue(builder, restTransport);
                    }
                    break;
                default:
                    throw new UserErrorException($"Unknown transport '{transport}'");
            }
            builderType.GetProperty("Endpoint").SetValue(builder, Endpoint);
            return builderType.GetMethod("Build", System.Type.EmptyTypes, null).Invoke(builder, new object[0]);
        }

        private MethodInfo FindMethod(System.Type client)
        {
            var methods = client.GetMethods().Where(method => method.Name == Method);
            var matchingMethods = methods.Where(method => MethodMatches(method, Arguments)).ToList();
            return matchingMethods.Count switch
            {
                0 => throw new UserErrorException($"No matching methods with name {Method} found"),
                1 => matchingMethods[0],
                _ => throw new UserErrorException($"Arguments for method {Method} are ambiguous; {matchingMethods.Count} overloads match")
            };

            bool MethodMatches(MethodInfo method, IReadOnlyDictionary<string, JToken> arguments)
            {
                var parameters = method.GetParameters();
                // If there are arguments that aren't parameters, it doesn't match.
                if (arguments.Keys.Except(parameters.Select(p => p.Name)).Any())
                {
                    return false;
                }
                // Check that each argument is supplied if it's required, and can be converted to the right type.
                foreach (var parameter in parameters)
                {
                    if (!arguments.TryGetValue(parameter.Name, out var argValue))
                    {
                        if (!parameter.IsOptional)
                        {
                            return false;
                        }
                    }
                    else if (!ArgumentMatches(parameter, argValue.Type))
                    {
                        return false;
                    }
                }
                return true;
            }

            bool ArgumentMatches(ParameterInfo parameter, JTokenType argument)
            {
                var parameterType = parameter.ParameterType;
                return argument switch
                {
                    JTokenType.String => parameterType == typeof(string),
                    JTokenType.Integer => parameterType == typeof(int),
                    JTokenType.Float => parameterType == typeof(float) || parameterType == typeof(double),
                    // TODO: Check whether it's a protobuf message?
                    JTokenType.Object => parameterType != typeof(string) && !parameterType.IsValueType,
                    JTokenType.Array => typeof(IEnumerable).IsAssignableFrom(parameterType),
                    _ => false
                };
            }
        }

        private object[] ConvertArguments(MethodInfo method, IReadOnlyDictionary<string, string> templateVariables)
        {
            foreach (var value in Arguments.Values)
            {
                ReplaceVariables(value);
            }
            var parameters = method.GetParameters();
            return parameters.Select(p => GetCorrespondingArgument(p)).ToArray();

            void ReplaceVariables(JToken token)
            {
                switch (token.Type)
                {
                    case JTokenType.String:
                        var value = (JValue) token;
                        value.Value = ReplaceVariablesInString((string) value.Value);
                        break;
                    case JTokenType.Array:
                        var array = (JArray) token;
                        foreach (var element in array.Children())
                        {
                            ReplaceVariables(element);
                        }
                        break;
                    case JTokenType.Object:
                        var obj = (JObject) token;
                        foreach (var property in obj.Properties())
                        {
                            ReplaceVariables(property.Value);
                        }
                        break;
                }
            }

            string ReplaceVariablesInString(string text)
            {
                foreach (var pair in templateVariables)
                {
                    text = text.Replace($"${{{pair.Key}}}", pair.Value);
                }
                if (text.Contains("$\""))
                {
                    throw new UserErrorException($"Unable to replace all variables within request text for method {method.Name}.");
                }
                return text;
            }

            object GetCorrespondingArgument(ParameterInfo parameter)
            {
                var parameterType = parameter.ParameterType;
                if (parameterType.FullName == "Google.Api.Gax.Grpc.CallSettings")
                {
                    return CreateCallSettings(parameterType);
                }
                if (!Arguments.TryGetValue(parameter.Name, out var argValue))
                {
                    return parameter.DefaultValue;
                }
                dynamic protoParser = MaybeGetMessageParser(parameterType);
                return protoParser is object
                    ? protoParser.ParseJson(argValue.ToString())
                    : argValue.ToObject(parameterType);
            }

            object MaybeGetMessageParser(System.Type type)
            {
                // Note that we don't want to take a dependency on Google.Protobuf directly in this tool,
                // as it could cause versioning problems when we try to load the API.
                var parserProperty = type.GetProperty("Parser", BindingFlags.Static | BindingFlags.Public);
                if (parserProperty is null)
                {
                    return null;
                }
                var propertyType = parserProperty.PropertyType;
                return propertyType.IsGenericType && propertyType.GetGenericTypeDefinition().FullName == "Google.Protobuf.MessageParser`1"
                    ? parserProperty.GetValue(null)
                    : null;
            }

            // Create a CallSettings object for the call, as determined by properties within the smoke test.
            // Currently, only FieldMask is supported.
            object CreateCallSettings(System.Type callSettingsType)
            {
                if (FieldMask is null)
                {
                    return null;
                }
                var fromHeaderMethod = callSettingsType.GetMethod("FromHeader", BindingFlags.Public | BindingFlags.Static, new[] { typeof(string), typeof(string) });
                return fromHeaderMethod.Invoke(null, new[] { "X-Goog-FieldMask", FieldMask });
            }
        }

        private void DisplayResult(object result)
        {
            if (result is null)
            {
                Console.WriteLine($"Result: null");
                return;
            }
            var resultType = result.GetType();
            if (resultType.IsGenericType && resultType.GetGenericTypeDefinition().FullName == "Google.LongRunning.Operation`2")
            {
                dynamic operation = result;
                Console.WriteLine($"Result is long-running operation with name {operation.Name}");
                Console.WriteLine("Polling for completion. (This could take some time.)");
                operation = operation.PollUntilCompleted();
                Console.WriteLine($"Operation completed. Result: {operation.Result}");
                return;
            }
            if (resultType.IsGenericType && resultType.GetGenericTypeDefinition().FullName == "Google.Api.Gax.Grpc.GrpcPagedEnumerable`3")
            {
                Console.WriteLine($"Result is paged, with an item type of {resultType.GetGenericArguments()[2].Name}");
                Console.WriteLine("Fetching at most 10 items from the result.");
                var results = ((IEnumerable) result).Cast<object>().Take(10).ToList();
                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }
                return;
            }
            Console.WriteLine($"Result: {result}");
        }
    }
}
