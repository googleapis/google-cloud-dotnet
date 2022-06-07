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
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Google.Cloud.Storage.V1.RetryConformanceTests;

internal class MethodInvocation
{
    internal string ProjectId { get; set; }

    internal string BucketName { get; set; }

    internal string ObjectName { get; set; }

    internal string Notification { get; set; }

    internal string HmacKey { get; set; }

    internal string AccessId { get; set; }

    internal string ServiceAccountEmail { get; set; }

    internal long Metageneration { get; set; }

    internal MethodInfo MethodInformation { get; set; }

    internal bool ProjectIdRequired { get; set; }

    internal bool BucketNameRequired { get; set; }

    internal bool ObjectNameRequired { get; set; }

    internal bool NotificationRequired { get; set; }

    internal bool HmacKeyRequired { get; set; }

    internal bool AccessIdRequired { get; set; }

    internal bool ServiceAccountEmailRequired { get; set; }

    internal bool MetagenerationRequired { get; set; }

    internal object Result { get; private set; }

    public MethodInvocation(MethodInfo methodInfo)
    {
        MethodInformation = methodInfo;
    }

    //TODO: Optimize the method
    public void Invoke(StorageClient storageClient, bool preConditionsPresent)
    {
        List<object> arguments = new List<object>();

        var parameters = MethodInformation.GetParameters();

        foreach (var item in parameters)
        {
            if (item.ParameterType == typeof(string) && !item.IsOptional)
            {
                if (item.Name is "bucket")
                {
                    arguments.Add(BucketName);
                }
                else if (item.Name is "object")
                {
                    arguments.Add(ObjectName);
                }
                else if (item.Name is "project" || item.Name is "projectId")
                {
                    arguments.Add(ProjectId);
                }
                else if (item.Name is "notification")
                {
                    arguments.Add(Notification);
                }
                else if (item.Name is "hmacKey")
                {
                    arguments.Add(HmacKey);
                }
                else if (item.Name is "serviceAccountEmail")
                {
                    arguments.Add(ServiceAccountEmail);
                }
                else if (item.Name is "accessId")
                {
                    arguments.Add(AccessId);
                }
                else
                {
                    arguments.Add(System.Type.Missing);
                }
            }
            else if (item.Name is "metageneration")
            {
                long metageneration = 1;
                arguments.Add(metageneration);
            }
            else if (item.Name is "permissions")
            {
                IList<string> permission = new List<string>();
                permission.Add("bucket.get");
                arguments.Add(permission);
            }
            else if (item.Name is "policy")
            {
                var policy = storageClient.GetBucketIamPolicy(BucketName);
                Policy.BindingsData AllUsersViewer = new Policy.BindingsData
                {
                    Members = new[] { "allUsers" },
                    Role = "roles/storage.objectViewer"
                };
                policy.Bindings.Add(AllUsersViewer);
                arguments.Add(policy);
            }
            else if (item.Name is "bucket")
            {
                arguments.Add(new Bucket() { Name = BucketName });
            }
            else if (item.ParameterType.Name is "HmacKeyMetadata")
            {
                arguments.Add(new HmacKeyMetadata() { ProjectId = ProjectId, AccessId = AccessId });
            }
            else if (preConditionsPresent == true && item.Name is "options")
            {
                if (item.ParameterType.Name is "UpdateBucketOptions")
                {
                    arguments.Add(new UpdateBucketOptions() { IfMetagenerationMatch = 1 });
                }
                else if (item.ParameterType.Name is "PatchBucketOptions")
                {
                    arguments.Add(new PatchBucketOptions() { IfMetagenerationMatch = 1 });
                }
                else
                {
                    arguments.Add(System.Type.Missing);
                }
            }
            else
            {
                arguments.Add(System.Type.Missing);
            }
        }

        if (MethodInformation.ReturnType != typeof(void))
        {
            Result = MethodInformation.Invoke(storageClient, arguments.ToArray());
            var methodName = MethodInformation.Name.ToLowerInvariant();
            if (methodName.Contains("listhmackeys"))
            {
                var res = Result as PagedEnumerable<HmacKeysMetadata, HmacKeyMetadata>;
                if (res != null)
                {
                    res.ReadPage(5);
                }
            }
            else if (methodName.Contains("listobject"))
            {
                var res = Result as PagedEnumerable<Objects, Object>;
                if (res != null)
                {
                    res.ReadPage(5);
                }
            }
            else if (methodName.Contains("listbuckets"))
            {
                var res = Result as PagedEnumerable<Buckets, Bucket>;
                if (res != null)
                {
                    res.ReadPage(5);
                }
            }
            else if (methodName.Contains("listnotifications"))
            {
                var res = Result as PagedEnumerable<Notifications, Notification>;
                if (res != null)
                {
                    res.ReadPage(5);
                }
            }
        }
        else
        {
            MethodInformation.Invoke(storageClient, arguments.ToArray());
        }
    }
}
