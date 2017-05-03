// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Storage.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests
{
    public class AclEnumsTest
    {
        private static readonly Type[] s_BucketAclEnums =
        {
            typeof(BucketsResource.InsertRequest.PredefinedAclEnum),
            typeof(BucketsResource.UpdateRequest.PredefinedAclEnum),
            typeof(BucketsResource.PatchRequest.PredefinedAclEnum)
        };

        public static readonly Type[] s_ObjectAclEnums =
        {
            typeof(BucketsResource.InsertRequest.PredefinedDefaultObjectAclEnum),
            typeof(BucketsResource.UpdateRequest.PredefinedDefaultObjectAclEnum),
            typeof(BucketsResource.PatchRequest.PredefinedDefaultObjectAclEnum),
            typeof(ObjectsResource.ComposeRequest.DestinationPredefinedAclEnum),
            typeof(ObjectsResource.CopyRequest.DestinationPredefinedAclEnum),
            typeof(ObjectsResource.RewriteRequest.DestinationPredefinedAclEnum),
            typeof(ObjectsResource.InsertRequest.PredefinedAclEnum),
            typeof(ObjectsResource.UpdateRequest.PredefinedAclEnum),
            typeof(ObjectsResource.PatchRequest.PredefinedAclEnum),
            typeof(ObjectsResource.InsertMediaUpload.PredefinedAclEnum),
        };

        public static IEnumerable<object[]> BucketAclEnums => s_BucketAclEnums.Select(t => new object[] { t });
        public static IEnumerable<object[]> ObjectAclEnums => s_ObjectAclEnums.Select(t => new object[] { t });

        [Theory]
        [MemberData(nameof(BucketAclEnums))]
        public void PredefinedBucketAclMatchesApiEnums(Type apiType)
        {
            var apiValues = Enum.GetValues(apiType);
            var wrapperValues = Enum.GetValues(typeof(PredefinedBucketAcl));
            Assert.Equal(apiValues.Length, wrapperValues.Length);
            foreach (PredefinedBucketAcl wrapperValue in wrapperValues)
            {
                var apiName = Enum.GetName(apiType, (int)wrapperValue);
                var wrapperName = wrapperValue.ToString();
                Assert.Equal(apiName.Replace("_", ""), wrapperName);
            }
        }

        [Theory]
        [MemberData(nameof(ObjectAclEnums))]
        public void PredefinedObjectAclMatchesApiEnums(Type apiType)
        {
            var apiValues = Enum.GetValues(apiType);
            var wrapperValues = Enum.GetValues(typeof(PredefinedObjectAcl));
            Assert.Equal(apiValues.Length, wrapperValues.Length);
            foreach (PredefinedObjectAcl wrapperValue in wrapperValues)
            {
                var apiName = Enum.GetName(apiType, (int)wrapperValue);
                var wrapperName = wrapperValue.ToString();
                Assert.Equal(apiName.Replace("_", ""), wrapperName);
            }
        }

        [Fact]
        public void AllAclEnumsCovered()
        {
            var allAclEnums = typeof(StorageService).GetTypeInfo().Assembly.GetTypes().Where(t => t.GetTypeInfo().IsEnum && t.Name.EndsWith("AclEnum"));
            // This gives a better error message than Assert.Empty
            Assert.Equal(new Type[0], allAclEnums.Except(s_BucketAclEnums).Except(s_ObjectAclEnums).ToArray());
        }
    }
}
