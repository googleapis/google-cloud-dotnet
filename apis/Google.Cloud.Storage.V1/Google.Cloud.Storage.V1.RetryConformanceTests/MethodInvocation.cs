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

namespace Google.Cloud.Storage.V1.RetryConformanceTests
{
    internal class MethodInvocation
    {
        internal string ProjectId { get; set; }

        internal string BucketName { get; set; }

        internal string ObjectName { get; set; }

        internal string Notification { get; set; }

        internal string HmacKey { get; set; }

        internal string AccessId { get; set; }

        internal string ServiceAccountEmail { get; set; }

        internal MethodInfo MethodInformation { get; set; }

        internal bool ProjectIdRequired { get; }

        internal bool BucketNameRequired { get; }

        internal bool ObjectNameRequired { get; }

        internal bool NotificationRequired { get; }

        internal bool HmacKeyRequired { get; }

        internal bool AccessIdRequired { get; }

        internal bool ServiceAccountEmailRequired { get; }

        internal bool MetagenerationRequired { get; }

        internal object Result { get; private set; }

        public MethodInvocation(MethodInfo methodInfo, bool projectIdRequired, bool bucketNameRequired, bool objectNameRequired, bool notificationRequired, bool hmacKeyRequired, bool serviceAccountEmailRequired, bool accessIdRequired, bool metagenerationRequired)
        {
            MethodInformation = methodInfo;
            ProjectIdRequired = projectIdRequired;
            BucketNameRequired = bucketNameRequired;
            ObjectNameRequired = objectNameRequired;
            NotificationRequired = notificationRequired;
            HmacKeyRequired = hmacKeyRequired;
            ServiceAccountEmailRequired = serviceAccountEmailRequired;
            AccessIdRequired = accessIdRequired;
            MetagenerationRequired = metagenerationRequired;

        }

        public void Invoke(StorageClient storageClient)
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
                else
                {
                    arguments.Add(System.Type.Missing);
                }
            }

            if (MethodInformation.ReturnType != typeof(void))
            {
                Result = MethodInformation.Invoke(storageClient, arguments.ToArray());
                if (MethodInformation.Name.ToLowerInvariant().Contains("listhmackeys"))
                {
                    var a = Result as PagedEnumerable<HmacKeysMetadata, HmacKeyMetadata>;
                    if (a != null)
                        a.ReadPage(5);
                }
                /*
                if (MethodInformation.Name.ToLowerInvariant().Contains("gethmackey"))
                {
                    var a = Result as PagedEnumerable<HmacKeysMetadata, HmacKeyMetadata>;
                    if (a != null)
                        a.ReadPage(5);
                }
                */
                if (MethodInformation.Name.ToLowerInvariant().Contains("listnotifications"))
                {
                    var a = Result as PagedEnumerable<HmacKeysMetadata, HmacKeyMetadata>;
                    if (a != null)
                        a.ReadPage(5);
                }
            }
            else
            {
                MethodInformation.Invoke(storageClient, arguments.ToArray());
            }
        }
    }
}
