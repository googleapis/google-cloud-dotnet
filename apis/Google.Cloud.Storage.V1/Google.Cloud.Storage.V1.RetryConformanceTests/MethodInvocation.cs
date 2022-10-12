// Copyright 2022 Google LLC
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

using Google.Api.Gax;
using Google.Apis.Storage.v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.RetryConformanceTests;

internal class MethodInvocation
{
    internal MethodInfo Method { get; set; }

    public MethodInvocation(Delegate d)
    {
        Method = d.Method;
    }

    /// <summary>
    /// Add parameters and invoke the API mapped 
    /// </summary>
    /// <param name="storageClient"></param>
    /// <param name="preConditionsPresent"></param>
    public void Invoke(StorageClient storageClient, TestContext context, bool preConditionsPresent)
    {
        var arguments = CreateArgumentList(storageClient, context, preConditionsPresent);
        var result = Method.Invoke(storageClient, arguments);
        if (Method.ReturnType != typeof(void) && Method.Name.StartsWith("List"))
        {
            // TODO: maybe do this more elegantly...
            ConsumeListOutput((dynamic) result);
        }
    }

    private static void ConsumeListOutput<TRequest, TResource>(PagedEnumerable<TRequest, TResource> pagedEnumerable) =>
        pagedEnumerable.ReadPage(100);

    /// <summary>
    /// Configures all the parameters required and adds them in the arguments for method invocations
    /// </summary>
    /// <param name="storageClient"></param>
    /// <param name="preConditionsPresent"></param>
    /// <returns></returns>
    private object[] CreateArgumentList(StorageClient storageClient, TestContext context, bool preConditionsPresent)
    {
        return Method.GetParameters().Select(GetArgument).ToArray();

        object GetArgument(ParameterInfo parameter) =>
            parameter.ParameterType == typeof(string) ? GetStringArgument(parameter)
            : preConditionsPresent && parameter.Name == "options" ? CreateOptionsArgument(parameter)
            : CreateResourceArgument(parameter);

        string GetStringArgument(ParameterInfo p) => p.Name switch
        {
            "bucket" or "sourceBucket" => context.BucketName,
            "objectName" or "sourceObjectName" => context.ObjectName,
            "project" or "projectId" => context.ProjectId,
            "notification" or "notificationId" => context.NotificationId,
            "hmacKey" => context.HmacSecret,
            "accessId" => context.HmacAccessId,
            "serviceAccountEmail" => context.ServiceAccountEmail,
            "destinationBucket" => context.DestinationBucketName,
            "destinationObject" => context.DestinationObjectName,
            _ => throw new InvalidOperationException($"Unhandled string parameter: {p.Name}")
        };

        object CreateOptionsArgument(ParameterInfo p) => p.ParameterType.Name switch
        {
            nameof(UpdateBucketOptions) => new UpdateBucketOptions { IfMetagenerationMatch = 1 },
            nameof(PatchBucketOptions) => new PatchBucketOptions { IfMetagenerationMatch = 1 },
            nameof(CopyObjectOptions) => new CopyObjectOptions { IfGenerationMatch = context.ObjectGeneration },
            nameof(UpdateObjectOptions) => new UpdateObjectOptions { IfMetagenerationMatch = 1 },
            nameof(DeleteObjectOptions) => new DeleteObjectOptions { IfGenerationMatch = context.ObjectGeneration },
            nameof(PatchObjectOptions) => new PatchObjectOptions { IfMetagenerationMatch = 1 },
            _ => throw new InvalidOperationException($"Unhandled options parameter: {p.ParameterType.Name}")
        };

        object CreateResourceArgument(ParameterInfo p) => (p.Name, p.ParameterType.Name) switch
        {
            ("metageneration", _) => 1L,
            ("permissions", _) => new List<string> { "bucket.get" },
            ("policy", _) => GetIamPolicyAndAddPublicViewer(),
            (_, nameof(Bucket)) => new Bucket { Name = context.BucketName },
            (_, nameof(Object)) => new Object { Name = context.ObjectName, Bucket = context.BucketName },
            (_, nameof(Notification)) => new Notification { Topic = "Test-topic", PayloadFormat = "NONE" },
            (_, nameof(HmacKeyMetadata)) => new HmacKeyMetadata
            {
                ProjectId = context.ProjectId,
                AccessId = context.HmacAccessId,
                State = HmacKeyStates.Inactive,
                ETag = preConditionsPresent ? "MQ==" : null
            },
            _ => throw new InvalidOperationException($"Unhandled resource parameter: name={p.Name}, type={p.ParameterType.FullName}")
        };

        Policy GetIamPolicyAndAddPublicViewer()
        {
            var policy = storageClient.GetBucketIamPolicy(context.BucketName);
            Policy.BindingsData AllUsersViewer = new Policy.BindingsData
            {
                Members = new[] { "allUsers" },
                Role = "roles/storage.objectViewer"
            };
            policy.Bindings.Add(AllUsersViewer);
            return policy;
        }
    }
}
